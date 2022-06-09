# FlagPFP GUI
![GitHub Repo size](https://img.shields.io/github/repo-size/aestheticalz/flagpfp-gui?label=Repo%20Size&style=flat-square)
![Lines of code](https://img.shields.io/tokei/lines/github/aestheticalz/flagpfp-gui?label=Lines%20Of%20Code&style=flat-square)
![GitHub Repo stars](https://img.shields.io/github/stars/aestheticalz/flagpfp-gui?label=Stars&style=flat-square)
![GitHub License](https://img.shields.io/github/license/aestheticalz/flagpfp-gui?label=License&style=flat-square)
![GitHub Issues](https://img.shields.io/github/issues/aestheticalz/flagpfp-gui?label=Issues&style=flat-square)

GUI frontend for [FlagPFP](https://github.com/AestheticalZ/FlagPFP), with [FlagPFP.Core](https://github.com/AestheticalZ/FlagPFPCore) integrated.

Now supports a large number of flags in the same image!

## Why was FlagPFP.Core integrated?
Due to compatibility issues with Newtonsoft.Json and NET Standard 2.0, I decided to integrate the code into the windows forms app, which is .NET Framework 4.8-based.

## Building
Open the .sln file in VS2022 and select Debug or Release, then build it.

⚠️ **WARNING** ⚠️ :: Needs libwebp named as "libwebp_x64.dll" in the same directory as the executable. Get libwebp [here](https://github.com/webmproject/libwebp).

# Program Screenshot
![example](picreadme.png)
