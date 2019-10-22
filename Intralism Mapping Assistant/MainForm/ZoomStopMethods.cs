using Intralism_Mapping_Assistant.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private Point oldLocation = Point.Empty;

        private void ChangeZoomStopOutputLabel(string text)
        {
            // Set to the text
            ZoomStopOutputLabel.Text = text;

            // Move down, since it's default text was 2 lines, now it should be one line.
            if (oldLocation == Point.Empty)
                oldLocation = ZoomStopOutputLabel.Location;

            ZoomStopOutputLabel.Location = new Point (oldLocation.X, oldLocation.Y + 12);
        }

        private void ChangeSelectionZSC()
        {
            Event currentEvent = MakeEventFromText(ConfigPreviewRTBZSC.SelectedText);

            if (currentEvent == null)
                return;
            else if (currentEvent.GetTypeString() != "SetPlayerDistance")
            {
                ErrorMessage("The selected event is not a zoom event!");
                return;
            }

            // Determine which part needs to be changed
            switch (ZoomStopOutputLabel.Text)
            {
                case "First Event Time":
                    ChangeTimeFor(currentEvent);
                    break;
                case "First Event Distance":
                    ChangeDistanceFor(currentEvent);
                    break;
                case "Second Event Time":
                    ChangeTimeFor(currentEvent);
                    break;
                case "Second Event Distance":
                    ChangeDistanceFor(currentEvent);
                    break;
                default:
                    ErrorMessage("Unknown error. Please try again. If this problem persists please let the developer know about this issue!");
                    break;
            }

            // Turn the event into a string and replace the selected text with it.
            ConfigPreviewRTBZSC.SelectedText = currentEvent.ToString();
            // Select and focus on this changed text.
            SelectPrevZoomEvent(ConfigPreviewRTBZSC);
        }

        private void ResetSelectionZSC()
        {
            Map map = MakeMapFromText(ConfigPreviewRTBZSC.Text);

            // If map equals null, then there's the Error Message from earlier displayed, and we don't need to worry about the rest of this method.
            if (map == null)
                return;

            // If the user has changed the textbox too much, show an error saying we can't easily reset it.
            if (map.events.Length != CurrentMap.events.Length)
            {
                ErrorMessage("You have made too many changes to accurately reset this event!\nYou can use CTRL+Z in the text box to undo your previous actions.");
                return;
            }

            Event currentEvent = MakeEventFromText(ConfigPreviewRTBZSC.SelectedText);

            if (currentEvent == null)
                return;
            else if (currentEvent.GetTypeString() != "SetPlayerDistance")
            {
                ErrorMessage("The selected event is not a zoom event!");
                return;
            }

            // Index of the event
            int i;
            for (i = 0; i < map.events.Length; i++)
            {
                // If these events match, we know we found the index.
                if (currentEvent.Equals(map.events[i]))
                    break;
            }

            // Double check
            if (i > map.events.Length - 1)
            {
                ErrorMessage("You shouldn't be seeing this message!");
                return;
            }

            // Turn this event into its equivalent in the CurrentMap
            ConfigPreviewRTBZSC.SelectedText = CurrentMap.events[i].ToString();
            SelectPrevZoomEvent(ConfigPreviewRTBZSC);
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

            ModifySelectedZoomZSC.Enabled = true;
            ResetSelectedZoomZSC.Enabled = true;

            OutputBox.Text = "";
        }

        private void FindFET()
        {
            // Not implemented (yet)
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
