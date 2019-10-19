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
                ConfigPreviewRTBZEM.LoadFile(LoadedMapFolderLocation + @"\config.txt", RichTextBoxStreamType.PlainText);
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while attempting to load the file. The error is:"
                                + System.Environment.NewLine + e.ToString() + System.Environment.NewLine);
            }

            Invalidate();
        }

        private void UpdateModifiedTracker()
        {
            ModifiedTracker.Text = CurrentMap.name ?? "No Map Currently Loaded";
        }

        private void ActivateButtons()
        {
            CopyPreviewBox.Enabled = true;
            DeleteZoomsButtonActivated = true;
            DestructiveCheckZEM.Enabled = true;
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

        private bool IsAddressBoxLegal()
        {
            return Directory.Exists(AddressBox.Text) && File.Exists(AddressBox.Text + @"\config.txt");
        }

        private void ErrorMessage(string text)
        {
            MessageBox.Show(text, "You Dingus!");
        }
    }
}
