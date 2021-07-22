using FlagPFPCore.Loading;
using FlagPFPCore.Processing;
using FlagPFPCore.Exceptions;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace FlagPFPCore.FlagMaking
{
    public class FlagCoreObject
    {
        public Dictionary<string, PrideFlag> FlagDictionary;
        public string FlagsDirectory;

        public FlagCoreObject(string flagsDir)
        {
            FlagsDirectory = flagsDir;
        }

        public void LoadFlagDefsFromDir(string dir)
        {
            FlagLoader flagLoader = new FlagLoader();
            FlagDictionary = flagLoader.LoadFlags(dir);
        }

        public void ExecuteProcessing(string inputImage, string flagType, int pixelMargin, int innerSize,
            int fullSize, string outputImage)
        {
            BitmapProcessing bitmapProcessor = new BitmapProcessing();
            bitmapProcessor.FinalImageSize = fullSize;

            PrideFlag chosenFlag;
            if (!FlagDictionary.TryGetValue(flagType, out chosenFlag)) throw new InvalidFlagException();

            Bitmap inputBmp = bitmapProcessor.LoadAndResizeBmp(inputImage, fullSize, fullSize);
            Bitmap flagBmp = bitmapProcessor.LoadAndResizeBmp(Path.Combine(FlagsDirectory, chosenFlag.FlagFile),
                                                                fullSize, fullSize);

            Bitmap croppedFlagBmp = bitmapProcessor.CropFlag(ref flagBmp, pixelMargin);
            Bitmap finalBmp = bitmapProcessor.StitchTogether(ref croppedFlagBmp, ref inputBmp, innerSize);

            finalBmp.Save(outputImage, ImageFormat.Png);
        }
    }
}
