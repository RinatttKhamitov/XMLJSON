using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLJSON
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CatalogJSON
    {
        public List<PartJSON> part { get; set; }
    }

    public class CompatibilityJSON
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
    }

    public class PartJSON
    {
        public string name { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int price { get; set; }
        public CompatibilityJSON compatibility { get; set; }
    }

    public class RootJSON
    {
        public CatalogJSON catalog { get; set; }
    }
}
