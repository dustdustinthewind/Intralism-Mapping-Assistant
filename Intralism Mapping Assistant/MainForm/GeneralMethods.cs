using Intralism_Mapping_Assistant.Util;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
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
                string address = LoadedMapFolderLocation + @"\config.txt";
                RichTextBoxStreamType type = RichTextBoxStreamType.PlainText;
                string text = File.ReadAllText(address);

                ConfigPreviewRTBZEM.LoadFile(address, type);
                ConfigPreviewRTBZSC.LoadFile(address, type);
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

        private void ActivateButtons()
        {
            CopyPreviewBox.Enabled = true;
            CopyPreviewBoxZSC.Enabled = true;

            DeleteZoomsButtonActivated = true;
            DestructiveCheckZEM.Enabled = true;

            FindNextZoomZSC.Enabled = true;
            FindNextZoomZEM.Enabled = true;

            FindPrevZoomZSC.Enabled = true;
            FindPrevZoomZEM.Enabled = true;

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

            try
            {
                // Try making a map out of our serializer.
                map = (Map)new JsonSerializer().Deserialize(new JsonTextReader(new StringReader(text)), typeof(Map));
            }
            catch
            {
                // Throw an error message box if it didn't work.
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
            js.Serialize(sw, map);

            // Change the text box to display the zoomless config.
            return sw.ToString();
        }

        private bool IsAddressBoxLegal()
        {
            return Directory.Exists(AddressBox.Text) && File.Exists(AddressBox.Text + @"\config.txt");
        }

        private void ErrorMessage(string text)
            => MessageBox.Show(text, "You Dingus!");

        private void SelectNextZoomEvent(RichTextBox textBox)
        {
            try
            {
                // Get the current start position
                int currentSelectionStart = textBox.SelectionStart + textBox.SelectionLength;

                // Find the next occurence of "SetPlayerDistance"
                currentSelectionStart = textBox.Text.IndexOf("SetPlayerDistance", currentSelectionStart);

                FocusOnEvent(textBox, currentSelectionStart);
            }
            catch
            {
                // Select the very last character
                textBox.Select(textBox.Text.Length - 1, 0);
                // Then find the last event
                SelectPrevZoomEvent(textBox);
            }
        }

        private void SelectPrevZoomEvent(RichTextBox textBox)
        {
            try
            {
                // Get the current start position
                int currentSelectionStart = textBox.SelectionStart;

                // Find the last occurence of "SetPlayerDistance"
                currentSelectionStart = textBox.Text.LastIndexOf("SetPlayerDistance", currentSelectionStart);

                FocusOnEvent(textBox, currentSelectionStart);
            }
            catch
            {
                // Select the very first character
                textBox.Select(0, 0);
                // Then findm the first event
                SelectNextZoomEvent(textBox);
            }
        }

        private void FocusOnEvent(RichTextBox textBox, int currentSelectionStart)
        {
            // Find the start of this event
            currentSelectionStart = textBox.Text.LastIndexOf('{', currentSelectionStart);

            // Find the end of this event
            int currentSelectionEnd = textBox.Text.IndexOf('}', currentSelectionStart) + 1;

            // Select it
            textBox.Select(currentSelectionStart, currentSelectionEnd - currentSelectionStart);
            textBox.Focus();
        }

        private void ChangeReadOnly(CheckBox readOnly, RichTextBox textBox)
            => textBox.ReadOnly = !readOnly.Checked;

        private void ChangeDistanceFor(Event evnt)
        {
            if (evnt.GetTypeString() != "SetPlayerDistance")
            {
                ErrorMessage("Tried to modify a non-zoom event! You shouldn't be seeing this error!");
                return;
            }

            evnt.data[1] = OutputBox.Text;
        }

        private void ChangeTimeFor(Event evnt)
            => evnt.time = double.Parse(OutputBox.Text);
    }
}
