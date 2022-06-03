using FlagPFPCore.Exceptions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlagPFPCore.Loading
{
	public class PrideFlag
	{
		public string FlagFile { get; set; }
		public string ParameterName { get; set; }
	}

	internal class FlagLoader
	{
		public Dictionary<string, PrideFlag> LoadFlags(string folder, string imageDir)
		{
			List<string> files = Directory.GetFiles(folder).ToList();
			if (files.Count == 0) throw new NoFlagsFoundException();

			Dictionary<string, PrideFlag> finalList = new Dictionary<string, PrideFlag>();

			foreach (string file in files)
			{
				string jsonContent = File.ReadAllText(file);
				PrideFlag flag = JsonConvert.DeserializeObject<PrideFlag>(jsonContent);

				if (!string.IsNullOrWhiteSpace(flag.FlagFile) && File.Exists(Path.Combine(imageDir, flag.FlagFile))) finalList.Add(flag.ParameterName, flag);
			}

			return finalList;
		}
	}
}
