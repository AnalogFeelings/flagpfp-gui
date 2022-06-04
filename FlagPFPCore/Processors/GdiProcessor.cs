using FlagPFPCore.Loading;
using FlagPFPCore.Processors;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace FlagPFPGUI.FlagPFPCore.Processors
{
	internal class GdiProcessor : BaseProcessor
	{
		public override List<string> ValidExtensions
		{
			get
			{
				return new List<string>
				{
					".png",
					".jpg",
					".jpeg"
				};
			}
		}

		public override void ExecuteProcessing(FlagParameters Parameters, string FlagsDir, ref List<PrideFlag> Flags)
		{
			FinalImageSize = Parameters.OutputImageSize;

			//Load input bitmap and primary flag.
			Bitmap InputBitmap = LoadAndResizeImage(Parameters.InputImagePath, Parameters.OutputImageSize, Parameters.OutputImageSize);
			Bitmap PrimaryFlagBitmap = LoadAndResizeImage(Path.Combine(FlagsDir, Flags[0].FlagFile),
																	Parameters.OutputImageSize, Parameters.OutputImageSize);

			//Do the transformations (rotate 90º, flip horizontally, etc).
			Bitmap TransformedPrimaryFlagBitmap = ProcessFlagTransformation(ref PrimaryFlagBitmap, Parameters.RotateFlag90,
																Parameters.FlipFlagHorizontally, Parameters.FlipFlagVertically);

			//We dont need the primary flag bitmap anymore.
			PrimaryFlagBitmap.Dispose();

			//Crop primary flag.
			Bitmap CroppedPrimaryFlagBitmap = CropFlag(ref TransformedPrimaryFlagBitmap, Parameters.RingPixelMargin);

			//We dont need the transformed primary flag bitmap anymore.
			TransformedPrimaryFlagBitmap.Dispose();

			// Place primary flag now.
			Bitmap FinalOutputBitmap = StitchTogether(ref CroppedPrimaryFlagBitmap, ref InputBitmap, Parameters.InnerImageSize);
			Flags.RemoveAt(0);

			//We dont need the input or the cropped primary flag bitmap anymore.
			InputBitmap.Dispose();
			CroppedPrimaryFlagBitmap.Dispose();

			int SegmentWidth = FinalOutputBitmap.Width / Parameters.Flags.Count; //How wide is each flag segment.
			int CurrentWidth = SegmentWidth; //How many pixels we must substract from a flag segment.
			foreach (PrideFlag Flag in Flags)
			{
				//Load flag segment bitmap.
				Bitmap SecondaryFlagBitmap = LoadAndResizeImage(Path.Combine(FlagsDir, Flag.FlagFile),
															Parameters.OutputImageSize, Parameters.OutputImageSize);

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

				FinalOutputBitmap = StitchTogether(ref CroppedSecondaryFlagBitmap, ref FinalOutputBitmap, Parameters.OutputImageSize);

				//We dont need the cropped flag segment bitmap anymore.
				CroppedSecondaryFlagBitmap.Dispose();

				CurrentWidth += SegmentWidth;
			}

			string Format = Path.GetExtension(Parameters.OutputImagePath);
			switch (Format)
			{
				case ".png":
					FinalOutputBitmap.Save(Parameters.OutputImagePath, ImageFormat.Png);
					break;
				case ".jpeg":
				case ".jpg":
					ImageCodecInfo JpegEncoder = GetEncoder(ImageFormat.Jpeg);
					Encoder Encoder = Encoder.Quality;
					EncoderParameters EncoderParameters = new EncoderParameters(1);

					EncoderParameter QualityParameter = new EncoderParameter(Encoder, 100L);
					EncoderParameters.Param[0] = QualityParameter;

					FinalOutputBitmap.Save(Parameters.OutputImagePath, JpegEncoder, EncoderParameters);
					break;
			}

			FinalOutputBitmap.Dispose();
		}

		private ImageCodecInfo GetEncoder(ImageFormat Format)
		{
			ImageCodecInfo[] Codecs = ImageCodecInfo.GetImageEncoders();
			foreach (ImageCodecInfo Codec in Codecs)
			{
				if (Codec.FormatID == Format.Guid)
				{
					return Codec;
				}
			}
			return null;
		}

		public override Bitmap LoadAndResizeImage(string Filename, int Width, int Height)
		{
			Bitmap Source = (Bitmap)Image.FromFile(Filename);
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

		public override Bitmap CropFlag(ref Bitmap Flag, int RingMargin)
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

		public override Bitmap ProcessSecondaryFlag(ref Bitmap Flag, int Substract)
		{
			using (Graphics Graphics = Graphics.FromImage(Flag))
			{
				Graphics.CompositingMode = CompositingMode.SourceCopy;
				Graphics.FillRectangle(Brushes.Transparent, new Rectangle(0, 0, Substract, Flag.Height));
			}

			return Flag;
		}

		public override Bitmap ProcessFlagTransformation(ref Bitmap Flag, bool Rotate90, bool FlipHorizontally, bool FlipVertically)
		{
			Bitmap Result = (Bitmap)Flag.Clone();

			if (Rotate90) Result.RotateFlip(RotateFlipType.Rotate90FlipNone);
			if (FlipHorizontally) Result.RotateFlip(RotateFlipType.RotateNoneFlipX);
			if (FlipVertically) Result.RotateFlip(RotateFlipType.RotateNoneFlipY);

			return Result;
		}

		public override Bitmap StitchTogether(ref Bitmap Flag, ref Bitmap Picture, int PictureSize)
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
}
