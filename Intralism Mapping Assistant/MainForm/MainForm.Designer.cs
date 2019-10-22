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
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.AboutTab.SuspendLayout();
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
            this.TabControl.Controls.Add(this.AboutTab);
            this.TabControl.Location = new System.Drawing.Point(13, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(935, 466);
            this.TabControl.TabIndex = 0;
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
            this.label7.Text = "Intralism Mapping Assistant v0.0.4";
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
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
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
        private System.Windows.Forms.TabPage MapSplitterTab;
        private System.Windows.Forms.TabPage EventModifier;
        private System.Windows.Forms.Panel EventModifierPanel;
        private System.Windows.Forms.SplitContainer ZEMContainer;
        private System.Windows.Forms.GroupBox DestructiveZEMGroup;
        private System.Windows.Forms.Button DeleteAllZoomsButton;
        private System.Windows.Forms.CheckBox DestructiveCheckZEM;
        private System.Windows.Forms.Button CopyPreviewBox;
        private System.Windows.Forms.CheckBox ModifyConfigPreviewZEM;
        private System.Windows.Forms.Label ConfigPreviewZEM;
        private System.Windows.Forms.RichTextBox ConfigPreviewRTBZEM;
        private System.Windows.Forms.Label ZoomModifierDescription;
        private System.Windows.Forms.TabPage ZoomStopTab;
        private System.Windows.Forms.Panel ZoomPanel;
        private System.Windows.Forms.GroupBox AdvancedOptions;
        private System.Windows.Forms.NumericUpDown CustomRangeZSCalc;
        private System.Windows.Forms.CheckBox AdvancedCustomRangeCalc;
        private System.Windows.Forms.NumericUpDown CustomFrameRate;
        private System.Windows.Forms.CheckBox AdvancedFrameRateCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button ZoomStopCalculate;
        private System.Windows.Forms.Label ZoomStopOutputLabel;
        private System.Windows.Forms.RadioButton CalcSED;
        private System.Windows.Forms.RadioButton CalcSET;
        private System.Windows.Forms.RadioButton CalcFED;
        private System.Windows.Forms.RadioButton CalcFET;
        private System.Windows.Forms.Label ZoomStopDescription;
        private System.Windows.Forms.GroupBox InputGroup;
        private System.Windows.Forms.NumericUpDown SecondEventDistanceBox;
        private System.Windows.Forms.NumericUpDown SecondEventTimeBox;
        private System.Windows.Forms.NumericUpDown FirstEventDistanceBox;
        private System.Windows.Forms.NumericUpDown FirstEventTimeBox;
        private System.Windows.Forms.NumericUpDown StartingDistanceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CopyPreviewBoxZSC;
        private System.Windows.Forms.CheckBox ModifyConfigPreviewZSC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ConfigPreviewRTBZSC;
        private System.Windows.Forms.Button FindNextZoomZSC;
        private System.Windows.Forms.Button FindPrevZoomZSC;
        private Button FindNextZoomZEM;
        private Button FindPrevZoomZEM;
        private Button ModifySelectedZoomZSC;
        private Button ResetSelectedZoomZSC;
        private SplitContainer SplitterSplitContainer;
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
        private Button SplitAtTimeButton;
        private Button SplitAtHalfButton;
        private Button SplitAfterEventButton;
        private Panel panel2;
        private NumericUpDown SplitTimeSelect;
        private Label SplitterDescription;
        private Button CopyAudioOffsetSplit;
        private TextBox AudioOffsetSplitter;
        private Label AudioSplitBoxLabel;
        private Label PSANoAudioSplit;
    }
}