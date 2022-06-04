using FlagPFPCore.Exceptions;
using FlagPFPCore.Loading;
using FlagPFPCore.Processors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FlagPFPCore.FlagMaking
{
	public class FlagCoreObject
	{
		public Dictionary<string, PrideFlag> FlagDictionary;
		public string FlagsDirectory;

		private List<BaseProcessor> Processors = new List<BaseProcessor>();

		public FlagCoreObject(string flagsDir)
		{
			FlagsDirectory = flagsDir;

			Processors = GetChildrenOfType<BaseProcessor>().ToList();
		}

		public void LoadFlagDefsFromDir(string FlagJsonDirectory)
		{
			FlagLoader FlagLoader = new FlagLoader();
			FlagDictionary = FlagLoader.LoadFlags(FlagJsonDirectory, FlagsDirectory);
		}

		public void ExecuteProcessing(FlagParameters Parameters)
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

			foreach(BaseProcessor Processor in Processors)
			{
				if(Processor.ValidExtensions.Contains(InputExtension))
				{
					Processor.ExecuteProcessing(Parameters, FlagsDirectory, ref ChosenFlags);
					break;
				}
			}
		}

		public bool IsExtensionValid(string Filename)
		{
			string Extension = Path.GetExtension(Filename);
			bool Found = false;

			foreach (BaseProcessor Processor in Processors)
			{
				if (Processor.ValidExtensions.Contains(Extension))
				{
					Found = true;
					break;
				}
			}

			return Found;
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
