using System;
using System.Collections.Generic;
using System.Text;

namespace ktaneapre
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class JsonHandling
    {
        public Wireseq wireseq { get; set; }
    }

    public class Wireseq
    {
        public List<string> red { get; set; }
        public List<string> blue { get; set; }
        public List<string> black { get; set; }
    }
}
