using Pastel;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace FlagPFPGUI.Updater
{
	public enum LogSeverity
	{
		MESSAGE,
		WARNING,
		ERROR
	}

	public class Program
	{
		//Arg 0: New version
		//Arg 1: FlagPFP process name
		//Arg 2: Checksum filename
		//Arg 3: Package filename
		static void Main(string[] args)
		{
			if (args.Length < 4) return;

			string TargetDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string CurrentFilename = Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);

			string NewVersion = args[0];
			string FriendlyFlagPFPProcess = args[1].Replace(".exe", "");
			string ChecksumFilename = args[2];
			string PackageFilename = args[3];

			Console.Title = "FlagPFP-GUI Updater";
			if (Environment.OSVersion.Version.Major < 10) ConsoleExtensions.Disable();

			Log($"Waiting until {"FlagPFP-GUI".Pastel(Color.LimeGreen)} shuts down...", LogSeverity.MESSAGE);

			while (true)
			{
				Process[] FlagProcess = Process.GetProcessesByName(FriendlyFlagPFPProcess);

				if (FlagProcess.Length > 0) Thread.Sleep(100);
				else break;
			}

			Log($"Installing {"FlagPFP-GUI".Pastel(Color.LimeGreen)} {$"v{NewVersion}".Pastel(Color.Lime)}", LogSeverity.MESSAGE);

			try
			{
				if (!File.Exists(PackageFilename)) throw new FileNotFoundException($"The update package was not found. Expected a file called \"{PackageFilename}\" in this directory.");

				Log($"Extracting {PackageFilename.Pastel(Color.LimeGreen)} to Temp directory...", LogSeverity.MESSAGE);
				if (Directory.Exists("Temp")) Directory.Delete("Temp", true);

				ZipFile.ExtractToDirectory(PackageFilename, "Temp");

				DirectoryInfo TempDir = new DirectoryInfo("Temp");
				DirectoryInfo[] TempSubdirs = TempDir.GetDirectories();

				foreach (DirectoryInfo Dir in TempSubdirs)
				{
					Log($"Copying updated directory \"{Dir.Name.Pastel(Color.Lime)}\" and its contents to existing install...", LogSeverity.MESSAGE);
					CopyDirectory(Dir.FullName, Path.Combine(TargetDirectory, Dir.Name), true);
				}

				FileInfo[] TempDirFiles = TempDir.GetFiles();
				foreach (FileInfo File in TempDirFiles)
				{
					if (File.Name == CurrentFilename || File.Name == "Pastel.dll") continue;

					Log($"Copying updated file \"{File.Name.Pastel(Color.Lime)}\" to existing install...", LogSeverity.MESSAGE);
					File.CopyTo(Path.Combine(TargetDirectory, File.Name), true);
				}

				Log($"Cleaning up left over files...", LogSeverity.MESSAGE);

				Directory.Delete("Temp", true);
				File.Delete(PackageFilename);
				File.Delete(ChecksumFilename);

				Log($"Done! Starting FlagPFP-GUI...", LogSeverity.MESSAGE);

				ProcessStartInfo editorProcess = new ProcessStartInfo(args[1]);
				editorProcess.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
				editorProcess.UseShellExecute = true;
				Process.Start(editorProcess);

				Environment.Exit(0);
			}
			catch (Exception ex)
			{
				Log($"Error! {ex.Message.Pastel(Color.IndianRed)}", LogSeverity.ERROR);

				Thread.Sleep(Timeout.Infinite);
			}
		}

		static void CopyDirectory(string Source, string Destination, bool Recursive)
		{
			DirectoryInfo Dir = new DirectoryInfo(Source);
			DirectoryInfo[] Subdirs = Dir.GetDirectories();

			Directory.CreateDirectory(Destination);

			foreach (FileInfo File in Dir.GetFiles())
			{
				string TargetPath = Path.Combine(Destination, File.Name);
				File.CopyTo(TargetPath, true);
			}

			if (Recursive)
			{
				foreach (DirectoryInfo Subdir in Subdirs)
				{
					string TargetPath = Path.Combine(Destination, Subdir.Name);
					CopyDirectory(Subdir.FullName, TargetPath, true);
				}
			}
		}

		static void Log(string Message, LogSeverity Severity)
		{
			switch (Severity)
			{
				case LogSeverity.MESSAGE:
					Console.WriteLine($"[{"MSG".Pastel(Color.CadetBlue)}] {Message}");
					break;
				case LogSeverity.WARNING:
					Console.WriteLine($"[{"WRN".Pastel(Color.Yellow)}] {Message}");
					break;
				case LogSeverity.ERROR:
					Console.WriteLine($"[{"ERR".Pastel(Color.Red)}] {Message}");
					break;
			}
		}
	}
}
