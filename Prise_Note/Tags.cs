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
    public class Tags
    {
        public SA SA { get; set; }
        public Performance Performance { get; set; }
        public Comportement Comportement { get; set; }
        public Securite Securite { get; set; }
        
        public static Tags Charger()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Tags));
            StreamReader lecteur = new StreamReader("Categories_etiquettes.xml");
            Tags p = (Tags) deserializer.Deserialize(lecteur);
            lecteur.Close();

            return p;
        }
    }
}
