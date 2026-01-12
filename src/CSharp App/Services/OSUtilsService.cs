using System;
using System.Diagnostics;

namespace VolumetricSelection2077.Services;

/// <summary>
/// Currently supports Windows, Linux and MacOS, created to gather all the OS specific code in one place (except UpdateService)
/// </summary>
public class OsUtilsService
{
    public static void OpenFolder(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
            return;
        
        if (OperatingSystem.IsWindows())
            Process.Start(new ProcessStartInfo("explorer.exe", $"\"{path}\"") { UseShellExecute = true });
        else if (OperatingSystem.IsLinux())
            Process.Start(new ProcessStartInfo("xdg-open", path) { UseShellExecute = true });
        else if  (OperatingSystem.IsMacOS())
            Process.Start(new ProcessStartInfo("open", path) { UseShellExecute = true });
    }
}