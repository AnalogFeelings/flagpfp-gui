using System.Collections.Generic;

namespace FlagPFPCore.Loading
{
	public class FlagParameters
	{
		public string InputImagePath { get; set; }
		public string OutputImagePath { get; set; }
		public int RingPixelMargin { get; set; }
		public int InnerImageSize { get; set; }
		public int OutputImageSize { get; set; }
		public bool RotateFlag90 { get; set; }
		public bool FlipFlagHorizontally { get; set; }
		public bool FlipFlagVertically { get; set; }
		public List<string> Flags { get; set; }
	}
}
