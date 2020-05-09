using Intralism_Mapping_Assistant.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private bool IsZoomEvent(Event evnt)
            => evnt.GetTypeString() == "SetPlayerDistance";

        private void DeleteZooms()
        {
            string textToParse = ConfigPreviewRTBZEM.Text;

            Map map = MakeMapFromText(textToParse);

            if (map == null)
                return;

            // Remove all Zoom Events from our Map object.
            map.events = map.events.Where(val => !IsZoomEvent(val)).ToArray();

            ConfigPreviewRTBZEM.Text = MakeTextFromMap(map);
        }

        private void DeleteNonZooms()
        {
            string textToParse = ConfigPreviewRTBZEM.Text;

            Map map = MakeMapFromText(textToParse);

            if (map == null) { return; }

            // Remove all non-zoom events from our map object
            map.events = map.events.Where(val => IsZoomEvent(val)).ToArray();

            ConfigPreviewRTBZEM.Text = MakeTextFromMap(map);
        }

        // Zoom Event Format:
        // {"time":[time],"data":["SetPlayerDistance","[distance]"]}
        private void AddLongZoomToConfig()
        {
            Event startZoom =
                new Event
                {
                    time = (double)ZEMLZStartTimeNUD.Value,
                    data = new string[]
                    {
                        "SetPlayerDistance",
                        ZEMLZStartZoomNUD.Value.ToString()
                    }
                };

            Event endZoom =
                new Event
                {
                    time = (double)ZEMLZEndTimeNUD.Value,
                    data = new string[]
                    {
                        "SetPlayerDistance",
                        ZEMLZEndZoomNUD.Value.ToString()
                    }
                };

            // Make sure there aren't any other zooms nearby (within 1ms) with the same zoom level.
            // If the user already added the key zooms in, we want to make sure we're using those
            string millesecondTime = startZoom.time.ToString("0.###");

            int[] currentlySelectedEvent = new int[]
            {
                ConfigPreviewRTBZEM.SelectionStart,
                ConfigPreviewRTBZEM.SelectionLength,
            };

            // If the time currently doesn't exist, then we know that there isn't a nearby time
            if (!ConfigPreviewRTBZEM.Text.Contains(millesecondTime))
            { }
            // But if that time does exist, we need to make sure its not a zoom event
            else
            {
                Event compareTo = FindEventToCompareTo(millesecondTime);
                if (compareTo.Equals(new Event())) { return; }

                if (compareTo.GetTypeString() == "SetPlayerDistance")
                {
                    startZoom.time = compareTo.time;

                    if (startZoom.GetEventData()[1].Equals(compareTo.GetEventData()[1]))
                    {
                        MessageBox.Show("There is a zoom event at the same time as your start zoom" +
                            " but they do not share the same zoom value. If you are sure you want to do" +
                            " that, please increase your start time by at least 1 millesecond.", "Are you sure about that?");

                        return;
                    }
                }
            }
            
            // Reselect what was selected previously.
            ConfigPreviewRTBZEM.SelectionStart = currentlySelectedEvent[0];
            ConfigPreviewRTBZEM.SelectionLength = currentlySelectedEvent[1];

            // Now that we've made sure we're using the right zoom, let's start making the long zoom.
            double zoomsPerSecond = (double)ZEMLZDesiredEventsPerSecNUD.Value;
            double timeBetweenEachZoom = 1d / zoomsPerSecond;

            double timeRange = (double)(ZEMLZEndTimeNUD.Value - ZEMLZStartTimeNUD.Value);
            int numberOfEvents = (int)Math.Ceiling(timeRange / timeBetweenEachZoom);

            double zoomRange = (double)(ZEMLZEndZoomNUD.Value - ZEMLZStartZoomNUD.Value);
            // Minus 1, the starting event.
            double zoomBetweenEachZoom = zoomRange / numberOfEvents - 1;

            double currentTime = startZoom.time + timeBetweenEachZoom;
            double currentZoom = double.Parse(startZoom.GetEventData()[1]);

            List<Event> events = new List<Event>();

            while (currentTime <= endZoom.time)
            {
                events.Add(
                    new Event()
                    {
                        time = currentTime,
                        data = new string[]
                        {
                            "SetPlayerDistance",
                            currentZoom.ToString(),
                        }
                    }
                );

                currentTime += timeBetweenEachZoom;
                currentZoom += zoomBetweenEachZoom;
            }

            // Replace end zoom from config (if it exists)
            if (currentTime > endZoom.time && ConfigPreviewRTBZEM.Text.Contains(endZoom.ToString()))
            {
                ConfigPreviewRTBZEM.Text.Replace(endZoom.ToString(),
                    new Event()
                    {
                        time = currentTime,
                        data = new string[]
                        {
                            "SetPlayerDistance",
                            currentZoom.ToString()
                        }
                    }.ToString());
            }
            // Otherwise add it to the events list
            else
            {
                events.Add(
                    new Event()
                    {
                        time = currentTime,
                        data = new string[]
                        {
                            "SetPlayerDistance",
                            currentZoom.ToString()
                        }
                    });
            }

            // Finally, add our list of Events to the events in the map.
            Map map = MakeMapFromText(ConfigPreviewRTBZEM.Text);
            // Get events from map
            List<Event> mapEvents = map.events.ToList();
            // Add our long zoom events
            mapEvents.AddRange(events);
            // Sort all events by time
            mapEvents.Sort((x, y) => x.time.CompareTo(y.time));
            // Insert back into map
            map.events = mapEvents.ToArray();
            // Turn new map w/ long zooms into text in the config preview
            ConfigPreviewRTBZEM.Text = MakeTextFromMap(map);
        }

        private Event FindEventToCompareTo(string millesecondTime)
        {
            // Select the event, from { to }
            int startIndex = ConfigPreviewRTBZEM.Text.IndexOf(millesecondTime);
            startIndex = ConfigPreviewRTBZEM.Text.LastIndexOf('{', startIndex);
            int endIndex = ConfigPreviewRTBZEM.Text.IndexOf('}', startIndex) + 1;

            // Select the text
            ConfigPreviewRTBZEM.Select(startIndex, endIndex - startIndex);
            Console.WriteLine(ConfigPreviewRTBZEM.SelectedText);

            // Turn that string into an event (hopefully)
            try
            {
                return new Event(ConfigPreviewRTBZEM.SelectedText);
            }
            catch (InvalidDataException)
            {
                ErrorMessage("Something went wrong with parsing, are you sure you're using an unencrypted config.txt for your map?");
            }
            catch (Exception e)
            {
                StackTrace stackTrace = new StackTrace(e, true);
                StackFrame frame = stackTrace.GetFrame(0);
                int line = frame.GetFileLineNumber();

                ErrorMessage("You shouldn't be seeing this.\nError Info:" +
                    $"\n{e}" +
                    $"\nTell FRUP to check line: {line}");
            }

            return new Event();
        }
    }
}
