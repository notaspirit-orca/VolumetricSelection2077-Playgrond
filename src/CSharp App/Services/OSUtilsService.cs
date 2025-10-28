using System.Diagnostics;

namespace VolumetricSelection2077.Services;

/// <summary>
/// Currently only supports Windows, created to gather all the OS specific code in one place (except UpdateService)
/// </summary>
public class OsUtilsService
{
    public static void OpenFolder(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
            return;
        
        Process.Start(new ProcessStartInfo("explorer.exe", $"\"{path}\"") { UseShellExecute = true });
    }
}