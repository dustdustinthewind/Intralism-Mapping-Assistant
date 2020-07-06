using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intralism_Mapping_Assistant.Util
{
    public class Map
    {
        public int configVersion;
        public string name;
        public string info;
        public LevelResource[] levelResources;
        public string[] tags;
        public int handCount;
        public string moreInfoURL;
        public double speed;
        public int lives;
        public int maxLives;
        public string musicFile;
        public double musicTime;
        public string iconFile;
        public int environmentType;
        public object[] unlockConditions;
        public bool hidden;
        public double[] checkpoints;
        public Event[] events;

        public Map() { }

        public Map(string textToParse) => ReadAllText(textToParse);

        protected virtual JsonTextReader ReadAllText(string textToParse)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(textToParse));

            configVersion = reader.ReadAsInt32() ?? 1;
            name = reader.ReadAsString();
            info = reader.ReadAsString();
            reader.Read();
            levelResources = (LevelResource[])reader.Value;
            reader.Read();
            tags = (string[])reader.Value;
            handCount = reader.ReadAsInt32() ?? 1;
            moreInfoURL = reader.ReadAsString();
            speed = reader.ReadAsDouble() ?? 15;
            lives = reader.ReadAsInt32() ?? 5;
            maxLives = reader.ReadAsInt32() ?? 5;
            musicFile = reader.ReadAsString();
            musicTime = reader.ReadAsDouble() ?? 10;
            iconFile = reader.ReadAsString();
            environmentType = reader.ReadAsInt32() ?? -1;
            reader.Read();
            unlockConditions = (object[])reader.Value;
            hidden = reader.ReadAsBoolean() ?? false;
            reader.Read();
            checkpoints = (double[])reader.Value;
            reader.Read();
            events = (Event[])reader.Value;

            return reader;
        }
    }

    public class Event
    {
        public double time;
        public string[] data = new string[2];

        public Event() { }

        // Makes an event out of an Intrlaism-formatted event string
        // Format: {"time":[time],"data":[[data]]}
        public Event(string configString)
        {
                // Make sure there's "time" and "data"
            if ((configString.Contains("time") && configString.Contains("data")
                // Make sure there's only one occurence of both.
                && configString.IndexOf("time") != configString.LastIndexOf("time")
                && configString.IndexOf("data") != configString.LastIndexOf("data"))
                // Make sure there's two :, one { and }, and one or two of [ and ]
                || configString.Count(f => f == ':') != 2
                || configString.Count(f => f == '{') != 1 || configString.Count(f => f == '}') != 1
                || configString.Count(f => f == '[') < 1 || configString.Count(f => f == ']') < 1
                || configString.Count(f => f == '[') > 2 || configString.Count(f => f == ']') > 2)
            {
                // If anything was incorrect, throw an ivalid data exception
                throw new InvalidDataException();
            }

            // Get the value for time
            int timeStartIndex = configString.IndexOf(':') + 1;
            int timeEndIndex = configString.IndexOf(',', timeStartIndex);

            time = double.Parse(configString.Substring(timeStartIndex, timeEndIndex - timeStartIndex));

            // Get the value(s) for data
            int dataStartIndex = configString.IndexOf('[') + 1;
            int dataEndIndex = configString.LastIndexOf(']');
            data = 
                // Get the inside of the data []
                configString.Substring(dataStartIndex, dataEndIndex - dataStartIndex)
                // Remove quotes
                .Replace("\"", "")
                // Split by the comma
                .Split(',');
        }

        public override bool Equals(object compareTo)
        {
            return ToString() == compareTo.ToString();
        }

        public string GetTypeString()
        {
            return data[0];
        }

        public string[] GetEventData()
        {
            return data[1].Split(',');
        }

        public override string ToString()
        {
            string compiledData = "";

            compiledData += "\"" + data[0] + "\"";

            for (int i = 1; i < data.Length; i++)
            {
                compiledData += ",\"";
                compiledData += data[i] + "\"";
            }

            return $"{{\"time\":{time},\"data\":[{compiledData}]}}";
        }
    }

    public class LevelResource
    {
        public string name;
        public string type;
        public string path;

        public override string ToString()
            => $"{{\"name\":\"{name}\",\"type\":\"{type}\",\"path\":\"{path}\"}}";

    }
}
