using System;
using System.IO;

namespace ValhemModUpdate.FileManager
{
    public class ThrunderModProfile
    {
        private static string ValheimDisplayBepInExInfoFileName = "Valheim.DisplayBepInExInfo.dll";

        private static string appdataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private static string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public string Name { get; set; }

        public bool BackUp { get; set; }

        public bool CustomBackup { get; set; }

        public string PlugInDirectory { get; set; }

        public string BackUpPlugInDirectory { get; set; }

        public string ZipFilePath { get; set; }
        /// <summary>
        /// Used to adjust Thundermod profile files/settings
        /// </summary>
        /// <param name="name">Profile Name (related to Thundermod profile folder)</param>
        public ThrunderModProfile(string name)
        {

            ValheimDisplayBepInExInfoFileName = "Valheim.DisplayBepInExInfo.dll";
            Name = name;
            CustomBackup = false;
            PlugInDirectory = $"{appdataFolderPath}\\Thunderstore Mod Manager\\DataFolder\\Valheim\\profiles\\{Name}" + @"\BepInEx\plugins";
            BackUpPlugInDirectory = $"{documentsFolder}" + $"\\plugins_old{DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss")}";
            ZipFilePath = "NotSet";
        }
        /// <summary>
        /// Unzip zip file defined in ZipFilePath To PlugInDirectory
        /// </summary>
        public void unzip()
        {
            // Move PlugIn Folder
            Directory.Move(PlugInDirectory, BackUpPlugInDirectory);
            // Create Plugin Folder in orignal path
            Directory.CreateDirectory(PlugInDirectory);
            // Copy needed dll
            File.Copy(Path.Combine(BackUpPlugInDirectory, ValheimDisplayBepInExInfoFileName), Path.Combine(PlugInDirectory, ValheimDisplayBepInExInfoFileName));
            // Delete back up if not wanted
            if (BackUp == false)
            {
                Directory.Delete(BackUpPlugInDirectory, true);
            }
            // Unzip to Plugins folder
            System.IO.Compression.ZipFile.ExtractToDirectory(ZipFilePath, PlugInDirectory);
        }
        /// <summary>
        /// Update cfg files and YAML files not implmented
        /// </summary>
        public void updateConfigurationFiles()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Set Custom Plugins Backup Location
        /// </summary>
        /// <param name="folderPath">Custom Folder Loaction</param>
        public void setCustomBackupFolder(string folderPath)
        {
            BackUpPlugInDirectory = folderPath + $"\\plugins_old{DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss")}";
        }
    }
}
