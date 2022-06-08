using FlagPFPCore.Loading;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace FlagPFPCore.Processors
{
	internal class GifProcessor : BaseProcessor
	{
		public override List<string> ValidInputExtensions { get; protected set; } = new List<string>
		{
			".gif"
		};

		public override List<string> ValidOutputExtensions { get; protected set; } = new List<string>
		{
			".gif"
		};

		//HACK HACK HACK HACK!!!!!!!!
		//Save processed GIF here, because we only return a single bitmap, not an array!!
		private List<GifFrame> BufferedOutput = new List<GifFrame>();

		public override Bitmap ExecuteProcessing(FlagParameters Parameters, string FlagsDir, ref List<PrideFlag> Flags)
		{
			FinalImageSize = Parameters.OutputImageSize;
			BufferedOutput.Clear();

			Bitmap InputBitmap = (Bitmap)Image.FromFile(Parameters.InputImagePath);
			FrameDimension Dimension = new FrameDimension(InputBitmap.FrameDimensionsList[0]);
			int FrameCount = InputBitmap.GetFrameCount(Dimension);

			if (FrameCount <= 1)
				throw new ArgumentException("GIF file is not animated!");

			//Timings prop, not documented in C# but documented for C++.
			byte[] Times = InputBitmap.GetPropertyItem(0x5100).Value;

			GifFrame[] InputFrames = new GifFrame[FrameCount];
			for (int i = 0; i < FrameCount; i++)
			{
				int Duration = BitConverter.ToInt32(Times, 4 * i);

				InputBitmap.SelectActiveFrame(Dimension, i);

				Bitmap Frame = (Bitmap)InputBitmap.Clone();

				InputFrames[i] = new GifFrame()
				{
					Image = ResizeImage(ref Frame, FinalImageSize, FinalImageSize),
					Duration = Duration
				};
			}

			//We dont need the input bitmap anymore.
			InputBitmap.Dispose();

			int SegmentWidth = FinalImageSize / Parameters.Flags.Count; //How wide is each flag segment.
			int CurrentWidth = SegmentWidth; //How many pixels we must substract from a flag segment.

			Bitmap[] LoadedAndProcessedFlags = new Bitmap[Parameters.Flags.Count];
			for (int i = 0; i < LoadedAndProcessedFlags.Length; i++)
			{
				if(i == 0)
				{
					Bitmap PrimaryFlagBitmap = LoadAndResizeFlag(Path.Combine(FlagsDir, Flags[0].FlagFile), Parameters.OutputImageSize, Parameters.OutputImageSize);

					Bitmap TransformedPrimaryFlagBitmap = ProcessFlagTransformation(ref PrimaryFlagBitmap, Parameters.RotateFlag90,
																					Parameters.FlipFlagHorizontally, Parameters.FlipFlagVertically);

					//We dont need the primary flag bitmap anymore.
					PrimaryFlagBitmap.Dispose();

					//Crop primary flag.
					Bitmap CroppedPrimaryFlagBitmap = CropFlag(ref TransformedPrimaryFlagBitmap, Parameters.RingPixelMargin);

					//We dont need the transformed primary flag bitmap anymore.
					TransformedPrimaryFlagBitmap.Dispose();

					LoadedAndProcessedFlags[i] = CroppedPrimaryFlagBitmap;

					continue;
				}

				//Load flag segment bitmap.
				Bitmap SecondaryFlagBitmap = LoadAndResizeFlag(Path.Combine(FlagsDir, Flags[i].FlagFile), Parameters.OutputImageSize, Parameters.OutputImageSize);

				//Do the transformations (rotate 90º, flip horizontally, etc).
				Bitmap TransformedSecondaryFlagBitmap = ProcessFlagTransformation(ref SecondaryFlagBitmap, Parameters.RotateFlag90,
																		Parameters.FlipFlagHorizontally, Parameters.FlipFlagVertically);

				//We dont need the flag segment bitmap anymore.
				SecondaryFlagBitmap.Dispose();

				//Crop secondary flag.
				Bitmap CroppedSecondaryFlagBitmap = CropFlag(ref TransformedSecondaryFlagBitmap, Parameters.RingPixelMargin);

				//We dont need the transformed flag segment bitmap anymore.
				TransformedSecondaryFlagBitmap.Dispose();

				//Substract pixels from the bitmap, so it looks like a segment.
				CroppedSecondaryFlagBitmap = ProcessSecondaryFlag(ref CroppedSecondaryFlagBitmap, CurrentWidth);

				LoadedAndProcessedFlags[i] = CroppedSecondaryFlagBitmap;
			}

			for (int i = 0; i < InputFrames.Length; i++)
			{
				Bitmap FinalOutputBitmap = new Bitmap(FinalImageSize, FinalImageSize);

				for (int k = 0; k < LoadedAndProcessedFlags.Length; k++)
				{
					if(k == 0)
					{
						FinalOutputBitmap = StitchTogether(ref LoadedAndProcessedFlags[k], ref InputFrames[i].Image, FinalImageSize);
					}

					FinalOutputBitmap = StitchTogether(ref LoadedAndProcessedFlags[k], ref FinalOutputBitmap, Parameters.OutputImageSize);
				}

				BufferedOutput.Add(new GifFrame
				{
					Image = FinalOutputBitmap,
					Duration = InputFrames[i].Duration
				});
			}

			for (int i = 0; i < BufferedOutput.Count; i++)
			{
				BufferedOutput[i].Image.Save($"frame{i}.png", ImageFormat.Png);
			}

			//HACK HACK HACK!
			return new Bitmap("Flags/transgender.png");
		}

		public override Bitmap ExportBitmap(ref Bitmap Picture, string Filename)
		{
			return new Bitmap("Flags/transgender.png");
		}

		private Bitmap ResizeImage(ref Bitmap Source, int Width, int Height)
		{
			Bitmap Result = new Bitmap(Width, Height);

			using (Graphics Graphics = Graphics.FromImage(Result))
			{
				Graphics.Clear(Color.Transparent);

				if(Source.Width >= 256 && Source.Height >= 256 && Width >= 256 && Height >= 256)
				{
					Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
				}
				else Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

				Graphics.DrawImage(Source, 0, 0, Width, Height);
			}

			Source.Dispose();
			return Result;
		}

		protected override Bitmap LoadAndResizeImage(string Filename, int Width, int Height)
		{
			Bitmap Source = new Bitmap(Filename);
			Bitmap Result = new Bitmap(Width, Height);

			using (Graphics Graphics = Graphics.FromImage(Result))
			{
				Graphics.Clear(Color.Transparent);

				if (Source.Width >= 256 && Source.Height >= 256 && Width >= 256 && Height >= 256)
				{
					Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
				}
				else Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

				Graphics.DrawImage(Source, 0, 0, Width, Height);
			}

			Source.Dispose();
			return Result;
		}

		protected override Bitmap LoadAndResizeFlag(string Filename, int Width, int Height)
		{
			Bitmap Source = new Bitmap(Filename);
			Bitmap Result = new Bitmap(Width, Height);

			using (Graphics Graphics = Graphics.FromImage(Result))
			{
				Graphics.Clear(Color.Transparent);
				Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
				Graphics.DrawImage(Source, 0, 0, Width, Height);
			}

			Source.Dispose();
			return Result;
		}

		protected override Bitmap CropFlag(ref Bitmap Flag, int RingMargin)
		{
			Bitmap Result = (Bitmap)Flag.Clone();

			int WidthAndHeight = FinalImageSize - RingMargin;

			using (Graphics Graphics = Graphics.FromImage(Result))
			{
				//Center ellipse.
				int xy = (FinalImageSize - WidthAndHeight) / 2;

				//SourceCopy lets us "cut out" areas with transparent shapes.
				Graphics.CompositingMode = CompositingMode.SourceCopy;
				Graphics.FillEllipse(Brushes.Transparent, xy, xy, WidthAndHeight, WidthAndHeight);
			}

			return Result;
		}

		protected override Bitmap ProcessSecondaryFlag(ref Bitmap Flag, int Substract)
		{
			using (Graphics Graphics = Graphics.FromImage(Flag))
			{
				Graphics.CompositingMode = CompositingMode.SourceCopy;
				Graphics.FillRectangle(Brushes.Transparent, new Rectangle(0, 0, Substract, Flag.Height));
			}

			return Flag;
		}

		protected override Bitmap ProcessFlagTransformation(ref Bitmap Flag, bool Rotate90, bool FlipHorizontally, bool FlipVertically)
		{
			Bitmap Result = (Bitmap)Flag.Clone();

			if (Rotate90) Result.RotateFlip(RotateFlipType.Rotate90FlipNone);
			if (FlipHorizontally) Result.RotateFlip(RotateFlipType.RotateNoneFlipX);
			if (FlipVertically) Result.RotateFlip(RotateFlipType.RotateNoneFlipY);

			return Result;
		}

		protected override Bitmap StitchTogether(ref Bitmap Flag, ref Bitmap Picture, int PictureSize)
		{
			Bitmap Result = new Bitmap(FinalImageSize, FinalImageSize);

			using (Graphics Graphics = Graphics.FromImage(Result))
			{
				//Center image.
				int xy = (FinalImageSize - PictureSize) / 2;

				Graphics.Clear(Color.White);

				Graphics.DrawImage(Picture, xy, xy, PictureSize, PictureSize);
				Graphics.DrawImage(Flag, 0, 0, FinalImageSize, FinalImageSize);
			}

			return Result;
		}
	}
	
	internal class GifFrame
	{
		public Bitmap Image;
		public int Duration;
	}
}

