// Some copyright should be here...

using UnrealBuildTool;
using System.IO;

public class OpenCV : ModuleRules
{
    private string ThirdPartyPath
    {
        get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "../../../../ThirdParty/")); }
    }

	public OpenCV(TargetInfo Target)
	{
        // Startard Module Dependencies
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "RHI", "RenderCore" });
		PrivateDependencyModuleNames.AddRange(new string[] { "CoreUObject", "Engine", "Slate", "SlateCore" });

        // Start OpenCV linking here!
        bool isLibrarySupported = false;

        // Create OpenCV Path 
        string OpenCVPath = Path.Combine(ThirdPartyPath, "OpenCV");

        // Get Library Path 
        string LibPath = "";
        bool isdebug = Target.Configuration == UnrealTargetConfiguration.Debug && BuildConfiguration.bDebugBuildsActuallyUseDebugCRT;
        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            LibPath = Path.Combine(OpenCVPath, "Libraries", "Win64");
            isLibrarySupported = true;
        }
        else if (Target.Platform == UnrealTargetPlatform.Win32)
        {
            // TODO: add OpenCV binaries for Win32
        }
        else if (Target.Platform == UnrealTargetPlatform.Mac)
        {
            // TODO: add OpenCV binaries for Mac
        }
        else if (Target.Platform == UnrealTargetPlatform.Linux)
        {
            // TODO: add OpenCV binaries for Linux
        }
        else
        {
            string Err = string.Format("{0} dedicated server is made to depend on {1}. We want to avoid this, please correct module dependencies.", Target.Platform.ToString(), this.ToString()); System.Console.WriteLine(Err);
        }

        if (isLibrarySupported)
        {
            //Add Include path 
            PublicIncludePaths.AddRange(new string[] { Path.Combine(OpenCVPath, "Includes") });

            // Add Library Path 
            PublicLibraryPaths.Add(LibPath);

            //Add Static Libraries
            PublicAdditionalLibraries.Add("opencv_world320.lib");

            //Add Dynamic Libraries
            PublicDelayLoadDLLs.Add("opencv_world320.dll");
            PublicDelayLoadDLLs.Add("opencv_ffmpeg320_64.dll");

        }

        Definitions.Add(string.Format("WITH_OPENCV_BINDING={0}", isLibrarySupported ? 1 : 0));
	}
}
