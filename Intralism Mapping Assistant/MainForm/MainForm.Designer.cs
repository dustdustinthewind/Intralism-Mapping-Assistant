using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CustomFRToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AdvancedFrameRateCalc = new System.Windows.Forms.CheckBox();
            this.CustomRangeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AdvancedCustomRangeCalc = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ModifiedTracker = new System.Windows.Forms.Label();
            this.Overwrite = new System.Windows.Forms.Button();
            this.SaveFolder = new System.Windows.Forms.Button();
            this.SaveConfig = new System.Windows.Forms.Button();
            this.LoadMapButton = new System.Windows.Forms.Button();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.LoadedMap = new System.Windows.Forms.Label();
            this.SaveConfigTT = new System.Windows.Forms.ToolTip(this.components);
            this.SaveFolderTT = new System.Windows.Forms.ToolTip(this.components);
            this.OverwriteTT = new System.Windows.Forms.ToolTip(this.components);
            this.BrowseForMapFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.HandSwitchTab = new System.Windows.Forms.TabPage();
            this.HandZeroButton = new System.Windows.Forms.Button();
            this.HandTwoButton = new System.Windows.Forms.Button();
            this.HandOneButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CopyConfigPreviewHS = new System.Windows.Forms.Button();
            this.ModifyConfigPreviewHS = new System.Windows.Forms.CheckBox();
            this.ConfigPreviewHSLabel = new System.Windows.Forms.Label();
            this.ConfigPreviewRTBHS = new System.Windows.Forms.RichTextBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MapSplitterTab = new System.Windows.Forms.TabPage();
            this.SplitterSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CopyAudioOffsetSplit = new System.Windows.Forms.Button();
            this.AudioOffsetSplitter = new System.Windows.Forms.TextBox();
            this.AudioSplitBoxLabel = new System.Windows.Forms.Label();
            this.PSANoAudioSplit = new System.Windows.Forms.Label();
            this.SplitTimeSelect = new System.Windows.Forms.NumericUpDown();
            this.SplitAfterEventButton = new System.Windows.Forms.Button();
            this.SplitAtTimeButton = new System.Windows.Forms.Button();
            this.SplitAtHalfButton = new System.Windows.Forms.Button();
            this.SplitterDescription = new System.Windows.Forms.Label();
            this.SplitPreviews = new System.Windows.Forms.SplitContainer();
            this.FindNextEventSCP1 = new System.Windows.Forms.Button();
            this.FindPrevEventSCP1 = new System.Windows.Forms.Button();
            this.CopySCP1 = new System.Windows.Forms.Button();
            this.ModifyConfigPreviewSCP1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SplitConfigPart1 = new System.Windows.Forms.RichTextBox();
            this.FindNextEventSCP2 = new System.Windows.Forms.Button();
            this.FindPrevEventSCP2 = new System.Windows.Forms.Button();
            this.CopySCP2 = new System.Windows.Forms.Button();
            this.ModifyConfigPreviewSCP2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SplitConfigPart2 = new System.Windows.Forms.RichTextBox();
            this.EventModifier = new System.Windows.Forms.TabPage();
            this.EventModifierPanel = new System.Windows.Forms.Panel();
            this.ZEMContainer = new System.Windows.Forms.SplitContainer();
            this.DestructiveZEMGroup = new System.Windows.Forms.GroupBox();
            this.DeleteAllZoomsButton = new System.Windows.Forms.Button();
            this.DestructiveCheckZEM = new System.Windows.Forms.CheckBox();
            this.FindNextZoomZEM = new System.Windows.Forms.Button();
            this.FindPrevZoomZEM = new System.Windows.Forms.Button();
            this.CopyPreviewBox = new System.Windows.Forms.Button();
            this.ModifyConfigPreviewZEM = new System.Windows.Forms.CheckBox();
            this.ConfigPreviewZEM = new System.Windows.Forms.Label();
            this.ConfigPreviewRTBZEM = new System.Windows.Forms.RichTextBox();
            this.ZoomModifierDescription = new System.Windows.Forms.Label();
            this.ZoomStopTab = new System.Windows.Forms.TabPage();
            this.ZoomPanel = new System.Windows.Forms.Panel();
            this.CopyPreviewBoxZSC = new System.Windows.Forms.Button();
            this.ModifyConfigPreviewZSC = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigPreviewRTBZSC = new System.Windows.Forms.RichTextBox();
            this.AdvancedOptions = new System.Windows.Forms.GroupBox();
            this.CustomRangeZSCalc = new System.Windows.Forms.NumericUpDown();
            this.CustomFrameRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetSelectedZoomZSC = new System.Windows.Forms.Button();
            this.ModifySelectedZoomZSC = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ZoomStopCalculate = new System.Windows.Forms.Button();
            this.ZoomStopOutputLabel = new System.Windows.Forms.Label();
            this.CalcSED = new System.Windows.Forms.RadioButton();
            this.CalcSET = new System.Windows.Forms.RadioButton();
            this.CalcFED = new System.Windows.Forms.RadioButton();
            this.CalcFET = new System.Windows.Forms.RadioButton();
            this.ZoomStopDescription = new System.Windows.Forms.Label();
            this.InputGroup = new System.Windows.Forms.GroupBox();
            this.SecondEventDistanceBox = new System.Windows.Forms.NumericUpDown();
            this.SecondEventTimeBox = new System.Windows.Forms.NumericUpDown();
            this.FirstEventDistanceBox = new System.Windows.Forms.NumericUpDown();
            this.FirstEventTimeBox = new System.Windows.Forms.NumericUpDown();
            this.StartingDistanceBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FindNextZoomZSC = new System.Windows.Forms.Button();
            this.FindPrevZoomZSC = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.EnvSpriteEndPosZ = new System.Windows.Forms.NumericUpDown();
            this.EnvSpriteStartPosZ = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.EnvSpriteEndPosY = new System.Windows.Forms.NumericUpDown();
            this.EnvSpriteStartPosY = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CreateEventsESM = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.EventsPerSec = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.EnvSpriteEndTime = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.EnvSpriteStartTime = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.EnvSpriteEndPosX = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.EnvSpriteStartPosX = new System.Windows.Forms.NumericUpDown();
            this.EnvSpriteIDLabel = new System.Windows.Forms.Label();
            this.EnvSpriteID = new System.Windows.Forms.TextBox();
            this.CopyConfigPreviewESM = new System.Windows.Forms.Button();
            this.ModifyConfigPreviewESM = new System.Windows.Forms.CheckBox();
            this.ConfigPreviewLabelESM = new System.Windows.Forms.Label();
            this.ConfigPreviewESMRTB = new System.Windows.Forms.RichTextBox();
            this.InvertHandButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.HandSwitchTab.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.MapSplitterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitterSplitContainer)).BeginInit();
            this.SplitterSplitContainer.Panel1.SuspendLayout();
            this.SplitterSplitContainer.Panel2.SuspendLayout();
            this.SplitterSplitContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitTimeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPreviews)).BeginInit();
            this.SplitPreviews.Panel1.SuspendLayout();
            this.SplitPreviews.Panel2.SuspendLayout();
            this.SplitPreviews.SuspendLayout();
            this.EventModifier.SuspendLayout();
            this.EventModifierPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZEMContainer)).BeginInit();
            this.ZEMContainer.Panel1.SuspendLayout();
            this.ZEMContainer.Panel2.SuspendLayout();
            this.ZEMContainer.SuspendLayout();
            this.DestructiveZEMGroup.SuspendLayout();
            this.ZoomStopTab.SuspendLayout();
            this.ZoomPanel.SuspendLayout();
            this.AdvancedOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomRangeZSCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomFrameRate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.InputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEventDistanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEventTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEventDistanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEventTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingDistanceBox)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteEndPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteStartPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteEndPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteStartPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsPerSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteEndPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteStartPosX)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvancedFrameRateCalc
            // 
            this.AdvancedFrameRateCalc.AutoSize = true;
            this.AdvancedFrameRateCalc.Cursor = System.Windows.Forms.Cursors.Help;
            this.AdvancedFrameRateCalc.Location = new System.Drawing.Point(10, 20);
            this.AdvancedFrameRateCalc.Name = "AdvancedFrameRateCalc";
            this.AdvancedFrameRateCalc.Size = new System.Drawing.Size(119, 17);
            this.AdvancedFrameRateCalc.TabIndex = 0;
            this.AdvancedFrameRateCalc.Text = "Custom Frame Rate";
            this.CustomFRToolTip.SetToolTip(this.AdvancedFrameRateCalc, "Used to mimmick in-game zoom calculations.\nIf you want a zoom that looks best on " +
        "your machine, input your average frame rate.\nDefault Frame Rate is 1000.");
            this.AdvancedFrameRateCalc.UseVisualStyleBackColor = true;
            this.AdvancedFrameRateCalc.CheckedChanged += new System.EventHandler(this.AdvancedFrameRateCalc_CheckedChanged);
            // 
            // AdvancedCustomRangeCalc
            // 
            this.AdvancedCustomRangeCalc.AutoSize = true;
            this.AdvancedCustomRangeCalc.Cursor = System.Windows.Forms.Cursors.Help;
            this.AdvancedCustomRangeCalc.Location = new System.Drawing.Point(11, 88);
            this.AdvancedCustomRangeCalc.Name = "AdvancedCustomRangeCalc";
            this.AdvancedCustomRangeCalc.Size = new System.Drawing.Size(96, 17);
            this.AdvancedCustomRangeCalc.TabIndex = 2;
            this.AdvancedCustomRangeCalc.Text = "Custom Range";
            this.CustomRangeToolTip.SetToolTip(this.AdvancedCustomRangeCalc, "Used in the calculation of the First Event Distance.\nIncreasing this range can ha" +
        "ve a big impact on calculation time. Use with caution.\nDefault: 500");
            this.AdvancedCustomRangeCalc.UseVisualStyleBackColor = true;
            this.AdvancedCustomRangeCalc.CheckedChanged += new System.EventHandler(this.AdvancedCustomRangeCalc_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoadButton);
            this.panel1.Controls.Add(this.ModifiedTracker);
            this.panel1.Controls.Add(this.Overwrite);
            this.panel1.Controls.Add(this.SaveFolder);
            this.panel1.Controls.Add(this.SaveConfig);
            this.panel1.Controls.Add(this.LoadMapButton);
            this.panel1.Controls.Add(this.AddressBox);
            this.panel1.Controls.Add(this.LoadedMap);
            this.panel1.Location = new System.Drawing.Point(13, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 51);
            this.panel1.TabIndex = 1;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(434, 0);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Load Map";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ModifiedTracker
            // 
            this.ModifiedTracker.AutoSize = true;
            this.ModifiedTracker.Location = new System.Drawing.Point(1, 30);
            this.ModifiedTracker.Name = "ModifiedTracker";
            this.ModifiedTracker.Size = new System.Drawing.Size(128, 13);
            this.ModifiedTracker.TabIndex = 8;
            this.ModifiedTracker.Text = "No Map Currently Loaded";
            // 
            // Overwrite
            // 
            this.Overwrite.Cursor = System.Windows.Forms.Cursors.Help;
            this.Overwrite.Enabled = false;
            this.Overwrite.Location = new System.Drawing.Point(845, 12);
            this.Overwrite.Name = "Overwrite";
            this.Overwrite.Size = new System.Drawing.Size(77, 23);
            this.Overwrite.TabIndex = 7;
            this.Overwrite.Text = "Overwrite";
            this.OverwriteTT.SetToolTip(this.Overwrite, "Not Yet Implemented.\nOverwrite the currently loaded config.txt with any changes y" +
        "ou\'ve made.\nWarning: This option can be destructive, be careful!");
            this.Overwrite.UseVisualStyleBackColor = true;
            // 
            // SaveFolder
            // 
            this.SaveFolder.Cursor = System.Windows.Forms.Cursors.Help;
            this.SaveFolder.Enabled = false;
            this.SaveFolder.Location = new System.Drawing.Point(764, 12);
            this.SaveFolder.Name = "SaveFolder";
            this.SaveFolder.Size = new System.Drawing.Size(75, 23);
            this.SaveFolder.TabIndex = 6;
            this.SaveFolder.Text = "Save Folder";
            this.SaveFolderTT.SetToolTip(this.SaveFolder, "Not Yet Implemented.\nSave a copy of the entire map folder to a new location.");
            this.SaveFolder.UseVisualStyleBackColor = true;
            // 
            // SaveConfig
            // 
            this.SaveConfig.Cursor = System.Windows.Forms.Cursors.Help;
            this.SaveConfig.Enabled = false;
            this.SaveConfig.Location = new System.Drawing.Point(681, 12);
            this.SaveConfig.Name = "SaveConfig";
            this.SaveConfig.Size = new System.Drawing.Size(77, 23);
            this.SaveConfig.TabIndex = 5;
            this.SaveConfig.Text = "Save Config";
            this.SaveConfigTT.SetToolTip(this.SaveConfig, "Not Yet Implemented.\nSave a copy of the map\'s config.txt to a new location.");
            this.SaveConfig.UseVisualStyleBackColor = true;
            // 
            // LoadMapButton
            // 
            this.LoadMapButton.Location = new System.Drawing.Point(353, 0);
            this.LoadMapButton.Name = "LoadMapButton";
            this.LoadMapButton.Size = new System.Drawing.Size(75, 23);
            this.LoadMapButton.TabIndex = 2;
            this.LoadMapButton.Text = "Browse";
            this.LoadMapButton.UseVisualStyleBackColor = true;
            this.LoadMapButton.Click += new System.EventHandler(this.LoadMapButton_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(87, 2);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(260, 20);
            this.AddressBox.TabIndex = 1;
            // 
            // LoadedMap
            // 
            this.LoadedMap.AutoSize = true;
            this.LoadedMap.Location = new System.Drawing.Point(1, 5);
            this.LoadedMap.Name = "LoadedMap";
            this.LoadedMap.Size = new System.Drawing.Size(84, 13);
            this.LoadedMap.TabIndex = 0;
            this.LoadedMap.Text = "Load Map From:";
            // 
            // BrowseForMapFolder
            // 
            this.BrowseForMapFolder.Description = "Select the folder of your map.";
            // 
            // HandSwitchTab
            // 
            this.HandSwitchTab.BackColor = System.Drawing.SystemColors.Control;
            this.HandSwitchTab.Controls.Add(this.InvertHandButton);
            this.HandSwitchTab.Controls.Add(this.HandZeroButton);
            this.HandSwitchTab.Controls.Add(this.HandTwoButton);
            this.HandSwitchTab.Controls.Add(this.HandOneButton);
            this.HandSwitchTab.Controls.Add(this.label12);
            this.HandSwitchTab.Controls.Add(this.CopyConfigPreviewHS);
            this.HandSwitchTab.Controls.Add(this.ModifyConfigPreviewHS);
            this.HandSwitchTab.Controls.Add(this.ConfigPreviewHSLabel);
            this.HandSwitchTab.Controls.Add(this.ConfigPreviewRTBHS);
            this.HandSwitchTab.Location = new System.Drawing.Point(4, 22);
            this.HandSwitchTab.Name = "HandSwitchTab";
            this.HandSwitchTab.Padding = new System.Windows.Forms.Padding(3);
            this.HandSwitchTab.Size = new System.Drawing.Size(927, 440);
            this.HandSwitchTab.TabIndex = 5;
            this.HandSwitchTab.Text = "Hand Switcher";
            // 
            // HandZeroButton
            // 
            this.HandZeroButton.Location = new System.Drawing.Point(9, 88);
            this.HandZeroButton.Name = "HandZeroButton";
            this.HandZeroButton.Size = new System.Drawing.Size(202, 23);
            this.HandZeroButton.TabIndex = 38;
            this.HandZeroButton.Text = "Make All Arcs Default (One Hand)";
            this.HandZeroButton.UseVisualStyleBackColor = true;
            this.HandZeroButton.Click += new System.EventHandler(this.HandZeroButton_Click);
            // 
            // HandTwoButton
            // 
            this.HandTwoButton.Location = new System.Drawing.Point(9, 59);
            this.HandTwoButton.Name = "HandTwoButton";
            this.HandTwoButton.Size = new System.Drawing.Size(202, 23);
            this.HandTwoButton.TabIndex = 37;
            this.HandTwoButton.Text = "Make All Arcs Hand Two (Right Side)";
            this.HandTwoButton.UseVisualStyleBackColor = true;
            this.HandTwoButton.Click += new System.EventHandler(this.HandTwoButton_Click);
            // 
            // HandOneButton
            // 
            this.HandOneButton.Location = new System.Drawing.Point(9, 30);
            this.HandOneButton.Name = "HandOneButton";
            this.HandOneButton.Size = new System.Drawing.Size(202, 23);
            this.HandOneButton.TabIndex = 36;
            this.HandOneButton.Text = "Make All Arcs Hand One (Left Side)";
            this.HandOneButton.UseVisualStyleBackColor = true;
            this.HandOneButton.Click += new System.EventHandler(this.HandOneButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "This tool switches all arcs in a map to hand one or hand two";
            // 
            // CopyConfigPreviewHS
            // 
            this.CopyConfigPreviewHS.Enabled = false;
            this.CopyConfigPreviewHS.Location = new System.Drawing.Point(841, 411);
            this.CopyConfigPreviewHS.Name = "CopyConfigPreviewHS";
            this.CopyConfigPreviewHS.Size = new System.Drawing.Size(75, 23);
            this.CopyConfigPreviewHS.TabIndex = 42;
            this.CopyConfigPreviewHS.Text = "Copy All";
            this.CopyConfigPreviewHS.UseVisualStyleBackColor = true;
            this.CopyConfigPreviewHS.Click += new System.EventHandler(this.CopyConfigPreviewHS_Click);
            // 
            // ModifyConfigPreviewHS
            // 
            this.ModifyConfigPreviewHS.AutoSize = true;
            this.ModifyConfigPreviewHS.Location = new System.Drawing.Point(842, 13);
            this.ModifyConfigPreviewHS.Name = "ModifyConfigPreviewHS";
            this.ModifyConfigPreviewHS.Size = new System.Drawing.Size(74, 17);
            this.ModifyConfigPreviewHS.TabIndex = 41;
            this.ModifyConfigPreviewHS.Text = "Modifiable";
            this.ModifyConfigPreviewHS.UseVisualStyleBackColor = true;
            this.ModifyConfigPreviewHS.CheckedChanged += new System.EventHandler(this.ModifyConfigPreviewHS_CheckedChanged);
            // 
            // ConfigPreviewHSLabel
            // 
            this.ConfigPreviewHSLabel.AutoSize = true;
            this.ConfigPreviewHSLabel.Location = new System.Drawing.Point(630, 14);
            this.ConfigPreviewHSLabel.Name = "ConfigPreviewHSLabel";
            this.ConfigPreviewHSLabel.Size = new System.Drawing.Size(78, 13);
            this.ConfigPreviewHSLabel.TabIndex = 40;
            this.ConfigPreviewHSLabel.Text = "Config Preview";
            // 
            // ConfigPreviewRTBHS
            // 
            this.ConfigPreviewRTBHS.DetectUrls = false;
            this.ConfigPreviewRTBHS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigPreviewRTBHS.Location = new System.Drawing.Point(631, 30);
            this.ConfigPreviewRTBHS.Name = "ConfigPreviewRTBHS";
            this.ConfigPreviewRTBHS.ReadOnly = true;
            this.ConfigPreviewRTBHS.Size = new System.Drawing.Size(287, 375);
            this.ConfigPreviewRTBHS.TabIndex = 39;
            this.ConfigPreviewRTBHS.Text = "No Map Loaded!";
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.linkLabel1);
            this.AboutTab.Controls.Add(this.label9);
            this.AboutTab.Controls.Add(this.label8);
            this.AboutTab.Controls.Add(this.label7);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(927, 440);
            this.AboutTab.TabIndex = 4;
            this.AboutTab.Text = "About";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 102);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Copyright (c) 2019 Nathaniel Beasley";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Intralism Mapping Assistant v0.6.0";
            // 
            // MapSplitterTab
            // 
            this.MapSplitterTab.Controls.Add(this.SplitterSplitContainer);
            this.MapSplitterTab.Location = new System.Drawing.Point(4, 22);
            this.MapSplitterTab.Name = "MapSplitterTab";
            this.MapSplitterTab.Padding = new System.Windows.Forms.Padding(3);
            this.MapSplitterTab.Size = new System.Drawing.Size(927, 440);
            this.MapSplitterTab.TabIndex = 3;
            this.MapSplitterTab.Text = "Map Splitter";
            // 
            // SplitterSplitContainer
            // 
            this.SplitterSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitterSplitContainer.IsSplitterFixed = true;
            this.SplitterSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.SplitterSplitContainer.Name = "SplitterSplitContainer";
            // 
            // SplitterSplitContainer.Panel1
            // 
            this.SplitterSplitContainer.Panel1.Controls.Add(this.panel2);
            this.SplitterSplitContainer.Panel1.Controls.Add(this.SplitterDescription);
            // 
            // SplitterSplitContainer.Panel2
            // 
            this.SplitterSplitContainer.Panel2.Controls.Add(this.SplitPreviews);
            this.SplitterSplitContainer.Size = new System.Drawing.Size(921, 434);
            this.SplitterSplitContainer.SplitterDistance = 307;
            this.SplitterSplitContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CopyAudioOffsetSplit);
            this.panel2.Controls.Add(this.AudioOffsetSplitter);
            this.panel2.Controls.Add(this.AudioSplitBoxLabel);
            this.panel2.Controls.Add(this.PSANoAudioSplit);
            this.panel2.Controls.Add(this.SplitTimeSelect);
            this.panel2.Controls.Add(this.SplitAfterEventButton);
            this.panel2.Controls.Add(this.SplitAtTimeButton);
            this.panel2.Controls.Add(this.SplitAtHalfButton);
            this.panel2.Location = new System.Drawing.Point(7, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 409);
            this.panel2.TabIndex = 5;
            // 
            // CopyAudioOffsetSplit
            // 
            this.CopyAudioOffsetSplit.Location = new System.Drawing.Point(109, 163);
            this.CopyAudioOffsetSplit.Name = "CopyAudioOffsetSplit";
            this.CopyAudioOffsetSplit.Size = new System.Drawing.Size(75, 23);
            this.CopyAudioOffsetSplit.TabIndex = 33;
            this.CopyAudioOffsetSplit.Text = "Copy";
            this.CopyAudioOffsetSplit.UseVisualStyleBackColor = true;
            this.CopyAudioOffsetSplit.Click += new System.EventHandler(this.CopyAudioOffsetSplit_Click);
            // 
            // AudioOffsetSplitter
            // 
            this.AudioOffsetSplitter.Location = new System.Drawing.Point(3, 165);
            this.AudioOffsetSplitter.Name = "AudioOffsetSplitter";
            this.AudioOffsetSplitter.ReadOnly = true;
            this.AudioOffsetSplitter.Size = new System.Drawing.Size(100, 20);
            this.AudioOffsetSplitter.TabIndex = 7;
            // 
            // AudioSplitBoxLabel
            // 
            this.AudioSplitBoxLabel.AutoSize = true;
            this.AudioSplitBoxLabel.Location = new System.Drawing.Point(0, 148);
            this.AudioSplitBoxLabel.Name = "AudioSplitBoxLabel";
            this.AudioSplitBoxLabel.Size = new System.Drawing.Size(65, 13);
            this.AudioSplitBoxLabel.TabIndex = 6;
            this.AudioSplitBoxLabel.Text = "Audio Offset";
            // 
            // PSANoAudioSplit
            // 
            this.PSANoAudioSplit.AutoSize = true;
            this.PSANoAudioSplit.Location = new System.Drawing.Point(3, 101);
            this.PSANoAudioSplit.Name = "PSANoAudioSplit";
            this.PSANoAudioSplit.Size = new System.Drawing.Size(225, 39);
            this.PSANoAudioSplit.TabIndex = 5;
            this.PSANoAudioSplit.Text = "This tool does not split the audio yet.\nYou can use the below offset to split the" +
    " audio\nin another program, like Audacity.";
            // 
            // SplitTimeSelect
            // 
            this.SplitTimeSelect.DecimalPlaces = 5;
            this.SplitTimeSelect.Location = new System.Drawing.Point(158, 73);
            this.SplitTimeSelect.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SplitTimeSelect.Name = "SplitTimeSelect";
            this.SplitTimeSelect.Size = new System.Drawing.Size(120, 20);
            this.SplitTimeSelect.TabIndex = 4;
            // 
            // SplitAfterEventButton
            // 
            this.SplitAfterEventButton.Location = new System.Drawing.Point(3, 13);
            this.SplitAfterEventButton.Name = "SplitAfterEventButton";
            this.SplitAfterEventButton.Size = new System.Drawing.Size(148, 23);
            this.SplitAfterEventButton.TabIndex = 0;
            this.SplitAfterEventButton.Text = "Split After Selected Event";
            this.SplitAfterEventButton.UseVisualStyleBackColor = true;
            this.SplitAfterEventButton.Click += new System.EventHandler(this.SplitAfterEventButton_Click);
            // 
            // SplitAtTimeButton
            // 
            this.SplitAtTimeButton.Location = new System.Drawing.Point(3, 71);
            this.SplitAtTimeButton.Name = "SplitAtTimeButton";
            this.SplitAtTimeButton.Size = new System.Drawing.Size(148, 23);
            this.SplitAtTimeButton.TabIndex = 3;
            this.SplitAtTimeButton.Text = "Split At Time";
            this.SplitAtTimeButton.UseVisualStyleBackColor = true;
            this.SplitAtTimeButton.Click += new System.EventHandler(this.SplitAtTimeButton_Click);
            // 
            // SplitAtHalfButton
            // 
            this.SplitAtHalfButton.Location = new System.Drawing.Point(3, 42);
            this.SplitAtHalfButton.Name = "SplitAtHalfButton";
            this.SplitAtHalfButton.Size = new System.Drawing.Size(148, 23);
            this.SplitAtHalfButton.TabIndex = 2;
            this.SplitAtHalfButton.Text = "Split in Half";
            this.SplitAtHalfButton.UseVisualStyleBackColor = true;
            this.SplitAtHalfButton.Click += new System.EventHandler(this.SplitAtHalfButton_Click);
            // 
            // SplitterDescription
            // 
            this.SplitterDescription.AutoSize = true;
            this.SplitterDescription.Location = new System.Drawing.Point(4, 4);
            this.SplitterDescription.Name = "SplitterDescription";
            this.SplitterDescription.Size = new System.Drawing.Size(259, 13);
            this.SplitterDescription.TabIndex = 4;
            this.SplitterDescription.Text = "This tool can split a config.txt into two individual maps";
            // 
            // SplitPreviews
            // 
            this.SplitPreviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPreviews.IsSplitterFixed = true;
            this.SplitPreviews.Location = new System.Drawing.Point(0, 0);
            this.SplitPreviews.Name = "SplitPreviews";
            // 
            // SplitPreviews.Panel1
            // 
            this.SplitPreviews.Panel1.Controls.Add(this.FindNextEventSCP1);
            this.SplitPreviews.Panel1.Controls.Add(this.FindPrevEventSCP1);
            this.SplitPreviews.Panel1.Controls.Add(this.CopySCP1);
            this.SplitPreviews.Panel1.Controls.Add(this.ModifyConfigPreviewSCP1);
            this.SplitPreviews.Panel1.Controls.Add(this.label11);
            this.SplitPreviews.Panel1.Controls.Add(this.SplitConfigPart1);
            // 
            // SplitPreviews.Panel2
            // 
            this.SplitPreviews.Panel2.Controls.Add(this.FindNextEventSCP2);
            this.SplitPreviews.Panel2.Controls.Add(this.FindPrevEventSCP2);
            this.SplitPreviews.Panel2.Controls.Add(this.CopySCP2);
            this.SplitPreviews.Panel2.Controls.Add(this.ModifyConfigPreviewSCP2);
            this.SplitPreviews.Panel2.Controls.Add(this.label10);
            this.SplitPreviews.Panel2.Controls.Add(this.SplitConfigPart2);
            this.SplitPreviews.Size = new System.Drawing.Size(610, 434);
            this.SplitPreviews.SplitterDistance = 306;
            this.SplitPreviews.TabIndex = 0;
            // 
            // FindNextEventSCP1
            // 
            this.FindNextEventSCP1.Location = new System.Drawing.Point(117, 390);
            this.FindNextEventSCP1.Name = "FindNextEventSCP1";
            this.FindNextEventSCP1.Size = new System.Drawing.Size(97, 23);
            this.FindNextEventSCP1.TabIndex = 32;
            this.FindNextEventSCP1.Text = "Find Next Event";
            this.FindNextEventSCP1.UseVisualStyleBackColor = true;
            this.FindNextEventSCP1.Click += new System.EventHandler(this.FindNextEventSCP1_Click);
            // 
            // FindPrevEventSCP1
            // 
            this.FindPrevEventSCP1.Location = new System.Drawing.Point(12, 390);
            this.FindPrevEventSCP1.Name = "FindPrevEventSCP1";
            this.FindPrevEventSCP1.Size = new System.Drawing.Size(97, 23);
            this.FindPrevEventSCP1.TabIndex = 31;
            this.FindPrevEventSCP1.Text = "Find Prev Event";
            this.FindPrevEventSCP1.UseVisualStyleBackColor = true;
            this.FindPrevEventSCP1.Click += new System.EventHandler(this.FindPrevEventSCP1_Click);
            // 
            // CopySCP1
            // 
            this.CopySCP1.Enabled = false;
            this.CopySCP1.Location = new System.Drawing.Point(220, 390);
            this.CopySCP1.Name = "CopySCP1";
            this.CopySCP1.Size = new System.Drawing.Size(75, 23);
            this.CopySCP1.TabIndex = 30;
            this.CopySCP1.Text = "Copy All";
            this.CopySCP1.UseVisualStyleBackColor = true;
            this.CopySCP1.Click += new System.EventHandler(this.CopySCP1_Click);
            // 
            // ModifyConfigPreviewSCP1
            // 
            this.ModifyConfigPreviewSCP1.AutoSize = true;
            this.ModifyConfigPreviewSCP1.Location = new System.Drawing.Point(221, 21);
            this.ModifyConfigPreviewSCP1.Name = "ModifyConfigPreviewSCP1";
            this.ModifyConfigPreviewSCP1.Size = new System.Drawing.Size(74, 17);
            this.ModifyConfigPreviewSCP1.TabIndex = 29;
            this.ModifyConfigPreviewSCP1.Text = "Modifiable";
            this.ModifyConfigPreviewSCP1.UseVisualStyleBackColor = true;
            this.ModifyConfigPreviewSCP1.CheckedChanged += new System.EventHandler(this.ModifyConfigPreviewSCP1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Split Config Part 1";
            // 
            // SplitConfigPart1
            // 
            this.SplitConfigPart1.DetectUrls = false;
            this.SplitConfigPart1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitConfigPart1.Location = new System.Drawing.Point(10, 38);
            this.SplitConfigPart1.Name = "SplitConfigPart1";
            this.SplitConfigPart1.ReadOnly = true;
            this.SplitConfigPart1.Size = new System.Drawing.Size(287, 346);
            this.SplitConfigPart1.TabIndex = 27;
            this.SplitConfigPart1.Text = "No Map Loaded!";
            // 
            // FindNextEventSCP2
            // 
            this.FindNextEventSCP2.Location = new System.Drawing.Point(114, 390);
            this.FindNextEventSCP2.Name = "FindNextEventSCP2";
            this.FindNextEventSCP2.Size = new System.Drawing.Size(97, 23);
            this.FindNextEventSCP2.TabIndex = 32;
            this.FindNextEventSCP2.Text = "Find Next Event";
            this.FindNextEventSCP2.UseVisualStyleBackColor = true;
            this.FindNextEventSCP2.Click += new System.EventHandler(this.FindNextEventSCP2_Click);
            // 
            // FindPrevEventSCP2
            // 
            this.FindPrevEventSCP2.Location = new System.Drawing.Point(9, 390);
            this.FindPrevEventSCP2.Name = "FindPrevEventSCP2";
            this.FindPrevEventSCP2.Size = new System.Drawing.Size(97, 23);
            this.FindPrevEventSCP2.TabIndex = 31;
            this.FindPrevEventSCP2.Text = "Find Prev Event";
            this.FindPrevEventSCP2.UseVisualStyleBackColor = true;
            this.FindPrevEventSCP2.Click += new System.EventHandler(this.FindPrevEventSCP2_Click);
            // 
            // CopySCP2
            // 
            this.CopySCP2.Enabled = false;
            this.CopySCP2.Location = new System.Drawing.Point(217, 390);
            this.CopySCP2.Name = "CopySCP2";
            this.CopySCP2.Size = new System.Drawing.Size(75, 23);
            this.CopySCP2.TabIndex = 30;
            this.CopySCP2.Text = "Copy All";
            this.CopySCP2.UseVisualStyleBackColor = true;
            this.CopySCP2.Click += new System.EventHandler(this.CopySCP2_Click);
            // 
            // ModifyConfigPreviewSCP2
            // 
            this.ModifyConfigPreviewSCP2.AutoSize = true;
            this.ModifyConfigPreviewSCP2.Location = new System.Drawing.Point(218, 21);
            this.ModifyConfigPreviewSCP2.Name = "ModifyConfigPreviewSCP2";
            this.ModifyConfigPreviewSCP2.Size = new System.Drawing.Size(74, 17);
            this.ModifyConfigPreviewSCP2.TabIndex = 29;
            this.ModifyConfigPreviewSCP2.Text = "Modifiable";
            this.ModifyConfigPreviewSCP2.UseVisualStyleBackColor = true;
            this.ModifyConfigPreviewSCP2.CheckedChanged += new System.EventHandler(this.ModifyConfigPreviewSCP2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Split Config Part 2";
            // 
            // SplitConfigPart2
            // 
            this.SplitConfigPart2.DetectUrls = false;
            this.SplitConfigPart2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitConfigPart2.Location = new System.Drawing.Point(7, 38);
            this.SplitConfigPart2.Name = "SplitConfigPart2";
            this.SplitConfigPart2.ReadOnly = true;
            this.SplitConfigPart2.Size = new System.Drawing.Size(287, 346);
            this.SplitConfigPart2.TabIndex = 27;
            this.SplitConfigPart2.Text = "Map hasn\'t been split yet!";
            // 
            // EventModifier
            // 
            this.EventModifier.Controls.Add(this.EventModifierPanel);
            this.EventModifier.Location = new System.Drawing.Point(4, 22);
            this.EventModifier.Name = "EventModifier";
            this.EventModifier.Padding = new System.Windows.Forms.Padding(3);
            this.EventModifier.Size = new System.Drawing.Size(927, 440);
            this.EventModifier.TabIndex = 2;
            this.EventModifier.Text = "Zoom Event Modifier";
            // 
            // EventModifierPanel
            // 
            this.EventModifierPanel.Controls.Add(this.ZEMContainer);
            this.EventModifierPanel.Controls.Add(this.ZoomModifierDescription);
            this.EventModifierPanel.Location = new System.Drawing.Point(7, 6);
            this.EventModifierPanel.Name = "EventModifierPanel";
            this.EventModifierPanel.Size = new System.Drawing.Size(914, 477);
            this.EventModifierPanel.TabIndex = 0;
            // 
            // ZEMContainer
            // 
            this.ZEMContainer.IsSplitterFixed = true;
            this.ZEMContainer.Location = new System.Drawing.Point(7, 23);
            this.ZEMContainer.Name = "ZEMContainer";
            // 
            // ZEMContainer.Panel1
            // 
            this.ZEMContainer.Panel1.Controls.Add(this.DestructiveZEMGroup);
            // 
            // ZEMContainer.Panel2
            // 
            this.ZEMContainer.Panel2.Controls.Add(this.FindNextZoomZEM);
            this.ZEMContainer.Panel2.Controls.Add(this.FindPrevZoomZEM);
            this.ZEMContainer.Panel2.Controls.Add(this.CopyPreviewBox);
            this.ZEMContainer.Panel2.Controls.Add(this.ModifyConfigPreviewZEM);
            this.ZEMContainer.Panel2.Controls.Add(this.ConfigPreviewZEM);
            this.ZEMContainer.Panel2.Controls.Add(this.ConfigPreviewRTBZEM);
            this.ZEMContainer.Size = new System.Drawing.Size(906, 405);
            this.ZEMContainer.SplitterDistance = 608;
            this.ZEMContainer.TabIndex = 1;
            // 
            // DestructiveZEMGroup
            // 
            this.DestructiveZEMGroup.Controls.Add(this.DeleteAllZoomsButton);
            this.DestructiveZEMGroup.Controls.Add(this.DestructiveCheckZEM);
            this.DestructiveZEMGroup.Location = new System.Drawing.Point(3, 307);
            this.DestructiveZEMGroup.Name = "DestructiveZEMGroup";
            this.DestructiveZEMGroup.Size = new System.Drawing.Size(602, 85);
            this.DestructiveZEMGroup.TabIndex = 0;
            this.DestructiveZEMGroup.TabStop = false;
            this.DestructiveZEMGroup.Text = "Destructive Options";
            // 
            // DeleteAllZoomsButton
            // 
            this.DeleteAllZoomsButton.Enabled = false;
            this.DeleteAllZoomsButton.Location = new System.Drawing.Point(7, 44);
            this.DeleteAllZoomsButton.Name = "DeleteAllZoomsButton";
            this.DeleteAllZoomsButton.Size = new System.Drawing.Size(142, 23);
            this.DeleteAllZoomsButton.TabIndex = 1;
            this.DeleteAllZoomsButton.Text = "Remove All Zoom Events";
            this.DeleteAllZoomsButton.UseVisualStyleBackColor = true;
            this.DeleteAllZoomsButton.Click += new System.EventHandler(this.DeleteAllZooms_Click);
            // 
            // DestructiveCheckZEM
            // 
            this.DestructiveCheckZEM.AutoSize = true;
            this.DestructiveCheckZEM.Enabled = false;
            this.DestructiveCheckZEM.Location = new System.Drawing.Point(7, 20);
            this.DestructiveCheckZEM.Name = "DestructiveCheckZEM";
            this.DestructiveCheckZEM.Size = new System.Drawing.Size(489, 17);
            this.DestructiveCheckZEM.TabIndex = 0;
            this.DestructiveCheckZEM.Text = "I understand this can seriously fuck up the map if I\'m not careful, lemme use the" +
    "se options anyway!";
            this.DestructiveCheckZEM.UseVisualStyleBackColor = true;
            this.DestructiveCheckZEM.CheckedChanged += new System.EventHandler(this.DestructiveCheckZEM_CheckedChanged);
            // 
            // FindNextZoomZEM
            // 
            this.FindNextZoomZEM.Enabled = false;
            this.FindNextZoomZEM.Location = new System.Drawing.Point(111, 373);
            this.FindNextZoomZEM.Name = "FindNextZoomZEM";
            this.FindNextZoomZEM.Size = new System.Drawing.Size(97, 23);
            this.FindNextZoomZEM.TabIndex = 26;
            this.FindNextZoomZEM.Text = "Find Next Zoom";
            this.FindNextZoomZEM.UseVisualStyleBackColor = true;
            this.FindNextZoomZEM.Click += new System.EventHandler(this.FindNextZoomZEM_Click);
            // 
            // FindPrevZoomZEM
            // 
            this.FindPrevZoomZEM.Enabled = false;
            this.FindPrevZoomZEM.Location = new System.Drawing.Point(6, 373);
            this.FindPrevZoomZEM.Name = "FindPrevZoomZEM";
            this.FindPrevZoomZEM.Size = new System.Drawing.Size(97, 23);
            this.FindPrevZoomZEM.TabIndex = 25;
            this.FindPrevZoomZEM.Text = "Find Prev Zoom";
            this.FindPrevZoomZEM.UseVisualStyleBackColor = true;
            this.FindPrevZoomZEM.Click += new System.EventHandler(this.FindPrevZoomZEM_Click);
            // 
            // CopyPreviewBox
            // 
            this.CopyPreviewBox.Enabled = false;
            this.CopyPreviewBox.Location = new System.Drawing.Point(214, 373);
            this.CopyPreviewBox.Name = "CopyPreviewBox";
            this.CopyPreviewBox.Size = new System.Drawing.Size(75, 23);
            this.CopyPreviewBox.TabIndex = 3;
            this.CopyPreviewBox.Text = "Copy All";
            this.CopyPreviewBox.UseVisualStyleBackColor = true;
            this.CopyPreviewBox.Click += new System.EventHandler(this.CopyPreviewBox_Click);
            // 
            // ModifyConfigPreviewZEM
            // 
            this.ModifyConfigPreviewZEM.AutoSize = true;
            this.ModifyConfigPreviewZEM.Location = new System.Drawing.Point(215, 4);
            this.ModifyConfigPreviewZEM.Name = "ModifyConfigPreviewZEM";
            this.ModifyConfigPreviewZEM.Size = new System.Drawing.Size(74, 17);
            this.ModifyConfigPreviewZEM.TabIndex = 2;
            this.ModifyConfigPreviewZEM.Text = "Modifiable";
            this.ModifyConfigPreviewZEM.UseVisualStyleBackColor = true;
            this.ModifyConfigPreviewZEM.CheckedChanged += new System.EventHandler(this.ModifyConfigPreviewZEM_CheckedChanged);
            // 
            // ConfigPreviewZEM
            // 
            this.ConfigPreviewZEM.AutoSize = true;
            this.ConfigPreviewZEM.Location = new System.Drawing.Point(3, 5);
            this.ConfigPreviewZEM.Name = "ConfigPreviewZEM";
            this.ConfigPreviewZEM.Size = new System.Drawing.Size(78, 13);
            this.ConfigPreviewZEM.TabIndex = 1;
            this.ConfigPreviewZEM.Text = "Config Preview";
            // 
            // ConfigPreviewRTBZEM
            // 
            this.ConfigPreviewRTBZEM.DetectUrls = false;
            this.ConfigPreviewRTBZEM.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigPreviewRTBZEM.Location = new System.Drawing.Point(4, 21);
            this.ConfigPreviewRTBZEM.Name = "ConfigPreviewRTBZEM";
            this.ConfigPreviewRTBZEM.ReadOnly = true;
            this.ConfigPreviewRTBZEM.Size = new System.Drawing.Size(287, 346);
            this.ConfigPreviewRTBZEM.TabIndex = 0;
            this.ConfigPreviewRTBZEM.Text = "No Map Loaded!";
            // 
            // ZoomModifierDescription
            // 
            this.ZoomModifierDescription.AutoSize = true;
            this.ZoomModifierDescription.Location = new System.Drawing.Point(4, 4);
            this.ZoomModifierDescription.Name = "ZoomModifierDescription";
            this.ZoomModifierDescription.Size = new System.Drawing.Size(297, 13);
            this.ZoomModifierDescription.TabIndex = 0;
            this.ZoomModifierDescription.Text = "This tool can modify zoom events in the currently loaded map.";
            // 
            // ZoomStopTab
            // 
            this.ZoomStopTab.Controls.Add(this.ZoomPanel);
            this.ZoomStopTab.Location = new System.Drawing.Point(4, 22);
            this.ZoomStopTab.Name = "ZoomStopTab";
            this.ZoomStopTab.Padding = new System.Windows.Forms.Padding(3);
            this.ZoomStopTab.Size = new System.Drawing.Size(927, 440);
            this.ZoomStopTab.TabIndex = 0;
            this.ZoomStopTab.Text = "\"Zoom Stop\" effect Calculator";
            // 
            // ZoomPanel
            // 
            this.ZoomPanel.Controls.Add(this.CopyPreviewBoxZSC);
            this.ZoomPanel.Controls.Add(this.ModifyConfigPreviewZSC);
            this.ZoomPanel.Controls.Add(this.label1);
            this.ZoomPanel.Controls.Add(this.ConfigPreviewRTBZSC);
            this.ZoomPanel.Controls.Add(this.AdvancedOptions);
            this.ZoomPanel.Controls.Add(this.groupBox2);
            this.ZoomPanel.Controls.Add(this.CalcSED);
            this.ZoomPanel.Controls.Add(this.CalcSET);
            this.ZoomPanel.Controls.Add(this.CalcFED);
            this.ZoomPanel.Controls.Add(this.CalcFET);
            this.ZoomPanel.Controls.Add(this.ZoomStopDescription);
            this.ZoomPanel.Controls.Add(this.InputGroup);
            this.ZoomPanel.Controls.Add(this.FindNextZoomZSC);
            this.ZoomPanel.Controls.Add(this.FindPrevZoomZSC);
            this.ZoomPanel.Location = new System.Drawing.Point(7, 7);
            this.ZoomPanel.Name = "ZoomPanel";
            this.ZoomPanel.Size = new System.Drawing.Size(914, 476);
            this.ZoomPanel.TabIndex = 0;
            // 
            // CopyPreviewBoxZSC
            // 
            this.CopyPreviewBoxZSC.Enabled = false;
            this.CopyPreviewBoxZSC.Location = new System.Drawing.Point(834, 396);
            this.CopyPreviewBoxZSC.Name = "CopyPreviewBoxZSC";
            this.CopyPreviewBoxZSC.Size = new System.Drawing.Size(75, 23);
            this.CopyPreviewBoxZSC.TabIndex = 21;
            this.CopyPreviewBoxZSC.Text = "Copy All";
            this.CopyPreviewBoxZSC.UseVisualStyleBackColor = true;
            this.CopyPreviewBoxZSC.Click += new System.EventHandler(this.CopyPreviewBoxZSC_Click);
            // 
            // ModifyConfigPreviewZSC
            // 
            this.ModifyConfigPreviewZSC.AutoSize = true;
            this.ModifyConfigPreviewZSC.Location = new System.Drawing.Point(835, 27);
            this.ModifyConfigPreviewZSC.Name = "ModifyConfigPreviewZSC";
            this.ModifyConfigPreviewZSC.Size = new System.Drawing.Size(74, 17);
            this.ModifyConfigPreviewZSC.TabIndex = 20;
            this.ModifyConfigPreviewZSC.Text = "Modifiable";
            this.ModifyConfigPreviewZSC.UseVisualStyleBackColor = true;
            this.ModifyConfigPreviewZSC.CheckedChanged += new System.EventHandler(this.ModifyConfigPreviewZSC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Config Preview";
            // 
            // ConfigPreviewRTBZSC
            // 
            this.ConfigPreviewRTBZSC.DetectUrls = false;
            this.ConfigPreviewRTBZSC.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigPreviewRTBZSC.Location = new System.Drawing.Point(624, 44);
            this.ConfigPreviewRTBZSC.Name = "ConfigPreviewRTBZSC";
            this.ConfigPreviewRTBZSC.ReadOnly = true;
            this.ConfigPreviewRTBZSC.Size = new System.Drawing.Size(287, 346);
            this.ConfigPreviewRTBZSC.TabIndex = 18;
            this.ConfigPreviewRTBZSC.Text = "No Map Loaded!";
            // 
            // AdvancedOptions
            // 
            this.AdvancedOptions.Controls.Add(this.CustomRangeZSCalc);
            this.AdvancedOptions.Controls.Add(this.AdvancedCustomRangeCalc);
            this.AdvancedOptions.Controls.Add(this.CustomFrameRate);
            this.AdvancedOptions.Controls.Add(this.AdvancedFrameRateCalc);
            this.AdvancedOptions.Location = new System.Drawing.Point(7, 274);
            this.AdvancedOptions.Name = "AdvancedOptions";
            this.AdvancedOptions.Size = new System.Drawing.Size(167, 147);
            this.AdvancedOptions.TabIndex = 17;
            this.AdvancedOptions.TabStop = false;
            this.AdvancedOptions.Text = "Advanced Options";
            // 
            // CustomRangeZSCalc
            // 
            this.CustomRangeZSCalc.Enabled = false;
            this.CustomRangeZSCalc.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CustomRangeZSCalc.Location = new System.Drawing.Point(11, 111);
            this.CustomRangeZSCalc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CustomRangeZSCalc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CustomRangeZSCalc.Name = "CustomRangeZSCalc";
            this.CustomRangeZSCalc.Size = new System.Drawing.Size(120, 20);
            this.CustomRangeZSCalc.TabIndex = 3;
            this.CustomRangeZSCalc.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // CustomFrameRate
            // 
            this.CustomFrameRate.Enabled = false;
            this.CustomFrameRate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CustomFrameRate.Location = new System.Drawing.Point(11, 43);
            this.CustomFrameRate.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.CustomFrameRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CustomFrameRate.Name = "CustomFrameRate";
            this.CustomFrameRate.Size = new System.Drawing.Size(120, 20);
            this.CustomFrameRate.TabIndex = 1;
            this.CustomFrameRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResetSelectedZoomZSC);
            this.groupBox2.Controls.Add(this.ModifySelectedZoomZSC);
            this.groupBox2.Controls.Add(this.OutputBox);
            this.groupBox2.Controls.Add(this.ZoomStopCalculate);
            this.groupBox2.Controls.Add(this.ZoomStopOutputLabel);
            this.groupBox2.Location = new System.Drawing.Point(377, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 131);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // ResetSelectedZoomZSC
            // 
            this.ResetSelectedZoomZSC.Enabled = false;
            this.ResetSelectedZoomZSC.Location = new System.Drawing.Point(6, 98);
            this.ResetSelectedZoomZSC.Name = "ResetSelectedZoomZSC";
            this.ResetSelectedZoomZSC.Size = new System.Drawing.Size(203, 23);
            this.ResetSelectedZoomZSC.TabIndex = 24;
            this.ResetSelectedZoomZSC.Text = "Reset Currently Selected Zoom Event";
            this.ResetSelectedZoomZSC.UseVisualStyleBackColor = true;
            this.ResetSelectedZoomZSC.Click += new System.EventHandler(this.ResetSelectedZoomZSC_Click);
            // 
            // ModifySelectedZoomZSC
            // 
            this.ModifySelectedZoomZSC.Enabled = false;
            this.ModifySelectedZoomZSC.Location = new System.Drawing.Point(6, 71);
            this.ModifySelectedZoomZSC.Name = "ModifySelectedZoomZSC";
            this.ModifySelectedZoomZSC.Size = new System.Drawing.Size(203, 23);
            this.ModifySelectedZoomZSC.TabIndex = 23;
            this.ModifySelectedZoomZSC.Text = "Change Currently Selected Zoom Event";
            this.ModifySelectedZoomZSC.UseVisualStyleBackColor = true;
            this.ModifySelectedZoomZSC.Click += new System.EventHandler(this.ModifySelectedZoomZSC_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(91, 45);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(100, 20);
            this.OutputBox.TabIndex = 22;
            // 
            // ZoomStopCalculate
            // 
            this.ZoomStopCalculate.Enabled = false;
            this.ZoomStopCalculate.Location = new System.Drawing.Point(6, 43);
            this.ZoomStopCalculate.Name = "ZoomStopCalculate";
            this.ZoomStopCalculate.Size = new System.Drawing.Size(75, 23);
            this.ZoomStopCalculate.TabIndex = 21;
            this.ZoomStopCalculate.Text = "Calculate";
            this.ZoomStopCalculate.UseVisualStyleBackColor = true;
            this.ZoomStopCalculate.Click += new System.EventHandler(this.ZoomStopCalculate_Click);
            // 
            // ZoomStopOutputLabel
            // 
            this.ZoomStopOutputLabel.AutoSize = true;
            this.ZoomStopOutputLabel.Location = new System.Drawing.Point(88, 16);
            this.ZoomStopOutputLabel.Name = "ZoomStopOutputLabel";
            this.ZoomStopOutputLabel.Size = new System.Drawing.Size(103, 26);
            this.ZoomStopOutputLabel.TabIndex = 20;
            this.ZoomStopOutputLabel.Text = "Please select one of\nthe above options!";
            // 
            // CalcSED
            // 
            this.CalcSED.AutoSize = true;
            this.CalcSED.Location = new System.Drawing.Point(7, 90);
            this.CalcSED.Name = "CalcSED";
            this.CalcSED.Size = new System.Drawing.Size(185, 17);
            this.CalcSED.TabIndex = 4;
            this.CalcSED.Text = "Calculate Second Event Distance";
            this.CalcSED.UseVisualStyleBackColor = true;
            this.CalcSED.CheckedChanged += new System.EventHandler(this.CalcSED_CheckedChanged);
            // 
            // CalcSET
            // 
            this.CalcSET.AutoSize = true;
            this.CalcSET.Location = new System.Drawing.Point(7, 67);
            this.CalcSET.Name = "CalcSET";
            this.CalcSET.Size = new System.Drawing.Size(166, 17);
            this.CalcSET.TabIndex = 3;
            this.CalcSET.Text = "Calculate Second Event Time";
            this.CalcSET.UseVisualStyleBackColor = true;
            this.CalcSET.CheckedChanged += new System.EventHandler(this.CalcSET_CheckedChanged);
            // 
            // CalcFED
            // 
            this.CalcFED.AutoSize = true;
            this.CalcFED.Location = new System.Drawing.Point(7, 44);
            this.CalcFED.Name = "CalcFED";
            this.CalcFED.Size = new System.Drawing.Size(167, 17);
            this.CalcFED.TabIndex = 2;
            this.CalcFED.Text = "Calculate First Event Distance";
            this.CalcFED.UseVisualStyleBackColor = true;
            this.CalcFED.CheckedChanged += new System.EventHandler(this.CalcFED_CheckedChanged);
            // 
            // CalcFET
            // 
            this.CalcFET.AutoSize = true;
            this.CalcFET.Enabled = false;
            this.CalcFET.Location = new System.Drawing.Point(7, 21);
            this.CalcFET.Name = "CalcFET";
            this.CalcFET.Size = new System.Drawing.Size(256, 17);
            this.CalcFET.TabIndex = 1;
            this.CalcFET.Text = "Calculate First Event Time (Not Implemented Yet)";
            this.CalcFET.UseVisualStyleBackColor = true;
            // 
            // ZoomStopDescription
            // 
            this.ZoomStopDescription.AutoSize = true;
            this.ZoomStopDescription.Location = new System.Drawing.Point(4, 4);
            this.ZoomStopDescription.Name = "ZoomStopDescription";
            this.ZoomStopDescription.Size = new System.Drawing.Size(500, 13);
            this.ZoomStopDescription.TabIndex = 0;
            this.ZoomStopDescription.Text = "This tool can calculate the timing or player distance of the events needed to mak" +
    "e a \"Zoom Stop\" effect.";
            // 
            // InputGroup
            // 
            this.InputGroup.Controls.Add(this.SecondEventDistanceBox);
            this.InputGroup.Controls.Add(this.SecondEventTimeBox);
            this.InputGroup.Controls.Add(this.FirstEventDistanceBox);
            this.InputGroup.Controls.Add(this.FirstEventTimeBox);
            this.InputGroup.Controls.Add(this.StartingDistanceBox);
            this.InputGroup.Controls.Add(this.label6);
            this.InputGroup.Controls.Add(this.label4);
            this.InputGroup.Controls.Add(this.label5);
            this.InputGroup.Controls.Add(this.label2);
            this.InputGroup.Controls.Add(this.label3);
            this.InputGroup.Location = new System.Drawing.Point(7, 122);
            this.InputGroup.Name = "InputGroup";
            this.InputGroup.Size = new System.Drawing.Size(340, 131);
            this.InputGroup.TabIndex = 15;
            this.InputGroup.TabStop = false;
            this.InputGroup.Text = "Input";
            // 
            // SecondEventDistanceBox
            // 
            this.SecondEventDistanceBox.DecimalPlaces = 3;
            this.SecondEventDistanceBox.Enabled = false;
            this.SecondEventDistanceBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SecondEventDistanceBox.Location = new System.Drawing.Point(216, 100);
            this.SecondEventDistanceBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.SecondEventDistanceBox.Name = "SecondEventDistanceBox";
            this.SecondEventDistanceBox.Size = new System.Drawing.Size(80, 20);
            this.SecondEventDistanceBox.TabIndex = 21;
            // 
            // SecondEventTimeBox
            // 
            this.SecondEventTimeBox.DecimalPlaces = 5;
            this.SecondEventTimeBox.Enabled = false;
            this.SecondEventTimeBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SecondEventTimeBox.Location = new System.Drawing.Point(216, 29);
            this.SecondEventTimeBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.SecondEventTimeBox.Name = "SecondEventTimeBox";
            this.SecondEventTimeBox.Size = new System.Drawing.Size(80, 20);
            this.SecondEventTimeBox.TabIndex = 20;
            // 
            // FirstEventDistanceBox
            // 
            this.FirstEventDistanceBox.DecimalPlaces = 3;
            this.FirstEventDistanceBox.Enabled = false;
            this.FirstEventDistanceBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.FirstEventDistanceBox.Location = new System.Drawing.Point(105, 100);
            this.FirstEventDistanceBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.FirstEventDistanceBox.Name = "FirstEventDistanceBox";
            this.FirstEventDistanceBox.Size = new System.Drawing.Size(80, 20);
            this.FirstEventDistanceBox.TabIndex = 19;
            // 
            // FirstEventTimeBox
            // 
            this.FirstEventTimeBox.DecimalPlaces = 5;
            this.FirstEventTimeBox.Enabled = false;
            this.FirstEventTimeBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.FirstEventTimeBox.Location = new System.Drawing.Point(105, 29);
            this.FirstEventTimeBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.FirstEventTimeBox.Name = "FirstEventTimeBox";
            this.FirstEventTimeBox.Size = new System.Drawing.Size(80, 20);
            this.FirstEventTimeBox.TabIndex = 18;
            // 
            // StartingDistanceBox
            // 
            this.StartingDistanceBox.DecimalPlaces = 3;
            this.StartingDistanceBox.Enabled = false;
            this.StartingDistanceBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.StartingDistanceBox.Location = new System.Drawing.Point(10, 62);
            this.StartingDistanceBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.StartingDistanceBox.Name = "StartingDistanceBox";
            this.StartingDistanceBox.Size = new System.Drawing.Size(80, 20);
            this.StartingDistanceBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Second Event Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Event Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Second Event Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Starting Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Event Time";
            // 
            // FindNextZoomZSC
            // 
            this.FindNextZoomZSC.Enabled = false;
            this.FindNextZoomZSC.Location = new System.Drawing.Point(729, 396);
            this.FindNextZoomZSC.Name = "FindNextZoomZSC";
            this.FindNextZoomZSC.Size = new System.Drawing.Size(97, 23);
            this.FindNextZoomZSC.TabIndex = 24;
            this.FindNextZoomZSC.Text = "Find Next Zoom";
            this.FindNextZoomZSC.UseVisualStyleBackColor = true;
            this.FindNextZoomZSC.Click += new System.EventHandler(this.FindNextZoomZSC_Click);
            // 
            // FindPrevZoomZSC
            // 
            this.FindPrevZoomZSC.Enabled = false;
            this.FindPrevZoomZSC.Location = new System.Drawing.Point(624, 396);
            this.FindPrevZoomZSC.Name = "FindPrevZoomZSC";
            this.FindPrevZoomZSC.Size = new System.Drawing.Size(97, 23);
            this.FindPrevZoomZSC.TabIndex = 23;
            this.FindPrevZoomZSC.Text = "Find Prev Zoom";
            this.FindPrevZoomZSC.UseVisualStyleBackColor = true;
            this.FindPrevZoomZSC.Click += new System.EventHandler(this.FindPrevZoomZSC_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ZoomStopTab);
            this.TabControl.Controls.Add(this.EventModifier);
            this.TabControl.Controls.Add(this.MapSplitterTab);
            this.TabControl.Controls.Add(this.HandSwitchTab);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.AboutTab);
            this.TabControl.Location = new System.Drawing.Point(13, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(935, 466);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.EnvSpriteEndPosZ);
            this.tabPage2.Controls.Add(this.EnvSpriteStartPosZ);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.EnvSpriteEndPosY);
            this.tabPage2.Controls.Add(this.EnvSpriteStartPosY);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.CreateEventsESM);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.EventsPerSec);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.EnvSpriteEndTime);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.EnvSpriteStartTime);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.EnvSpriteEndPosX);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.EnvSpriteStartPosX);
            this.tabPage2.Controls.Add(this.EnvSpriteIDLabel);
            this.tabPage2.Controls.Add(this.EnvSpriteID);
            this.tabPage2.Controls.Add(this.CopyConfigPreviewESM);
            this.tabPage2.Controls.Add(this.ModifyConfigPreviewESM);
            this.tabPage2.Controls.Add(this.ConfigPreviewLabelESM);
            this.tabPage2.Controls.Add(this.ConfigPreviewESMRTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 440);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "EnvSprite Movement";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(286, 166);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 13);
            this.label22.TabIndex = 69;
            this.label22.Text = "z";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(286, 113);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 13);
            this.label23.TabIndex = 68;
            this.label23.Text = "z";
            // 
            // EnvSpriteEndPosZ
            // 
            this.EnvSpriteEndPosZ.DecimalPlaces = 5;
            this.EnvSpriteEndPosZ.Location = new System.Drawing.Point(303, 164);
            this.EnvSpriteEndPosZ.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.EnvSpriteEndPosZ.Minimum = new decimal(new int[] {
            86400,
            0,
            0,
            -2147483648});
            this.EnvSpriteEndPosZ.Name = "EnvSpriteEndPosZ";
            this.EnvSpriteEndPosZ.Size = new System.Drawing.Size(98, 20);
            this.EnvSpriteEndPosZ.TabIndex = 67;
            // 
            // EnvSpriteStartPosZ
            // 
            this.EnvSpriteStartPosZ.DecimalPlaces = 5;
            this.EnvSpriteStartPosZ.Location = new System.Drawing.Point(304, 111);
            this.EnvSpriteStartPosZ.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.EnvSpriteStartPosZ.Minimum = new decimal(new int[] {
            86400,
            0,
            0,
            -2147483648});
            this.EnvSpriteStartPosZ.Name = "EnvSpriteStartPosZ";
            this.EnvSpriteStartPosZ.Size = new System.Drawing.Size(98, 20);
            this.EnvSpriteStartPosZ.TabIndex = 66;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(144, 166);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 13);
            this.label20.TabIndex = 65;
            this.label20.Text = "y";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(144, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 13);
            this.label21.TabIndex = 64;
            this.label21.Text = "y";
            // 
            // EnvSpriteEndPosY
            // 
            this.EnvSpriteEndPosY.DecimalPlaces = 5;
            this.EnvSpriteEndPosY.Location = new System.Drawing.Point(161, 164);
            this.EnvSpriteEndPosY.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.EnvSpriteEndPosY.Minimum = new decimal(new int[] {
            86400,
            0,
            0,
            -2147483648});
            this.EnvSpriteEndPosY.Name = "EnvSpriteEndPosY";
            this.EnvSpriteEndPosY.Size = new System.Drawing.Size(98, 20);
            this.EnvSpriteEndPosY.TabIndex = 63;
            // 
            // EnvSpriteStartPosY
            // 
            this.EnvSpriteStartPosY.DecimalPlaces = 5;
            this.EnvSpriteStartPosY.Location = new System.Drawing.Point(162, 111);
            this.EnvSpriteStartPosY.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.EnvSpriteStartPosY.Minimum = new decimal(new int[] {
            86400,
            0,
            0,
            -2147483648});
            this.EnvSpriteStartPosY.Name = "EnvSpriteStartPosY";
            this.EnvSpriteStartPosY.Size = new System.Drawing.Size(98, 20);
            this.EnvSpriteStartPosY.TabIndex = 62;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 13);
            this.label19.TabIndex = 61;
            this.label19.Text = "x";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "x";
            // 
            // CreateEventsESM
            // 
            this.CreateEventsESM.Location = new System.Drawing.Point(205, 333);
            this.CreateEventsESM.Name = "CreateEventsESM";
            this.CreateEventsESM.Size = new System.Drawing.Size(75, 23);
            this.CreateEventsESM.TabIndex = 59;
            this.CreateEventsESM.Text = "Create";
            this.CreateEventsESM.UseVisualStyleBackColor = true;
            this.CreateEventsESM.Click += new System.EventHandler(this.CreateEventsESM_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "Events Per Second";
            // 
            // EventsPerSec
            // 
            this.EventsPerSec.Location = new System.Drawing.Point(10, 336);
            this.EventsPerSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EventsPerSec.Name = "EventsPerSec";
            this.EventsPerSec.Size = new System.Drawing.Size(98, 20);
            this.EventsPerSec.TabIndex = 57;
            this.EventsPerSec.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "EnvSpirte End Time";
            // 
            // EnvSpriteEndTime
            // 
            this.EnvSpriteEndTime.DecimalPlaces = 5;
            this.EnvSpriteEndTime.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EnvSpriteEndTime.Location = new System.Drawing.Point(9, 277);
            this.EnvSpriteEndTime.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.EnvSpriteEndTime.Name = "EnvSpriteEndTime";
            this.EnvSpriteEndTime.Size = new System.Drawing.Size(98, 20);
            this.EnvSpriteEndTime.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "EnvSpirte Start Time";
            // 
            // EnvSpriteStartTime
            // 
            this.EnvSpriteStartTime.DecimalPlaces = 5;
            this.EnvSpriteStartTime.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EnvSpriteStartTime.Location = new System.Drawing.Point(8, 224);
            this.EnvSpriteStartTime.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.EnvSpriteStartTime.Name = "EnvSpriteStartTime";
            this.EnvSpriteStartTime.Size = new System.Drawing.Size(98, 20);
            this.EnvSpriteStartTime.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "EnvSpirte End Position";
            // 
            // EnvSpriteEndPosX
            // 
            this.EnvSpriteEndPosX.DecimalPlaces = 5;
            this.EnvSpriteEndPosX.Location = new System.Drawing.Point(26, 164);
            this.EnvSpriteEndPosX.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.EnvSpriteEndPosX.Minimum = new decimal(new int[] {
            86400,
            0,
            0,
            -2147483648});
            this.EnvSpriteEndPosX.Name = "EnvSpriteEndPosX";
            this.EnvSpriteEndPosX.Size = new System.Drawing.Size(98, 20);
            this.EnvSpriteEndPosX.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "EnvSpirte Start Position";
            // 
            // EnvSpriteStartPosX
            // 
            this.EnvSpriteStartPosX.DecimalPlaces = 5;
            this.EnvSpriteStartPosX.Location = new System.Drawing.Point(27, 111);
            this.EnvSpriteStartPosX.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.EnvSpriteStartPosX.Minimum = new decimal(new int[] {
            86400,
            0,
            0,
            -2147483648});
            this.EnvSpriteStartPosX.Name = "EnvSpriteStartPosX";
            this.EnvSpriteStartPosX.Size = new System.Drawing.Size(98, 20);
            this.EnvSpriteStartPosX.TabIndex = 49;
            // 
            // EnvSpriteIDLabel
            // 
            this.EnvSpriteIDLabel.AutoSize = true;
            this.EnvSpriteIDLabel.Location = new System.Drawing.Point(6, 12);
            this.EnvSpriteIDLabel.Name = "EnvSpriteIDLabel";
            this.EnvSpriteIDLabel.Size = new System.Drawing.Size(67, 13);
            this.EnvSpriteIDLabel.TabIndex = 48;
            this.EnvSpriteIDLabel.Text = "EnvSprite ID";
            // 
            // EnvSpriteID
            // 
            this.EnvSpriteID.Location = new System.Drawing.Point(7, 29);
            this.EnvSpriteID.Name = "EnvSpriteID";
            this.EnvSpriteID.Size = new System.Drawing.Size(100, 20);
            this.EnvSpriteID.TabIndex = 47;
            // 
            // CopyConfigPreviewESM
            // 
            this.CopyConfigPreviewESM.Enabled = false;
            this.CopyConfigPreviewESM.Location = new System.Drawing.Point(841, 410);
            this.CopyConfigPreviewESM.Name = "CopyConfigPreviewESM";
            this.CopyConfigPreviewESM.Size = new System.Drawing.Size(75, 23);
            this.CopyConfigPreviewESM.TabIndex = 46;
            this.CopyConfigPreviewESM.Text = "Copy All";
            this.CopyConfigPreviewESM.UseVisualStyleBackColor = true;
            this.CopyConfigPreviewESM.Click += new System.EventHandler(this.CopyConfigPreviewESM_Click);
            // 
            // ModifyConfigPreviewESM
            // 
            this.ModifyConfigPreviewESM.AutoSize = true;
            this.ModifyConfigPreviewESM.Location = new System.Drawing.Point(842, 12);
            this.ModifyConfigPreviewESM.Name = "ModifyConfigPreviewESM";
            this.ModifyConfigPreviewESM.Size = new System.Drawing.Size(74, 17);
            this.ModifyConfigPreviewESM.TabIndex = 45;
            this.ModifyConfigPreviewESM.Text = "Modifiable";
            this.ModifyConfigPreviewESM.UseVisualStyleBackColor = true;
            this.ModifyConfigPreviewESM.CheckedChanged += new System.EventHandler(this.ModifyConfigPreviewESM_CheckedChanged);
            // 
            // ConfigPreviewLabelESM
            // 
            this.ConfigPreviewLabelESM.AutoSize = true;
            this.ConfigPreviewLabelESM.Location = new System.Drawing.Point(630, 13);
            this.ConfigPreviewLabelESM.Name = "ConfigPreviewLabelESM";
            this.ConfigPreviewLabelESM.Size = new System.Drawing.Size(45, 13);
            this.ConfigPreviewLabelESM.TabIndex = 44;
            this.ConfigPreviewLabelESM.Text = "Preview";
            // 
            // ConfigPreviewESMRTB
            // 
            this.ConfigPreviewESMRTB.DetectUrls = false;
            this.ConfigPreviewESMRTB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigPreviewESMRTB.Location = new System.Drawing.Point(631, 29);
            this.ConfigPreviewESMRTB.Name = "ConfigPreviewESMRTB";
            this.ConfigPreviewESMRTB.ReadOnly = true;
            this.ConfigPreviewESMRTB.Size = new System.Drawing.Size(287, 375);
            this.ConfigPreviewESMRTB.TabIndex = 43;
            this.ConfigPreviewESMRTB.Text = "Choose the settings you want then click \"Create\" when you\'re ready!";
            // 
            // InvertHandButton
            // 
            this.InvertHandButton.Location = new System.Drawing.Point(9, 117);
            this.InvertHandButton.Name = "InvertHandButton";
            this.InvertHandButton.Size = new System.Drawing.Size(202, 23);
            this.InvertHandButton.TabIndex = 43;
            this.InvertHandButton.Text = "Invert All Arcs";
            this.InvertHandButton.UseVisualStyleBackColor = true;
            this.InvertHandButton.Click += new System.EventHandler(this.InvertHandButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Intralism Mapping Assistant";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.HandSwitchTab.ResumeLayout(false);
            this.HandSwitchTab.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.MapSplitterTab.ResumeLayout(false);
            this.SplitterSplitContainer.Panel1.ResumeLayout(false);
            this.SplitterSplitContainer.Panel1.PerformLayout();
            this.SplitterSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitterSplitContainer)).EndInit();
            this.SplitterSplitContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitTimeSelect)).EndInit();
            this.SplitPreviews.Panel1.ResumeLayout(false);
            this.SplitPreviews.Panel1.PerformLayout();
            this.SplitPreviews.Panel2.ResumeLayout(false);
            this.SplitPreviews.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPreviews)).EndInit();
            this.SplitPreviews.ResumeLayout(false);
            this.EventModifier.ResumeLayout(false);
            this.EventModifierPanel.ResumeLayout(false);
            this.EventModifierPanel.PerformLayout();
            this.ZEMContainer.Panel1.ResumeLayout(false);
            this.ZEMContainer.Panel2.ResumeLayout(false);
            this.ZEMContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZEMContainer)).EndInit();
            this.ZEMContainer.ResumeLayout(false);
            this.DestructiveZEMGroup.ResumeLayout(false);
            this.DestructiveZEMGroup.PerformLayout();
            this.ZoomStopTab.ResumeLayout(false);
            this.ZoomPanel.ResumeLayout(false);
            this.ZoomPanel.PerformLayout();
            this.AdvancedOptions.ResumeLayout(false);
            this.AdvancedOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomRangeZSCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomFrameRate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.InputGroup.ResumeLayout(false);
            this.InputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEventDistanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEventTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEventDistanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEventTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingDistanceBox)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteEndPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteStartPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteEndPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteStartPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsPerSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteEndPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteStartPosX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip CustomFRToolTip;
        private System.Windows.Forms.ToolTip CustomRangeToolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LoadedMap;
        private System.Windows.Forms.Button LoadMapButton;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Button SaveFolder;
        private System.Windows.Forms.Button SaveConfig;
        private System.Windows.Forms.ToolTip SaveConfigTT;
        private System.Windows.Forms.Button Overwrite;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label ModifiedTracker;
        private System.Windows.Forms.ToolTip SaveFolderTT;
        private System.Windows.Forms.ToolTip OverwriteTT;
        private System.Windows.Forms.FolderBrowserDialog BrowseForMapFolder;
        private TabPage HandSwitchTab;
        private TabPage AboutTab;
        private LinkLabel linkLabel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private TabPage MapSplitterTab;
        private SplitContainer SplitterSplitContainer;
        private Panel panel2;
        private Button CopyAudioOffsetSplit;
        private TextBox AudioOffsetSplitter;
        private Label AudioSplitBoxLabel;
        private Label PSANoAudioSplit;
        private NumericUpDown SplitTimeSelect;
        private Button SplitAfterEventButton;
        private Button SplitAtTimeButton;
        private Button SplitAtHalfButton;
        private Label SplitterDescription;
        private SplitContainer SplitPreviews;
        private Button FindNextEventSCP1;
        private Button FindPrevEventSCP1;
        private Button CopySCP1;
        private CheckBox ModifyConfigPreviewSCP1;
        private Label label11;
        private RichTextBox SplitConfigPart1;
        private Button FindNextEventSCP2;
        private Button FindPrevEventSCP2;
        private Button CopySCP2;
        private CheckBox ModifyConfigPreviewSCP2;
        private Label label10;
        private RichTextBox SplitConfigPart2;
        private TabPage EventModifier;
        private Panel EventModifierPanel;
        private SplitContainer ZEMContainer;
        private GroupBox DestructiveZEMGroup;
        private Button DeleteAllZoomsButton;
        private CheckBox DestructiveCheckZEM;
        private Button FindNextZoomZEM;
        private Button FindPrevZoomZEM;
        private Button CopyPreviewBox;
        private CheckBox ModifyConfigPreviewZEM;
        private Label ConfigPreviewZEM;
        private RichTextBox ConfigPreviewRTBZEM;
        private Label ZoomModifierDescription;
        private TabPage ZoomStopTab;
        private Panel ZoomPanel;
        private Button CopyPreviewBoxZSC;
        private CheckBox ModifyConfigPreviewZSC;
        private Label label1;
        private RichTextBox ConfigPreviewRTBZSC;
        private GroupBox AdvancedOptions;
        private NumericUpDown CustomRangeZSCalc;
        private CheckBox AdvancedCustomRangeCalc;
        private NumericUpDown CustomFrameRate;
        private CheckBox AdvancedFrameRateCalc;
        private GroupBox groupBox2;
        private Button ResetSelectedZoomZSC;
        private Button ModifySelectedZoomZSC;
        private TextBox OutputBox;
        private Button ZoomStopCalculate;
        private Label ZoomStopOutputLabel;
        private RadioButton CalcSED;
        private RadioButton CalcSET;
        private RadioButton CalcFED;
        private RadioButton CalcFET;
        private Label ZoomStopDescription;
        private GroupBox InputGroup;
        private NumericUpDown SecondEventDistanceBox;
        private NumericUpDown SecondEventTimeBox;
        private NumericUpDown FirstEventDistanceBox;
        private NumericUpDown FirstEventTimeBox;
        private NumericUpDown StartingDistanceBox;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
        private Button FindNextZoomZSC;
        private Button FindPrevZoomZSC;
        private TabControl TabControl;
        private Button HandZeroButton;
        private Button HandTwoButton;
        private Button HandOneButton;
        private Label label12;
        private Button CopyConfigPreviewHS;
        private CheckBox ModifyConfigPreviewHS;
        private Label ConfigPreviewHSLabel;
        private RichTextBox ConfigPreviewRTBHS;
        private TabPage tabPage2;
        private Button CopyConfigPreviewESM;
        private CheckBox ModifyConfigPreviewESM;
        private Label ConfigPreviewLabelESM;
        private RichTextBox ConfigPreviewESMRTB;
        private Label label15;
        private NumericUpDown EnvSpriteEndTime;
        private Label label16;
        private NumericUpDown EnvSpriteStartTime;
        private Label label14;
        private NumericUpDown EnvSpriteEndPosX;
        private Label label13;
        private NumericUpDown EnvSpriteStartPosX;
        private Label EnvSpriteIDLabel;
        private TextBox EnvSpriteID;
        private Button CreateEventsESM;
        private Label label17;
        private NumericUpDown EventsPerSec;
        private Label label22;
        private Label label23;
        private NumericUpDown EnvSpriteEndPosZ;
        private NumericUpDown EnvSpriteStartPosZ;
        private Label label20;
        private Label label21;
        private NumericUpDown EnvSpriteEndPosY;
        private NumericUpDown EnvSpriteStartPosY;
        private Label label19;
        private Label label18;
        private Button InvertHandButton;
    }
}