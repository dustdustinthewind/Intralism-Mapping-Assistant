using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Intralism_Mapping_Assistant.Util
{
    public class MapConfig3 : Map
    {
        public string e;

        public MapConfig3() { }

        public MapConfig3(string textToParse) : base(textToParse) { }

        protected override JsonTextReader ReadAllText(string textToParse)
        {
            JsonTextReader reader = base.ReadAllText(textToParse);

            e = reader.ReadAsString();

            return reader;
        }
    }
}
