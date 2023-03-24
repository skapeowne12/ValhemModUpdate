using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using ValhemModUpdate.FileManager;

namespace ValhemModUpdate
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private ValhemModUpdate.FileManager.ThrunderModProfile thrunderModProfile = new ThrunderModProfile("Default");
        /// <summary>
        /// Click To get zip file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Open File Dialog
            ZipFileDiag = new OpenFileDialog();
            // set Folder Dir
            ZipFileDiag.InitialDirectory = "C:";
            // Set Profile Name
            string profileName = ProfileTextBox.Text;
            thrunderModProfile.Name = profileName;
            // File Dialog Open to Select Zip File
            if (ZipFileDiag.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    // Update UI Path
                    ZipFileTxtBox.Text = ZipFileDiag.FileName;
                    // Update Zip File Path
                    thrunderModProfile.ZipFilePath = ZipFileTxtBox.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error getting zip file");
                    throw;
                }

            }
            /// Rename Plugins to Plugins_old
            
            // Check for Back up
            if (backUpCheckBox.Checked == true)
            {
                thrunderModProfile.BackUp = true;
            }
            // Unzip Selected File
            thrunderModProfile.unzip();

            MessageBox.Show("Profile Has been Updated with mods in Zip");

        }

        private void ProfileSelectBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.InitialDirectory = $"C:%APPDATA%\\Roaming\\Thunderstore Mod Manager\\DataFolder\\Valheim\\profiles\\";

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                try
                {
                    ProfileTextBox.Text = System.IO.Path.GetFullPath(dialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in getting file path for Thunderstone Profile");
                    throw;
                }
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void SetCustomFolderbtn_Click(object sender, EventArgs e)
        {
            // Open File Dialog
            CommonOpenFileDialog backupDialog = new CommonOpenFileDialog();
            // Set To Folder Selector
            backupDialog.IsFolderPicker = true;
            // Set Custom Backup location
            if (backupDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                thrunderModProfile.setCustomBackupFolder(backupDialog.FileName);
                thrunderModProfile.CustomBackup = true;
            }

        }
    }
}
