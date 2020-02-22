using Intralism_Mapping_Assistant.Util;
using System;
using System.IO;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    public partial class MainForm : Form
    {
        private string LoadedMapFolderLocation;

        // TODO: Make a "LoadedMap" for loading from config and a "CurrentMap" for whatever is
        // in the currently active TextBox
        private Map CurrentMap => MakeMapFromPath(LoadedMapFolderLocation + @"\config.txt");

        private bool Config3 = false;

        private bool DeleteZoomsButtonActivated = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalcFED_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("First Event Distance");
            ReactivateAllZoomStopBoxes();
            FirstEventDistanceBox.Enabled = false;
            ZoomStopCalculate.Enabled = true;
        }

        private void CalcSET_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("Second Event Time");
            ReactivateAllZoomStopBoxes();
            SecondEventTimeBox.Enabled = false;
            ZoomStopCalculate.Enabled = true;
        }

        private void CalcSED_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("Second Event Distance");
            ReactivateAllZoomStopBoxes();
            SecondEventDistanceBox.Enabled = false;
            ZoomStopCalculate.Enabled = true;
        }

        private void ZoomStopCalculate_Click(object sender, EventArgs e)
        {
            if (!StartingDistanceBox.Enabled)
                return;

            if (!FirstEventDistanceBox.Enabled)
                FindFED();

            if (!FirstEventTimeBox.Enabled)
                FindFET();

            if (!SecondEventDistanceBox.Enabled)
                FindSED();

            if (!SecondEventTimeBox.Enabled)
                FindSET();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => System.Diagnostics.Process.Start("https://github.com/FlyingRabidUnicornPig/Intralism-Mapping-Assistant");

        private void AdvancedFrameRateCalc_CheckedChanged(object sender, EventArgs e)
            => CustomFrameRate.Enabled = AdvancedFrameRateCalc.Checked;

        private void AdvancedCustomRangeCalc_CheckedChanged(object sender, EventArgs e)
            => CustomRangeZSCalc.Enabled = AdvancedCustomRangeCalc.Checked;

        private void ModifyConfigPreviewZEM_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewZEM, ConfigPreviewRTBZEM);

        private void ModifyConfigPreviewZSC_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewZSC, ConfigPreviewRTBZSC);

        private void ModifyConfigPreviewSCP1_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewSCP1, SplitConfigPart1);

        private void ModifyConfigPreviewSCP2_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewSCP2, SplitConfigPart2);

        private void DestructiveCheckZEM_CheckedChanged(object sender, EventArgs e)
            => DeleteAllZoomsButton.Enabled = DestructiveCheckZEM.Checked && DeleteZoomsButtonActivated;

        private void LoadMapButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = BrowseForMapFolder.ShowDialog();

            if (dialogResult == DialogResult.OK)
                AddressBox.Text = BrowseForMapFolder.SelectedPath;
            else if (dialogResult == DialogResult.Cancel)
                return;
        }

        private void DeleteAllZooms_Click(object sender, EventArgs e)
            => DeleteZooms();

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (!IsAddressBoxLegal())
            {
                ErrorMessage("Please provide a proper directory address!");
                return;
            }

            UpdateAllRTBs();
            UpdateModifiedTracker();
            ActivateEverythingElse();
        }

        private void CopyPreviewBox_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewRTBZEM.Text);

        private void CopyPreviewBoxZSC_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewRTBZSC.Text);

        private void CopySCP1_Click(object sender, EventArgs e)
            => Copy(SplitConfigPart1.Text);

        private void CopySCP2_Click(object sender, EventArgs e)
            => Copy(SplitConfigPart2.Text);

        private void CopyAudioOffsetSplit_Click(object sender, EventArgs e)
            => Copy(AudioOffsetSplitter.Text);

        private void CopyEOC_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewEOC.Text);

        private void FindPrevZoomZSC_Click(object sender, EventArgs e)
            => SelectPrevZoomEvent(ConfigPreviewRTBZSC);

        private void FindNextZoomZSC_Click(object sender, EventArgs e)
            => SelectNextZoomEvent(ConfigPreviewRTBZSC);

        private void FindPrevZoomZEM_Click(object sender, EventArgs e)
            => SelectPrevZoomEvent(ConfigPreviewRTBZEM);

        private void FindNextZoomZEM_Click(object sender, EventArgs e)
            => SelectNextZoomEvent(ConfigPreviewRTBZEM);

        private void FindPrevEventSCP1_Click(object sender, EventArgs e)
            => SelectPrevEvent(SplitConfigPart1);

        private void FindNextEventSCP1_Click(object sender, EventArgs e)
            => SelectNextEvent(SplitConfigPart1);

        private void FindPrevEventSCP2_Click(object sender, EventArgs e)
            => SelectPrevEvent(SplitConfigPart2);

        private void FindNextEventSCP2_Click(object sender, EventArgs e)
            => SelectNextEvent(SplitConfigPart2);

        private void ModifySelectedZoomZSC_Click(object sender, EventArgs e)
            => ChangeSelectionZSC();

        private void ResetSelectedZoomZSC_Click(object sender, EventArgs e)
            => ResetSelectionZSC();

        private void SplitAfterEventButton_Click(object sender, EventArgs e)
            => SplitAfterSelectedEvent();

        private void SplitAtHalfButton_Click(object sender, EventArgs e)
            => SplitAtHalf();

        private void SplitAtTimeButton_Click(object sender, EventArgs e)
            => SplitAtTime((double)SplitTimeSelect.Value);

        private void ModifyConfigPreviewHS_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewHS, ConfigPreviewRTBHS);

        private void CopyConfigPreviewHS_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewRTBHS.Text);

        private void HandOneButton_Click(object sender, EventArgs e)
            => MakeAllEventsHand(1);

        private void HandTwoButton_Click(object sender, EventArgs e)
            => MakeAllEventsHand(2);

        private void HandZeroButton_Click(object sender, EventArgs e)
            => MakeAllEventsHand(0);

        private void CreateEventsESM_Click(object sender, EventArgs e)
            => CreateEnvSpriteMovementEvents();

        private void ModifyConfigPreviewESM_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewESM, ConfigPreviewESMRTB);

        private void CopyConfigPreviewESM_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewESMRTB.Text);

        private void InvertHandButton_Click(object sender, EventArgs e)
            => InvertHandOfAllEvents();

        private void ModifyEOC_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyEOC, ConfigPreviewEOC);

        private void SunRB_CheckedChanged(object sender, EventArgs e)
            => ReactivatePropertyBoxes(EnvironmentObjectType.Sun);

        private void SatelliteRB_CheckedChanged(object sender, EventArgs e)
            => ReactivatePropertyBoxes(EnvironmentObjectType.Satellite);

        private void ParticleEmitterRB_CheckedChanged(object sender, EventArgs e)
            => ReactivatePropertyBoxes(EnvironmentObjectType.ParticleEmitter);

        private void ColorPickSunMaxLives_Click(object sender, EventArgs e)
            => FillTextBoxWithSelectedColorCode(MaxLivesColorTB);

        private void ColorPickSunNoLives_Click(object sender, EventArgs e)
            => FillTextBoxWithSelectedColorCode(NoLivesColorTB);

        private void ColorPickSatellite_Click(object sender, EventArgs e)
            => FillTextBoxWithSelectedColorCode(SatelliteColorTB);

        private void ColorPickParticleEmitter_Click(object sender, EventArgs e)
            => FillTextBoxWithSelectedColorCode(ParticleEmitterColorTB);

        private void ParentIDCB_CheckedChanged(object sender, EventArgs e)
            => ParentIDTB.Enabled = ParentIDCB.Checked;

        private void RemoveTimeCB_CheckedChanged(object sender, EventArgs e)
            => RemoveTimeNUD.Enabled = RemoveTimeCB.Checked;

        private void PositionCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { PositionXNUD, PositionYNUD, PositionZNUD }, PositionCB.Checked);

        private void RotationCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { RotationXNUD, RotationYNUD, RotationZNUD }, RotationCB.Checked);

        private void ScaleCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { ScaleXNUD, ScaleYNUD, ScaleZNUD }, ScaleCB.Checked);

        private void MaxLivesCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { MaxLivesColorTB, ColorPickSunMaxLives }, MaxLivesCB.Checked);

        private void NoLivesColorCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { NoLivesColorTB, ColorPickSunNoLives }, NoLivesColorCB.Checked);

        private void SunEmissionCB_CheckedChanged(object sender, EventArgs e)
            => SunEmissionNUD.Enabled = SunEmissionCB.Checked;

        private void SunInputCB_CheckedChanged(object sender, EventArgs e)
            => SunInputNUD.Enabled = SunInputCB.Checked;

        private void SunLerpSpeedCB_CheckedChanged(object sender, EventArgs e)
            => SunLerpNUD.Enabled = SunLerpSpeedCB.Checked;

        private void SunSensivityCB_CheckedChanged(object sender, EventArgs e)
            => SunSensitivityNUD.Enabled = SunSensivityCB.Checked;

        private void SunMinSizeCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus( new Control[] { SunMinSizeXNUD, SunMinSizeYNUD, SunMinSizeZNUD },
                                    SunMinSizeCB.Checked);

        private void SunMaxSizeCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus( new Control[] { SunMaxSizeXNUD, SunMaxSizeYNUD, SunMaxSizeZNUD },
                                    SunMaxSizeCB.Checked);

        private void SunDirectionVectorCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus( new Control[] { DirectionVectorXNUD, DirectionVectorYNUD, DirectionVectorZNUD },
                                    SunDirectionVectorCB.Checked);

        private void SatelliteColorCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { SatelliteColorTB, ColorPickSatellite }, SatelliteColorCB.Checked);

        private void SatelliteEmissionCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteEmissionNUD.Enabled = SatelliteEmissionCB.Checked;

        private void SatelliteTypeCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteInputNUD.Enabled = SatelliteTypeCB.Checked;

        private void SatelliteLerpSpeedCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteLerpSpeedNUD.Enabled = SatelliteLerpSpeedCB.Checked;

        private void SatelliteSensitivityCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteSensitivityNUD.Enabled = SatelliteSensitivityCB.Checked;

        private void SatelliteRotationCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteRotationSpeedNUD.Enabled = SatelliteRotationCB.Checked;

        private void SatelliteRadiusCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteRadiusNUD.Enabled = SatelliteRadiusCB.Checked;

        private void SatelliteTrailFadeTimeCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteTrailTimeNUD.Enabled = SatelliteTrailFadeTimeCB.Checked;

        private void SatellieTrailWidthCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteTrailWidthNUD.Enabled = SatellieTrailWidthCB.Checked;

        private void SatelliteMinimumVertexCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteMinimumVertexDistanceNUD.Enabled = SatelliteMinimumVertexCB.Checked;

        private void ParticleEmitterColorCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { ParticleEmitterColorTB, ColorPickParticleEmitter }, ParticleEmitterColorCB.Checked);

        private void ParticleEmitterEmissionCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterEmissionNUD.Enabled = ParticleEmitterEmissionCB.Checked;

        private void ParticleEmitterTypeCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterInputNUD.Enabled = ParticleEmitterTypeCB.Checked;

        private void ParticleEmitterGravityCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterGravityNUD.Enabled = ParticleEmitterGravityCB.Checked;

        private void ParticleEmitterSpeedCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterSpeedNUD.Enabled = ParticleEmitterSpeedCB.Checked;

        private void ParticleEmitterPPBCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterPPBNUD.Enabled = ParticleEmitterPPBCB.Checked;

        private void ParticleEmitterSizeCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterSizeNUD.Enabled = ParticleEmitterSizeCB.Checked;

        private void CreateEnvObjButton_Click(object sender, EventArgs e)
            => ConfigPreviewEOC.Text =
                ChangeEnvObjToString(CreateEnvironmentObjectWithCurrentSettings());
    }
}
