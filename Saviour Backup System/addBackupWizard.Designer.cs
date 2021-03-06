﻿namespace Saviour_Backup_System
{
    partial class addBackupWizard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBackupWizard));
            this.backupNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drivesDropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.directoryBrowseButton = new System.Windows.Forms.Button();
            this.introTextBox = new System.Windows.Forms.RichTextBox();
            this.insertionSwitch = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.compressionSwitch = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previousBackupInput = new DevComponents.Editors.IntegerInput();
            this.createButton = new System.Windows.Forms.Button();
            this.statusProgress = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.previousBackupInput)).BeginInit();
            this.SuspendLayout();
            // 
            // backupNameInput
            // 
            this.backupNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backupNameInput.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupNameInput.Location = new System.Drawing.Point(320, 9);
            this.backupNameInput.MaxLength = 30;
            this.backupNameInput.Name = "backupNameInput";
            this.backupNameInput.Size = new System.Drawing.Size(231, 28);
            this.backupNameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drive:";
            // 
            // drivesDropdown
            // 
            this.drivesDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drivesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drivesDropdown.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivesDropdown.FormattingEnabled = true;
            this.drivesDropdown.Location = new System.Drawing.Point(320, 43);
            this.drivesDropdown.MaxDropDownItems = 26;
            this.drivesDropdown.Name = "drivesDropdown";
            this.drivesDropdown.Size = new System.Drawing.Size(231, 24);
            this.drivesDropdown.Sorted = true;
            this.drivesDropdown.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Directory:";
            // 
            // folderPath
            // 
            this.folderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderPath.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPath.Location = new System.Drawing.Point(99, 161);
            this.folderPath.MaxLength = 30;
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(376, 28);
            this.folderPath.TabIndex = 9;
            // 
            // directoryBrowseButton
            // 
            this.directoryBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryBrowseButton.Location = new System.Drawing.Point(476, 161);
            this.directoryBrowseButton.Name = "directoryBrowseButton";
            this.directoryBrowseButton.Size = new System.Drawing.Size(75, 28);
            this.directoryBrowseButton.TabIndex = 11;
            this.directoryBrowseButton.Text = "Browse";
            this.directoryBrowseButton.UseVisualStyleBackColor = true;
            this.directoryBrowseButton.Click += new System.EventHandler(this.directoryBrowseButton_Click);
            // 
            // introTextBox
            // 
            this.introTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.introTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introTextBox.Location = new System.Drawing.Point(2, 12);
            this.introTextBox.Name = "introTextBox";
            this.introTextBox.ReadOnly = true;
            this.introTextBox.Size = new System.Drawing.Size(193, 144);
            this.introTextBox.TabIndex = 12;
            this.introTextBox.TabStop = false;
            this.introTextBox.Text = resources.GetString("introTextBox.Text");
            // 
            // insertionSwitch
            // 
            this.insertionSwitch.BackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // 
            // 
            this.insertionSwitch.BackgroundStyle.Class = "";
            this.insertionSwitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.insertionSwitch.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertionSwitch.Location = new System.Drawing.Point(487, 103);
            this.insertionSwitch.Name = "insertionSwitch";
            this.insertionSwitch.OffBackColor = System.Drawing.Color.DarkRed;
            this.insertionSwitch.OffTextColor = System.Drawing.Color.White;
            this.insertionSwitch.OnBackColor = System.Drawing.Color.LimeGreen;
            this.insertionSwitch.OnTextColor = System.Drawing.Color.Black;
            this.insertionSwitch.Size = new System.Drawing.Size(64, 23);
            this.insertionSwitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.insertionSwitch.TabIndex = 13;
            this.insertionSwitch.Click += new System.EventHandler(this.insertionSwitch_Click);
            // 
            // compressionSwitch
            // 
            this.compressionSwitch.BackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // 
            // 
            this.compressionSwitch.BackgroundStyle.Class = "";
            this.compressionSwitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.compressionSwitch.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressionSwitch.Location = new System.Drawing.Point(487, 132);
            this.compressionSwitch.Name = "compressionSwitch";
            this.compressionSwitch.OffBackColor = System.Drawing.Color.DarkRed;
            this.compressionSwitch.OffTextColor = System.Drawing.Color.White;
            this.compressionSwitch.OnBackColor = System.Drawing.Color.LimeGreen;
            this.compressionSwitch.OnTextColor = System.Drawing.Color.Black;
            this.compressionSwitch.Size = new System.Drawing.Size(64, 23);
            this.compressionSwitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.compressionSwitch.TabIndex = 15;
            this.compressionSwitch.Click += new System.EventHandler(this.unifiedFileSwitch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Backup on Insertion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Use Compression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Previous Backups:";
            // 
            // previousBackupInput
            // 
            this.previousBackupInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.previousBackupInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.previousBackupInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.previousBackupInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.previousBackupInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.previousBackupInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBackupInput.Location = new System.Drawing.Point(471, 73);
            this.previousBackupInput.MaxValue = 999;
            this.previousBackupInput.MinValue = -1;
            this.previousBackupInput.Name = "previousBackupInput";
            this.previousBackupInput.ShowUpDown = true;
            this.previousBackupInput.Size = new System.Drawing.Size(80, 24);
            this.previousBackupInput.TabIndex = 25;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(395, 195);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(156, 27);
            this.createButton.TabIndex = 27;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // statusProgress
            // 
            // 
            // 
            // 
            this.statusProgress.BackgroundStyle.Class = "";
            this.statusProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statusProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusProgress.Location = new System.Drawing.Point(12, 228);
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.statusProgress.Size = new System.Drawing.Size(539, 26);
            this.statusProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.statusProgress.TabIndex = 28;
            this.statusProgress.Text = "Initialising...";
            this.statusProgress.TextVisible = true;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.Black;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // addBackupWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 259);
            this.Controls.Add(this.statusProgress);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.previousBackupInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.compressionSwitch);
            this.Controls.Add(this.insertionSwitch);
            this.Controls.Add(this.introTextBox);
            this.Controls.Add(this.directoryBrowseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.drivesDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backupNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addBackupWizard";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Backup Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.previousBackupInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox backupNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button directoryBrowseButton;
        private System.Windows.Forms.RichTextBox introTextBox;
        private DevComponents.DotNetBar.Controls.SwitchButton insertionSwitch;
        private DevComponents.DotNetBar.Controls.SwitchButton compressionSwitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.IntegerInput previousBackupInput;
        private DevComponents.DotNetBar.Controls.ProgressBarX statusProgress;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        public System.Windows.Forms.Button createButton;
        public System.Windows.Forms.ComboBox drivesDropdown;
    }
}