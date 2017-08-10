using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prise_Note
{
    public class Tag
    {
        public List<string> categorie = new List<string>();
        public List<string> statut = new List<string>();
        public List<string> etiquette = new List<string>();
        public OverlayControl tag_show = new OverlayControl();
        public DateTime thisDate = DateTime.Now.ToUniversalTime();
        

        public Tag (OverlayControl tag_show)
        {
            foreach(string[] element in form1.list_tags)
            {
                this.categorie.Add(element[0]);
            }

            foreach (string[] element in form1.list_tags)
            {
                this.statut.Add(element[1]);
            }

            foreach (string[] element in form1.list_tags)
            {
                this.etiquette.Add(element[2]);
            }

            this.tag_show = tag_show;
            tag_show.info = new Info_tag(categorie, etiquette, statut, thisDate);
        }

    }
}
