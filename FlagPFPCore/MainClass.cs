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

        public void ExecuteProcessing(string inputImage, int pixelMargin, int innerSize,
            int fullSize, string outputImage, string flagType, string flagType2 = "")
        {
            BitmapProcessing bitmapProcessor = new BitmapProcessing();

            bitmapProcessor.SetFullImageSize(fullSize);

            PrideFlag chosenFlag = null;
            PrideFlag chosenFlag2 = null;
            if (!FlagDictionary.TryGetValue(flagType, out chosenFlag)) throw new InvalidFlagException($"Flag type \"{flagType}\" is invalid.");
            if (flagType2 != "")
            {
                if (!FlagDictionary.TryGetValue(flagType2, out chosenFlag2)) throw new InvalidFlagException($"Flag type \"{flagType2}\" is invalid.");
            }

            Bitmap inputBmp = bitmapProcessor.LoadAndResizeBmp(inputImage, fullSize, fullSize);
            Bitmap flagBmp = bitmapProcessor.LoadAndResizeBmp(Path.Combine(FlagsDirectory, chosenFlag.FlagFile),
                                                                fullSize, fullSize);
            Bitmap flagBmp2 = null;
            if (flagType2 != "")
            {
                flagBmp2 = bitmapProcessor.LoadAndResizeBmp(Path.Combine(FlagsDirectory, chosenFlag2.FlagFile),
                                                                fullSize, fullSize);
            }

            Bitmap croppedFlagBmp = bitmapProcessor.CropFlag(ref flagBmp, pixelMargin);
            Bitmap croppedFlag2Bmp = null;
            if (flagType2 != "")
            {
                croppedFlag2Bmp = bitmapProcessor.CropFlag(ref flagBmp2, pixelMargin);
                croppedFlag2Bmp = bitmapProcessor.ProcessSecondaryFlag(ref croppedFlag2Bmp);
            }

            Bitmap finalBmp = bitmapProcessor.StitchTogether(ref croppedFlagBmp, ref inputBmp, innerSize);
            if (flagType2 != "")
            {
                finalBmp = bitmapProcessor.StitchTogether(ref croppedFlag2Bmp, ref finalBmp, innerSize);
            }

            finalBmp.Save(outputImage, ImageFormat.Png);
        }
    }
}
