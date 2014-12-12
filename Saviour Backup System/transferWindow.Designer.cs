namespace Saviour_Backup_System
{
    partial class transferWindow
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.title = new System.Windows.Forms.Label();
            this.totalFilesProgress = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.currentFileProgress = new System.Windows.Forms.ProgressBar();
            this.currentFileTitle = new System.Windows.Forms.Label();
            this.currentFile = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CanCustomize = false;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.CategorizeMode = DevComponents.DotNetBar.eCategorizeMode.Categories;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(434, 29);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.Black;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(130, 20);
            this.title.TabIndex = 2;
            this.title.Text = "Copying Files...";
            // 
            // totalFilesProgress
            // 
            // 
            // 
            // 
            this.totalFilesProgress.BackgroundStyle.Class = "";
            this.totalFilesProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.totalFilesProgress.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFilesProgress.Location = new System.Drawing.Point(12, 55);
            this.totalFilesProgress.Name = "totalFilesProgress";
            this.totalFilesProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalFilesProgress.Size = new System.Drawing.Size(410, 33);
            this.totalFilesProgress.TabIndex = 3;
            this.totalFilesProgress.Text = "Initialising...";
            this.totalFilesProgress.TextVisible = true;
            // 
            // currentFileProgress
            // 
            this.currentFileProgress.Location = new System.Drawing.Point(12, 124);
            this.currentFileProgress.Name = "currentFileProgress";
            this.currentFileProgress.Size = new System.Drawing.Size(410, 33);
            this.currentFileProgress.TabIndex = 4;
            // 
            // currentFileTitle
            // 
            this.currentFileTitle.AutoSize = true;
            this.currentFileTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFileTitle.Location = new System.Drawing.Point(12, 104);
            this.currentFileTitle.Name = "currentFileTitle";
            this.currentFileTitle.Size = new System.Drawing.Size(93, 17);
            this.currentFileTitle.TabIndex = 5;
            this.currentFileTitle.Text = "Current File:";
            // 
            // currentFile
            // 
            this.currentFile.AutoSize = true;
            this.currentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFile.Location = new System.Drawing.Point(103, 104);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(0, 17);
            this.currentFile.TabIndex = 6;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(12, 163);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(96, 29);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "Minimize";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(326, 163);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 29);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // transferWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 204);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.currentFile);
            this.Controls.Add(this.currentFileTitle);
            this.Controls.Add(this.currentFileProgress);
            this.Controls.Add(this.totalFilesProgress);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transferWindow";
            this.Text = "Backup Process";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.transferWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.transferWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Label title;
        private DevComponents.DotNetBar.Controls.ProgressBarX totalFilesProgress;
        private System.Windows.Forms.ProgressBar currentFileProgress;
        private System.Windows.Forms.Label currentFileTitle;
        private System.Windows.Forms.Label currentFile;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button cancelButton;

    }
}