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
        {
            System.Diagnostics.Process.Start("https://github.com/FlyingRabidUnicornPig/Intralism-Mapping-Assistant");
        }

        private void AdvancedFrameRateCalc_CheckedChanged(object sender, EventArgs e)
        {
            CustomFrameRate.Enabled = AdvancedFrameRateCalc.Checked;

            if (!CustomFrameRate.Enabled)
                CustomFrameRate.Value = 1000;
        }

        private void AdvancedCustomRangeCalc_CheckedChanged(object sender, EventArgs e)
        {
            CustomRangeZSCalc.Enabled = AdvancedCustomRangeCalc.Checked;

            if (!CustomRangeZSCalc.Enabled)
                CustomRangeZSCalc.Value = 500;
        }

        private void ModifyConfigPreviewZEM_CheckedChanged(object sender, EventArgs e)
        {
            ConfigPreviewRTBZEM.ReadOnly = !ModifyConfigPreviewZEM.Checked;
        }

        private void DestructiveCheckZEM_CheckedChanged(object sender, EventArgs e)
        {
            DeleteAllZoomsButton.Enabled = DestructiveCheckZEM.Checked && DeleteZoomsButtonActivated;
        }

        private void LoadMapButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = BrowseForMapFolder.ShowDialog();

            if (dialogResult == DialogResult.OK)
                AddressBox.Text = BrowseForMapFolder.SelectedPath;
            else if (dialogResult == DialogResult.Cancel)
                return;
        }

        private void DeleteAllZooms_Click(object sender, EventArgs e)
        {
            DeleteZooms();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (!IsAddressBoxLegal())
            {
                ErrorMessage("Please provide a proper directory address!");
                return;
            }

            UpdateAllRTBs();
            UpdateModifiedTracker();
            ActivateButtons();
        }
    }
}
