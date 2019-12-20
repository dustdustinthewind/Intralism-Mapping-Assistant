using Intralism_Mapping_Assistant.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private void CreateEnvSpriteMovementEvents()
        {
            string id = EnvSpriteID.Text;

            if (id == null || id == "")
            {
                ErrorMessage("Please provide an ID");
                return;
            }

            double startTime = (double)EnvSpriteStartTime.Value;
            double endTime = (double)EnvSpriteEndTime.Value;

            if (endTime <= startTime)
            {
                ErrorMessage("Please make sure the End Time is greater than the Start Time");
                return;
            }

            Vector3 startPos = new Vector3(
                    (float)EnvSpriteStartPosX.Value,
                    (float)EnvSpriteStartPosY.Value,
                    (float)EnvSpriteStartPosZ.Value
                );

            Vector3 endPos = new Vector3(
                    (float)EnvSpriteEndPosX.Value,
                    (float)EnvSpriteEndPosY.Value,
                    (float)EnvSpriteEndPosZ.Value
                );

            if (startPos == endPos)
            {
                ErrorMessage("Start and end position is the same! Please change at least one value");
                return;
            }

            int eventsPerSec = (int)EventsPerSec.Value;
            int totalNumberOfEvents = (int)((endTime - startTime) * eventsPerSec);

            if (totalNumberOfEvents < 3)
            {
                ErrorMessage("Not enough events to make the effect, have you tried increasing Events Per Second");
                return;
            }

            Vector3 posIncrement = new Vector3(
                    (endPos.X - startPos.X) / totalNumberOfEvents,
                    (endPos.Y - startPos.Y) / totalNumberOfEvents,
                    (endPos.Z - startPos.Z) / totalNumberOfEvents
                );

            ConfigPreviewESMRTB.Text = MakeAllEnvSpriteMovementEvents(in id, in startTime, in startPos, in posIncrement, 1d / eventsPerSec, in totalNumberOfEvents);
        }

        private string MakeAllEnvSpriteMovementEvents(
            in string envSpriteID,
            in double startTime,
            in Vector3 startPos,
            in Vector3 incrementPosBy,
            in double incrementTimeBy,
            in int numOfEvents)
        {
            string events = ",";

            for (int i = 0; i <= numOfEvents; i++)
            {
                events += new Event()
                {
                    time = startTime + incrementTimeBy * i,
                    data = new string[2]
                    {
                        "SetPosition",
                        $"{envSpriteID}," +
                        $"{startPos.X + Math.Round(incrementPosBy.X * i, 5)}," +
                        $"{startPos.Y + Math.Round(incrementPosBy.Y * i, 5)}," +
                        $"{startPos.Z + Math.Round(incrementPosBy.Z * i, 5)}"
                    }
                }.ToString() + (i == numOfEvents ? "" : ",");
            }

            return events;
        }
    }
}
