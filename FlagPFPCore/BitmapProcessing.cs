using System.Drawing;
using System.Drawing.Drawing2D;

namespace FlagPFPCore.Processing
{
	internal class BitmapProcessing
	{
		public int FinalImageSize;

		public void SetFullImageSize(int size)
		{
			FinalImageSize = size;
		}

		public Bitmap StitchTogether(ref Bitmap flag, ref Bitmap pic, int picSize)
		{
			Bitmap res = new Bitmap(FinalImageSize, FinalImageSize);

			using (Graphics g = Graphics.FromImage(res))
			{
				g.Clear(Color.White);
				g.DrawImage(pic, (FinalImageSize - picSize) / 2, (FinalImageSize - picSize) / 2, picSize, picSize);
				g.DrawImage(flag, 0, 0, FinalImageSize, FinalImageSize);
			}

			return res;
		}

		public Bitmap LoadAndResizeBmp(string filename, int width, int height)
		{
			Bitmap source = (Bitmap)Image.FromFile(filename);
			Bitmap result = new Bitmap(width, height);

			using (Graphics g = Graphics.FromImage(result))
			{
				g.Clear(Color.Transparent);
				g.InterpolationMode = InterpolationMode.NearestNeighbor;
				g.DrawImage(source, 0, 0, width, height);
			}

			source.Dispose();
			return result;
		}

		public Bitmap ProcessFlagTransformation(ref Bitmap flagImg, bool rotate90, bool flipHorizontally, bool flipVertically)
		{
			Bitmap target = flagImg;

			if (rotate90) target.RotateFlip(RotateFlipType.Rotate90FlipNone);
			if(flipHorizontally) target.RotateFlip(RotateFlipType.RotateNoneFlipX);
			if (flipVertically) target.RotateFlip(RotateFlipType.RotateNoneFlipY);

			return target;
		}

		public Bitmap CropFlag(ref Bitmap flagImg, int pixelMargin)
		{
			int widthHeight = FinalImageSize - pixelMargin;

			using (Graphics g = Graphics.FromImage(flagImg))
			{
				g.CompositingMode = CompositingMode.SourceCopy;
				g.FillEllipse(Brushes.Transparent,
					(FinalImageSize - widthHeight) / 2,
					(FinalImageSize - widthHeight) / 2, widthHeight, widthHeight);
			}

			return flagImg;
		}

		public Bitmap ProcessSecondaryFlag(ref Bitmap flag2Img, int width)
		{
			using (Graphics g = Graphics.FromImage(flag2Img))
			{
				g.CompositingMode = CompositingMode.SourceCopy;
				g.FillRectangle(Brushes.Transparent, new Rectangle(0, 0, width, flag2Img.Height));
			}

			return flag2Img;
		}
	}
}
