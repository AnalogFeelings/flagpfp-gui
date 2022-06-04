using FlagPFPCore.Loading;
using System.Collections.Generic;
using System.Drawing;

namespace FlagPFPCore.Processors
{
	internal abstract class BaseProcessor
	{
		public virtual List<string> ValidExtensions { get; protected set; }
		public int FinalImageSize;

		public abstract void ExecuteProcessing(FlagParameters Parameters, string FlagsDir, ref List<PrideFlag> Flags);

		public abstract Bitmap StitchTogether(ref Bitmap Flag, ref Bitmap Picture, int PictureSize);
		public abstract Bitmap LoadAndResizeImage(string Filename, int Width, int Height);
		public abstract Bitmap ProcessFlagTransformation(ref Bitmap Flag, bool Rotate90, bool FlipHorizontally, bool FlipVertically);
		public abstract Bitmap CropFlag(ref Bitmap Flag, int RingMargin);
		public abstract Bitmap ProcessSecondaryFlag(ref Bitmap Flag, int Substract);
	}
}
