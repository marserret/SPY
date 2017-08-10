using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Prise_Note
{
    [Serializable]
    public class Carte
    {
        [XmlAttribute()]
        public string Categorie { get; set; }

        [XmlAttribute()]
        public string Titre { get; set; }

        [XmlAttribute()]
        public string Type { get; set; }
    }
}
