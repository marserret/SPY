using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prise_Note
{
    public partial class Info_tag : Form
    {
        public List<string> categories = new List<string>();
        public List<string> statuts = new List<string>();
        public List<string> etiquettes = new List<string>();
        public DateTime thisDate_tags;
        int i = 0;
        Label categorie_label;
        Label statut_label;
        Label etiquette_label;
        Button next;
        Button back;

        public Info_tag(List<string> categorie, List<string> statut, List<string> etiquette, DateTime thisDate)
        {
            InitializeComponent();

            foreach(string element in categorie)
            {
                categories.Add(element);
            }

            foreach (string element in statut)
            {
                statuts.Add(element);
            }

            foreach (string element in etiquette)
            {
                etiquettes.Add(element);
            }

            thisDate_tags = thisDate;

            this.Size = new Size(200 * Screen.PrimaryScreen.WorkingArea.Right / 900, 200 * Screen.PrimaryScreen.WorkingArea.Bottom / 600);
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right / 900, 200 * Screen.PrimaryScreen.WorkingArea.Bottom / 600);

            categorie_label = new Label();
            categorie_label.Size = new Size(200, 40);
            categorie_label.Text = "Catégorie : " + categories[i];
            categorie_label.Font = new Font("Arial Narrow", 12);
            categorie_label.Location = new Point(20, 30);
            categorie_label.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.Controls.Add(categorie_label);

            statut_label = new Label();
            statut_label.Size = new Size(200, 40);
            statut_label.Text = "Statut : " + statuts[i];
            statut_label.Font = new Font("Arial Narrow", 12);
            statut_label.Location = new Point(categorie_label.Location.X, categorie_label.Location.Y + 40);
            this.Controls.Add(statut_label);

            etiquette_label = new Label();
            etiquette_label.Size = new Size(200, 40);
            etiquette_label.Text = "Etiquette : " + etiquettes[i];
            etiquette_label.Font = new Font("Arial Narrow", 12);
            etiquette_label.Location = new Point(categorie_label.Location.X, statut_label.Location.Y + 40);
            this.Controls.Add(etiquette_label);

            Label heure = new Label();
            heure.Size = new Size(200, 40);
            heure.Text = "Heure : " + thisDate_tags.ToString("yyyy-MM-dd-HH:mm:ss");
            heure.Font = new Font("Arial Narrow", 12);
            heure.Location = new Point(categorie_label.Location.X, etiquette_label.Location.Y + 40);
            this.Controls.Add(heure);

            if (categories.Count() != 1)
            {
                next = new Button();
                next.BackgroundImage = ((System.Drawing.Image) (Properties.Resources.Right));
                next.BackColor = Color.Transparent;
                next.BackgroundImageLayout = ImageLayout.Stretch;
                next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                next.TabStop = false;
                next.Size = new Size(30, 30);
                next.Location = new Point(this.Width - 50 , this.Height - 75);
                next.FlatAppearance.BorderSize = 0;
                next.Click += new EventHandler(next_Click);
                this.Controls.Add(next);

                back = new Button();
                back.BackgroundImage = ((System.Drawing.Image) (Properties.Resources.left_arrow));
                back.BackColor = Color.Transparent;
                back.BackgroundImageLayout = ImageLayout.Stretch;
                back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                back.TabStop = false;
                back.Size = new Size(30, 30);
                back.Location = new Point(0, this.Height - 75);
                back.FlatAppearance.BorderSize = 0;
                back.Click += new EventHandler(back_Click);
                back.Visible = false;
                this.Controls.Add(back);
            }


            color_categorie();
            color_statut();
        }

        private void color_categorie()
        {
            if (categories[i] == "Securite")
            {
                categorie_label.ForeColor = Color.FromArgb(255, 253, 184, 19);
            }

            else if (categories[i] == "Performance")
            {
                categorie_label.ForeColor = Color.FromArgb(255, 153, 53, 255);
            }

            else if (categories[i] == "Comportement")
            {
                categorie_label.ForeColor = Color.FromArgb(255, 6, 159, 219);
            }

            else if (categories[i] == "SA")
            {
                categorie_label.ForeColor = Color.FromArgb(255, 143, 114, 81);
            }

            else
                categorie_label.ForeColor = Color.Black;
        }


        private void color_statut()
        {
            if (statuts[i] == "Bad")
            {
                statut_label.ForeColor = Color.FromArgb(255, 237, 25, 65);
            }

            else
                statut_label.ForeColor = Color.FromArgb(255, 88, 171, 65);
        }

        private void next_Click(object sender, EventArgs e)
        {
            i++;
            categorie_label.Text = "Catégorie : " + categories[i];
            statut_label.Text = "Statut : " + statuts[i];
            etiquette_label.Text = "Etiquette : " + etiquettes[i];
            color_categorie();
            color_statut();

            if (i == categories.Count() - 1)
            {
                next.Visible = false;
            }

            back.Visible = true;

        }

        private void back_Click(object sender, EventArgs e)
        {
            i--;
            categorie_label.Text = "Catégorie : " + categories[i];
            statut_label.Text = "Statut : " + statuts[i];
            etiquette_label.Text = "Etiquette : " + etiquettes[i];
            color_categorie();
            color_statut();

            if (i == 0)
            {
                back.Visible = false;
            }

            next.Visible = true;
        }
    }
}
