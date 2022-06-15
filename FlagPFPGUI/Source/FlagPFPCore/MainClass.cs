using FlagPFPCore.Exceptions;
using FlagPFPCore.Loading;
using FlagPFPCore.Processors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FlagPFPCore.FlagMaking
{
	public class FlagCoreObject
	{
		public Dictionary<string, PrideFlag> FlagDictionary;
		public string FlagImageDirectory;
		public string FlagJsonsDirectory;

		private List<BaseProcessor> Processors = new List<BaseProcessor>();
		private List<string> ValidExtensions = new List<string>();

		public FlagCoreObject(string FlagImagesDirectory)
		{
			FlagImageDirectory = FlagImagesDirectory;

			Processors = GetChildrenOfType<BaseProcessor>().ToList();

			foreach (BaseProcessor Processor in Processors)
			{
				foreach (string Extension in Processor.ValidInputExtensions)
				{
					if (!ValidExtensions.Contains(Extension)) ValidExtensions.Add(Extension);
				}
			}
		}

		public void LoadFlagDefsFromDir(string FlagJsonDirectory)
		{
			FlagJsonsDirectory = FlagJsonDirectory;

			FlagLoader FlagLoader = new FlagLoader();
			FlagDictionary = FlagLoader.LoadFlags(FlagJsonDirectory, FlagImageDirectory);
		}

		public Bitmap ExecuteProcessing(FlagParameters Parameters)
		{
			//Go through the passed list of pride flags the user wants, check if they are valid, and put the PrideFlag object on a list.
			List<PrideFlag> ChosenFlags = new List<PrideFlag>();
			foreach (string PassedFlag in Parameters.Flags)
			{
				PrideFlag RetrievedFlag;

				if (!FlagDictionary.TryGetValue(PassedFlag, out RetrievedFlag))
				{
					throw new InvalidFlagException($"Flag type \"{PassedFlag}\" is invalid.");
				}

				ChosenFlags.Add(RetrievedFlag);
			}

			string InputExtension = Path.GetExtension(Parameters.InputImagePath);

			BaseProcessor InputProcessor = null;

			foreach (BaseProcessor Processor in Processors)
			{
				if (Processor.ValidInputExtensions.Contains(InputExtension))
				{
					InputProcessor = Processor;
					break;
				}
			}

			if (InputProcessor == null) throw new NoProcessorFoundException($"No input processor for extension \"{InputExtension}\" found.");

			return InputProcessor.ExecuteProcessing(Parameters, FlagImageDirectory, ref ChosenFlags);
		}

		public Bitmap ExportBitmap(ref Bitmap Picture, string Filename)
		{
			string OutputExtension = Path.GetExtension(Filename);

			BaseProcessor OutputProcessor = null;

			foreach (BaseProcessor Processor in Processors)
			{
				if (Processor.ValidOutputExtensions.Contains(OutputExtension))
				{
					OutputProcessor = Processor;
					break;
				}
			}

			if (OutputProcessor == null) throw new NoProcessorFoundException($"No output processor for extension \"{OutputExtension}\" found.");

			Bitmap Result = OutputProcessor.ExportBitmap(ref Picture, Filename);

			return Result;
		}

		public bool IsExtensionValid(string Filename)
		{
			string Extension = Path.GetExtension(Filename);

			return ValidExtensions.Contains(Extension);
		}

		public List<string> GetValidExtensions()
		{
			return ValidExtensions;
		}

		private IEnumerable<T> GetChildrenOfType<T>() where T : class
		{
			List<T> FoundClasses = new List<T>();

			foreach (Type Type in Assembly.GetAssembly(typeof(T)).GetTypes()
				.Where(ClassType => ClassType.IsClass && !ClassType.IsAbstract && ClassType.IsSubclassOf(typeof(T))))
			{
				FoundClasses.Add((T)Activator.CreateInstance(Type));
			}

			return FoundClasses;
		}
	}
}
