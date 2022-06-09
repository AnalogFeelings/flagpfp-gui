using Newtonsoft.Json;
using System.Collections.Generic;

namespace FlagPFPGUI
{
	public class UpdaterResponse
	{
		[JsonProperty("html_url")]
		public string ReleaseUrl { get; set; }
		[JsonProperty("tag_name")]
		public string VersionTag { get; set; }
		[JsonProperty("body")]
		public string Description { get; set; }
		[JsonProperty("assets")]
		public List<ReleaseAsset> Assets { get; set; }
	}

	public class ReleaseAsset
	{
		[JsonProperty("browser_download_url")]
		public string DownloadUrl { get; set; }
		[JsonProperty("name")]
		public string Filename { get; set; }
	}
}
