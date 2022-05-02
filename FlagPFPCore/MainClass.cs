using FlagPFPCore.Exceptions;
using FlagPFPCore.Loading;
using FlagPFPCore.Processing;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

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
			int fullSize, string outputImage, params string[] flags)
		{
			BitmapProcessing bitmapProcessor = new BitmapProcessing();
			bitmapProcessor.SetFullImageSize(fullSize);

			List<PrideFlag> chosenFlags = new List<PrideFlag>();
			foreach (string chosenFlag in flags)
			{
				PrideFlag outputFlag;
				if (!FlagDictionary.TryGetValue(chosenFlag, out outputFlag))
				{
					throw new InvalidFlagException($"Flag type \"{chosenFlag}\" is invalid.");
				}
				chosenFlags.Add(outputFlag);
			}

			Bitmap inputBmp = bitmapProcessor.LoadAndResizeBmp(inputImage, fullSize, fullSize);
			Bitmap primaryFlagBmp = bitmapProcessor.LoadAndResizeBmp(Path.Combine(FlagsDirectory, chosenFlags[0].FlagFile),
																fullSize, fullSize);

			Bitmap croppedPrimaryFlagBmp = bitmapProcessor.CropFlag(ref primaryFlagBmp, pixelMargin);
			// Place primary flag now.
			Bitmap finalBmp = bitmapProcessor.StitchTogether(ref croppedPrimaryFlagBmp, ref inputBmp, innerSize);
			chosenFlags.RemoveAt(0);

			int segmentWidth = finalBmp.Width / flags.Length;
			int currentWidth = segmentWidth;
			foreach (PrideFlag prideFlag in chosenFlags)
			{
				Bitmap secondaryFlagBmp = bitmapProcessor.LoadAndResizeBmp(Path.Combine(FlagsDirectory, prideFlag.FlagFile),
																			fullSize, fullSize);
				Bitmap croppedSecondaryFlagBmp = bitmapProcessor.CropFlag(ref secondaryFlagBmp, pixelMargin);
				croppedSecondaryFlagBmp = bitmapProcessor.ProcessSecondaryFlag(ref croppedSecondaryFlagBmp, currentWidth);

				finalBmp = bitmapProcessor.StitchTogether(ref croppedSecondaryFlagBmp, ref finalBmp, fullSize);

				currentWidth += segmentWidth;
			}

			finalBmp.Save(outputImage, ImageFormat.Png);
		}
	}
}
