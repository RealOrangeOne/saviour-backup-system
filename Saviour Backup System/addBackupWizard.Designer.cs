namespace Saviour_Backup_System
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drivesDropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.directoryBrowseButton = new System.Windows.Forms.Button();
            this.introTextBox = new System.Windows.Forms.RichTextBox();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton3 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.compressionTypeDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.previousBackupInput = new DevComponents.Editors.IntegerInput();
            this.createButton = new System.Windows.Forms.Button();
            this.statusProgress = new DevComponents.DotNetBar.Controls.ProgressBarX();
            ((System.ComponentModel.ISupportInitialize)(this.previousBackupInput)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(302, 9);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 28);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 44);
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
            this.drivesDropdown.Location = new System.Drawing.Point(302, 43);
            this.drivesDropdown.MaxDropDownItems = 26;
            this.drivesDropdown.Name = "drivesDropdown";
            this.drivesDropdown.Size = new System.Drawing.Size(249, 24);
            this.drivesDropdown.Sorted = true;
            this.drivesDropdown.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 195);
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
            this.folderPath.Location = new System.Drawing.Point(99, 191);
            this.folderPath.MaxLength = 30;
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(376, 28);
            this.folderPath.TabIndex = 9;
            // 
            // directoryBrowseButton
            // 
            this.directoryBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryBrowseButton.Location = new System.Drawing.Point(476, 191);
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
            this.introTextBox.Size = new System.Drawing.Size(175, 176);
            this.introTextBox.TabIndex = 12;
            this.introTextBox.TabStop = false;
            this.introTextBox.Text = "In order for Saviour Backup System to backup your device, you need to add a backu" +
    "p record.\n\nBe careful when filling in the details, they may not be able to be ch" +
    "anged later.";
            // 
            // switchButton1
            // 
            this.switchButton1.BackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.Class = "";
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton1.Location = new System.Drawing.Point(487, 133);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffBackColor = System.Drawing.Color.DarkRed;
            this.switchButton1.OffTextColor = System.Drawing.Color.White;
            this.switchButton1.OnBackColor = System.Drawing.Color.LimeGreen;
            this.switchButton1.OnTextColor = System.Drawing.Color.Black;
            this.switchButton1.Size = new System.Drawing.Size(64, 23);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 13;
            // 
            // switchButton3
            // 
            this.switchButton3.BackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // 
            // 
            this.switchButton3.BackgroundStyle.Class = "";
            this.switchButton3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton3.Location = new System.Drawing.Point(487, 162);
            this.switchButton3.Name = "switchButton3";
            this.switchButton3.OffBackColor = System.Drawing.Color.DarkRed;
            this.switchButton3.OffTextColor = System.Drawing.Color.White;
            this.switchButton3.OnBackColor = System.Drawing.Color.LimeGreen;
            this.switchButton3.OnTextColor = System.Drawing.Color.Black;
            this.switchButton3.Size = new System.Drawing.Size(64, 23);
            this.switchButton3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Backup on Insertion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Unified Backup File";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Compression:";
            // 
            // compressionTypeDropdown
            // 
            this.compressionTypeDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compressionTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compressionTypeDropdown.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressionTypeDropdown.FormattingEnabled = true;
            this.compressionTypeDropdown.Items.AddRange(new object[] {
            "None",
            "ZIP Archive (*.zip)"});
            this.compressionTypeDropdown.Location = new System.Drawing.Point(302, 73);
            this.compressionTypeDropdown.MaxDropDownItems = 26;
            this.compressionTypeDropdown.Name = "compressionTypeDropdown";
            this.compressionTypeDropdown.Size = new System.Drawing.Size(249, 24);
            this.compressionTypeDropdown.Sorted = true;
            this.compressionTypeDropdown.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 106);
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
            this.previousBackupInput.Location = new System.Drawing.Point(471, 103);
            this.previousBackupInput.MinValue = -1;
            this.previousBackupInput.Name = "previousBackupInput";
            this.previousBackupInput.ShowUpDown = true;
            this.previousBackupInput.Size = new System.Drawing.Size(80, 24);
            this.previousBackupInput.TabIndex = 25;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(395, 225);
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
            this.statusProgress.Location = new System.Drawing.Point(12, 258);
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.statusProgress.Size = new System.Drawing.Size(539, 26);
            this.statusProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.statusProgress.TabIndex = 28;
            this.statusProgress.Text = "Initialising...";
            this.statusProgress.TextVisible = true;
            // 
            // addBackupWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 294);
            this.Controls.Add(this.statusProgress);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.previousBackupInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.compressionTypeDropdown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.switchButton3);
            this.Controls.Add(this.switchButton1);
            this.Controls.Add(this.introTextBox);
            this.Controls.Add(this.directoryBrowseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.drivesDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
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

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drivesDropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button directoryBrowseButton;
        private System.Windows.Forms.RichTextBox introTextBox;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox compressionTypeDropdown;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.IntegerInput previousBackupInput;
        private System.Windows.Forms.Button createButton;
        private DevComponents.DotNetBar.Controls.ProgressBarX statusProgress;
    }
}