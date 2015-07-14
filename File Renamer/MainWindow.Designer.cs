namespace File_Renamer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblCurrentName = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.lblFilesLeft = new System.Windows.Forms.Label();
            this.FilesLeft = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.chkRUnderScore = new System.Windows.Forms.CheckBox();
            this.TrackNum = new System.Windows.Forms.TextBox();
            this.lblTrackNo = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.TextBox();
            this.CurrentName = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.lblCurrentFolder = new System.Windows.Forms.Label();
            this.lblCurrentFolderPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentName
            // 
            this.lblCurrentName.AutoSize = true;
            this.lblCurrentName.Location = new System.Drawing.Point(3, 7);
            this.lblCurrentName.Name = "lblCurrentName";
            this.lblCurrentName.Size = new System.Drawing.Size(100, 17);
            this.lblCurrentName.TabIndex = 0;
            this.lblCurrentName.Text = "Current Name:";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(3, 33);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(139, 17);
            this.lblNewName.TabIndex = 2;
            this.lblNewName.Text = "New Name and Title:";
            // 
            // NewName
            // 
            this.NewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewName.Location = new System.Drawing.Point(6, 53);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(437, 15);
            this.NewName.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(387, 205);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // lblFilesLeft
            // 
            this.lblFilesLeft.AutoSize = true;
            this.lblFilesLeft.Location = new System.Drawing.Point(3, 237);
            this.lblFilesLeft.Name = "lblFilesLeft";
            this.lblFilesLeft.Size = new System.Drawing.Size(69, 17);
            this.lblFilesLeft.TabIndex = 5;
            this.lblFilesLeft.Text = "Files Left:";
            // 
            // FilesLeft
            // 
            this.FilesLeft.AutoSize = true;
            this.FilesLeft.Location = new System.Drawing.Point(78, 237);
            this.FilesLeft.Name = "FilesLeft";
            this.FilesLeft.Size = new System.Drawing.Size(37, 17);
            this.FilesLeft.TabIndex = 6;
            this.FilesLeft.Text = "Num";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(367, 9);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(46, 17);
            this.lblDone.TabIndex = 7;
            this.lblDone.Text = "Done:";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(387, 234);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(306, 205);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 15;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(419, 7);
            this.NumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(43, 22);
            this.NumericUpDown.TabIndex = 17;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(399, 14);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 18;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.chkUpperCase);
            this.PanelMain.Controls.Add(this.chkRUnderScore);
            this.PanelMain.Controls.Add(this.TrackNum);
            this.PanelMain.Controls.Add(this.lblTrackNo);
            this.PanelMain.Controls.Add(this.lblAlbum);
            this.PanelMain.Controls.Add(this.Artist);
            this.PanelMain.Controls.Add(this.lblArtist);
            this.PanelMain.Controls.Add(this.Album);
            this.PanelMain.Controls.Add(this.CurrentName);
            this.PanelMain.Controls.Add(this.Delete);
            this.PanelMain.Controls.Add(this.lblFilesLeft);
            this.PanelMain.Controls.Add(this.FilesLeft);
            this.PanelMain.Controls.Add(this.NumericUpDown);
            this.PanelMain.Controls.Add(this.Save);
            this.PanelMain.Controls.Add(this.lblDone);
            this.PanelMain.Controls.Add(this.Back);
            this.PanelMain.Controls.Add(this.lblCurrentName);
            this.PanelMain.Controls.Add(this.NewName);
            this.PanelMain.Controls.Add(this.lblNewName);
            this.PanelMain.Location = new System.Drawing.Point(12, 120);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(465, 260);
            this.PanelMain.TabIndex = 19;
            this.PanelMain.Visible = false;
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.Location = new System.Drawing.Point(172, 167);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(133, 21);
            this.chkUpperCase.TabIndex = 27;
            this.chkUpperCase.Text = "Uppercase Start";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // chkRUnderScore
            // 
            this.chkRUnderScore.AutoSize = true;
            this.chkRUnderScore.Location = new System.Drawing.Point(6, 167);
            this.chkRUnderScore.Name = "chkRUnderScore";
            this.chkRUnderScore.Size = new System.Drawing.Size(160, 21);
            this.chkRUnderScore.TabIndex = 26;
            this.chkRUnderScore.Text = "Remove Underscore";
            this.chkRUnderScore.UseVisualStyleBackColor = true;
            // 
            // TrackNum
            // 
            this.TrackNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrackNum.Location = new System.Drawing.Point(143, 116);
            this.TrackNum.Name = "TrackNum";
            this.TrackNum.Size = new System.Drawing.Size(50, 15);
            this.TrackNum.TabIndex = 25;
            this.TrackNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrackNum_KeyPress);
            // 
            // lblTrackNo
            // 
            this.lblTrackNo.AutoSize = true;
            this.lblTrackNo.Location = new System.Drawing.Point(3, 116);
            this.lblTrackNo.Name = "lblTrackNo";
            this.lblTrackNo.Size = new System.Drawing.Size(16, 17);
            this.lblTrackNo.TabIndex = 24;
            this.lblTrackNo.Text = "#";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(3, 95);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(51, 17);
            this.lblAlbum.TabIndex = 23;
            this.lblAlbum.Text = "Album:";
            // 
            // Artist
            // 
            this.Artist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Artist.Location = new System.Drawing.Point(143, 74);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(300, 15);
            this.Artist.TabIndex = 22;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(3, 74);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(44, 17);
            this.lblArtist.TabIndex = 21;
            this.lblArtist.Text = "Artist:";
            // 
            // Album
            // 
            this.Album.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Album.Location = new System.Drawing.Point(143, 95);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(300, 15);
            this.Album.TabIndex = 20;
            // 
            // CurrentName
            // 
            this.CurrentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentName.Location = new System.Drawing.Point(109, 7);
            this.CurrentName.Name = "CurrentName";
            this.CurrentName.ReadOnly = true;
            this.CurrentName.Size = new System.Drawing.Size(200, 15);
            this.CurrentName.TabIndex = 18;
            this.CurrentName.Text = "NameText";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(15, 17);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(126, 17);
            this.lblFilePath.TabIndex = 20;
            this.lblFilePath.Text = "Selected File Path:";
            // 
            // lblCurrentPath
            // 
            this.lblCurrentPath.AutoSize = true;
            this.lblCurrentPath.Location = new System.Drawing.Point(15, 34);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(122, 17);
            this.lblCurrentPath.TabIndex = 21;
            this.lblCurrentPath.Text = "No Path Selected.";
            // 
            // lblCurrentFolder
            // 
            this.lblCurrentFolder.AutoSize = true;
            this.lblCurrentFolder.Location = new System.Drawing.Point(15, 78);
            this.lblCurrentFolder.Name = "lblCurrentFolder";
            this.lblCurrentFolder.Size = new System.Drawing.Size(129, 17);
            this.lblCurrentFolder.TabIndex = 23;
            this.lblCurrentFolder.Text = "No Folder Selected";
            // 
            // lblCurrentFolderPath
            // 
            this.lblCurrentFolderPath.AutoSize = true;
            this.lblCurrentFolderPath.Location = new System.Drawing.Point(15, 61);
            this.lblCurrentFolderPath.Name = "lblCurrentFolderPath";
            this.lblCurrentFolderPath.Size = new System.Drawing.Size(103, 17);
            this.lblCurrentFolderPath.TabIndex = 24;
            this.lblCurrentFolderPath.Text = "Current Folder:";
            // 
            // MainWindow
            // 
            this.AcceptButton = this.Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 392);
            this.Controls.Add(this.lblCurrentFolderPath);
            this.Controls.Add(this.lblCurrentFolder);
            this.Controls.Add(this.lblCurrentPath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.btnSelectPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "File Renamer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label lblFilesLeft;
        private System.Windows.Forms.Label FilesLeft;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Label lblCurrentPath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox CurrentName;
        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.TextBox Artist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox TrackNum;
        private System.Windows.Forms.Label lblTrackNo;
        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.CheckBox chkRUnderScore;
        private System.Windows.Forms.Label lblCurrentFolder;
        private System.Windows.Forms.Label lblCurrentFolderPath;
    }
}