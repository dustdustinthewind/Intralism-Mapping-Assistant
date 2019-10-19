using Intralism_Mapping_Assistant.Util;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private bool IsZoomEvent(Event evnt)
        {
            return evnt.GetTypeString() == "SetPlayerDistance";
        }

        private void DeleteZooms()
        {
            string textToParse = ConfigPreviewRTBZEM.Text;

            Map map = MakeMapFromText(textToParse);

            if (map == null)
                return;

            // Remove all Zoom Events from our Map object.
            map.events = map.events.Where(val => !IsZoomEvent(val)).ToArray();

            // Write the zoomless config into a StringWriter
            StringWriter sw = new StringWriter();
            JsonSerializer js = new JsonSerializer();
            js.Serialize(sw, map);

            // Change the text box to display the zoomless config.
            ConfigPreviewRTBZEM.Text = sw.ToString();
        }
    }
}
