using System;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalcFED_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("First Event Distance");
            ReactivateAllZoomStopBoxes();
            FirstEventDistanceBox.Enabled = false;
        }

        private void CalcSET_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("Second Event Time");
            ReactivateAllZoomStopBoxes();
            SecondEventTimeBox.Enabled = false;
        }

        private void CalcSED_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("Second Event Distance");
            ReactivateAllZoomStopBoxes();
            SecondEventDistanceBox.Enabled = false;
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
        }
    }
}
