
namespace ValhemModUpdate
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogBTN = new System.Windows.Forms.Button();
            this.ZipFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.ZipFileTxtBox = new System.Windows.Forms.TextBox();
            this.ZipFileLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileTextBox = new System.Windows.Forms.TextBox();
            this.ProfileGB = new System.Windows.Forms.GroupBox();
            this.backUpCheckBox = new System.Windows.Forms.CheckBox();
            this.ZipModGB = new System.Windows.Forms.GroupBox();
            this.ProfileFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.SetCustomFolderbtn = new System.Windows.Forms.Button();
            this.ProfileGB.SuspendLayout();
            this.ZipModGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogBTN
            // 
            this.openFileDialogBTN.Location = new System.Drawing.Point(90, 19);
            this.openFileDialogBTN.Name = "openFileDialogBTN";
            this.openFileDialogBTN.Size = new System.Drawing.Size(152, 23);
            this.openFileDialogBTN.TabIndex = 0;
            this.openFileDialogBTN.Text = "Open File Browser";
            this.openFileDialogBTN.UseVisualStyleBackColor = true;
            this.openFileDialogBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZipFileDiag
            // 
            this.ZipFileDiag.FileName = "openFileDialog1";
            // 
            // ZipFileTxtBox
            // 
            this.ZipFileTxtBox.Location = new System.Drawing.Point(88, 58);
            this.ZipFileTxtBox.Name = "ZipFileTxtBox";
            this.ZipFileTxtBox.Size = new System.Drawing.Size(561, 20);
            this.ZipFileTxtBox.TabIndex = 1;
            // 
            // ZipFileLbl
            // 
            this.ZipFileLbl.AutoSize = true;
            this.ZipFileLbl.Location = new System.Drawing.Point(9, 61);
            this.ZipFileLbl.Name = "ZipFileLbl";
            this.ZipFileLbl.Size = new System.Drawing.Size(73, 13);
            this.ZipFileLbl.TabIndex = 3;
            this.ZipFileLbl.Text = "ZipFile (Mods)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Profile Name";
            // 
            // ProfileTextBox
            // 
            this.ProfileTextBox.Location = new System.Drawing.Point(90, 60);
            this.ProfileTextBox.Name = "ProfileTextBox";
            this.ProfileTextBox.Size = new System.Drawing.Size(561, 20);
            this.ProfileTextBox.TabIndex = 5;
            this.ProfileTextBox.Text = "Default";
            // 
            // ProfileGB
            // 
            this.ProfileGB.Controls.Add(this.SetCustomFolderbtn);
            this.ProfileGB.Controls.Add(this.backUpCheckBox);
            this.ProfileGB.Controls.Add(this.label1);
            this.ProfileGB.Controls.Add(this.ProfileTextBox);
            this.ProfileGB.Location = new System.Drawing.Point(12, 12);
            this.ProfileGB.Name = "ProfileGB";
            this.ProfileGB.Size = new System.Drawing.Size(691, 128);
            this.ProfileGB.TabIndex = 8;
            this.ProfileGB.TabStop = false;
            this.ProfileGB.Text = "Please Enter Thunderstone Profile Name";
            // 
            // backUpCheckBox
            // 
            this.backUpCheckBox.AutoSize = true;
            this.backUpCheckBox.Checked = true;
            this.backUpCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backUpCheckBox.Location = new System.Drawing.Point(91, 91);
            this.backUpCheckBox.Name = "backUpCheckBox";
            this.backUpCheckBox.Size = new System.Drawing.Size(134, 17);
            this.backUpCheckBox.TabIndex = 8;
            this.backUpCheckBox.Text = "Create Back Up Folder";
            this.backUpCheckBox.UseVisualStyleBackColor = true;
            // 
            // ZipModGB
            // 
            this.ZipModGB.Controls.Add(this.openFileDialogBTN);
            this.ZipModGB.Controls.Add(this.ZipFileTxtBox);
            this.ZipModGB.Controls.Add(this.ZipFileLbl);
            this.ZipModGB.Location = new System.Drawing.Point(12, 170);
            this.ZipModGB.Name = "ZipModGB";
            this.ZipModGB.Size = new System.Drawing.Size(691, 128);
            this.ZipModGB.TabIndex = 9;
            this.ZipModGB.TabStop = false;
            this.ZipModGB.Text = "Select Zip File (MODS)";
            // 
            // ProfileFileDiag
            // 
            this.ProfileFileDiag.FileName = "openFileDialog1";
            // 
            // SetCustomFolderbtn
            // 
            this.SetCustomFolderbtn.Location = new System.Drawing.Point(231, 87);
            this.SetCustomFolderbtn.Name = "SetCustomFolderbtn";
            this.SetCustomFolderbtn.Size = new System.Drawing.Size(158, 23);
            this.SetCustomFolderbtn.TabIndex = 9;
            this.SetCustomFolderbtn.Text = "Set Custom Backup folder";
            this.SetCustomFolderbtn.UseVisualStyleBackColor = true;
            this.SetCustomFolderbtn.Click += new System.EventHandler(this.SetCustomFolderbtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 318);
            this.Controls.Add(this.ZipModGB);
            this.Controls.Add(this.ProfileGB);
            this.Name = "MainView";
            this.Text = "Valheim Mod Zip Deployment";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ProfileGB.ResumeLayout(false);
            this.ProfileGB.PerformLayout();
            this.ZipModGB.ResumeLayout(false);
            this.ZipModGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileDialogBTN;
        private System.Windows.Forms.OpenFileDialog ZipFileDiag;
        private System.Windows.Forms.TextBox ZipFileTxtBox;
        private System.Windows.Forms.Label ZipFileLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProfileTextBox;
        private System.Windows.Forms.GroupBox ProfileGB;
        private System.Windows.Forms.GroupBox ZipModGB;
        private System.Windows.Forms.OpenFileDialog ProfileFileDiag;
        private System.Windows.Forms.CheckBox backUpCheckBox;
        private System.Windows.Forms.Button SetCustomFolderbtn;
    }
}

