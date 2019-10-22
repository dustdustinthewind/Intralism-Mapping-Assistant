using Intralism_Mapping_Assistant.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private void SplitAfterSelectedEvent()
        {
            // Make an event from the text
            Event evnt = MakeEventFromText(SplitConfigPart1.SelectedText);

            if (evnt == null)
                return;

            // Make a map from the text
            Map originalMap = MakeMapFromText(SplitConfigPart1.Text);

            if (originalMap == null)
                return;

            // Find the split index
            int splitIndex = -1;
            for (int i = 0; i < originalMap.events.Length; i++)
            {
                // If these events match, we know we found the index.
                if (evnt.Equals(originalMap.events[i]))
                {
                    splitIndex = i;
                    break;
                }
            }

            // Double check
            if (splitIndex < 0)
                ErrorMessage("You shouldn't be seeing this!");

            // Copy the map
            Map map1 = MakeMapFromText(MakeTextFromMap(originalMap));
            Map map2 = MakeMapFromText(MakeTextFromMap(originalMap));

            // Find the events for the first split
            List<Event> firstMapEvents = new List<Event>();

            for (int i = 0; i <= splitIndex; i++)
                firstMapEvents.Add(originalMap.events[i]);
            map1.events = firstMapEvents.ToArray();

            double offset;

            try
            {
                offset = map1.events.Last().time;
            }
            catch
            {
                ErrorMessage("You shouldn't be seeing this!");
                return;
            }

            AudioOffsetSplitter.Text = Math.Round(offset, 6).ToString();

            // Find the events for the second split
            List<Event> secondMapEvents = new List<Event>();

            for (int i = splitIndex; i < originalMap.events.Length; i++)
            {
                secondMapEvents.Add(originalMap.events[i]);
                secondMapEvents.Last().time -= offset;
                secondMapEvents.Last().time = Math.Round(secondMapEvents.Last().time, 6);
            }
            map2.events = secondMapEvents.ToArray();

            SplitConfigPart1.Text = MakeTextFromMap(map1);
            SplitConfigPart2.Text = MakeTextFromMap(map2);
        }

        private void SplitAtHalf()
        {
            Map originalMap = MakeMapFromText(SplitConfigPart1.Text);

            if (originalMap == null)
                return;

            int half = originalMap.events.Length / 2;

            string halfString = originalMap.events[half].ToString();

            int i = SplitConfigPart1.Text.IndexOf(halfString);
            SelectEvent(SplitConfigPart1, i, true);
            SplitAfterSelectedEvent();
        }

        private void SplitAtTime(double time)
        {
            Map originalMap = MakeMapFromText(SplitConfigPart1.Text);

            if (originalMap == null)
                return;

            Event closestEvent = originalMap.events.First();

            foreach (Event evnt in originalMap.events)
            {
                if (evnt.time > time)
                    break;
                closestEvent = evnt;
            }

            int i = SplitConfigPart1.Text.IndexOf(closestEvent.ToString());
            SelectEvent(SplitConfigPart1, i, true);
            SplitAfterSelectedEvent();
        }
    }
}
