using Intralism_Mapping_Assistant.Util;
using System;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private void MakeAllEventsHand(int hand)
        {
            Map map = CurrentMap;

            for (int i = 0; i < CurrentMap.events.Length; i++)
                map.events[i] = MakeEventHand(map.events[i], hand);

            ConfigPreviewRTBHS.Text = MakeTextFromMap(map);
        }

        private Event MakeEventHand(Event evnt, int hand)
        {
            if (evnt.GetTypeString() != "SpawnObj")
                return evnt;

            evnt.data[1] = evnt.data[1].Replace(",", "").Replace("1", "").Replace("2", "");
                
            if (hand != 0)
                evnt.data[1] += "," + hand.ToString();

            return evnt;
        }

        private void InvertHandOfAllEvents()
        {
            Map map = CurrentMap;

            for (int i = 0; i < CurrentMap.events.Length; i++)
                map.events[i] = InvertHandOfEvent(map.events[i]);

            ConfigPreviewRTBHS.Text = MakeTextFromMap(map);
        }

        private Event InvertHandOfEvent(Event evnt)
        {
            if (evnt.GetTypeString() != "SpawnObj")
                return evnt;

            int hand = int.Parse(evnt.data[1].Substring(evnt.data[1].Length - 1));

            switch (hand)
            {
                case 0:
                case 2:
                    hand = 1;
                    break;
                case 1:
                    hand = 2;
                    break;
                default:
                    hand = 0;
                    break;
            }

            return MakeEventHand(evnt, hand);
        }
    }
}
