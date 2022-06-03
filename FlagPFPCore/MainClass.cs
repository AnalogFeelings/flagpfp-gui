using FlagPFPCore.Exceptions;
using FlagPFPCore.Loading;
using FlagPFPCore.Processing;
using FlagPFPGUI.FlagPFPCore;
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
			FlagDictionary = flagLoader.LoadFlags(dir, FlagsDirectory);
		}

		public void ExecuteProcessing(FlagParameters Parameters)
		{
			BitmapProcessing bitmapProcessor = new BitmapProcessing();
			bitmapProcessor.SetFullImageSize(Parameters.OutputImageSize);

			List<PrideFlag> chosenFlags = new List<PrideFlag>();
			foreach (string chosenFlag in Parameters.Flags)
			{
				PrideFlag outputFlag;
				if (!FlagDictionary.TryGetValue(chosenFlag, out outputFlag))
				{
					throw new InvalidFlagException($"Flag type \"{chosenFlag}\" is invalid.");
				}
				chosenFlags.Add(outputFlag);
			}

			Bitmap inputBmp = bitmapProcessor.LoadAndResizeBmp(Parameters.InputImagePath, Parameters.OutputImageSize, Parameters.OutputImageSize);
			Bitmap primaryFlagBmp = bitmapProcessor.LoadAndResizeBmp(Path.Combine(FlagsDirectory, chosenFlags[0].FlagFile),
																Parameters.OutputImageSize, Parameters.OutputImageSize);

			Bitmap transformedPrimaryFlagBmp = bitmapProcessor.ProcessFlagTransformation(ref primaryFlagBmp, Parameters.RotateFlag90,
				Parameters.FlipFlagHorizontally, Parameters.FlipFlagVertically);

			Bitmap croppedPrimaryFlagBmp = bitmapProcessor.CropFlag(ref transformedPrimaryFlagBmp, Parameters.RingPixelMargin);
			// Place primary flag now.
			Bitmap finalBmp = bitmapProcessor.StitchTogether(ref croppedPrimaryFlagBmp, ref inputBmp, Parameters.InnerImageSize);
			chosenFlags.RemoveAt(0);

			int segmentWidth = finalBmp.Width / Parameters.Flags.Count;
			int currentWidth = segmentWidth;
			foreach (PrideFlag prideFlag in chosenFlags)
			{
				Bitmap secondaryFlagBmp = bitmapProcessor.LoadAndResizeBmp(Path.Combine(FlagsDirectory, prideFlag.FlagFile),
																			Parameters.OutputImageSize, Parameters.OutputImageSize);
				Bitmap transformedSecondaryFlagBmp = bitmapProcessor.ProcessFlagTransformation(ref secondaryFlagBmp, Parameters.RotateFlag90,
					Parameters.FlipFlagHorizontally, Parameters.FlipFlagVertically);

				Bitmap croppedSecondaryFlagBmp = bitmapProcessor.CropFlag(ref transformedSecondaryFlagBmp, Parameters.RingPixelMargin);
				croppedSecondaryFlagBmp = bitmapProcessor.ProcessSecondaryFlag(ref croppedSecondaryFlagBmp, currentWidth);

				finalBmp = bitmapProcessor.StitchTogether(ref croppedSecondaryFlagBmp, ref finalBmp, Parameters.OutputImageSize);

				currentWidth += segmentWidth;

				secondaryFlagBmp.Dispose();
				transformedSecondaryFlagBmp.Dispose();
				croppedSecondaryFlagBmp.Dispose();
			}

			finalBmp.Save(Parameters.OutputImagePath, ImageFormat.Png);

			inputBmp.Dispose();
			primaryFlagBmp.Dispose();
			transformedPrimaryFlagBmp.Dispose();
			croppedPrimaryFlagBmp.Dispose();
			finalBmp.Dispose();
		}
	}
}
