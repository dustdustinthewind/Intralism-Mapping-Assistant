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
            this.InvertHandButton = new System.Windows.Forms.Button();
            this.HandZeroButton = new System.Windows.Forms.Button();
            this.HandTwoButton = new System.Windows.Forms.Button();
            this.HandOneButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CopyConfigPreviewHS = new System.Windows.Forms.Button();
            this.ModifyConfigPreviewHS = new System.Windows.Forms.CheckBox();
            this.ConfigPreviewHSLabel = new System.Windows.Forms.Label();
            this.ConfigPreviewRTBHS = new System.Windows.Forms.RichTextBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label40 = new System.Windows.Forms.Label();
            this.CreateButtonESA = new System.Windows.Forms.Button();
            this.FramesPerSecondCBESA = new System.Windows.Forms.CheckBox();
            this.FramesPerSecondNUDESA = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.FrameTimeCBESA = new System.Windows.Forms.CheckBox();
            this.TimePerFrameNUDESA = new System.Windows.Forms.NumericUpDown();
            this.LoopAmountCBESA = new System.Windows.Forms.CheckBox();
            this.LoopAmountNUDESA = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.EndTimeCBESA = new System.Windows.Forms.CheckBox();
            this.EndTimeNUDESA = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.StartTimeNUDESA = new System.Windows.Forms.NumericUpDown();
            this.FramesESARTB = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.SpriteIDESATB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.PreviewRTBESA = new System.Windows.Forms.RichTextBox();
            this.EOCTab = new System.Windows.Forms.TabPage();
            this.EnvSpriteRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Speed = new System.Windows.Forms.Label();
            this.EnvSpriteSpeedNUD = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label41 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.EnvSpriteColorTB = new System.Windows.Forms.TextBox();
            this.MirrorZCB = new System.Windows.Forms.CheckBox();
            this.MirrorYCB = new System.Windows.Forms.CheckBox();
            this.MirrorXCB = new System.Windows.Forms.CheckBox();
            this.CreateNewObjectsCB = new System.Windows.Forms.CheckBox();
            this.MakeMultipleCopiesCB = new System.Windows.Forms.CheckBox();
            this.MakeMultipleCopiesNUD = new System.Windows.Forms.NumericUpDown();
            this.CreateEnvObjButton = new System.Windows.Forms.Button();
            this.ParentIDCB = new System.Windows.Forms.CheckBox();
            this.ParentIDTB = new System.Windows.Forms.TextBox();
            this.RemoveTimeCB = new System.Windows.Forms.CheckBox();
            this.SpawnTimeCB = new System.Windows.Forms.Label();
            this.RemoveTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.SpawnTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.ScaleZNUD = new System.Windows.Forms.NumericUpDown();
            this.RotationZNUD = new System.Windows.Forms.NumericUpDown();
            this.PositionZNUD = new System.Windows.Forms.NumericUpDown();
            this.ScaleYNUD = new System.Windows.Forms.NumericUpDown();
            this.ParticleEmitterGroupBox = new System.Windows.Forms.GroupBox();
            this.ParticleEmitterTypeCB = new System.Windows.Forms.CheckBox();
            this.ParticleEmitterPPBNUD = new System.Windows.Forms.NumericUpDown();
            this.ParticleEmitterColorCB = new System.Windows.Forms.CheckBox();
            this.ParticleEmitterSizeCB = new System.Windows.Forms.CheckBox();
            this.ParticleEmitterInputNUD = new System.Windows.Forms.NumericUpDown();
            this.ParticleEmitterPPBCB = new System.Windows.Forms.CheckBox();
            this.ParticleEmitterEmissionCB = new System.Windows.Forms.CheckBox();
            this.ParticleEmitterSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.ParticleEmitterSpeedCB = new System.Windows.Forms.CheckBox();
            this.ParticleEmitterEmissionNUD = new System.Windows.Forms.NumericUpDown();
            this.ColorPickParticleEmitter = new System.Windows.Forms.Button();
            this.ParticleEmitterGravityNUD = new System.Windows.Forms.NumericUpDown();
            this.ParticleEmitterSpeedNUD = new System.Windows.Forms.NumericUpDown();
            this.ParticleEmitterColorTB = new System.Windows.Forms.TextBox();
            this.ParticleEmitterGravityCB = new System.Windows.Forms.CheckBox();
            this.RotationYNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteGroupBox = new System.Windows.Forms.GroupBox();
            this.SatelliteMinimumVertexDistanceNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteTrailWidthNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteMinimumVertexCB = new System.Windows.Forms.CheckBox();
            this.SatellieTrailWidthCB = new System.Windows.Forms.CheckBox();
            this.SatelliteTrailFadeTimeCB = new System.Windows.Forms.CheckBox();
            this.SatelliteTrailTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteRotationSpeedNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteRadiusCB = new System.Windows.Forms.CheckBox();
            this.SatelliteRotationCB = new System.Windows.Forms.CheckBox();
            this.SatelliteRadiusNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteSensitivityCB = new System.Windows.Forms.CheckBox();
            this.ColorPickSatellite = new System.Windows.Forms.Button();
            this.SatelliteSensitivityNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteColorCB = new System.Windows.Forms.CheckBox();
            this.SatelliteLerpSpeedCB = new System.Windows.Forms.CheckBox();
            this.SatelliteColorTB = new System.Windows.Forms.TextBox();
            this.SatelliteLerpSpeedNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteEmissionNUD = new System.Windows.Forms.NumericUpDown();
            this.SatelliteTypeCB = new System.Windows.Forms.CheckBox();
            this.SatelliteEmissionCB = new System.Windows.Forms.CheckBox();
            this.SatelliteInputNUD = new System.Windows.Forms.NumericUpDown();
            this.PositionYNUD = new System.Windows.Forms.NumericUpDown();
            this.SunGroupBox = new System.Windows.Forms.GroupBox();
            this.SunDirectionVectorCB = new System.Windows.Forms.CheckBox();
            this.DirectionVectorZNUD = new System.Windows.Forms.NumericUpDown();
            this.DirectionVectorYNUD = new System.Windows.Forms.NumericUpDown();
            this.DirectionVectorXNUD = new System.Windows.Forms.NumericUpDown();
            this.SunMaxSizeCB = new System.Windows.Forms.CheckBox();
            this.SunMaxSizeZNUD = new System.Windows.Forms.NumericUpDown();
            this.SunMaxSizeYNUD = new System.Windows.Forms.NumericUpDown();
            this.SunMaxSizeXNUD = new System.Windows.Forms.NumericUpDown();
            this.SunMinSizeCB = new System.Windows.Forms.CheckBox();
            this.SunMinSizeZNUD = new System.Windows.Forms.NumericUpDown();
            this.SunSensivityCB = new System.Windows.Forms.CheckBox();
            this.SunMinSizeYNUD = new System.Windows.Forms.NumericUpDown();
            this.SunSensitivityNUD = new System.Windows.Forms.NumericUpDown();
            this.SunMinSizeXNUD = new System.Windows.Forms.NumericUpDown();
            this.SunLerpSpeedCB = new System.Windows.Forms.CheckBox();
            this.SunLerpNUD = new System.Windows.Forms.NumericUpDown();
            this.SunInputCB = new System.Windows.Forms.CheckBox();
            this.SunInputNUD = new System.Windows.Forms.NumericUpDown();
            this.SunEmissionCB = new System.Windows.Forms.CheckBox();
            this.SunEmissionNUD = new System.Windows.Forms.NumericUpDown();
            this.ColorPickSunNoLives = new System.Windows.Forms.Button();
            this.NoLivesColorCB = new System.Windows.Forms.CheckBox();
            this.NoLivesColorTB = new System.Windows.Forms.TextBox();
            this.ColorPickSunMaxLives = new System.Windows.Forms.Button();
            this.MaxLivesCB = new System.Windows.Forms.CheckBox();
            this.MaxLivesColorTB = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.ScaleCB = new System.Windows.Forms.CheckBox();
            this.ScaleXNUD = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.RotationCB = new System.Windows.Forms.CheckBox();
            this.RotationXNUD = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.PositionCB = new System.Windows.Forms.CheckBox();
            this.PositionXNUD = new System.Windows.Forms.NumericUpDown();
            this.ParticleEmitterRB = new System.Windows.Forms.RadioButton();
            this.SatelliteRB = new System.Windows.Forms.RadioButton();
            this.SunRB = new System.Windows.Forms.RadioButton();
            this.label25 = new System.Windows.Forms.Label();
            this.EnvObjTB = new System.Windows.Forms.TextBox();
            this.CopyEOC = new System.Windows.Forms.Button();
            this.ModifyEOC = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.ConfigPreviewEOC = new System.Windows.Forms.RichTextBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
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
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FramesPerSecondNUDESA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePerFrameNUDESA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoopAmountNUDESA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeNUDESA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeNUDESA)).BeginInit();
            this.EOCTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteSpeedNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakeMultipleCopiesNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveTimeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnTimeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleYNUD)).BeginInit();
            this.ParticleEmitterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterPPBNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterInputNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterSizeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterEmissionNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterGravityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterSpeedNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationYNUD)).BeginInit();
            this.SatelliteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteMinimumVertexDistanceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteTrailWidthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteTrailTimeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteRotationSpeedNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteRadiusNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteSensitivityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteLerpSpeedNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteEmissionNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteInputNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionYNUD)).BeginInit();
            this.SunGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionVectorZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionVectorYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionVectorXNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMaxSizeZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMaxSizeYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMaxSizeXNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMinSizeZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMinSizeYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunSensitivityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMinSizeXNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunLerpNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunInputNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunEmissionNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleXNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationXNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionXNUD)).BeginInit();
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
            this.AboutTab.Controls.Add(this.linkLabel2);
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
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(51, 102);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(87, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Buy me a coffee!";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
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
            this.label8.Text = "Copyright (c) 2020 Nathaniel Beasley";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Intralism Mapping Assistant v0.8.2";
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
            this.DestructiveZEMGroup.Controls.Add(this.button1);
            this.DestructiveZEMGroup.Controls.Add(this.DeleteAllZoomsButton);
            this.DestructiveZEMGroup.Controls.Add(this.DestructiveCheckZEM);
            this.DestructiveZEMGroup.Location = new System.Drawing.Point(3, 307);
            this.DestructiveZEMGroup.Name = "DestructiveZEMGroup";
            this.DestructiveZEMGroup.Size = new System.Drawing.Size(602, 85);
            this.DestructiveZEMGroup.TabIndex = 0;
            this.DestructiveZEMGroup.TabStop = false;
            this.DestructiveZEMGroup.Text = "Destructive Options";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(155, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove All Non-Zoom Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.EOCTab);
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.CreateButtonESA);
            this.tabPage1.Controls.Add(this.FramesPerSecondCBESA);
            this.tabPage1.Controls.Add(this.FramesPerSecondNUDESA);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.FrameTimeCBESA);
            this.tabPage1.Controls.Add(this.TimePerFrameNUDESA);
            this.tabPage1.Controls.Add(this.LoopAmountCBESA);
            this.tabPage1.Controls.Add(this.LoopAmountNUDESA);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.EndTimeCBESA);
            this.tabPage1.Controls.Add(this.EndTimeNUDESA);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.StartTimeNUDESA);
            this.tabPage1.Controls.Add(this.FramesESARTB);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.SpriteIDESATB);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.PreviewRTBESA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 440);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "EnvSprite Animator";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(7, 59);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(90, 13);
            this.label40.TabIndex = 102;
            this.label40.Text = "Image Resources";
            // 
            // CreateButtonESA
            // 
            this.CreateButtonESA.Location = new System.Drawing.Point(291, 408);
            this.CreateButtonESA.Name = "CreateButtonESA";
            this.CreateButtonESA.Size = new System.Drawing.Size(75, 23);
            this.CreateButtonESA.TabIndex = 101;
            this.CreateButtonESA.Text = "Create";
            this.CreateButtonESA.UseVisualStyleBackColor = true;
            this.CreateButtonESA.Click += new System.EventHandler(this.CreateButtonESA_Click);
            // 
            // FramesPerSecondCBESA
            // 
            this.FramesPerSecondCBESA.AutoSize = true;
            this.FramesPerSecondCBESA.Location = new System.Drawing.Point(425, 68);
            this.FramesPerSecondCBESA.Name = "FramesPerSecondCBESA";
            this.FramesPerSecondCBESA.Size = new System.Drawing.Size(119, 17);
            this.FramesPerSecondCBESA.TabIndex = 100;
            this.FramesPerSecondCBESA.Text = "Frames Per Second";
            this.FramesPerSecondCBESA.UseVisualStyleBackColor = true;
            this.FramesPerSecondCBESA.CheckedChanged += new System.EventHandler(this.FramesPerSecondCBESA_CheckedChanged);
            // 
            // FramesPerSecondNUDESA
            // 
            this.FramesPerSecondNUDESA.DecimalPlaces = 3;
            this.FramesPerSecondNUDESA.Location = new System.Drawing.Point(425, 89);
            this.FramesPerSecondNUDESA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FramesPerSecondNUDESA.Name = "FramesPerSecondNUDESA";
            this.FramesPerSecondNUDESA.Size = new System.Drawing.Size(80, 20);
            this.FramesPerSecondNUDESA.TabIndex = 99;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(386, 88);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(23, 13);
            this.label39.TabIndex = 98;
            this.label39.Text = "OR";
            // 
            // FrameTimeCBESA
            // 
            this.FrameTimeCBESA.AutoSize = true;
            this.FrameTimeCBESA.Location = new System.Drawing.Point(291, 68);
            this.FrameTimeCBESA.Name = "FrameTimeCBESA";
            this.FrameTimeCBESA.Size = new System.Drawing.Size(100, 17);
            this.FrameTimeCBESA.TabIndex = 97;
            this.FrameTimeCBESA.Text = "Time Per Frame";
            this.FrameTimeCBESA.UseVisualStyleBackColor = true;
            this.FrameTimeCBESA.CheckedChanged += new System.EventHandler(this.FrameTimeCBESA_CheckedChanged);
            // 
            // TimePerFrameNUDESA
            // 
            this.TimePerFrameNUDESA.DecimalPlaces = 3;
            this.TimePerFrameNUDESA.Location = new System.Drawing.Point(291, 89);
            this.TimePerFrameNUDESA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TimePerFrameNUDESA.Name = "TimePerFrameNUDESA";
            this.TimePerFrameNUDESA.Size = new System.Drawing.Size(80, 20);
            this.TimePerFrameNUDESA.TabIndex = 96;
            // 
            // LoopAmountCBESA
            // 
            this.LoopAmountCBESA.AutoSize = true;
            this.LoopAmountCBESA.Location = new System.Drawing.Point(425, 7);
            this.LoopAmountCBESA.Name = "LoopAmountCBESA";
            this.LoopAmountCBESA.Size = new System.Drawing.Size(91, 17);
            this.LoopAmountCBESA.TabIndex = 95;
            this.LoopAmountCBESA.Text = "Loop X Times";
            this.LoopAmountCBESA.UseVisualStyleBackColor = true;
            this.LoopAmountCBESA.CheckedChanged += new System.EventHandler(this.LoopAmountCBESA_CheckedChanged);
            // 
            // LoopAmountNUDESA
            // 
            this.LoopAmountNUDESA.Location = new System.Drawing.Point(425, 28);
            this.LoopAmountNUDESA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LoopAmountNUDESA.Name = "LoopAmountNUDESA";
            this.LoopAmountNUDESA.Size = new System.Drawing.Size(80, 20);
            this.LoopAmountNUDESA.TabIndex = 94;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(386, 27);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(23, 13);
            this.label38.TabIndex = 93;
            this.label38.Text = "OR";
            // 
            // EndTimeCBESA
            // 
            this.EndTimeCBESA.AutoSize = true;
            this.EndTimeCBESA.Location = new System.Drawing.Point(291, 7);
            this.EndTimeCBESA.Name = "EndTimeCBESA";
            this.EndTimeCBESA.Size = new System.Drawing.Size(71, 17);
            this.EndTimeCBESA.TabIndex = 92;
            this.EndTimeCBESA.Text = "End Time";
            this.EndTimeCBESA.UseVisualStyleBackColor = true;
            this.EndTimeCBESA.CheckedChanged += new System.EventHandler(this.EndTimeCBESA_CheckedChanged);
            // 
            // EndTimeNUDESA
            // 
            this.EndTimeNUDESA.DecimalPlaces = 5;
            this.EndTimeNUDESA.Location = new System.Drawing.Point(291, 28);
            this.EndTimeNUDESA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.EndTimeNUDESA.Name = "EndTimeNUDESA";
            this.EndTimeNUDESA.Size = new System.Drawing.Size(80, 20);
            this.EndTimeNUDESA.TabIndex = 90;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(111, 10);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 13);
            this.label37.TabIndex = 89;
            this.label37.Text = "Start Time";
            // 
            // StartTimeNUDESA
            // 
            this.StartTimeNUDESA.DecimalPlaces = 5;
            this.StartTimeNUDESA.Location = new System.Drawing.Point(114, 27);
            this.StartTimeNUDESA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.StartTimeNUDESA.Name = "StartTimeNUDESA";
            this.StartTimeNUDESA.Size = new System.Drawing.Size(80, 20);
            this.StartTimeNUDESA.TabIndex = 88;
            // 
            // FramesESARTB
            // 
            this.FramesESARTB.DetectUrls = false;
            this.FramesESARTB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FramesESARTB.Location = new System.Drawing.Point(10, 75);
            this.FramesESARTB.Name = "FramesESARTB";
            this.FramesESARTB.Size = new System.Drawing.Size(263, 356);
            this.FramesESARTB.TabIndex = 55;
            this.FramesESARTB.Text = "Type each image resource\'s name here, separate with commas \",\" (i.e. \"Frame1,Fram" +
    "e2,Frame3\")";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 54;
            this.label26.Text = "EnvSprite ID";
            // 
            // SpriteIDESATB
            // 
            this.SpriteIDESATB.Location = new System.Drawing.Point(8, 27);
            this.SpriteIDESATB.Name = "SpriteIDESATB";
            this.SpriteIDESATB.Size = new System.Drawing.Size(100, 20);
            this.SpriteIDESATB.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(842, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "Copy All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(843, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "Modifiable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(631, 11);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(45, 13);
            this.label33.TabIndex = 50;
            this.label33.Text = "Preview";
            // 
            // PreviewRTBESA
            // 
            this.PreviewRTBESA.DetectUrls = false;
            this.PreviewRTBESA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewRTBESA.Location = new System.Drawing.Point(632, 27);
            this.PreviewRTBESA.Name = "PreviewRTBESA";
            this.PreviewRTBESA.ReadOnly = true;
            this.PreviewRTBESA.Size = new System.Drawing.Size(287, 375);
            this.PreviewRTBESA.TabIndex = 49;
            this.PreviewRTBESA.Text = "Choose the settings you want then click \"Create\" when you\'re ready!";
            // 
            // EOCTab
            // 
            this.EOCTab.BackColor = System.Drawing.SystemColors.Control;
            this.EOCTab.Controls.Add(this.EnvSpriteRB);
            this.EOCTab.Controls.Add(this.groupBox1);
            this.EOCTab.Controls.Add(this.MirrorZCB);
            this.EOCTab.Controls.Add(this.MirrorYCB);
            this.EOCTab.Controls.Add(this.MirrorXCB);
            this.EOCTab.Controls.Add(this.CreateNewObjectsCB);
            this.EOCTab.Controls.Add(this.MakeMultipleCopiesCB);
            this.EOCTab.Controls.Add(this.MakeMultipleCopiesNUD);
            this.EOCTab.Controls.Add(this.CreateEnvObjButton);
            this.EOCTab.Controls.Add(this.ParentIDCB);
            this.EOCTab.Controls.Add(this.ParentIDTB);
            this.EOCTab.Controls.Add(this.RemoveTimeCB);
            this.EOCTab.Controls.Add(this.SpawnTimeCB);
            this.EOCTab.Controls.Add(this.RemoveTimeNUD);
            this.EOCTab.Controls.Add(this.SpawnTimeNUD);
            this.EOCTab.Controls.Add(this.ScaleZNUD);
            this.EOCTab.Controls.Add(this.RotationZNUD);
            this.EOCTab.Controls.Add(this.PositionZNUD);
            this.EOCTab.Controls.Add(this.ScaleYNUD);
            this.EOCTab.Controls.Add(this.ParticleEmitterGroupBox);
            this.EOCTab.Controls.Add(this.RotationYNUD);
            this.EOCTab.Controls.Add(this.SatelliteGroupBox);
            this.EOCTab.Controls.Add(this.PositionYNUD);
            this.EOCTab.Controls.Add(this.SunGroupBox);
            this.EOCTab.Controls.Add(this.label34);
            this.EOCTab.Controls.Add(this.label35);
            this.EOCTab.Controls.Add(this.label36);
            this.EOCTab.Controls.Add(this.ScaleCB);
            this.EOCTab.Controls.Add(this.ScaleXNUD);
            this.EOCTab.Controls.Add(this.label30);
            this.EOCTab.Controls.Add(this.label31);
            this.EOCTab.Controls.Add(this.label32);
            this.EOCTab.Controls.Add(this.RotationCB);
            this.EOCTab.Controls.Add(this.RotationXNUD);
            this.EOCTab.Controls.Add(this.label29);
            this.EOCTab.Controls.Add(this.label28);
            this.EOCTab.Controls.Add(this.label27);
            this.EOCTab.Controls.Add(this.PositionCB);
            this.EOCTab.Controls.Add(this.PositionXNUD);
            this.EOCTab.Controls.Add(this.ParticleEmitterRB);
            this.EOCTab.Controls.Add(this.SatelliteRB);
            this.EOCTab.Controls.Add(this.SunRB);
            this.EOCTab.Controls.Add(this.label25);
            this.EOCTab.Controls.Add(this.EnvObjTB);
            this.EOCTab.Controls.Add(this.CopyEOC);
            this.EOCTab.Controls.Add(this.ModifyEOC);
            this.EOCTab.Controls.Add(this.label24);
            this.EOCTab.Controls.Add(this.ConfigPreviewEOC);
            this.EOCTab.Location = new System.Drawing.Point(4, 22);
            this.EOCTab.Name = "EOCTab";
            this.EOCTab.Padding = new System.Windows.Forms.Padding(3);
            this.EOCTab.Size = new System.Drawing.Size(927, 440);
            this.EOCTab.TabIndex = 7;
            this.EOCTab.Text = "Env Object Creator";
            // 
            // EnvSpriteRB
            // 
            this.EnvSpriteRB.AutoSize = true;
            this.EnvSpriteRB.Location = new System.Drawing.Point(463, 52);
            this.EnvSpriteRB.Name = "EnvSpriteRB";
            this.EnvSpriteRB.Size = new System.Drawing.Size(111, 17);
            this.EnvSpriteRB.TabIndex = 99;
            this.EnvSpriteRB.TabStop = true;
            this.EnvSpriteRB.Text = "environment sprite";
            this.EnvSpriteRB.UseVisualStyleBackColor = true;
            this.EnvSpriteRB.CheckedChanged += new System.EventHandler(this.EnvSpriteRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Speed);
            this.groupBox1.Controls.Add(this.EnvSpriteSpeedNUD);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.EnvSpriteColorTB);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(424, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 97);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Environment Sprite Color Options";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(7, 76);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(38, 13);
            this.Speed.TabIndex = 152;
            this.Speed.Text = "Speed";
            // 
            // EnvSpriteSpeedNUD
            // 
            this.EnvSpriteSpeedNUD.DecimalPlaces = 3;
            this.EnvSpriteSpeedNUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.EnvSpriteSpeedNUD.Location = new System.Drawing.Point(59, 74);
            this.EnvSpriteSpeedNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.EnvSpriteSpeedNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.EnvSpriteSpeedNUD.Name = "EnvSpriteSpeedNUD";
            this.EnvSpriteSpeedNUD.Size = new System.Drawing.Size(79, 20);
            this.EnvSpriteSpeedNUD.TabIndex = 112;
            this.EnvSpriteSpeedNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 15;
            this.trackBar1.Location = new System.Drawing.Point(52, 42);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(142, 32);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 151;
            this.trackBar1.Value = 255;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 51);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 13);
            this.label41.TabIndex = 150;
            this.label41.Text = "Opacity";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 149;
            this.button3.Text = "Pick Color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EnvSpriteColorTB
            // 
            this.EnvSpriteColorTB.Location = new System.Drawing.Point(6, 19);
            this.EnvSpriteColorTB.Name = "EnvSpriteColorTB";
            this.EnvSpriteColorTB.Size = new System.Drawing.Size(100, 20);
            this.EnvSpriteColorTB.TabIndex = 148;
            this.EnvSpriteColorTB.Text = "#FFFFFFFF";
            // 
            // MirrorZCB
            // 
            this.MirrorZCB.AutoSize = true;
            this.MirrorZCB.Enabled = false;
            this.MirrorZCB.Location = new System.Drawing.Point(338, 115);
            this.MirrorZCB.Name = "MirrorZCB";
            this.MirrorZCB.Size = new System.Drawing.Size(98, 17);
            this.MirrorZCB.TabIndex = 97;
            this.MirrorZCB.Text = "Mirror on Z-axis";
            // 
            // MirrorYCB
            // 
            this.MirrorYCB.AutoSize = true;
            this.MirrorYCB.Enabled = false;
            this.MirrorYCB.Location = new System.Drawing.Point(338, 89);
            this.MirrorYCB.Name = "MirrorYCB";
            this.MirrorYCB.Size = new System.Drawing.Size(98, 17);
            this.MirrorYCB.TabIndex = 96;
            this.MirrorYCB.Text = "Mirror on Y-axis";
            // 
            // MirrorXCB
            // 
            this.MirrorXCB.AutoSize = true;
            this.MirrorXCB.Enabled = false;
            this.MirrorXCB.Location = new System.Drawing.Point(338, 63);
            this.MirrorXCB.Name = "MirrorXCB";
            this.MirrorXCB.Size = new System.Drawing.Size(98, 17);
            this.MirrorXCB.TabIndex = 95;
            this.MirrorXCB.Text = "Mirror on X-axis";
            // 
            // CreateNewObjectsCB
            // 
            this.CreateNewObjectsCB.AutoSize = true;
            this.CreateNewObjectsCB.Checked = true;
            this.CreateNewObjectsCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateNewObjectsCB.Location = new System.Drawing.Point(464, 72);
            this.CreateNewObjectsCB.Name = "CreateNewObjectsCB";
            this.CreateNewObjectsCB.Size = new System.Drawing.Size(127, 17);
            this.CreateNewObjectsCB.TabIndex = 94;
            this.CreateNewObjectsCB.Text = "Create New Object(s)";
            // 
            // MakeMultipleCopiesCB
            // 
            this.MakeMultipleCopiesCB.AutoSize = true;
            this.MakeMultipleCopiesCB.Location = new System.Drawing.Point(464, 95);
            this.MakeMultipleCopiesCB.Name = "MakeMultipleCopiesCB";
            this.MakeMultipleCopiesCB.Size = new System.Drawing.Size(98, 17);
            this.MakeMultipleCopiesCB.TabIndex = 93;
            this.MakeMultipleCopiesCB.Text = "Make X Copies";
            this.MakeMultipleCopiesCB.CheckedChanged += new System.EventHandler(this.MakeMultipleCopiesCB_CheckedChanged);
            // 
            // MakeMultipleCopiesNUD
            // 
            this.MakeMultipleCopiesNUD.Enabled = false;
            this.MakeMultipleCopiesNUD.Location = new System.Drawing.Point(464, 113);
            this.MakeMultipleCopiesNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MakeMultipleCopiesNUD.Name = "MakeMultipleCopiesNUD";
            this.MakeMultipleCopiesNUD.Size = new System.Drawing.Size(80, 20);
            this.MakeMultipleCopiesNUD.TabIndex = 92;
            this.MakeMultipleCopiesNUD.ValueChanged += new System.EventHandler(this.MakeMultipleCopiesNUD_ValueChanged);
            // 
            // CreateEnvObjButton
            // 
            this.CreateEnvObjButton.Location = new System.Drawing.Point(550, 111);
            this.CreateEnvObjButton.Name = "CreateEnvObjButton";
            this.CreateEnvObjButton.Size = new System.Drawing.Size(75, 23);
            this.CreateEnvObjButton.TabIndex = 91;
            this.CreateEnvObjButton.Text = "Create";
            this.CreateEnvObjButton.UseVisualStyleBackColor = true;
            this.CreateEnvObjButton.Click += new System.EventHandler(this.CreateEnvObjButton_Click);
            // 
            // ParentIDCB
            // 
            this.ParentIDCB.AutoSize = true;
            this.ParentIDCB.Location = new System.Drawing.Point(135, 7);
            this.ParentIDCB.Name = "ParentIDCB";
            this.ParentIDCB.Size = new System.Drawing.Size(71, 17);
            this.ParentIDCB.TabIndex = 90;
            this.ParentIDCB.Text = "Parent ID";
            this.ParentIDCB.CheckedChanged += new System.EventHandler(this.ParentIDCB_CheckedChanged);
            // 
            // ParentIDTB
            // 
            this.ParentIDTB.Enabled = false;
            this.ParentIDTB.Location = new System.Drawing.Point(135, 25);
            this.ParentIDTB.Name = "ParentIDTB";
            this.ParentIDTB.Size = new System.Drawing.Size(100, 20);
            this.ParentIDTB.TabIndex = 89;
            // 
            // RemoveTimeCB
            // 
            this.RemoveTimeCB.AutoSize = true;
            this.RemoveTimeCB.Location = new System.Drawing.Point(369, 8);
            this.RemoveTimeCB.Name = "RemoveTimeCB";
            this.RemoveTimeCB.Size = new System.Drawing.Size(92, 17);
            this.RemoveTimeCB.TabIndex = 88;
            this.RemoveTimeCB.Text = "Remove Time";
            this.RemoveTimeCB.CheckedChanged += new System.EventHandler(this.RemoveTimeCB_CheckedChanged);
            // 
            // SpawnTimeCB
            // 
            this.SpawnTimeCB.AutoSize = true;
            this.SpawnTimeCB.Location = new System.Drawing.Point(269, 9);
            this.SpawnTimeCB.Name = "SpawnTimeCB";
            this.SpawnTimeCB.Size = new System.Drawing.Size(61, 13);
            this.SpawnTimeCB.TabIndex = 87;
            this.SpawnTimeCB.Text = "Event Time";
            // 
            // RemoveTimeNUD
            // 
            this.RemoveTimeNUD.DecimalPlaces = 5;
            this.RemoveTimeNUD.Enabled = false;
            this.RemoveTimeNUD.Location = new System.Drawing.Point(369, 26);
            this.RemoveTimeNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.RemoveTimeNUD.Name = "RemoveTimeNUD";
            this.RemoveTimeNUD.Size = new System.Drawing.Size(80, 20);
            this.RemoveTimeNUD.TabIndex = 86;
            // 
            // SpawnTimeNUD
            // 
            this.SpawnTimeNUD.DecimalPlaces = 5;
            this.SpawnTimeNUD.Location = new System.Drawing.Point(272, 26);
            this.SpawnTimeNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SpawnTimeNUD.Name = "SpawnTimeNUD";
            this.SpawnTimeNUD.Size = new System.Drawing.Size(80, 20);
            this.SpawnTimeNUD.TabIndex = 85;
            // 
            // ScaleZNUD
            // 
            this.ScaleZNUD.DecimalPlaces = 2;
            this.ScaleZNUD.Enabled = false;
            this.ScaleZNUD.Location = new System.Drawing.Point(274, 114);
            this.ScaleZNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ScaleZNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ScaleZNUD.Name = "ScaleZNUD";
            this.ScaleZNUD.Size = new System.Drawing.Size(58, 20);
            this.ScaleZNUD.TabIndex = 84;
            // 
            // RotationZNUD
            // 
            this.RotationZNUD.DecimalPlaces = 2;
            this.RotationZNUD.Enabled = false;
            this.RotationZNUD.Location = new System.Drawing.Point(274, 88);
            this.RotationZNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.RotationZNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.RotationZNUD.Name = "RotationZNUD";
            this.RotationZNUD.Size = new System.Drawing.Size(58, 20);
            this.RotationZNUD.TabIndex = 83;
            // 
            // PositionZNUD
            // 
            this.PositionZNUD.DecimalPlaces = 2;
            this.PositionZNUD.Enabled = false;
            this.PositionZNUD.Location = new System.Drawing.Point(274, 62);
            this.PositionZNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PositionZNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.PositionZNUD.Name = "PositionZNUD";
            this.PositionZNUD.Size = new System.Drawing.Size(58, 20);
            this.PositionZNUD.TabIndex = 82;
            // 
            // ScaleYNUD
            // 
            this.ScaleYNUD.DecimalPlaces = 2;
            this.ScaleYNUD.Enabled = false;
            this.ScaleYNUD.Location = new System.Drawing.Point(185, 113);
            this.ScaleYNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ScaleYNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ScaleYNUD.Name = "ScaleYNUD";
            this.ScaleYNUD.Size = new System.Drawing.Size(58, 20);
            this.ScaleYNUD.TabIndex = 75;
            // 
            // ParticleEmitterGroupBox
            // 
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterTypeCB);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterPPBNUD);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterColorCB);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterSizeCB);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterInputNUD);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterPPBCB);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterEmissionCB);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterSizeNUD);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterSpeedCB);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterEmissionNUD);
            this.ParticleEmitterGroupBox.Controls.Add(this.ColorPickParticleEmitter);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterGravityNUD);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterSpeedNUD);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterColorTB);
            this.ParticleEmitterGroupBox.Controls.Add(this.ParticleEmitterGravityCB);
            this.ParticleEmitterGroupBox.Enabled = false;
            this.ParticleEmitterGroupBox.Location = new System.Drawing.Point(424, 140);
            this.ParticleEmitterGroupBox.Name = "ParticleEmitterGroupBox";
            this.ParticleEmitterGroupBox.Size = new System.Drawing.Size(202, 195);
            this.ParticleEmitterGroupBox.TabIndex = 81;
            this.ParticleEmitterGroupBox.TabStop = false;
            this.ParticleEmitterGroupBox.Text = "Particle Emitter Options";
            // 
            // ParticleEmitterTypeCB
            // 
            this.ParticleEmitterTypeCB.AutoSize = true;
            this.ParticleEmitterTypeCB.Location = new System.Drawing.Point(100, 56);
            this.ParticleEmitterTypeCB.Name = "ParticleEmitterTypeCB";
            this.ParticleEmitterTypeCB.Size = new System.Drawing.Size(77, 17);
            this.ParticleEmitterTypeCB.TabIndex = 146;
            this.ParticleEmitterTypeCB.Text = "Input Type";
            this.ParticleEmitterTypeCB.CheckedChanged += new System.EventHandler(this.ParticleEmitterTypeCB_CheckedChanged);
            // 
            // ParticleEmitterPPBNUD
            // 
            this.ParticleEmitterPPBNUD.DecimalPlaces = 2;
            this.ParticleEmitterPPBNUD.Enabled = false;
            this.ParticleEmitterPPBNUD.Location = new System.Drawing.Point(10, 161);
            this.ParticleEmitterPPBNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ParticleEmitterPPBNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ParticleEmitterPPBNUD.Name = "ParticleEmitterPPBNUD";
            this.ParticleEmitterPPBNUD.Size = new System.Drawing.Size(79, 20);
            this.ParticleEmitterPPBNUD.TabIndex = 145;
            // 
            // ParticleEmitterColorCB
            // 
            this.ParticleEmitterColorCB.AutoSize = true;
            this.ParticleEmitterColorCB.Location = new System.Drawing.Point(6, 17);
            this.ParticleEmitterColorCB.Name = "ParticleEmitterColorCB";
            this.ParticleEmitterColorCB.Size = new System.Drawing.Size(123, 17);
            this.ParticleEmitterColorCB.TabIndex = 130;
            this.ParticleEmitterColorCB.Text = "Particle Emitter Color";
            this.ParticleEmitterColorCB.CheckedChanged += new System.EventHandler(this.ParticleEmitterColorCB_CheckedChanged);
            // 
            // ParticleEmitterSizeCB
            // 
            this.ParticleEmitterSizeCB.AutoSize = true;
            this.ParticleEmitterSizeCB.Location = new System.Drawing.Point(115, 145);
            this.ParticleEmitterSizeCB.Name = "ParticleEmitterSizeCB";
            this.ParticleEmitterSizeCB.Size = new System.Drawing.Size(46, 17);
            this.ParticleEmitterSizeCB.TabIndex = 144;
            this.ParticleEmitterSizeCB.Text = "Size";
            this.ParticleEmitterSizeCB.CheckedChanged += new System.EventHandler(this.ParticleEmitterSizeCB_CheckedChanged);
            // 
            // ParticleEmitterInputNUD
            // 
            this.ParticleEmitterInputNUD.Enabled = false;
            this.ParticleEmitterInputNUD.Location = new System.Drawing.Point(102, 73);
            this.ParticleEmitterInputNUD.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.ParticleEmitterInputNUD.Name = "ParticleEmitterInputNUD";
            this.ParticleEmitterInputNUD.Size = new System.Drawing.Size(79, 20);
            this.ParticleEmitterInputNUD.TabIndex = 135;
            // 
            // ParticleEmitterPPBCB
            // 
            this.ParticleEmitterPPBCB.AutoSize = true;
            this.ParticleEmitterPPBCB.Location = new System.Drawing.Point(7, 145);
            this.ParticleEmitterPPBCB.Name = "ParticleEmitterPPBCB";
            this.ParticleEmitterPPBCB.Size = new System.Drawing.Size(110, 17);
            this.ParticleEmitterPPBCB.TabIndex = 142;
            this.ParticleEmitterPPBCB.Text = "Particles Per Beat";
            this.ParticleEmitterPPBCB.CheckedChanged += new System.EventHandler(this.ParticleEmitterPPBCB_CheckedChanged);
            // 
            // ParticleEmitterEmissionCB
            // 
            this.ParticleEmitterEmissionCB.AutoSize = true;
            this.ParticleEmitterEmissionCB.Location = new System.Drawing.Point(6, 57);
            this.ParticleEmitterEmissionCB.Name = "ParticleEmitterEmissionCB";
            this.ParticleEmitterEmissionCB.Size = new System.Drawing.Size(100, 17);
            this.ParticleEmitterEmissionCB.TabIndex = 136;
            this.ParticleEmitterEmissionCB.Text = "Emission (Glow)";
            this.ParticleEmitterEmissionCB.CheckedChanged += new System.EventHandler(this.ParticleEmitterEmissionCB_CheckedChanged);
            // 
            // ParticleEmitterSizeNUD
            // 
            this.ParticleEmitterSizeNUD.DecimalPlaces = 2;
            this.ParticleEmitterSizeNUD.Enabled = false;
            this.ParticleEmitterSizeNUD.Location = new System.Drawing.Point(118, 161);
            this.ParticleEmitterSizeNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ParticleEmitterSizeNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ParticleEmitterSizeNUD.Name = "ParticleEmitterSizeNUD";
            this.ParticleEmitterSizeNUD.Size = new System.Drawing.Size(79, 20);
            this.ParticleEmitterSizeNUD.TabIndex = 143;
            this.ParticleEmitterSizeNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ParticleEmitterSpeedCB
            // 
            this.ParticleEmitterSpeedCB.AutoSize = true;
            this.ParticleEmitterSpeedCB.Location = new System.Drawing.Point(99, 101);
            this.ParticleEmitterSpeedCB.Name = "ParticleEmitterSpeedCB";
            this.ParticleEmitterSpeedCB.Size = new System.Drawing.Size(57, 17);
            this.ParticleEmitterSpeedCB.TabIndex = 140;
            this.ParticleEmitterSpeedCB.Text = "Speed";
            this.ParticleEmitterSpeedCB.CheckedChanged += new System.EventHandler(this.ParticleEmitterSpeedCB_CheckedChanged);
            // 
            // ParticleEmitterEmissionNUD
            // 
            this.ParticleEmitterEmissionNUD.DecimalPlaces = 3;
            this.ParticleEmitterEmissionNUD.Enabled = false;
            this.ParticleEmitterEmissionNUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.ParticleEmitterEmissionNUD.Location = new System.Drawing.Point(9, 73);
            this.ParticleEmitterEmissionNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ParticleEmitterEmissionNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ParticleEmitterEmissionNUD.Name = "ParticleEmitterEmissionNUD";
            this.ParticleEmitterEmissionNUD.Size = new System.Drawing.Size(78, 20);
            this.ParticleEmitterEmissionNUD.TabIndex = 131;
            this.ParticleEmitterEmissionNUD.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // ColorPickParticleEmitter
            // 
            this.ColorPickParticleEmitter.Enabled = false;
            this.ColorPickParticleEmitter.Location = new System.Drawing.Point(115, 31);
            this.ColorPickParticleEmitter.Name = "ColorPickParticleEmitter";
            this.ColorPickParticleEmitter.Size = new System.Drawing.Size(84, 23);
            this.ColorPickParticleEmitter.TabIndex = 134;
            this.ColorPickParticleEmitter.Text = "Pick Color";
            this.ColorPickParticleEmitter.UseVisualStyleBackColor = true;
            this.ColorPickParticleEmitter.Click += new System.EventHandler(this.ColorPickParticleEmitter_Click);
            // 
            // ParticleEmitterGravityNUD
            // 
            this.ParticleEmitterGravityNUD.DecimalPlaces = 2;
            this.ParticleEmitterGravityNUD.Enabled = false;
            this.ParticleEmitterGravityNUD.Location = new System.Drawing.Point(9, 117);
            this.ParticleEmitterGravityNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ParticleEmitterGravityNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ParticleEmitterGravityNUD.Name = "ParticleEmitterGravityNUD";
            this.ParticleEmitterGravityNUD.Size = new System.Drawing.Size(79, 20);
            this.ParticleEmitterGravityNUD.TabIndex = 137;
            // 
            // ParticleEmitterSpeedNUD
            // 
            this.ParticleEmitterSpeedNUD.DecimalPlaces = 2;
            this.ParticleEmitterSpeedNUD.Enabled = false;
            this.ParticleEmitterSpeedNUD.Location = new System.Drawing.Point(102, 117);
            this.ParticleEmitterSpeedNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ParticleEmitterSpeedNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ParticleEmitterSpeedNUD.Name = "ParticleEmitterSpeedNUD";
            this.ParticleEmitterSpeedNUD.Size = new System.Drawing.Size(79, 20);
            this.ParticleEmitterSpeedNUD.TabIndex = 139;
            // 
            // ParticleEmitterColorTB
            // 
            this.ParticleEmitterColorTB.Enabled = false;
            this.ParticleEmitterColorTB.Location = new System.Drawing.Point(9, 33);
            this.ParticleEmitterColorTB.Name = "ParticleEmitterColorTB";
            this.ParticleEmitterColorTB.Size = new System.Drawing.Size(100, 20);
            this.ParticleEmitterColorTB.TabIndex = 132;
            // 
            // ParticleEmitterGravityCB
            // 
            this.ParticleEmitterGravityCB.AutoSize = true;
            this.ParticleEmitterGravityCB.Location = new System.Drawing.Point(6, 101);
            this.ParticleEmitterGravityCB.Name = "ParticleEmitterGravityCB";
            this.ParticleEmitterGravityCB.Size = new System.Drawing.Size(59, 17);
            this.ParticleEmitterGravityCB.TabIndex = 138;
            this.ParticleEmitterGravityCB.Text = "Gravity";
            this.ParticleEmitterGravityCB.CheckedChanged += new System.EventHandler(this.ParticleEmitterGravityCB_CheckedChanged);
            // 
            // RotationYNUD
            // 
            this.RotationYNUD.DecimalPlaces = 2;
            this.RotationYNUD.Enabled = false;
            this.RotationYNUD.Location = new System.Drawing.Point(185, 87);
            this.RotationYNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.RotationYNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.RotationYNUD.Name = "RotationYNUD";
            this.RotationYNUD.Size = new System.Drawing.Size(58, 20);
            this.RotationYNUD.TabIndex = 74;
            // 
            // SatelliteGroupBox
            // 
            this.SatelliteGroupBox.Controls.Add(this.SatelliteMinimumVertexDistanceNUD);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteTrailWidthNUD);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteMinimumVertexCB);
            this.SatelliteGroupBox.Controls.Add(this.SatellieTrailWidthCB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteTrailFadeTimeCB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteTrailTimeNUD);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteRotationSpeedNUD);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteRadiusCB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteRotationCB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteRadiusNUD);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteSensitivityCB);
            this.SatelliteGroupBox.Controls.Add(this.ColorPickSatellite);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteSensitivityNUD);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteColorCB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteLerpSpeedCB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteColorTB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteLerpSpeedNUD);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteEmissionNUD);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteTypeCB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteEmissionCB);
            this.SatelliteGroupBox.Controls.Add(this.SatelliteInputNUD);
            this.SatelliteGroupBox.Enabled = false;
            this.SatelliteGroupBox.Location = new System.Drawing.Point(216, 140);
            this.SatelliteGroupBox.Name = "SatelliteGroupBox";
            this.SatelliteGroupBox.Size = new System.Drawing.Size(202, 297);
            this.SatelliteGroupBox.TabIndex = 80;
            this.SatelliteGroupBox.TabStop = false;
            this.SatelliteGroupBox.Text = "Satellite Options";
            // 
            // SatelliteMinimumVertexDistanceNUD
            // 
            this.SatelliteMinimumVertexDistanceNUD.DecimalPlaces = 2;
            this.SatelliteMinimumVertexDistanceNUD.Enabled = false;
            this.SatelliteMinimumVertexDistanceNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SatelliteMinimumVertexDistanceNUD.InterceptArrowKeys = false;
            this.SatelliteMinimumVertexDistanceNUD.Location = new System.Drawing.Point(7, 246);
            this.SatelliteMinimumVertexDistanceNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SatelliteMinimumVertexDistanceNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SatelliteMinimumVertexDistanceNUD.Name = "SatelliteMinimumVertexDistanceNUD";
            this.SatelliteMinimumVertexDistanceNUD.Size = new System.Drawing.Size(79, 20);
            this.SatelliteMinimumVertexDistanceNUD.TabIndex = 131;
            this.SatelliteMinimumVertexDistanceNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SatelliteTrailWidthNUD
            // 
            this.SatelliteTrailWidthNUD.DecimalPlaces = 2;
            this.SatelliteTrailWidthNUD.Enabled = false;
            this.SatelliteTrailWidthNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SatelliteTrailWidthNUD.InterceptArrowKeys = false;
            this.SatelliteTrailWidthNUD.Location = new System.Drawing.Point(100, 205);
            this.SatelliteTrailWidthNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SatelliteTrailWidthNUD.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.SatelliteTrailWidthNUD.Name = "SatelliteTrailWidthNUD";
            this.SatelliteTrailWidthNUD.Size = new System.Drawing.Size(79, 20);
            this.SatelliteTrailWidthNUD.TabIndex = 130;
            this.SatelliteTrailWidthNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SatelliteMinimumVertexCB
            // 
            this.SatelliteMinimumVertexCB.AutoSize = true;
            this.SatelliteMinimumVertexCB.Location = new System.Drawing.Point(7, 230);
            this.SatelliteMinimumVertexCB.Name = "SatelliteMinimumVertexCB";
            this.SatelliteMinimumVertexCB.Size = new System.Drawing.Size(145, 17);
            this.SatelliteMinimumVertexCB.TabIndex = 129;
            this.SatelliteMinimumVertexCB.Text = "Minimum Vertex Distance";
            this.SatelliteMinimumVertexCB.CheckedChanged += new System.EventHandler(this.SatelliteMinimumVertexCB_CheckedChanged);
            // 
            // SatellieTrailWidthCB
            // 
            this.SatellieTrailWidthCB.AutoSize = true;
            this.SatellieTrailWidthCB.Location = new System.Drawing.Point(100, 189);
            this.SatellieTrailWidthCB.Name = "SatellieTrailWidthCB";
            this.SatellieTrailWidthCB.Size = new System.Drawing.Size(77, 17);
            this.SatellieTrailWidthCB.TabIndex = 127;
            this.SatellieTrailWidthCB.Text = "Trail Width";
            this.SatellieTrailWidthCB.CheckedChanged += new System.EventHandler(this.SatellieTrailWidthCB_CheckedChanged);
            // 
            // SatelliteTrailFadeTimeCB
            // 
            this.SatelliteTrailFadeTimeCB.AutoSize = true;
            this.SatelliteTrailFadeTimeCB.Location = new System.Drawing.Point(7, 189);
            this.SatelliteTrailFadeTimeCB.Name = "SatelliteTrailFadeTimeCB";
            this.SatelliteTrailFadeTimeCB.Size = new System.Drawing.Size(99, 17);
            this.SatelliteTrailFadeTimeCB.TabIndex = 125;
            this.SatelliteTrailFadeTimeCB.Text = "Trail Fade Time";
            this.SatelliteTrailFadeTimeCB.CheckedChanged += new System.EventHandler(this.SatelliteTrailFadeTimeCB_CheckedChanged);
            // 
            // SatelliteTrailTimeNUD
            // 
            this.SatelliteTrailTimeNUD.DecimalPlaces = 2;
            this.SatelliteTrailTimeNUD.Enabled = false;
            this.SatelliteTrailTimeNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SatelliteTrailTimeNUD.InterceptArrowKeys = false;
            this.SatelliteTrailTimeNUD.Location = new System.Drawing.Point(7, 205);
            this.SatelliteTrailTimeNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SatelliteTrailTimeNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SatelliteTrailTimeNUD.Name = "SatelliteTrailTimeNUD";
            this.SatelliteTrailTimeNUD.Size = new System.Drawing.Size(79, 20);
            this.SatelliteTrailTimeNUD.TabIndex = 124;
            this.SatelliteTrailTimeNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SatelliteRotationSpeedNUD
            // 
            this.SatelliteRotationSpeedNUD.DecimalPlaces = 2;
            this.SatelliteRotationSpeedNUD.Enabled = false;
            this.SatelliteRotationSpeedNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SatelliteRotationSpeedNUD.Location = new System.Drawing.Point(7, 161);
            this.SatelliteRotationSpeedNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SatelliteRotationSpeedNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SatelliteRotationSpeedNUD.Name = "SatelliteRotationSpeedNUD";
            this.SatelliteRotationSpeedNUD.Size = new System.Drawing.Size(79, 20);
            this.SatelliteRotationSpeedNUD.TabIndex = 120;
            this.SatelliteRotationSpeedNUD.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // SatelliteRadiusCB
            // 
            this.SatelliteRadiusCB.AutoSize = true;
            this.SatelliteRadiusCB.Location = new System.Drawing.Point(100, 145);
            this.SatelliteRadiusCB.Name = "SatelliteRadiusCB";
            this.SatelliteRadiusCB.Size = new System.Drawing.Size(59, 17);
            this.SatelliteRadiusCB.TabIndex = 123;
            this.SatelliteRadiusCB.Text = "Radius";
            this.SatelliteRadiusCB.CheckedChanged += new System.EventHandler(this.SatelliteRadiusCB_CheckedChanged);
            // 
            // SatelliteRotationCB
            // 
            this.SatelliteRotationCB.AutoSize = true;
            this.SatelliteRotationCB.Location = new System.Drawing.Point(7, 145);
            this.SatelliteRotationCB.Name = "SatelliteRotationCB";
            this.SatelliteRotationCB.Size = new System.Drawing.Size(100, 17);
            this.SatelliteRotationCB.TabIndex = 121;
            this.SatelliteRotationCB.Text = "Rotation Speed";
            this.SatelliteRotationCB.CheckedChanged += new System.EventHandler(this.SatelliteRotationCB_CheckedChanged);
            // 
            // SatelliteRadiusNUD
            // 
            this.SatelliteRadiusNUD.DecimalPlaces = 2;
            this.SatelliteRadiusNUD.Enabled = false;
            this.SatelliteRadiusNUD.Location = new System.Drawing.Point(100, 161);
            this.SatelliteRadiusNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SatelliteRadiusNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SatelliteRadiusNUD.Name = "SatelliteRadiusNUD";
            this.SatelliteRadiusNUD.Size = new System.Drawing.Size(79, 20);
            this.SatelliteRadiusNUD.TabIndex = 122;
            this.SatelliteRadiusNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SatelliteSensitivityCB
            // 
            this.SatelliteSensitivityCB.AutoSize = true;
            this.SatelliteSensitivityCB.Location = new System.Drawing.Point(99, 101);
            this.SatelliteSensitivityCB.Name = "SatelliteSensitivityCB";
            this.SatelliteSensitivityCB.Size = new System.Drawing.Size(73, 17);
            this.SatelliteSensitivityCB.TabIndex = 119;
            this.SatelliteSensitivityCB.Text = "Sensitivity";
            this.SatelliteSensitivityCB.CheckedChanged += new System.EventHandler(this.SatelliteSensitivityCB_CheckedChanged);
            // 
            // ColorPickSatellite
            // 
            this.ColorPickSatellite.Enabled = false;
            this.ColorPickSatellite.Location = new System.Drawing.Point(112, 31);
            this.ColorPickSatellite.Name = "ColorPickSatellite";
            this.ColorPickSatellite.Size = new System.Drawing.Size(84, 23);
            this.ColorPickSatellite.TabIndex = 114;
            this.ColorPickSatellite.Text = "Pick Color";
            this.ColorPickSatellite.UseVisualStyleBackColor = true;
            this.ColorPickSatellite.Click += new System.EventHandler(this.ColorPickSatellite_Click);
            // 
            // SatelliteSensitivityNUD
            // 
            this.SatelliteSensitivityNUD.DecimalPlaces = 2;
            this.SatelliteSensitivityNUD.Enabled = false;
            this.SatelliteSensitivityNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SatelliteSensitivityNUD.Location = new System.Drawing.Point(99, 117);
            this.SatelliteSensitivityNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SatelliteSensitivityNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SatelliteSensitivityNUD.Name = "SatelliteSensitivityNUD";
            this.SatelliteSensitivityNUD.Size = new System.Drawing.Size(79, 20);
            this.SatelliteSensitivityNUD.TabIndex = 118;
            this.SatelliteSensitivityNUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // SatelliteColorCB
            // 
            this.SatelliteColorCB.AutoSize = true;
            this.SatelliteColorCB.Location = new System.Drawing.Point(6, 17);
            this.SatelliteColorCB.Name = "SatelliteColorCB";
            this.SatelliteColorCB.Size = new System.Drawing.Size(90, 17);
            this.SatelliteColorCB.TabIndex = 112;
            this.SatelliteColorCB.Text = "Satellite Color";
            this.SatelliteColorCB.CheckedChanged += new System.EventHandler(this.SatelliteColorCB_CheckedChanged);
            // 
            // SatelliteLerpSpeedCB
            // 
            this.SatelliteLerpSpeedCB.AutoSize = true;
            this.SatelliteLerpSpeedCB.Location = new System.Drawing.Point(6, 101);
            this.SatelliteLerpSpeedCB.Name = "SatelliteLerpSpeedCB";
            this.SatelliteLerpSpeedCB.Size = new System.Drawing.Size(81, 17);
            this.SatelliteLerpSpeedCB.TabIndex = 117;
            this.SatelliteLerpSpeedCB.Text = "Lerp Speed";
            this.SatelliteLerpSpeedCB.CheckedChanged += new System.EventHandler(this.SatelliteLerpSpeedCB_CheckedChanged);
            // 
            // SatelliteColorTB
            // 
            this.SatelliteColorTB.Enabled = false;
            this.SatelliteColorTB.Location = new System.Drawing.Point(6, 33);
            this.SatelliteColorTB.Name = "SatelliteColorTB";
            this.SatelliteColorTB.Size = new System.Drawing.Size(100, 20);
            this.SatelliteColorTB.TabIndex = 113;
            // 
            // SatelliteLerpSpeedNUD
            // 
            this.SatelliteLerpSpeedNUD.DecimalPlaces = 3;
            this.SatelliteLerpSpeedNUD.Enabled = false;
            this.SatelliteLerpSpeedNUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.SatelliteLerpSpeedNUD.Location = new System.Drawing.Point(6, 117);
            this.SatelliteLerpSpeedNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SatelliteLerpSpeedNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SatelliteLerpSpeedNUD.Name = "SatelliteLerpSpeedNUD";
            this.SatelliteLerpSpeedNUD.Size = new System.Drawing.Size(79, 20);
            this.SatelliteLerpSpeedNUD.TabIndex = 116;
            this.SatelliteLerpSpeedNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SatelliteEmissionNUD
            // 
            this.SatelliteEmissionNUD.DecimalPlaces = 3;
            this.SatelliteEmissionNUD.Enabled = false;
            this.SatelliteEmissionNUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.SatelliteEmissionNUD.Location = new System.Drawing.Point(6, 73);
            this.SatelliteEmissionNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SatelliteEmissionNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SatelliteEmissionNUD.Name = "SatelliteEmissionNUD";
            this.SatelliteEmissionNUD.Size = new System.Drawing.Size(78, 20);
            this.SatelliteEmissionNUD.TabIndex = 112;
            this.SatelliteEmissionNUD.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // SatelliteTypeCB
            // 
            this.SatelliteTypeCB.AutoSize = true;
            this.SatelliteTypeCB.Location = new System.Drawing.Point(99, 57);
            this.SatelliteTypeCB.Name = "SatelliteTypeCB";
            this.SatelliteTypeCB.Size = new System.Drawing.Size(77, 17);
            this.SatelliteTypeCB.TabIndex = 115;
            this.SatelliteTypeCB.Text = "Input Type";
            this.SatelliteTypeCB.CheckedChanged += new System.EventHandler(this.SatelliteTypeCB_CheckedChanged);
            // 
            // SatelliteEmissionCB
            // 
            this.SatelliteEmissionCB.AutoSize = true;
            this.SatelliteEmissionCB.Location = new System.Drawing.Point(6, 57);
            this.SatelliteEmissionCB.Name = "SatelliteEmissionCB";
            this.SatelliteEmissionCB.Size = new System.Drawing.Size(100, 17);
            this.SatelliteEmissionCB.TabIndex = 113;
            this.SatelliteEmissionCB.Text = "Emission (Glow)";
            this.SatelliteEmissionCB.CheckedChanged += new System.EventHandler(this.SatelliteEmissionCB_CheckedChanged);
            // 
            // SatelliteInputNUD
            // 
            this.SatelliteInputNUD.Enabled = false;
            this.SatelliteInputNUD.Location = new System.Drawing.Point(99, 73);
            this.SatelliteInputNUD.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.SatelliteInputNUD.Name = "SatelliteInputNUD";
            this.SatelliteInputNUD.Size = new System.Drawing.Size(79, 20);
            this.SatelliteInputNUD.TabIndex = 114;
            // 
            // PositionYNUD
            // 
            this.PositionYNUD.DecimalPlaces = 2;
            this.PositionYNUD.Enabled = false;
            this.PositionYNUD.Location = new System.Drawing.Point(185, 61);
            this.PositionYNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PositionYNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.PositionYNUD.Name = "PositionYNUD";
            this.PositionYNUD.Size = new System.Drawing.Size(58, 20);
            this.PositionYNUD.TabIndex = 73;
            // 
            // SunGroupBox
            // 
            this.SunGroupBox.Controls.Add(this.SunDirectionVectorCB);
            this.SunGroupBox.Controls.Add(this.DirectionVectorZNUD);
            this.SunGroupBox.Controls.Add(this.DirectionVectorYNUD);
            this.SunGroupBox.Controls.Add(this.DirectionVectorXNUD);
            this.SunGroupBox.Controls.Add(this.SunMaxSizeCB);
            this.SunGroupBox.Controls.Add(this.SunMaxSizeZNUD);
            this.SunGroupBox.Controls.Add(this.SunMaxSizeYNUD);
            this.SunGroupBox.Controls.Add(this.SunMaxSizeXNUD);
            this.SunGroupBox.Controls.Add(this.SunMinSizeCB);
            this.SunGroupBox.Controls.Add(this.SunMinSizeZNUD);
            this.SunGroupBox.Controls.Add(this.SunSensivityCB);
            this.SunGroupBox.Controls.Add(this.SunMinSizeYNUD);
            this.SunGroupBox.Controls.Add(this.SunSensitivityNUD);
            this.SunGroupBox.Controls.Add(this.SunMinSizeXNUD);
            this.SunGroupBox.Controls.Add(this.SunLerpSpeedCB);
            this.SunGroupBox.Controls.Add(this.SunLerpNUD);
            this.SunGroupBox.Controls.Add(this.SunInputCB);
            this.SunGroupBox.Controls.Add(this.SunInputNUD);
            this.SunGroupBox.Controls.Add(this.SunEmissionCB);
            this.SunGroupBox.Controls.Add(this.SunEmissionNUD);
            this.SunGroupBox.Controls.Add(this.ColorPickSunNoLives);
            this.SunGroupBox.Controls.Add(this.NoLivesColorCB);
            this.SunGroupBox.Controls.Add(this.NoLivesColorTB);
            this.SunGroupBox.Controls.Add(this.ColorPickSunMaxLives);
            this.SunGroupBox.Controls.Add(this.MaxLivesCB);
            this.SunGroupBox.Controls.Add(this.MaxLivesColorTB);
            this.SunGroupBox.Enabled = false;
            this.SunGroupBox.Location = new System.Drawing.Point(8, 138);
            this.SunGroupBox.Name = "SunGroupBox";
            this.SunGroupBox.Size = new System.Drawing.Size(202, 299);
            this.SunGroupBox.TabIndex = 79;
            this.SunGroupBox.TabStop = false;
            this.SunGroupBox.Text = "Sun Options";
            // 
            // SunDirectionVectorCB
            // 
            this.SunDirectionVectorCB.AutoSize = true;
            this.SunDirectionVectorCB.Location = new System.Drawing.Point(6, 255);
            this.SunDirectionVectorCB.Name = "SunDirectionVectorCB";
            this.SunDirectionVectorCB.Size = new System.Drawing.Size(102, 17);
            this.SunDirectionVectorCB.TabIndex = 111;
            this.SunDirectionVectorCB.Text = "Direction Vector";
            this.SunDirectionVectorCB.CheckedChanged += new System.EventHandler(this.SunDirectionVectorCB_CheckedChanged);
            // 
            // DirectionVectorZNUD
            // 
            this.DirectionVectorZNUD.DecimalPlaces = 2;
            this.DirectionVectorZNUD.Enabled = false;
            this.DirectionVectorZNUD.Location = new System.Drawing.Point(134, 269);
            this.DirectionVectorZNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DirectionVectorZNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.DirectionVectorZNUD.Name = "DirectionVectorZNUD";
            this.DirectionVectorZNUD.Size = new System.Drawing.Size(58, 20);
            this.DirectionVectorZNUD.TabIndex = 110;
            // 
            // DirectionVectorYNUD
            // 
            this.DirectionVectorYNUD.DecimalPlaces = 2;
            this.DirectionVectorYNUD.Enabled = false;
            this.DirectionVectorYNUD.Location = new System.Drawing.Point(70, 269);
            this.DirectionVectorYNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DirectionVectorYNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.DirectionVectorYNUD.Name = "DirectionVectorYNUD";
            this.DirectionVectorYNUD.Size = new System.Drawing.Size(58, 20);
            this.DirectionVectorYNUD.TabIndex = 109;
            // 
            // DirectionVectorXNUD
            // 
            this.DirectionVectorXNUD.DecimalPlaces = 2;
            this.DirectionVectorXNUD.Enabled = false;
            this.DirectionVectorXNUD.Location = new System.Drawing.Point(6, 269);
            this.DirectionVectorXNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DirectionVectorXNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.DirectionVectorXNUD.Name = "DirectionVectorXNUD";
            this.DirectionVectorXNUD.Size = new System.Drawing.Size(58, 20);
            this.DirectionVectorXNUD.TabIndex = 108;
            // 
            // SunMaxSizeCB
            // 
            this.SunMaxSizeCB.AutoSize = true;
            this.SunMaxSizeCB.Location = new System.Drawing.Point(6, 218);
            this.SunMaxSizeCB.Name = "SunMaxSizeCB";
            this.SunMaxSizeCB.Size = new System.Drawing.Size(69, 17);
            this.SunMaxSizeCB.TabIndex = 107;
            this.SunMaxSizeCB.Text = "Max Size";
            this.SunMaxSizeCB.CheckedChanged += new System.EventHandler(this.SunMaxSizeCB_CheckedChanged);
            // 
            // SunMaxSizeZNUD
            // 
            this.SunMaxSizeZNUD.DecimalPlaces = 2;
            this.SunMaxSizeZNUD.Enabled = false;
            this.SunMaxSizeZNUD.Location = new System.Drawing.Point(134, 232);
            this.SunMaxSizeZNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunMaxSizeZNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunMaxSizeZNUD.Name = "SunMaxSizeZNUD";
            this.SunMaxSizeZNUD.Size = new System.Drawing.Size(58, 20);
            this.SunMaxSizeZNUD.TabIndex = 106;
            // 
            // SunMaxSizeYNUD
            // 
            this.SunMaxSizeYNUD.DecimalPlaces = 2;
            this.SunMaxSizeYNUD.Enabled = false;
            this.SunMaxSizeYNUD.Location = new System.Drawing.Point(70, 232);
            this.SunMaxSizeYNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunMaxSizeYNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunMaxSizeYNUD.Name = "SunMaxSizeYNUD";
            this.SunMaxSizeYNUD.Size = new System.Drawing.Size(58, 20);
            this.SunMaxSizeYNUD.TabIndex = 105;
            // 
            // SunMaxSizeXNUD
            // 
            this.SunMaxSizeXNUD.DecimalPlaces = 2;
            this.SunMaxSizeXNUD.Enabled = false;
            this.SunMaxSizeXNUD.Location = new System.Drawing.Point(6, 232);
            this.SunMaxSizeXNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunMaxSizeXNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunMaxSizeXNUD.Name = "SunMaxSizeXNUD";
            this.SunMaxSizeXNUD.Size = new System.Drawing.Size(58, 20);
            this.SunMaxSizeXNUD.TabIndex = 104;
            // 
            // SunMinSizeCB
            // 
            this.SunMinSizeCB.AutoSize = true;
            this.SunMinSizeCB.Location = new System.Drawing.Point(6, 180);
            this.SunMinSizeCB.Name = "SunMinSizeCB";
            this.SunMinSizeCB.Size = new System.Drawing.Size(66, 17);
            this.SunMinSizeCB.TabIndex = 103;
            this.SunMinSizeCB.Text = "Min Size";
            this.SunMinSizeCB.CheckedChanged += new System.EventHandler(this.SunMinSizeCB_CheckedChanged);
            // 
            // SunMinSizeZNUD
            // 
            this.SunMinSizeZNUD.DecimalPlaces = 2;
            this.SunMinSizeZNUD.Enabled = false;
            this.SunMinSizeZNUD.Location = new System.Drawing.Point(134, 194);
            this.SunMinSizeZNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunMinSizeZNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunMinSizeZNUD.Name = "SunMinSizeZNUD";
            this.SunMinSizeZNUD.Size = new System.Drawing.Size(58, 20);
            this.SunMinSizeZNUD.TabIndex = 93;
            // 
            // SunSensivityCB
            // 
            this.SunSensivityCB.AutoSize = true;
            this.SunSensivityCB.Location = new System.Drawing.Point(99, 141);
            this.SunSensivityCB.Name = "SunSensivityCB";
            this.SunSensivityCB.Size = new System.Drawing.Size(73, 17);
            this.SunSensivityCB.TabIndex = 102;
            this.SunSensivityCB.Text = "Sensitivity";
            this.SunSensivityCB.CheckedChanged += new System.EventHandler(this.SunSensivityCB_CheckedChanged);
            // 
            // SunMinSizeYNUD
            // 
            this.SunMinSizeYNUD.DecimalPlaces = 2;
            this.SunMinSizeYNUD.Enabled = false;
            this.SunMinSizeYNUD.Location = new System.Drawing.Point(70, 194);
            this.SunMinSizeYNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunMinSizeYNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunMinSizeYNUD.Name = "SunMinSizeYNUD";
            this.SunMinSizeYNUD.Size = new System.Drawing.Size(58, 20);
            this.SunMinSizeYNUD.TabIndex = 92;
            // 
            // SunSensitivityNUD
            // 
            this.SunSensitivityNUD.DecimalPlaces = 2;
            this.SunSensitivityNUD.Enabled = false;
            this.SunSensitivityNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SunSensitivityNUD.Location = new System.Drawing.Point(99, 157);
            this.SunSensitivityNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunSensitivityNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunSensitivityNUD.Name = "SunSensitivityNUD";
            this.SunSensitivityNUD.Size = new System.Drawing.Size(79, 20);
            this.SunSensitivityNUD.TabIndex = 101;
            this.SunSensitivityNUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // SunMinSizeXNUD
            // 
            this.SunMinSizeXNUD.DecimalPlaces = 2;
            this.SunMinSizeXNUD.Enabled = false;
            this.SunMinSizeXNUD.Location = new System.Drawing.Point(6, 194);
            this.SunMinSizeXNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunMinSizeXNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunMinSizeXNUD.Name = "SunMinSizeXNUD";
            this.SunMinSizeXNUD.Size = new System.Drawing.Size(58, 20);
            this.SunMinSizeXNUD.TabIndex = 91;
            // 
            // SunLerpSpeedCB
            // 
            this.SunLerpSpeedCB.AutoSize = true;
            this.SunLerpSpeedCB.Location = new System.Drawing.Point(6, 141);
            this.SunLerpSpeedCB.Name = "SunLerpSpeedCB";
            this.SunLerpSpeedCB.Size = new System.Drawing.Size(81, 17);
            this.SunLerpSpeedCB.TabIndex = 100;
            this.SunLerpSpeedCB.Text = "Lerp Speed";
            this.SunLerpSpeedCB.CheckedChanged += new System.EventHandler(this.SunLerpSpeedCB_CheckedChanged);
            // 
            // SunLerpNUD
            // 
            this.SunLerpNUD.DecimalPlaces = 3;
            this.SunLerpNUD.Enabled = false;
            this.SunLerpNUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.SunLerpNUD.Location = new System.Drawing.Point(6, 157);
            this.SunLerpNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunLerpNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunLerpNUD.Name = "SunLerpNUD";
            this.SunLerpNUD.Size = new System.Drawing.Size(79, 20);
            this.SunLerpNUD.TabIndex = 99;
            this.SunLerpNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SunInputCB
            // 
            this.SunInputCB.AutoSize = true;
            this.SunInputCB.Location = new System.Drawing.Point(99, 97);
            this.SunInputCB.Name = "SunInputCB";
            this.SunInputCB.Size = new System.Drawing.Size(77, 17);
            this.SunInputCB.TabIndex = 98;
            this.SunInputCB.Text = "Input Type";
            this.SunInputCB.CheckedChanged += new System.EventHandler(this.SunInputCB_CheckedChanged);
            // 
            // SunInputNUD
            // 
            this.SunInputNUD.Enabled = false;
            this.SunInputNUD.Location = new System.Drawing.Point(99, 113);
            this.SunInputNUD.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.SunInputNUD.Name = "SunInputNUD";
            this.SunInputNUD.Size = new System.Drawing.Size(79, 20);
            this.SunInputNUD.TabIndex = 97;
            // 
            // SunEmissionCB
            // 
            this.SunEmissionCB.AutoSize = true;
            this.SunEmissionCB.Location = new System.Drawing.Point(6, 97);
            this.SunEmissionCB.Name = "SunEmissionCB";
            this.SunEmissionCB.Size = new System.Drawing.Size(100, 17);
            this.SunEmissionCB.TabIndex = 96;
            this.SunEmissionCB.Text = "Emission (Glow)";
            this.SunEmissionCB.CheckedChanged += new System.EventHandler(this.SunEmissionCB_CheckedChanged);
            // 
            // SunEmissionNUD
            // 
            this.SunEmissionNUD.DecimalPlaces = 3;
            this.SunEmissionNUD.Enabled = false;
            this.SunEmissionNUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.SunEmissionNUD.Location = new System.Drawing.Point(6, 113);
            this.SunEmissionNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SunEmissionNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.SunEmissionNUD.Name = "SunEmissionNUD";
            this.SunEmissionNUD.Size = new System.Drawing.Size(80, 20);
            this.SunEmissionNUD.TabIndex = 91;
            this.SunEmissionNUD.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // ColorPickSunNoLives
            // 
            this.ColorPickSunNoLives.Enabled = false;
            this.ColorPickSunNoLives.Location = new System.Drawing.Point(112, 72);
            this.ColorPickSunNoLives.Name = "ColorPickSunNoLives";
            this.ColorPickSunNoLives.Size = new System.Drawing.Size(84, 23);
            this.ColorPickSunNoLives.TabIndex = 95;
            this.ColorPickSunNoLives.Text = "Pick Color";
            this.ColorPickSunNoLives.UseVisualStyleBackColor = true;
            this.ColorPickSunNoLives.Click += new System.EventHandler(this.ColorPickSunNoLives_Click);
            // 
            // NoLivesColorCB
            // 
            this.NoLivesColorCB.AutoSize = true;
            this.NoLivesColorCB.Location = new System.Drawing.Point(6, 58);
            this.NoLivesColorCB.Name = "NoLivesColorCB";
            this.NoLivesColorCB.Size = new System.Drawing.Size(95, 17);
            this.NoLivesColorCB.TabIndex = 93;
            this.NoLivesColorCB.Text = "No Lives Color";
            this.NoLivesColorCB.CheckedChanged += new System.EventHandler(this.NoLivesColorCB_CheckedChanged);
            // 
            // NoLivesColorTB
            // 
            this.NoLivesColorTB.Enabled = false;
            this.NoLivesColorTB.Location = new System.Drawing.Point(6, 74);
            this.NoLivesColorTB.Name = "NoLivesColorTB";
            this.NoLivesColorTB.Size = new System.Drawing.Size(100, 20);
            this.NoLivesColorTB.TabIndex = 94;
            // 
            // ColorPickSunMaxLives
            // 
            this.ColorPickSunMaxLives.Enabled = false;
            this.ColorPickSunMaxLives.Location = new System.Drawing.Point(112, 33);
            this.ColorPickSunMaxLives.Name = "ColorPickSunMaxLives";
            this.ColorPickSunMaxLives.Size = new System.Drawing.Size(84, 23);
            this.ColorPickSunMaxLives.TabIndex = 92;
            this.ColorPickSunMaxLives.Text = "Pick Color";
            this.ColorPickSunMaxLives.UseVisualStyleBackColor = true;
            this.ColorPickSunMaxLives.Click += new System.EventHandler(this.ColorPickSunMaxLives_Click);
            // 
            // MaxLivesCB
            // 
            this.MaxLivesCB.AutoSize = true;
            this.MaxLivesCB.Location = new System.Drawing.Point(6, 19);
            this.MaxLivesCB.Name = "MaxLivesCB";
            this.MaxLivesCB.Size = new System.Drawing.Size(101, 17);
            this.MaxLivesCB.TabIndex = 91;
            this.MaxLivesCB.Text = "Max Lives Color";
            this.MaxLivesCB.CheckedChanged += new System.EventHandler(this.MaxLivesCB_CheckedChanged);
            // 
            // MaxLivesColorTB
            // 
            this.MaxLivesColorTB.Enabled = false;
            this.MaxLivesColorTB.Location = new System.Drawing.Point(6, 35);
            this.MaxLivesColorTB.Name = "MaxLivesColorTB";
            this.MaxLivesColorTB.Size = new System.Drawing.Size(100, 20);
            this.MaxLivesColorTB.TabIndex = 91;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(252, 116);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(17, 13);
            this.label34.TabIndex = 78;
            this.label34.Text = "Z:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(162, 115);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(17, 13);
            this.label35.TabIndex = 76;
            this.label35.Text = "Y:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(68, 115);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(17, 13);
            this.label36.TabIndex = 74;
            this.label36.Text = "X:";
            // 
            // ScaleCB
            // 
            this.ScaleCB.AutoSize = true;
            this.ScaleCB.Location = new System.Drawing.Point(3, 114);
            this.ScaleCB.Name = "ScaleCB";
            this.ScaleCB.Size = new System.Drawing.Size(56, 17);
            this.ScaleCB.TabIndex = 73;
            this.ScaleCB.Text = "Scale:";
            this.ScaleCB.CheckedChanged += new System.EventHandler(this.ScaleCB_CheckedChanged);
            // 
            // ScaleXNUD
            // 
            this.ScaleXNUD.DecimalPlaces = 2;
            this.ScaleXNUD.Enabled = false;
            this.ScaleXNUD.Location = new System.Drawing.Point(91, 113);
            this.ScaleXNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ScaleXNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ScaleXNUD.Name = "ScaleXNUD";
            this.ScaleXNUD.Size = new System.Drawing.Size(58, 20);
            this.ScaleXNUD.TabIndex = 72;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(252, 90);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 13);
            this.label30.TabIndex = 71;
            this.label30.Text = "Z:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(162, 89);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 13);
            this.label31.TabIndex = 69;
            this.label31.Text = "Y:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(68, 89);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(17, 13);
            this.label32.TabIndex = 67;
            this.label32.Text = "X:";
            // 
            // RotationCB
            // 
            this.RotationCB.AutoSize = true;
            this.RotationCB.Location = new System.Drawing.Point(3, 88);
            this.RotationCB.Name = "RotationCB";
            this.RotationCB.Size = new System.Drawing.Size(69, 17);
            this.RotationCB.TabIndex = 66;
            this.RotationCB.Text = "Rotation:";
            this.RotationCB.CheckedChanged += new System.EventHandler(this.RotationCB_CheckedChanged);
            // 
            // RotationXNUD
            // 
            this.RotationXNUD.DecimalPlaces = 2;
            this.RotationXNUD.Enabled = false;
            this.RotationXNUD.Location = new System.Drawing.Point(91, 87);
            this.RotationXNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.RotationXNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.RotationXNUD.Name = "RotationXNUD";
            this.RotationXNUD.Size = new System.Drawing.Size(58, 20);
            this.RotationXNUD.TabIndex = 65;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(252, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 13);
            this.label29.TabIndex = 64;
            this.label29.Text = "Z:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(162, 63);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 13);
            this.label28.TabIndex = 62;
            this.label28.Text = "Y:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(68, 63);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 13);
            this.label27.TabIndex = 60;
            this.label27.Text = "X:";
            // 
            // PositionCB
            // 
            this.PositionCB.AutoSize = true;
            this.PositionCB.Location = new System.Drawing.Point(3, 62);
            this.PositionCB.Name = "PositionCB";
            this.PositionCB.Size = new System.Drawing.Size(66, 17);
            this.PositionCB.TabIndex = 59;
            this.PositionCB.Text = "Position:";
            this.PositionCB.CheckedChanged += new System.EventHandler(this.PositionCB_CheckedChanged);
            // 
            // PositionXNUD
            // 
            this.PositionXNUD.DecimalPlaces = 2;
            this.PositionXNUD.Enabled = false;
            this.PositionXNUD.Location = new System.Drawing.Point(91, 61);
            this.PositionXNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PositionXNUD.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.PositionXNUD.Name = "PositionXNUD";
            this.PositionXNUD.Size = new System.Drawing.Size(58, 20);
            this.PositionXNUD.TabIndex = 56;
            // 
            // ParticleEmitterRB
            // 
            this.ParticleEmitterRB.AutoSize = true;
            this.ParticleEmitterRB.Location = new System.Drawing.Point(463, 37);
            this.ParticleEmitterRB.Name = "ParticleEmitterRB";
            this.ParticleEmitterRB.Size = new System.Drawing.Size(93, 17);
            this.ParticleEmitterRB.TabIndex = 55;
            this.ParticleEmitterRB.TabStop = true;
            this.ParticleEmitterRB.Text = "particle emitter";
            this.ParticleEmitterRB.UseVisualStyleBackColor = true;
            this.ParticleEmitterRB.CheckedChanged += new System.EventHandler(this.ParticleEmitterRB_CheckedChanged);
            // 
            // SatelliteRB
            // 
            this.SatelliteRB.AutoSize = true;
            this.SatelliteRB.Location = new System.Drawing.Point(463, 21);
            this.SatelliteRB.Name = "SatelliteRB";
            this.SatelliteRB.Size = new System.Drawing.Size(60, 17);
            this.SatelliteRB.TabIndex = 54;
            this.SatelliteRB.TabStop = true;
            this.SatelliteRB.Text = "satellite";
            this.SatelliteRB.UseVisualStyleBackColor = true;
            this.SatelliteRB.CheckedChanged += new System.EventHandler(this.SatelliteRB_CheckedChanged);
            // 
            // SunRB
            // 
            this.SunRB.AutoSize = true;
            this.SunRB.Location = new System.Drawing.Point(463, 6);
            this.SunRB.Name = "SunRB";
            this.SunRB.Size = new System.Drawing.Size(42, 17);
            this.SunRB.TabIndex = 53;
            this.SunRB.TabStop = true;
            this.SunRB.Text = "sun";
            this.SunRB.UseVisualStyleBackColor = true;
            this.SunRB.CheckedChanged += new System.EventHandler(this.SunRB_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 13);
            this.label25.TabIndex = 52;
            this.label25.Text = "EnvObj ID";
            // 
            // EnvObjTB
            // 
            this.EnvObjTB.Location = new System.Drawing.Point(6, 25);
            this.EnvObjTB.Name = "EnvObjTB";
            this.EnvObjTB.Size = new System.Drawing.Size(100, 20);
            this.EnvObjTB.TabIndex = 51;
            // 
            // CopyEOC
            // 
            this.CopyEOC.Enabled = false;
            this.CopyEOC.Location = new System.Drawing.Point(841, 407);
            this.CopyEOC.Name = "CopyEOC";
            this.CopyEOC.Size = new System.Drawing.Size(75, 23);
            this.CopyEOC.TabIndex = 50;
            this.CopyEOC.Text = "Copy All";
            this.CopyEOC.UseVisualStyleBackColor = true;
            this.CopyEOC.Click += new System.EventHandler(this.CopyEOC_Click);
            // 
            // ModifyEOC
            // 
            this.ModifyEOC.AutoSize = true;
            this.ModifyEOC.Location = new System.Drawing.Point(842, 9);
            this.ModifyEOC.Name = "ModifyEOC";
            this.ModifyEOC.Size = new System.Drawing.Size(74, 17);
            this.ModifyEOC.TabIndex = 49;
            this.ModifyEOC.Text = "Modifiable";
            this.ModifyEOC.UseVisualStyleBackColor = true;
            this.ModifyEOC.CheckedChanged += new System.EventHandler(this.ModifyEOC_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(630, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "Preview";
            // 
            // ConfigPreviewEOC
            // 
            this.ConfigPreviewEOC.DetectUrls = false;
            this.ConfigPreviewEOC.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigPreviewEOC.Location = new System.Drawing.Point(631, 26);
            this.ConfigPreviewEOC.Name = "ConfigPreviewEOC";
            this.ConfigPreviewEOC.ReadOnly = true;
            this.ConfigPreviewEOC.Size = new System.Drawing.Size(287, 375);
            this.ConfigPreviewEOC.TabIndex = 47;
            this.ConfigPreviewEOC.Text = "Choose the settings you want then click \"Create\" when you\'re ready!";
            // 
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            this.ColorDialog.FullOpen = true;
            this.ColorDialog.ShowHelp = true;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FramesPerSecondNUDESA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePerFrameNUDESA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoopAmountNUDESA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeNUDESA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeNUDESA)).EndInit();
            this.EOCTab.ResumeLayout(false);
            this.EOCTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnvSpriteSpeedNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakeMultipleCopiesNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveTimeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnTimeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleYNUD)).EndInit();
            this.ParticleEmitterGroupBox.ResumeLayout(false);
            this.ParticleEmitterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterPPBNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterInputNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterSizeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterEmissionNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterGravityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleEmitterSpeedNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationYNUD)).EndInit();
            this.SatelliteGroupBox.ResumeLayout(false);
            this.SatelliteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteMinimumVertexDistanceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteTrailWidthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteTrailTimeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteRotationSpeedNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteRadiusNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteSensitivityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteLerpSpeedNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteEmissionNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatelliteInputNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionYNUD)).EndInit();
            this.SunGroupBox.ResumeLayout(false);
            this.SunGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionVectorZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionVectorYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionVectorXNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMaxSizeZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMaxSizeYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMaxSizeXNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMinSizeZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMinSizeYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunSensitivityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunMinSizeXNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunLerpNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunInputNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunEmissionNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleXNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationXNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionXNUD)).EndInit();
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
        private TabPage EOCTab;
        private Button CopyEOC;
        private CheckBox ModifyEOC;
        private Label label24;
        private RichTextBox ConfigPreviewEOC;
        private Label label25;
        private TextBox EnvObjTB;
        private RadioButton ParticleEmitterRB;
        private RadioButton SatelliteRB;
        private RadioButton SunRB;
        private CheckBox ParentIDCB;
        private TextBox ParentIDTB;
        private CheckBox RemoveTimeCB;
        private Label SpawnTimeCB;
        private NumericUpDown RemoveTimeNUD;
        private NumericUpDown SpawnTimeNUD;
        private NumericUpDown ScaleZNUD;
        private NumericUpDown RotationZNUD;
        private NumericUpDown ScaleYNUD;
        private GroupBox ParticleEmitterGroupBox;
        private NumericUpDown RotationYNUD;
        private GroupBox SatelliteGroupBox;
        private NumericUpDown PositionYNUD;
        private GroupBox SunGroupBox;
        private Label label34;
        private Label label35;
        private Label label36;
        private CheckBox ScaleCB;
        private NumericUpDown ScaleXNUD;
        private Label label30;
        private Label label31;
        private Label label32;
        private CheckBox RotationCB;
        private NumericUpDown RotationXNUD;
        private Label label29;
        private Label label28;
        private Label label27;
        private CheckBox PositionCB;
        private NumericUpDown PositionXNUD;
        private ColorDialog ColorDialog;
        private CheckBox MaxLivesCB;
        private TextBox MaxLivesColorTB;
        private Button ColorPickSunNoLives;
        private CheckBox NoLivesColorCB;
        private TextBox NoLivesColorTB;
        private Button ColorPickSunMaxLives;
        private NumericUpDown SunEmissionNUD;
        private CheckBox SunEmissionCB;
        private CheckBox SunInputCB;
        private NumericUpDown SunInputNUD;
        private CheckBox SunLerpSpeedCB;
        private NumericUpDown SunLerpNUD;
        private CheckBox SunMaxSizeCB;
        private NumericUpDown SunMaxSizeZNUD;
        private NumericUpDown SunMaxSizeYNUD;
        private NumericUpDown SunMaxSizeXNUD;
        private CheckBox SunMinSizeCB;
        private NumericUpDown SunMinSizeZNUD;
        private CheckBox SunSensivityCB;
        private NumericUpDown SunMinSizeYNUD;
        private NumericUpDown SunSensitivityNUD;
        private NumericUpDown SunMinSizeXNUD;
        private Button CreateEnvObjButton;
        private CheckBox SunDirectionVectorCB;
        private NumericUpDown DirectionVectorZNUD;
        private NumericUpDown DirectionVectorYNUD;
        private NumericUpDown DirectionVectorXNUD;
        private NumericUpDown ParticleEmitterPPBNUD;
        private CheckBox ParticleEmitterColorCB;
        private CheckBox ParticleEmitterSizeCB;
        private NumericUpDown ParticleEmitterInputNUD;
        private CheckBox ParticleEmitterPPBCB;
        private CheckBox ParticleEmitterEmissionCB;
        private NumericUpDown ParticleEmitterSizeNUD;
        private CheckBox ParticleEmitterSpeedCB;
        private NumericUpDown ParticleEmitterEmissionNUD;
        private Button ColorPickParticleEmitter;
        private NumericUpDown ParticleEmitterGravityNUD;
        private NumericUpDown ParticleEmitterSpeedNUD;
        private TextBox ParticleEmitterColorTB;
        private CheckBox ParticleEmitterGravityCB;
        private NumericUpDown SatelliteMinimumVertexDistanceNUD;
        private NumericUpDown SatelliteTrailWidthNUD;
        private CheckBox SatelliteMinimumVertexCB;
        private CheckBox SatellieTrailWidthCB;
        private CheckBox SatelliteTrailFadeTimeCB;
        private NumericUpDown SatelliteTrailTimeNUD;
        private NumericUpDown SatelliteRotationSpeedNUD;
        private CheckBox SatelliteRadiusCB;
        private CheckBox SatelliteRotationCB;
        private NumericUpDown SatelliteRadiusNUD;
        private CheckBox SatelliteSensitivityCB;
        private Button ColorPickSatellite;
        private NumericUpDown SatelliteSensitivityNUD;
        private CheckBox SatelliteColorCB;
        private CheckBox SatelliteLerpSpeedCB;
        private TextBox SatelliteColorTB;
        private NumericUpDown SatelliteLerpSpeedNUD;
        private NumericUpDown SatelliteEmissionNUD;
        private CheckBox SatelliteTypeCB;
        private CheckBox SatelliteEmissionCB;
        private NumericUpDown SatelliteInputNUD;
        private CheckBox ParticleEmitterTypeCB;
        private NumericUpDown PositionZNUD;
        private Button button1;
        private CheckBox MakeMultipleCopiesCB;
        private NumericUpDown MakeMultipleCopiesNUD;
        private CheckBox CreateNewObjectsCB;
        private TabPage tabPage1;
        private CheckBox EndTimeCBESA;
        private NumericUpDown EndTimeNUDESA;
        private Label label37;
        private NumericUpDown StartTimeNUDESA;
        private RichTextBox FramesESARTB;
        private Label label26;
        private TextBox SpriteIDESATB;
        private Button button2;
        private CheckBox checkBox1;
        private Label label33;
        private RichTextBox PreviewRTBESA;
        private CheckBox LoopAmountCBESA;
        private NumericUpDown LoopAmountNUDESA;
        private Label label38;
        private CheckBox FramesPerSecondCBESA;
        private NumericUpDown FramesPerSecondNUDESA;
        private Label label39;
        private CheckBox FrameTimeCBESA;
        private NumericUpDown TimePerFrameNUDESA;
        private LinkLabel linkLabel2;
        private Button CreateButtonESA;
        private Label label40;
        private CheckBox MirrorZCB;
        private CheckBox MirrorYCB;
        private CheckBox MirrorXCB;
        private GroupBox groupBox1;
        private TrackBar trackBar1;
        private Label label41;
        private Button button3;
        private TextBox EnvSpriteColorTB;
        private RadioButton EnvSpriteRB;
        private NumericUpDown EnvSpriteSpeedNUD;
        private Label Speed;
    }
}