using System.Reflection;
using System.Resources;

// General Information
[assembly: AssemblyTitle("CursorMod")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Tommo J. Productions")]
[assembly: AssemblyProduct("CursorMod")]
[assembly: AssemblyCopyright("Tommo J. Productions Copyright © 2022")]
[assembly: AssemblyTrademark("Azine")]
[assembly: NeutralResourcesLanguage("en-AU")]

// Version information
[assembly: AssemblyVersion("1.0.309.5")]
[assembly: AssemblyFileVersion("1.0.309.5")]

namespace TommoJProductions.CursorMod
{

    public class VersionInfo
    {
	    public const string lastestRelease = "06.11.2022 11:35 AM";
	    public const string version = "1.0.309.5";

        /// <summary>
        /// Represents if the mod has been complied for x64
        /// </summary>
        #if x64
            internal const bool IS_64_BIT = true;
        #else
            internal const bool IS_64_BIT = false;
        #endif
        /// <summary>
        /// Represents if the mod has been complied in Debug mode
        /// </summary>
        #if DEBUG
            internal const bool IS_DEBUG_CONFIG = true;
        #else
            internal const bool IS_DEBUG_CONFIG = false;
        #endif
    }
}
