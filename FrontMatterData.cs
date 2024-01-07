using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Yaml_Parser
{
    public class FrontMatterData
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Layout { get; set; }

        public string[] Categories { get; set; }

        public string[] Tags { get; set; }

        public string Date { get; set; }
    }
}
