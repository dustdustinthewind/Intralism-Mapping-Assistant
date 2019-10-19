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
        public double[] checkpoints;
        public Event[] events;

        public Map() { }

        public Map(string textToParse)
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
            reader.Read();
            checkpoints = (double[])reader.Value;
            reader.Read();
            events = (Event[])reader.Value;
        }
    }

    public class Event
    {
        public double time;
        public string[] data = new string[2];

        public string GetTypeString()
        {
            return data[0];
        }

        public string[] GetEventData()
        {
            return data[1].Split(',');
        }
    }

    public class LevelResource
    {
        public string name;
        public string type;
        public string path;
    }
}
