using Intralism_Mapping_Assistant.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private void Copy(string text)
            => Clipboard.SetText(text);

        private void UpdateAllRTBs()
        {
            LoadedMapFolderLocation = AddressBox.Text;

            if (!File.Exists(LoadedMapFolderLocation + @"\config.txt"))
            {
                ErrorMessage("You have not selected a map folder that has a \"config.txt\"!");
                return;
            }

            try
            {
                string text = File.ReadAllText(LoadedMapFolderLocation + @"\config.txt");

                ConfigPreviewRTBZEM.Text = text;
                ConfigPreviewRTBZSC.Text = text;
                SplitConfigPart1.Text = text;
                ConfigPreviewRTBHS.Text = text;
                ConfigPreviewESMRTB.Text = text;
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while attempting to load the file. The error is:"
                                + System.Environment.NewLine + e.ToString() + System.Environment.NewLine);
            }

            Invalidate();
        }

        private void UpdateModifiedTracker()
            => ModifiedTracker.Text = CurrentMap.name ?? "No Map Currently Loaded";

        private void ActivateEverythingElse()
        {
            CopyPreviewBox.Enabled = true;
            CopyPreviewBoxZSC.Enabled = true;
            CopySCP1.Enabled = true;
            CopySCP2.Enabled = true;
            CopyConfigPreviewHS.Enabled = true;
            CopyConfigPreviewESM.Enabled = true;

            DeleteZoomsButtonActivated = true;
            DeleteNonZoomsButtonActivated = true;
            DestructiveCheckZEM.Enabled = true;

            FindNextZoomZSC.Enabled = true;
            FindNextZoomZEM.Enabled = true;
            FindNextEventSCP1.Enabled = true;
            FindNextEventSCP2.Enabled = true;

            FindPrevZoomZSC.Enabled = true;
            FindPrevZoomZEM.Enabled = true;
            FindPrevEventSCP1.Enabled = true;
            FindPrevEventSCP2.Enabled = true;

            /*SaveConfig.Enabled = true;
            SaveFolder.Enabled = true;
            Overwrite.Enabled = true;*/
        }

        private Map MakeMapFromPath(string path)
        {
            return MakeMapFromText(File.ReadAllText(path));
        }

        private Map MakeMapFromText(string text)
        {
            Map map;

            // Try making a map out of our serializer.
            try
            {
                // If our config version is 3, use the MapConfig3 format
                if (text.Substring(text.IndexOf(":") + 1, 1).Equals("3"))
                {
                    Config3 = true;
                    map = (MapConfig3)new JsonSerializer().Deserialize(new JsonTextReader(new StringReader(text)), typeof(MapConfig3));
                }
                else
                {
                    Config3 = false;
                    map = (Map)new JsonSerializer().Deserialize(new JsonTextReader(new StringReader(text)), typeof(Map));
                }
            }
            // Throw an error message box if it didn't work.
            catch
            {
                ErrorMessage("Invalid config.txt format!");
                return null;
            }

            return map;
        }

        private string MakeTextFromMap(Map map)
        {
            // Write the zoomless config into a StringWriter
            StringWriter sw = new StringWriter();
            JsonSerializer js = new JsonSerializer();

            if (Config3)
                js.Serialize(sw, (MapConfig3)map);
            else
                js.Serialize(sw, map);

            // Change the text box to display the zoomless config.
            return sw.ToString();
        }

        private Event MakeEventFromText(string text)
        {
            try
            {
                return (Event)new JsonSerializer().Deserialize(new JsonTextReader(new StringReader(text)), typeof(Event));
            }
            catch
            {
                ErrorMessage("The Event wasn't properly selected!\nClick on the \"Find Prev\" or \"Find Next\" buttons to select an event.");
                return null;
            }
        }

        private bool IsAddressBoxLegal()
        {
            return Directory.Exists(AddressBox.Text) && File.Exists(AddressBox.Text + @"\config.txt");
        }

        private void ErrorMessage(string text)
            => MessageBox.Show(text, "You Dingus!");

        private void SelectNextEvent(RichTextBox textBox, bool focus = true)
        {
            if (!textBox.Text.Contains("{\"time\":"))
            {
                ErrorMessage("There are no events in this config!");
                return;
            }

            try
            {
                // Get the current start position
                int currentSelectionStart = textBox.SelectionStart + textBox.SelectionLength;

                // Find the next occurence of "time":
                currentSelectionStart = textBox.Text.IndexOf("\"time\":", currentSelectionStart);

                SelectEvent(textBox, currentSelectionStart, focus);
            }
            catch (ArgumentOutOfRangeException)
            {
                // Select the very last character
                textBox.Select(textBox.Text.Length - 1, 0);
                // Then find the last event
                SelectPrevEvent(textBox, focus);
            }
        }

        private void SelectPrevEvent(RichTextBox textBox, bool focus = true)
        {
            if (!textBox.Text.Contains("{\"time\":"))
            {
                ErrorMessage("There are no events in this config!");
                return;
            }

            try
            {
                // Get the current start position
                int currentSelectionStart = textBox.SelectionStart;

                // Find the last occurence of "time":
                currentSelectionStart = textBox.Text.LastIndexOf("\"time\":", currentSelectionStart);

                SelectEvent(textBox, currentSelectionStart, focus);
            }
            catch (ArgumentOutOfRangeException)
            {
                // Select the very first character
                textBox.Select(0, 0);
                // Then find the next event
                SelectNextEvent(textBox, focus);
            }
        }

        private void SelectNextZoomEvent(RichTextBox textBox)
        {
            Event evnt = new Event();

            while (evnt.GetTypeString() != "SetPlayerDistance")
            {
                Event prevEvent = evnt;

                SelectNextEvent(textBox, false);
                evnt = MakeEventFromText(textBox.SelectedText);

                if (evnt.Equals(prevEvent))
                {
                    SelectPrevZoomEvent(textBox);
                    return;
                }
            }

            textBox.Focus();
        }

        private void SelectPrevZoomEvent(RichTextBox textBox)
        {
            Event evnt = new Event();

            while (evnt.GetTypeString() != "SetPlayerDistance")
            {
                Event nextEvent = evnt;

                SelectPrevEvent(textBox, false);
                evnt = MakeEventFromText(textBox.SelectedText);

                if (evnt.Equals(nextEvent))
                {
                    SelectNextZoomEvent(textBox);
                    return;
                }
            }

            textBox.Focus();
        }

        private void SelectEvent(RichTextBox textBox, int currentSelectionStart, bool focus = true)
        {
            // Find the start of this event
            currentSelectionStart = textBox.Text.LastIndexOf('{', currentSelectionStart);

            // Find the end of this event
            int currentSelectionEnd = textBox.Text.IndexOf('}', currentSelectionStart) + 1;

            int length = currentSelectionEnd - currentSelectionStart;

            // Select it
            textBox.Select(currentSelectionStart, length);

            if (focus)
                textBox.Focus();
        }

        private void ChangeReadOnly(CheckBox readOnly, RichTextBox textBox)
            => textBox.ReadOnly = !readOnly.Checked;

        private void ChangeDistanceFor(Event evnt)
        {
            if (evnt.GetTypeString() != "SetPlayerDistance")
            {
                ErrorMessage("Tried to modify a non-zoom event!\nYou shouldn't be seeing this error!");
                return;
            }

            evnt.data[1] = OutputBox.Text;
        }

        private void ChangeTimeFor(Event evnt)
            => evnt.time = double.Parse(OutputBox.Text);
    }
}
