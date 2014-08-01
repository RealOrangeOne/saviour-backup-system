namespace Saviour_Backup_System
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.backupRestoreTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.deviceTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.settingsTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sideBar = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.connectedDrivesList = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.connectedDrivesListRefresh = new DevComponents.DotNetBar.ButtonX();
            this.connectedDevicesTab = new DevComponents.DotNetBar.TabItem(this.components);
            this.driveDetailsPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.driveTypeDisplay = new System.Windows.Forms.Label();
            this.driveTypeLabel = new System.Windows.Forms.Label();
            this.driveLetterDisplay = new System.Windows.Forms.Label();
            this.driveSystemDisplay = new System.Windows.Forms.Label();
            this.driveNameDisplay = new System.Windows.Forms.Label();
            this.driveLetterLabel = new System.Windows.Forms.Label();
            this.driveSystemLabel = new System.Windows.Forms.Label();
            this.driveNameLabel = new System.Windows.Forms.Label();
            this.driveIconBox = new System.Windows.Forms.PictureBox();
            this.driveCapacityDisplay = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.driveRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.formatDriveCapacityTimer = new System.Windows.Forms.Timer(this.components);
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.backupDeviceButton = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideBar)).BeginInit();
            this.sideBar.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.driveDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.Class = "";
            this.ribbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanel3);
            this.ribbonControl.Controls.Add(this.ribbonPanel2);
            this.ribbonControl.Controls.Add(this.ribbonPanel4);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.backupRestoreTab,
            this.deviceTab,
            this.settingsTab});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl.Size = new System.Drawing.Size(992, 163);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 0;
            this.ribbonControl.Text = "Saviour Backup System";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar1);
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(992, 108);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.Class = "";
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem4});
            this.ribbonBar3.Location = new System.Drawing.Point(270, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(167, 105);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 1;
            this.ribbonBar3.Text = "Restore";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.Class = "";
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.Class = "";
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem4
            // 
            this.buttonItem4.Image = global::Saviour_Backup_System.Properties.Resources.restoreIcon;
            this.buttonItem4.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 14;
            this.buttonItem4.Text = "Restore Device from Backup";
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.buttonItem3});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(267, 105);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "Backup";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = global::Saviour_Backup_System.Properties.Resources.backupIcon;
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.PopupFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "Backup All Devices";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 14;
            this.buttonItem3.Text = "Add Backup Rule";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.ribbonBar6);
            this.ribbonPanel4.Controls.Add(this.ribbonBar5);
            this.ribbonPanel4.Controls.Add(this.ribbonBar4);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(992, 161);
            // 
            // 
            // 
            this.ribbonPanel4.Style.Class = "";
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.Class = "";
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.Class = "";
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundStyle.Class = "";
            this.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar6.ContainerControlProcessDialogKey = true;
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem7});
            this.ribbonBar6.Location = new System.Drawing.Point(203, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(100, 158);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar6.TabIndex = 2;
            this.ribbonBar6.Text = "Exit";
            // 
            // 
            // 
            this.ribbonBar6.TitleStyle.Class = "";
            this.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyleMouseOver.Class = "";
            this.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem7
            // 
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.SubItemsExpandWidth = 14;
            this.buttonItem7.Text = "Exit Saviour Backup";
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.Class = "";
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem6});
            this.ribbonBar5.Location = new System.Drawing.Point(103, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(100, 158);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 1;
            this.ribbonBar5.Text = "About";
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.Class = "";
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.Class = "";
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem6
            // 
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 14;
            this.buttonItem6.Text = "About Saviour Backup";
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.Class = "";
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem5});
            this.ribbonBar4.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(100, 158);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 0;
            this.ribbonBar4.Text = "Preferences";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.Class = "";
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.Class = "";
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem5
            // 
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 14;
            this.buttonItem5.Text = "Edit Preferences";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.ribbonBar7);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(992, 108);
            // 
            // 
            // 
            this.ribbonPanel3.Style.Class = "";
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.Class = "";
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.Class = "";
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 5;
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundStyle.Class = "";
            this.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.backupDeviceButton});
            this.ribbonBar7.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(170, 105);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar7.TabIndex = 0;
            this.ribbonBar7.Text = "Backup / Restore";
            // 
            // 
            // 
            this.ribbonBar7.TitleStyle.Class = "";
            this.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.TitleStyleMouseOver.Class = "";
            this.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // backupRestoreTab
            // 
            this.backupRestoreTab.Name = "backupRestoreTab";
            this.backupRestoreTab.Panel = this.ribbonPanel2;
            this.backupRestoreTab.Text = "Backup and Restore";
            // 
            // deviceTab
            // 
            this.deviceTab.Checked = true;
            this.deviceTab.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Green;
            this.deviceTab.Name = "deviceTab";
            this.deviceTab.Panel = this.ribbonPanel3;
            this.deviceTab.Text = "Device";
            this.deviceTab.Visible = false;
            // 
            // settingsTab
            // 
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Panel = this.ribbonPanel4;
            this.settingsTab.Text = "Settings";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.Black;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // sideBar
            // 
            this.sideBar.CanReorderTabs = true;
            this.sideBar.Controls.Add(this.tabControlPanel1);
            this.sideBar.Location = new System.Drawing.Point(0, 163);
            this.sideBar.Name = "sideBar";
            this.sideBar.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.sideBar.SelectedTabIndex = 0;
            this.sideBar.Size = new System.Drawing.Size(180, 358);
            this.sideBar.TabIndex = 2;
            this.sideBar.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.sideBar.Tabs.Add(this.connectedDevicesTab);
            this.sideBar.Text = "tabControl1";
            this.sideBar.ThemeAware = true;
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.connectedDrivesList);
            this.tabControlPanel1.Controls.Add(this.connectedDrivesListRefresh);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 27);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(180, 331);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.connectedDevicesTab;
            this.tabControlPanel1.ThemeAware = true;
            // 
            // connectedDrivesList
            // 
            this.connectedDrivesList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            // 
            // 
            // 
            this.connectedDrivesList.Border.Class = "ListViewBorder";
            this.connectedDrivesList.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.connectedDrivesList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.connectedDrivesList.FullRowSelect = true;
            this.connectedDrivesList.Location = new System.Drawing.Point(4, 4);
            this.connectedDrivesList.Name = "connectedDrivesList";
            this.connectedDrivesList.Size = new System.Drawing.Size(169, 286);
            this.connectedDrivesList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.connectedDrivesList.TabIndex = 2;
            this.connectedDrivesList.UseCompatibleStateImageBehavior = false;
            this.connectedDrivesList.View = System.Windows.Forms.View.Tile;
            this.connectedDrivesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.connectedDrivesList_Selection);
            // 
            // connectedDrivesListRefresh
            // 
            this.connectedDrivesListRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.connectedDrivesListRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.connectedDrivesListRefresh.Location = new System.Drawing.Point(4, 296);
            this.connectedDrivesListRefresh.Name = "connectedDrivesListRefresh";
            this.connectedDrivesListRefresh.Size = new System.Drawing.Size(169, 31);
            this.connectedDrivesListRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.connectedDrivesListRefresh.TabIndex = 1;
            this.connectedDrivesListRefresh.Text = "Refresh List";
            this.connectedDrivesListRefresh.Click += new System.EventHandler(this.connectedDrivesListRefresh_Click);
            // 
            // connectedDevicesTab
            // 
            this.connectedDevicesTab.AttachedControl = this.tabControlPanel1;
            this.connectedDevicesTab.Name = "connectedDevicesTab";
            this.connectedDevicesTab.Text = "Connected Drives";
            // 
            // driveDetailsPanel
            // 
            this.driveDetailsPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.driveDetailsPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.driveDetailsPanel.Controls.Add(this.driveTypeDisplay);
            this.driveDetailsPanel.Controls.Add(this.driveTypeLabel);
            this.driveDetailsPanel.Controls.Add(this.driveLetterDisplay);
            this.driveDetailsPanel.Controls.Add(this.driveSystemDisplay);
            this.driveDetailsPanel.Controls.Add(this.driveNameDisplay);
            this.driveDetailsPanel.Controls.Add(this.driveLetterLabel);
            this.driveDetailsPanel.Controls.Add(this.driveSystemLabel);
            this.driveDetailsPanel.Controls.Add(this.driveNameLabel);
            this.driveDetailsPanel.Controls.Add(this.driveIconBox);
            this.driveDetailsPanel.Controls.Add(this.driveCapacityDisplay);
            this.driveDetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveDetailsPanel.Location = new System.Drawing.Point(186, 169);
            this.driveDetailsPanel.Name = "driveDetailsPanel";
            this.driveDetailsPanel.Size = new System.Drawing.Size(794, 199);
            // 
            // 
            // 
            this.driveDetailsPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.driveDetailsPanel.Style.BackColorGradientAngle = 90;
            this.driveDetailsPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.driveDetailsPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.driveDetailsPanel.Style.BorderBottomWidth = 1;
            this.driveDetailsPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.driveDetailsPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.driveDetailsPanel.Style.BorderLeftWidth = 1;
            this.driveDetailsPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.driveDetailsPanel.Style.BorderRightWidth = 1;
            this.driveDetailsPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.driveDetailsPanel.Style.BorderTopWidth = 1;
            this.driveDetailsPanel.Style.Class = "";
            this.driveDetailsPanel.Style.CornerDiameter = 4;
            this.driveDetailsPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.driveDetailsPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.driveDetailsPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.driveDetailsPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.driveDetailsPanel.StyleMouseDown.Class = "";
            this.driveDetailsPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.driveDetailsPanel.StyleMouseOver.Class = "";
            this.driveDetailsPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.driveDetailsPanel.TabIndex = 3;
            this.driveDetailsPanel.Text = "Drive Details";
            // 
            // driveTypeDisplay
            // 
            this.driveTypeDisplay.AutoSize = true;
            this.driveTypeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.driveTypeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveTypeDisplay.Location = new System.Drawing.Point(480, 39);
            this.driveTypeDisplay.Name = "driveTypeDisplay";
            this.driveTypeDisplay.Size = new System.Drawing.Size(48, 17);
            this.driveTypeDisplay.TabIndex = 7;
            this.driveTypeDisplay.Text = "NONE";
            // 
            // driveTypeLabel
            // 
            this.driveTypeLabel.AutoSize = true;
            this.driveTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.driveTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveTypeLabel.Location = new System.Drawing.Point(405, 39);
            this.driveTypeLabel.Name = "driveTypeLabel";
            this.driveTypeLabel.Size = new System.Drawing.Size(81, 17);
            this.driveTypeLabel.TabIndex = 6;
            this.driveTypeLabel.Text = "Drive Type:";
            // 
            // driveLetterDisplay
            // 
            this.driveLetterDisplay.AutoSize = true;
            this.driveLetterDisplay.BackColor = System.Drawing.Color.Transparent;
            this.driveLetterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveLetterDisplay.Location = new System.Drawing.Point(485, 5);
            this.driveLetterDisplay.Name = "driveLetterDisplay";
            this.driveLetterDisplay.Size = new System.Drawing.Size(48, 17);
            this.driveLetterDisplay.TabIndex = 5;
            this.driveLetterDisplay.Text = "NONE";
            // 
            // driveSystemDisplay
            // 
            this.driveSystemDisplay.AutoSize = true;
            this.driveSystemDisplay.BackColor = System.Drawing.Color.Transparent;
            this.driveSystemDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveSystemDisplay.Location = new System.Drawing.Point(266, 39);
            this.driveSystemDisplay.Name = "driveSystemDisplay";
            this.driveSystemDisplay.Size = new System.Drawing.Size(48, 17);
            this.driveSystemDisplay.TabIndex = 4;
            this.driveSystemDisplay.Text = "NONE";
            // 
            // driveNameDisplay
            // 
            this.driveNameDisplay.AutoSize = true;
            this.driveNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.driveNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveNameDisplay.Location = new System.Drawing.Point(229, 5);
            this.driveNameDisplay.Name = "driveNameDisplay";
            this.driveNameDisplay.Size = new System.Drawing.Size(48, 17);
            this.driveNameDisplay.TabIndex = 4;
            this.driveNameDisplay.Text = "NONE";
            // 
            // driveLetterLabel
            // 
            this.driveLetterLabel.AutoSize = true;
            this.driveLetterLabel.BackColor = System.Drawing.Color.Transparent;
            this.driveLetterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveLetterLabel.Location = new System.Drawing.Point(405, 5);
            this.driveLetterLabel.Name = "driveLetterLabel";
            this.driveLetterLabel.Size = new System.Drawing.Size(86, 17);
            this.driveLetterLabel.TabIndex = 3;
            this.driveLetterLabel.Text = "Drive Letter:";
            // 
            // driveSystemLabel
            // 
            this.driveSystemLabel.AutoSize = true;
            this.driveSystemLabel.BackColor = System.Drawing.Color.Transparent;
            this.driveSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveSystemLabel.Location = new System.Drawing.Point(188, 39);
            this.driveSystemLabel.Name = "driveSystemLabel";
            this.driveSystemLabel.Size = new System.Drawing.Size(84, 17);
            this.driveSystemLabel.TabIndex = 2;
            this.driveSystemLabel.Text = "File System:";
            // 
            // driveNameLabel
            // 
            this.driveNameLabel.AutoSize = true;
            this.driveNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.driveNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveNameLabel.Location = new System.Drawing.Point(188, 5);
            this.driveNameLabel.Name = "driveNameLabel";
            this.driveNameLabel.Size = new System.Drawing.Size(47, 17);
            this.driveNameLabel.TabIndex = 2;
            this.driveNameLabel.Text = "Label:";
            // 
            // driveIconBox
            // 
            this.driveIconBox.BackColor = System.Drawing.Color.Transparent;
            this.driveIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.driveIconBox.Location = new System.Drawing.Point(3, -1);
            this.driveIconBox.Name = "driveIconBox";
            this.driveIconBox.Size = new System.Drawing.Size(183, 143);
            this.driveIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.driveIconBox.TabIndex = 1;
            this.driveIconBox.TabStop = false;
            // 
            // driveCapacityDisplay
            // 
            this.driveCapacityDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.driveCapacityDisplay.BackgroundStyle.Class = "";
            this.driveCapacityDisplay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.driveCapacityDisplay.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Error;
            this.driveCapacityDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveCapacityDisplay.Location = new System.Drawing.Point(3, 148);
            this.driveCapacityDisplay.Maximum = 10000;
            this.driveCapacityDisplay.Name = "driveCapacityDisplay";
            this.driveCapacityDisplay.Size = new System.Drawing.Size(782, 23);
            this.driveCapacityDisplay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.driveCapacityDisplay.TabIndex = 0;
            this.driveCapacityDisplay.TabStop = false;
            this.driveCapacityDisplay.Text = "Drive Capacity";
            this.driveCapacityDisplay.TextVisible = true;
            // 
            // driveRefreshTimer
            // 
            this.driveRefreshTimer.Enabled = true;
            this.driveRefreshTimer.Interval = 800;
            this.driveRefreshTimer.Tick += new System.EventHandler(this.driveRefreshTimer_Tick);
            // 
            // formatDriveCapacityTimer
            // 
            this.formatDriveCapacityTimer.Enabled = true;
            this.formatDriveCapacityTimer.Interval = 300;
            this.formatDriveCapacityTimer.Tick += new System.EventHandler(this.formatDriveCapacityTimer_Tick);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem8});
            this.ribbonBar1.Location = new System.Drawing.Point(437, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(100, 105);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 2;
            this.ribbonBar1.Text = "Manage";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem8
            // 
            this.buttonItem8.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.SubItemsExpandWidth = 14;
            this.buttonItem8.Text = "View All Rules";
            // 
            // backupDeviceButton
            // 
            this.backupDeviceButton.Name = "backupDeviceButton";
            this.backupDeviceButton.SubItemsExpandWidth = 14;
            this.backupDeviceButton.Text = "Backup Device";
            this.backupDeviceButton.ThemeAware = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 546);
            this.Controls.Add(this.driveDetailsPanel);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saviour Backup System";
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideBar)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.driveDetailsPanel.ResumeLayout(false);
            this.driveDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem backupRestoreTab;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonTabItem settingsTab;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar6;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem deviceTab;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DevComponents.DotNetBar.TabControl sideBar;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem connectedDevicesTab;
        private DevComponents.DotNetBar.ButtonX connectedDrivesListRefresh;
        private DevComponents.DotNetBar.Controls.ListViewEx connectedDrivesList;
        private DevComponents.DotNetBar.Controls.GroupPanel driveDetailsPanel;
        private DevComponents.DotNetBar.Controls.ProgressBarX driveCapacityDisplay;
        private System.Windows.Forms.PictureBox driveIconBox;
        private System.Windows.Forms.Label driveLetterLabel;
        private System.Windows.Forms.Label driveNameLabel;
        private System.Windows.Forms.Label driveNameDisplay;
        private System.Windows.Forms.Label driveLetterDisplay;
        private System.Windows.Forms.Label driveSystemDisplay;
        private System.Windows.Forms.Label driveSystemLabel;
        private System.Windows.Forms.Label driveTypeDisplay;
        private System.Windows.Forms.Label driveTypeLabel;
        private System.Windows.Forms.Timer driveRefreshTimer;
        private System.Windows.Forms.Timer formatDriveCapacityTimer;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem backupDeviceButton;

    }
}

