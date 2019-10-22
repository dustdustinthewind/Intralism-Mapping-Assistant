using Intralism_Mapping_Assistant.Util;
using System;
using System.IO;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    public partial class MainForm : Form
    {
        private string LoadedMapFolderLocation;

        private Map CurrentMap
        {
            get
            {
                return MakeMapFromPath(LoadedMapFolderLocation + @"\config.txt");
            }
        }

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
    }
}
