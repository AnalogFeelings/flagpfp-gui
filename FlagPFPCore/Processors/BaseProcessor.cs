using FlagPFPCore.Loading;
using System.Collections.Generic;
using System.Drawing;

namespace FlagPFPCore.Processors
{
	internal abstract class BaseProcessor
	{
		public virtual List<string> ValidInputExtensions { get; protected set; }
		public virtual List<string> ValidOutputExtensions { get; protected set; }

		protected int FinalImageSize = 0;

		public abstract Bitmap ExecuteProcessing(FlagParameters Parameters, string FlagsDir, ref List<PrideFlag> Flags);
		public abstract Bitmap ExportBitmap(ref Bitmap Picture, string Filename);

		protected abstract Bitmap StitchTogether(ref Bitmap Flag, ref Bitmap Picture, int PictureSize);
		protected abstract Bitmap LoadAndResizeImage(string Filename, int Width, int Height);
		protected abstract Bitmap LoadAndResizeFlag(string Filename, int Width, int Height);
		protected abstract Bitmap ProcessFlagTransformation(ref Bitmap Flag, bool Rotate90, bool FlipHorizontally, bool FlipVertically);
		protected abstract Bitmap CropFlag(ref Bitmap Flag, int RingMargin);
		protected abstract Bitmap ProcessSecondaryFlag(ref Bitmap Flag, int Substract);
	}
}
