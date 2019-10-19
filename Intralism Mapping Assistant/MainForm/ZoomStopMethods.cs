using Intralism_Mapping_Utils.Util;
using System;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private void ChangeZoomStopOutputLabel(string text)
        {
            ZoomStopOutputLabel.Text = text;
        }

        private void ReactivateAllZoomStopBoxes()
        {
            StartingDistanceBox.Enabled = true;
            StartingDistanceBox.Value = 0;

            FirstEventTimeBox.Enabled = true;
            FirstEventTimeBox.Value = 0;

            FirstEventDistanceBox.Enabled = true;
            FirstEventDistanceBox.Value = 0;

            SecondEventTimeBox.Enabled = true;
            SecondEventTimeBox.Value = 0;

            SecondEventDistanceBox.Enabled = true;
            SecondEventDistanceBox.Value = 0;
        }

        private void FindFET()
        {
            return;
        }

        private void FindFED()
        {
            OutputBox.Text = "Calcuting...";

            decimal startingDistance = StartingDistanceBox.Value;
            decimal firstEventTime = FirstEventTimeBox.Value;
            decimal secondEventTime = SecondEventTimeBox.Value;
            decimal secondEventDistance = SecondEventDistanceBox.Value;

            decimal FPS = AdvancedFrameRateCalc.Checked ? CustomFrameRate.Value : 1000;

            decimal frameTime = (decimal)1d / FPS;
            decimal by = frameTime * (decimal)5d;

            // TODO make these "smarter" and more dynamic.
            // Right now the bruteforcing is too simplistic.
            // Making the bruteforce smarter can increase performance and provide
            // more accurate results.
            decimal range = CustomRangeZSCalc.Enabled ? CustomRangeZSCalc.Value : 500m;
            decimal step = .025m;

            decimal currentFED = secondEventDistance - range / 2m;
            decimal lastCurrentFED = currentFED - step;

            decimal lastCurrentDistance = 100000000m;

            while (currentFED < secondEventDistance + range / 2m)
            {
                decimal currentDistance = startingDistance;
                currentDistance = IMAMath.Lerp(currentDistance, currentFED, by);

                decimal time = firstEventTime + frameTime;

                while (time < secondEventTime)
                {
                    currentDistance = IMAMath.Lerp(currentDistance, currentFED, by);

                    time += frameTime;
                }

                decimal currentDelta = currentDistance - secondEventDistance;
                decimal lastDelta = lastCurrentDistance - secondEventDistance;

                if (Math.Abs(currentDelta) > Math.Abs(lastDelta))
                {
                    OutputBox.Text = Math.Round(lastCurrentFED, 3).ToString();
                    return;
                }

                lastCurrentFED = currentFED;
                currentFED += step;

                lastCurrentDistance = currentDistance;
            }

            OutputBox.Text = "Calculation Failed!";
        }

        private void FindSET()
        {
            OutputBox.Text = "Calculating...";

            decimal startingDistance = StartingDistanceBox.Value;
            decimal firstEventTime = FirstEventTimeBox.Value;
            decimal firstEventDistance = FirstEventDistanceBox.Value;
            decimal secondEventDistance = SecondEventDistanceBox.Value;

            decimal FPS = AdvancedFrameRateCalc.Checked ? CustomFrameRate.Value : 1000;

            decimal frameTime = 1m / FPS;
            decimal by = frameTime * 5m;

            decimal currentDistance = IMAMath.Lerp(startingDistance, firstEventDistance, by);

            decimal lastDeltaDistance = startingDistance - secondEventDistance;
            decimal deltaDistance = currentDistance - secondEventDistance;

            decimal time = firstEventTime + frameTime;

            while (Math.Abs(deltaDistance) < Math.Abs(lastDeltaDistance))
            {
                currentDistance = IMAMath.Lerp(currentDistance, firstEventDistance, by);

                lastDeltaDistance = deltaDistance;
                deltaDistance = currentDistance - secondEventDistance;

                time += frameTime;
            }

            OutputBox.Text = Math.Round(time, 5).ToString();
        }

        private void FindSED()
        {
            OutputBox.Text = "Calculating...";

            decimal startingDistance = StartingDistanceBox.Value;
            decimal firstEventTime = FirstEventTimeBox.Value;
            decimal firstEventDistance = FirstEventDistanceBox.Value;
            decimal secondEventTime = SecondEventTimeBox.Value;

            decimal FPS = AdvancedFrameRateCalc.Checked ? CustomFrameRate.Value : 1000;

            decimal frameTime = (decimal)1d / FPS;
            decimal by = frameTime * (decimal)5d;

            decimal currentDistance = startingDistance;
            currentDistance = IMAMath.Lerp(currentDistance, firstEventDistance, by);

            decimal time = firstEventTime + frameTime;

            while (time < secondEventTime)
            {
                currentDistance = IMAMath.Lerp(currentDistance, firstEventDistance, by);

                time += frameTime;
            }

            OutputBox.Text = Math.Round(currentDistance, 3).ToString();
        }
    }
}
