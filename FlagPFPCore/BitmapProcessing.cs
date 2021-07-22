using System.Drawing;
using System.Drawing.Drawing2D;

namespace FlagPFPCore.Processing
{
    internal class BitmapProcessing
    {
        public int FinalImageSize;

        public Bitmap StitchTogether(ref Bitmap flag, ref Bitmap pic, int picSize)
        {
            Bitmap res = new Bitmap(FinalImageSize, FinalImageSize);
            using (Graphics g = Graphics.FromImage(res))
            {
                g.Clear(Color.White);
                g.DrawImage(pic, new Rectangle((FinalImageSize - picSize) / 2,
                    (FinalImageSize - picSize) / 2, picSize, picSize));
                g.DrawImage(flag, new Rectangle(0, 0, FinalImageSize, FinalImageSize));
            }
            return res;
        }

        public Bitmap LoadAndResizeBmp(string filename, int width, int height)
        {
            Bitmap source = new Bitmap(Image.FromFile(filename));
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(source, 0, 0, width, height);
            }
            return result;
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
    }
}
