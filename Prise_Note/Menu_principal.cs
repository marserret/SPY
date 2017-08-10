using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Drawing.Drawing2D;

namespace Prise_Note
{
    public partial class form1 : Form
    {
        Tags tags = null;
        public static string[][] sa;
        public static string[][] performance;
        public static string[][] comportement;
        public static string[][] securite;
        choix_etiquette etiquettes;
        public string choice;
        bool result;
        Button_menu button_menu;
        List<Control> list_buttons = new List<Control>();

        bool finish = false;

        bool info_visible = false;

        List<Tag> tags_add = new List<Tag>();
        Tag tag_on_screen;
        OverlayControl tag_show;

        public static List<OverlayControl> tags_show_on_screen = new List<OverlayControl>();

        public static string comment = "";

        public static List<string[]> list_tags = new List<string[]>();

        public form1(choix_etiquette menu_etiquette, Button_menu bouton_menu)
        {
            InitializeComponent();

            timer2.Interval = 1000; // specify interval time as you want
            timer2.Start();

            button_menu = bouton_menu;
            Delete_first();

            this.Width = Screen.PrimaryScreen.WorkingArea.Right - Button_menu.button_menu_width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Bottom;

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right, 0);
            tags = Tags.Charger();
            etiquettes = menu_etiquette;

            sa = new string[tags.SA.Count][];
            performance = new string[tags.Performance.Count][];
            comportement = new string[tags.Comportement.Count][];
            securite = new string[tags.Securite.Count][];
            creation_tableau();
            affichage_boutons();
        }

        private void creation_tableau()
        {
            for (int i = 0; i < sa.Length; i++)
            {
                sa[i] = new string[3];
                performance[i] = new string[3];
                securite[i] = new string[3];
            }

            for (int i = 0; i < comportement.Length; i++)
            {
                comportement[i] = new string[3];
            }

            int j = 0;
            foreach (Carte carte in tags.SA)
            {
                sa[j][0] = carte.Categorie;
                sa[j][1] = carte.Titre;
                sa[j][2] = carte.Type;
                j++;
            }

            j = 0;
            foreach (Carte carte in tags.Performance)
            {
                performance[j][0] = carte.Categorie;
                performance[j][1] = carte.Titre;
                performance[j][2] = carte.Type;
                j++;
            }

            j = 0;
            foreach (Carte carte in tags.Comportement)
            {
                comportement[j][0] = carte.Categorie;
                comportement[j][1] = carte.Titre;
                comportement[j][2] = carte.Type;
                j++;
            }

            j = 0;
            foreach (Carte carte in tags.Securite)
            {
                securite[j][0] = carte.Categorie;
                securite[j][1] = carte.Titre;
                securite[j][2] = carte.Type;
                j++;
            }
        }

        private void affichage_boutons()
        {
            //Bouton Securite
            //---------------
            securite_moins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            securite_moins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            securite_moins.TabStop = false;
            securite_moins.FlatAppearance.BorderSize = 0;
            securite_moins.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            securite_moins.Location = new Point(this.Width * 65 / 900, this.Height * 60 / 600);

            securite_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            securite_button.FlatAppearance.BorderColor = Color.FromArgb(255, 253, 184, 19);
            securite_button.FlatAppearance.BorderSize = 2;
            securite_button.Font = new Font("Arial Narrow", 12 * this.Width / 900);
            securite_button.ForeColor = Color.FromArgb(255, 253, 184, 19);
            securite_button.Size = new Size(this.Width * 150 / 900, this.Height * 50 / 600);
            securite_button.Location = new Point((this.Width / 900) * (securite_moins.Location.X + (35 * this.Width / 900) + securite_moins.Width), this.Height * 60 / 600);

            securite_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            securite_plus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            securite_plus.TabStop = false;
            securite_plus.FlatAppearance.BorderSize = 0;
            securite_plus.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            securite_plus.Location = new Point((this.Width / 900) * (securite_button.Location.X + (35 * this.Width / 900) + securite_button.Width), this.Height * 60 / 600);


            //Bouton Performance
            //------------------
            performance_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            performance_plus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            performance_plus.TabStop = false;
            performance_plus.FlatAppearance.BorderSize = 0;
            performance_plus.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            performance_plus.Location = new Point((this.Width / 900) * (this.Width - (65 * this.Width / 900) - performance_plus.Width), this.Height * 60 / 600);

            performance_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            performance_button.FlatAppearance.BorderColor = Color.FromArgb(255, 153, 53, 255);
            performance_button.FlatAppearance.BorderSize = 2;
            performance_button.Font = new Font("Arial Narrow", 12 * this.Width / 900);
            performance_button.ForeColor = Color.FromArgb(255, 153, 53, 255);
            performance_button.Size = new Size(this.Width * 150 / 900, this.Height * 50 / 600);
            performance_button.Location = new Point((this.Width / 900) * (performance_plus.Location.X - (35 * this.Width / 900) - performance_button.Width), this.Height * 60 / 600);

            performance_moins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            performance_moins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            performance_moins.TabStop = false;
            performance_moins.FlatAppearance.BorderSize = 0;
            performance_moins.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            performance_moins.Location = new Point((this.Width / 900) * (performance_button.Location.X - (35 * this.Width / 900) - performance_moins.Width), this.Height * 60 / 600);


            //Bouton Comportement
            //-------------------
            comportement_moins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comportement_moins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            comportement_moins.TabStop = false;
            comportement_moins.FlatAppearance.BorderSize = 0;
            comportement_moins.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            comportement_moins.Location = new Point(this.Width * 65 / 900, securite_moins.Location.Y + securite_moins.Height + (this.Height * 60 / 600));

            comportement_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comportement_button.FlatAppearance.BorderColor = Color.FromArgb(255, 6, 159, 219);
            comportement_button.FlatAppearance.BorderSize = 2;
            comportement_button.Font = new Font("Arial Narrow", 12 * this.Width / 900);
            comportement_button.ForeColor = Color.FromArgb(255, 6, 159, 219);
            comportement_button.Size = new Size(this.Width * 150 / 900, this.Height * 50 / 600);
            comportement_button.Location = new Point((this.Width / 900) * (securite_moins.Location.X + (35 * this.Width / 900) + securite_moins.Width), securite_moins.Location.Y + securite_moins.Height + (this.Height * 60 / 600));

            comportement_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comportement_plus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            comportement_plus.FlatAppearance.BorderSize = 0;
            comportement_plus.TabStop = false;
            comportement_plus.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            comportement_plus.Location = new Point((this.Width / 900) * (securite_button.Location.X + (35 * this.Width / 900) + securite_button.Width), securite_moins.Location.Y + securite_moins.Height + (this.Height * 60 / 600));


            //Bouton S.A
            //----------
            sa_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sa_plus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            sa_plus.TabStop = false;
            sa_plus.FlatAppearance.BorderSize = 0;
            sa_plus.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            sa_plus.Location = new Point((this.Width / 900) * (this.Width - (65 * this.Width / 900) - performance_plus.Width), securite_moins.Location.Y + securite_moins.Height + (this.Height * 60 / 600));


            sa_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sa_button.FlatAppearance.BorderColor = Color.FromArgb(255, 143, 114, 81);
            sa_button.FlatAppearance.BorderSize = 2;
            sa_button.Font = new Font("Arial Narrow", 12 * this.Width / 900);
            sa_button.ForeColor = Color.FromArgb(255, 143, 114, 81);
            sa_button.Size = new Size(this.Width * 150 / 900, this.Height * 50 / 600);
            sa_button.Location = new Point((this.Width / 900) * (performance_plus.Location.X - (35 * this.Width / 900) - performance_button.Width), securite_moins.Location.Y + securite_moins.Height + (this.Height * 60 / 600));

            sa_moins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sa_moins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            sa_moins.TabStop = false;
            sa_moins.FlatAppearance.BorderSize = 0;
            sa_moins.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            sa_moins.Location = new Point((this.Width / 900) * (performance_button.Location.X - (35 * this.Width / 900) - performance_moins.Width), securite_moins.Location.Y + securite_moins.Height + (this.Height * 60 / 600));

            //Bouton Commentaire
            //----------
            commentaire_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            commentaire_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            commentaire_icon.TabStop = false;
            commentaire_icon.FlatAppearance.BorderSize = 0;
            commentaire_icon.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            commentaire_icon.Location = new Point(this.Width * 125 / 900, comportement_moins.Location.Y + comportement_moins.Height + (this.Height * 60 / 600));

            commentaire_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            commentaire_button.FlatAppearance.BorderSize = 0;
            commentaire_button.Font = new Font("Arial Narrow", 18 * this.Width / 900);
            commentaire_button.ForeColor = Color.FromArgb(255, 0, 0, 0);
            commentaire_button.Size = new Size(this.Width * 150 / 900, this.Height * 50 / 600);
            commentaire_button.Location = new Point((this.Width / 900) * (commentaire_icon.Location.X + (10 * this.Width / 900) + commentaire_icon.Width), comportement_moins.Location.Y + comportement_moins.Height + (this.Height * 60 / 600));


            //Logo
            //----
            pictureBox1.Size = new Size(sa_button.Width, sa_button.Width * pictureBox1.Height / pictureBox1.Width);
            pictureBox1.Location = new Point(sa_button.Location.X, commentaire_button.Location.Y - (int) (commentaire_button.Location.Y * 0.10));



            //Bouton Annuler
            //--------------
            cancel_button.Size = new Size(this.Width * 150 / 900, this.Height * 50 / 600);
            cancel_button.Location = new Point(this.Width * 200 / 900, commentaire_icon.Location.Y + commentaire_icon.Height + (this.Height * 60 / 600));

            //Bouton Valider
            //--------------
            valid_button.Size = new Size(this.Width * 150 / 900, this.Height * 50 / 600);
            valid_button.Location = new Point(this.Width * 550 / 900, commentaire_icon.Location.Y + commentaire_icon.Height + (this.Height * 60 / 600));

            //TimeLine
            //--------
            timeline.Size = new Size(this.Width * 770 / 900, this.Height * 50 / 600);
            timeline.Location = new Point(securite_moins.Location.X, valid_button.Location.Y + valid_button.Height + (this.Height * 100 / 600));
            //timeline.max = timeline.Width;
        }

        private void form1_Shown(object sender, EventArgs e)
        {
            affichage_boutons();
        }

        private void securite_button_Click(object sender, EventArgs e)
        {
            choice = "sécurité";
            etiquettes.true_position(this.Location);
            etiquettes.creation_buttons(choice);
            etiquettes.affichage_buttons();
            etiquettes.Show();
            this.Hide();
        }

        private void comportement_button_Click(object sender, EventArgs e)
        {
            choice = "comportement";
            etiquettes.true_position(this.Location);
            etiquettes.creation_buttons(choice);
            etiquettes.affichage_buttons();
            etiquettes.Show();
            this.Hide();
        }

        private void performance_button_Click(object sender, EventArgs e)
        {
            choice = "performance";
            etiquettes.true_position(this.Location);
            etiquettes.creation_buttons(choice);
            etiquettes.affichage_buttons();
            etiquettes.Show();
            this.Hide();
        }

        private void sa_button_Click(object sender, EventArgs e)
        {
            choice = "SA";
            etiquettes.true_position(this.Location);
            etiquettes.creation_buttons(choice);
            etiquettes.affichage_buttons();
            etiquettes.Show();
            this.Hide();
        }

        private void commentaire_button_Click(object sender, EventArgs e)
        {
            choice = "Commentaire";
            etiquettes.true_position(this.Location);
            etiquettes.creation_buttons(choice);
            etiquettes.affichage_buttons();
            etiquettes.Show();
            this.Hide();
        }

        private void commentaire_icon_Click(object sender, EventArgs e)
        {
            choice = "Commentaire";
            etiquettes.true_position(this.Location);
            etiquettes.creation_buttons(choice);
            etiquettes.affichage_buttons();
            etiquettes.Show();
            this.Hide();
        }

        public void clear_list_tags()
        {
            list_tags.Clear();
        }

        private void securite_moins_Click(object sender, EventArgs e)
        {
            result = list_tags.Exists(x => x == securite[0]);

            if (result == false)
            {
                list_tags.Add(securite[0]);
                securite_moins.BackColor = Color.LightGray;
            }

            else
            {
                list_tags.Remove(list_tags.Find(x => x == securite[0]));
                securite_moins.BackColor = Color.Transparent;
            }
        }

        private void securite_plus_Click(object sender, EventArgs e)
        {

            result = list_tags.Exists(x => x == securite[1]);

            if (result == false)
            {
                list_tags.Add(securite[1]);
                securite_plus.BackColor = Color.LightGray;
            }

            else
            {
                list_tags.Remove(list_tags.Find(x => x == securite[1]));
                securite_plus.BackColor = Color.Transparent;
            }

        }

        private void comportement_moins_Click(object sender, EventArgs e)
        {
            result = list_tags.Exists(x => x == comportement[0]);

            if (result == false)
            {
                list_tags.Add(comportement[0]);
                comportement_moins.BackColor = Color.LightGray;
            }

            else
            {
                list_tags.Remove(list_tags.Find(x => x == comportement[0]));
                comportement_moins.BackColor = Color.Transparent;
            }
        }

        private void comportement_plus_Click(object sender, EventArgs e)
        {
            result = list_tags.Exists(x => x == comportement[1]);

            if (result == false)
            {
                list_tags.Add(comportement[1]);
                comportement_plus.BackColor = Color.LightGray;
            }

            else
            {
                list_tags.Remove(list_tags.Find(x => x == comportement[1]));
                comportement_plus.BackColor = Color.Transparent;
            }
        }

        private void performance_moins_Click(object sender, EventArgs e)
        {
            result = list_tags.Exists(x => x == performance[0]);

            if (result == false)
            {
                list_tags.Add(performance[0]);
                performance_moins.BackColor = Color.LightGray;
            }

            else
            {
                list_tags.Remove(list_tags.Find(x => x == performance[0]));
                performance_moins.BackColor = Color.Transparent;
            }
        }

        private void performance_plus_Click(object sender, EventArgs e)
        {
            result = list_tags.Exists(x => x == performance[1]);

            if (result == false)
            {
                list_tags.Add(performance[1]);
                performance_plus.BackColor = Color.LightGray;
            }

            else
            {
                list_tags.Remove(list_tags.Find(x => x == performance[1]));
                performance_plus.BackColor = Color.Transparent;
            }
        }

        private void sa_moins_Click(object sender, EventArgs e)
        {
            result = list_tags.Exists(x => x == sa[0]);

            if (result == false)
            {
                list_tags.Add(sa[0]);
                sa_moins.BackColor = Color.LightGray;
            }

            else
            {
                list_tags.Remove(list_tags.Find(x => x == sa[0]));
                sa_moins.BackColor = Color.Transparent;
            }
        }

        private void sa_plus_Click(object sender, EventArgs e)
        {
            result = list_tags.Exists(x => x == sa[1]);

            if (result == false)
            {
                list_tags.Add(sa[1]);
                sa_plus.BackColor = Color.LightGray;
            }

            else
            {
                list_tags.Remove(list_tags.Find(x => x == sa[1]));
                sa_plus.BackColor = Color.Transparent;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close_color();
            button_menu.Methode_to_close();
        }

        private void valid_button_Click(object sender, EventArgs e)
        {
            bool isEmpty = !list_tags.Any();

            if (isEmpty)
            { }

            else
            {
                DateTime thisDate = DateTime.Now;

                DateTime Date_GMT = thisDate.ToUniversalTime();

                XDocument xDocument = XDocument.Load(Initialisation.file_name + ".xml");
                XElement root = xDocument.Element("Analyse");
                IEnumerable<XElement> rows = root.Descendants("Tags");
                XElement firstRow = rows.Last();

                firstRow.Add(
                       new XElement("Tag",
                       new XElement("Heure", Date_GMT.ToString("yyyy-MM-dd-HH:mm:ss"))/*,
                   new XElement("Duree", "A définir")*/));

                XElement root2 = xDocument.Element("Analyse");
                IEnumerable<XElement> rows2 = root2.Descendants("Tag");
                XElement secondRow = rows2.Last();


                foreach (string[] tag in list_tags)
                {
                    if (tag[0] != "Commentaire")
                    {
                        secondRow.Add(
                           new XElement("Carte",
                           new XAttribute("Categorie", tag[0]),
                           new XAttribute("Titre", tag[1]),
                           new XAttribute("Type", tag[2]),
                           new XElement("Commentaire", "")
                           ));
                    }

                    else
                    {
                        secondRow.Add(
                           new XElement("Carte",
                           new XAttribute("Categorie", tag[0]),
                           new XAttribute("Titre", tag[1]),
                           new XAttribute("Type", tag[2]),
                           new XElement("Commentaire", comment)
                           ));
                    }
                }

                xDocument.Save(Initialisation.file_name + ".xml");
                comment = "";
                Color_tag();

                tag_on_screen = new Tag(tag_show);
                tags_add.Add(tag_on_screen);
            }

            timer1.Start();
        }

        private void Delete_first()
        {
            XDocument xDocument = XDocument.Load(Initialisation.file_name + ".xml");
            XElement root = xDocument.Element("Analyse");
            IEnumerable<XElement> rows = root.Descendants("Tags");
            XElement firstRow = rows.First();

            firstRow.RemoveAll();
            xDocument.Save(Initialisation.file_name + ".xml");
        }

        public void Close_color()
        {
            GetAllControl(this, list_buttons);

            foreach (Tag element in tags_add)
            {
                element.tag_show.info.Visible = false;
            }


            foreach (Control control in list_buttons)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.Transparent;
                }
            }
        }

        private void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(Panel))
                    GetAllControl(control, list);
            }
        }

        private void form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs) e;
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!finish)
                {
                    if (MessageBox.Show("Terminer l'analyse de l'activité ?", "Terminer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        timeline.timer.Stop();
                        timer2.Stop();
                        timeline.Value = timeline.max;
                        int tag_time_int;
                        int time_total = timeline.result.Hours * 3600 + timeline.result.Minutes * 60 + timeline.result.Seconds;

                        timeline.finish();

                        foreach (Tag element in tags_add)
                        {
                            Info_tag info = new Info_tag(element.categorie, element.statut, element.etiquette, element.thisDate);
                            info.Visible = false;
                            element.tag_show.Click += new EventHandler(tag_Click);
                            element.tag_show.MouseMove += new System.Windows.Forms.MouseEventHandler(tag_Mouse_move);
                        }

                        for (int i = 0; i < tags_show_on_screen.Count(); i++)
                        {
                            tag_time_int = (tags_add[i].thisDate.Hour * 3600 + tags_add[i].thisDate.Minute * 60 + tags_add[i].thisDate.Second) - (timeline.begin.Hour * 3600 + timeline.begin.Minute * 60 + timeline.begin.Second);
                            tags_show_on_screen[i].Location = new Point((timeline.Width) * tag_time_int / time_total, tags_show_on_screen[i].Location.Y);
                            tags_show_on_screen[i].Refresh();
                        }

                        finish = true;
                    }


                }

                else
                {
                    if (MessageBox.Show("Quitter SPY ?", "Quitter", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Move(@Initialisation.file_name + ".xml", Initialisation.chemin + "\\" + Initialisation.file_name + ".xml");
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
        }

        private void Color_tag()
        {
            tag_show = new OverlayControl();
            tag_show.Location = new Point(timeline.Location.X + timeline.pb.Location.X - 18 * this.Width / 900, 480 * this.Height / 600);
            tag_show.Size = new Size(this.Height * 44 / 600, this.Height * 200 / 600);

            string first_statut = list_tags[0][2];
            bool idem_statut = false;

            idem_statut = Border_color(first_statut, idem_statut);

            if (idem_statut && first_statut == "Bad")
                tag_show.pen = new Pen(Color.FromArgb(255, 237, 25, 65), 3);

            else if (idem_statut && first_statut == "Good")
                tag_show.pen = new Pen(Color.FromArgb(255, 88, 171, 65), 3);

            else
                tag_show.pen = new Pen(Color.Black, 3);

            string first_categorie = list_tags[0][0];
            bool idem_categorie = false;

            idem_categorie = Inside_color(first_categorie, idem_categorie);

            if (idem_categorie && first_categorie == "Securite")
            {
                tag_show.inside_color = Color.FromArgb(255, 253, 184, 19);
                tag_show.title_tag.BackColor = Color.FromArgb(255, 253, 184, 19);
                tag_show.title_tag.ForeColor = System.Drawing.Color.White;
                tag_show.title_tag.Text = "SECU";
            }

            else if (idem_categorie && first_categorie == "Performance")
            {
                tag_show.inside_color = Color.FromArgb(255, 153, 53, 255);
                tag_show.title_tag.BackColor = Color.FromArgb(255, 153, 53, 255);
                tag_show.title_tag.ForeColor = System.Drawing.Color.White;
                tag_show.title_tag.Text = "PERF";
            }

            else if (idem_categorie && first_categorie == "Comportement")
            {
                tag_show.inside_color = Color.FromArgb(255, 6, 159, 219);
                tag_show.title_tag.BackColor = Color.FromArgb(255, 6, 159, 219);
                tag_show.title_tag.ForeColor = System.Drawing.Color.White;
                tag_show.title_tag.Text = "COM";
            }

            else if (idem_categorie && first_categorie == "SA")
            {
                tag_show.inside_color = Color.FromArgb(255, 143, 114, 81);
                tag_show.title_tag.BackColor = Color.FromArgb(255, 143, 114, 81);
                tag_show.title_tag.ForeColor = System.Drawing.Color.White;
                tag_show.title_tag.Text = "SA";
            }

            else if (idem_categorie && first_categorie == "Commentaire")
            {
                tag_show.inside_color = Color.White;
                tag_show.title_tag.BackColor = Color.White;
                tag_show.title_tag.ForeColor = System.Drawing.Color.Black;
                tag_show.title_tag.Text = "MAN";
            }

            else
            {
                tag_show.inside_color = Color.White;
                tag_show.title_tag.BackColor = Color.White;
                tag_show.title_tag.ForeColor = System.Drawing.Color.Black;
                tag_show.title_tag.Text = "MULTI";
            }

            tags_show_on_screen.Add(tag_show);
            this.Controls.Add(tag_show);
        }


        private bool Border_color(string first_statut, bool idem_statut)
        {
            foreach (string[] tag in list_tags)
            {
                if (tag[2] == first_statut)
                    idem_statut = true;

                else
                {
                    idem_statut = false;
                    break;
                }
            }

            return idem_statut;
        }


        private bool Inside_color(string first_categorie, bool idem_categorie)
        {
            foreach (string[] tag in list_tags)
            {
                if (tag[0] == first_categorie)
                    idem_categorie = true;

                else
                {
                    idem_categorie = false;
                    break;
                }
            }

            return idem_categorie;
        }

        private void tag_Click(object sender, EventArgs e)
        {
            OverlayControl true_tag = (OverlayControl) sender;

            if (info_visible == false)
            {
                info_visible = true;
                true_tag.info.Visible = true;
                true_tag.info.TopMost = true;
            }

            else
            {
                info_visible = false;
                true_tag.info.Visible = false;
            }
        }

        private void tag_Mouse_move(object sender, EventArgs e)
        {
            OverlayControl true_tag = (OverlayControl) sender;
            true_tag.Refresh();
            //true_tag.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close_color();
            button_menu.Methode_to_close();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeline.refresh)
            {
                for (int i = 0; i < tags_show_on_screen.Count(); i++)
                {
                    tags_show_on_screen[i].Location = new Point(timeline.Location.X + (tags_show_on_screen[i].Location.X / 2), tags_show_on_screen[i].Location.Y);
                }
            }
        }


    }
}
