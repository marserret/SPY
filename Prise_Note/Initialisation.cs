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

namespace Prise_Note
{
    public partial class Initialisation : Form
    {
        public static string file_name;
        public static string chemin;

        public Initialisation()
        {
            InitializeComponent();

            //Adaptation de la fenêtre à la taille de n'importe quel écran
            this.Width = Screen.PrimaryScreen.WorkingArea.Right;
            this.Height = Screen.PrimaryScreen.WorkingArea.Bottom;
            this.BackColor = Color.White;

            //Position du titre principal en fonction de la dimension de l'écran
            label1.Font = new Font("Arial Narrow", 16 * this.Width / 900);
            label1.Location = new Point (((Screen.PrimaryScreen.WorkingArea.Right / 2) - label1.Width/2), 40 * this.Height / 600);

            //Position et dimensionnement des logos en fonction de la dimension de l'écran
            pictureBox1.Location = new Point(79 * this.Width / 900, 51 * this.Height / 600);
            pictureBox2.Location = new Point(70 * this.Width / 900, 398 * this.Height / 600);
            pictureBox3.Location = new Point(79 * this.Width / 900, 208 * this.Height / 600);

            pictureBox1.Size = new Size(pictureBox1.Width * this.Width / 900, pictureBox1.Height * this.Height / 600);
            pictureBox2.Size = new Size(pictureBox2.Width * this.Width / 900, pictureBox2.Height * this.Height / 600);
            pictureBox3.Size = new Size(pictureBox3.Width * this.Width / 900, pictureBox3.Height * this.Height / 600);

            //Toutes les positions sont définies par rapport au titre principal
            //-----------------------------------------------------------------

            //Titre
            titre_textbox.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            label_titre.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            label_titre.Location = new Point(365 * this.Width / 900, label1.Location.Y + (40 * this.Height / 600) + label1.Height);
            titre_textbox.Location = new Point(label_titre.Location.X + label_titre.Width + (35 * this.Width / 900) , label1.Location.Y + (40 * this.Height / 600) + label1.Height);
            titre_textbox.Text = "Titre de l'étude";

            //Organisateur
            Organisateur_label.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Organisateur_textbox.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Organisateur_label.Location = new Point(365 * this.Width / 900, titre_textbox.Location.Y + (20 * this.Height / 600) + titre_textbox.Height);
            Organisateur_textbox.Location = new Point(label_titre.Location.X + label_titre.Width + (35 * this.Width / 900), titre_textbox.Location.Y + (20 * this.Height / 600) + titre_textbox.Height);
            Organisateur_textbox.Text = "Nom de l'organisateur";

            //Participant
            Participant_label.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Participant_nom.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Participant_label.Location = new Point(365 * this.Width / 900, Organisateur_textbox.Location.Y + (20 * this.Height / 600) + Organisateur_textbox.Height);
            Participant_nom.Location = new Point(label_titre.Location.X + label_titre.Width + (35 * this.Width / 900), Organisateur_textbox.Location.Y + (20 * this.Height / 600) + Organisateur_textbox.Height);
            Participant_nom.Text = "Nom du participant";

            Participant_specialite.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Participant_specialite.Location = new Point(label_titre.Location.X + label_titre.Width + (35 * this.Width / 900), Participant_nom.Location.Y + (10 * this.Height / 600) + Participant_nom.Height);
            Participant_specialite.Text = "Spécialité";

            Participant_qualification.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Participant_qualification.Location = new Point(label_titre.Location.X + label_titre.Width + (35 * this.Width / 900), Participant_specialite.Location.Y + (10 * this.Height / 600) + Participant_specialite.Height);
            Participant_qualification.Text = "Qualification";

            Participant_anciennete.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Participant_anciennete.Location = new Point(label_titre.Location.X + label_titre.Width + (35 * this.Width / 900), Participant_qualification.Location.Y + (10 * this.Height / 600) + Participant_qualification.Height);
            Participant_anciennete.Text = "Ancienneté";

            //Contexte
            Contexte_label.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Contexte_textbox.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Contexte_label.Location = new Point(365 * this.Width / 900, Participant_anciennete.Location.Y + (20 * this.Height / 600) + Participant_anciennete.Height);
            Contexte_textbox.Location = new Point(label_titre.Location.X + label_titre.Width + (35 * this.Width / 900), Participant_anciennete.Location.Y + (20 * this.Height / 600) + Participant_anciennete.Height);
            Contexte_textbox.Size = new Size(Contexte_textbox.Width * this.Width / 900, Contexte_textbox.Height * this.Height / 600);
            Contexte_textbox.Text = "Contexte";

            Valider.Font = new Font("Arial Narrow", 8 * this.Width / 900);
            Valider.Size = new Size(Valider.Width * this.Width / 900, Valider.Height * this.Height / 600);
            Valider.Location = new Point(label_titre.Location.X + label_titre.Width + (35 * this.Width / 900), Contexte_textbox.Location.Y + (60 * this.Height / 600) + Contexte_textbox.Height);
            
        }

        private void titre_textbox_Enter(object sender, EventArgs e)
        {
            if (titre_textbox.Text == "Titre de l'étude")
            {
                titre_textbox.Text = "";
                titre_textbox.ForeColor = Color.Black;
            }
        }

        private void titre_textbox_Leave(object sender, EventArgs e)
        {
            if (titre_textbox.Text == "")
            {
                titre_textbox.Text = "Titre de l'étude";
                titre_textbox.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (Organisateur_textbox.Text == "Nom de l'organisateur")
            {
                Organisateur_textbox.Text = "";
                Organisateur_textbox.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (Organisateur_textbox.Text == "")
            {
                Organisateur_textbox.Text = "Nom de l'organisateur";
                Organisateur_textbox.ForeColor = Color.Gray;
            }
        }

        private void Participant_nom_Enter(object sender, EventArgs e)
        {
            if (Participant_nom.Text == "Nom du participant")
            {
                Participant_nom.Text = "";
                Participant_nom.ForeColor = Color.Black;
            }
        }

        private void Participant_nom_Leave(object sender, EventArgs e)
        {
            if (Participant_nom.Text == "")
            {
                Participant_nom.Text = "Nom du participant";
                Participant_nom.ForeColor = Color.Gray;
            }
        }

        private void Participant_specialite_Enter(object sender, EventArgs e)
        {
            if (Participant_specialite.Text == "Spécialité")
            {
                Participant_specialite.Text = "";
                Participant_specialite.ForeColor = Color.Black;
            }
        }

        private void Participant_specialite_Leave(object sender, EventArgs e)
        {
            if (Participant_specialite.Text == "")
            {
                Participant_specialite.Text = "Spécialité";
                Participant_specialite.ForeColor = Color.Gray;
            }
        }

        private void Participant_qualification_Enter(object sender, EventArgs e)
        {
            if (Participant_qualification.Text == "Qualification")
            {
                Participant_qualification.Text = "";
                Participant_qualification.ForeColor = Color.Black;
            }
        }

        private void Participant_qualification_Leave(object sender, EventArgs e)
        {
            if (Participant_qualification.Text == "")
            {
                Participant_qualification.Text = "Qualification";
                Participant_qualification.ForeColor = Color.Gray;
            }
        }

        private void Participant_anciennete_Enter(object sender, EventArgs e)
        {
            if (Participant_anciennete.Text == "Ancienneté")
            {
                Participant_anciennete.Text = "";
                Participant_anciennete.ForeColor = Color.Black;
            }
        }

        private void Participant_anciennete_Leave(object sender, EventArgs e)
        {
            if (Participant_anciennete.Text == "")
            {
                Participant_anciennete.Text = "Ancienneté";
                Participant_anciennete.ForeColor = Color.Gray;
            }
        }

        private void Contexte_textbox_Enter(object sender, EventArgs e)
        {
            if (Contexte_textbox.Text == "Contexte")
            {
                Contexte_textbox.Text = "";
                Contexte_textbox.ForeColor = Color.Black;
            }
        }

        private void Contexte_textbox_Leave(object sender, EventArgs e)
        {
            if (Contexte_textbox.Text == "")
            {
                Contexte_textbox.Text = "Contexte";
                Contexte_textbox.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmer les informations ?", "Confirmer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DateTime now = DateTime.Now;
                DateTime time_GMT = DateTime.Now.ToUniversalTime();

                chemin = "Analyse du " + time_GMT.ToString("dd-MM-yyyy à HH") + "h " + time_GMT.ToString("mm") + "m " + time_GMT.ToString("ss") + "s";

                StreamWriter info = new StreamWriter("Informations sur l'analyse.txt");
                info.WriteLine("Obervateur : " + Organisateur_textbox.Text);
                info.WriteLine("");
                info.WriteLine("Participant");
                info.WriteLine("Nom : " + Participant_nom.Text);
                info.WriteLine("Spécialité : " + Participant_specialite.Text);
                info.WriteLine("Qualification : " + Participant_qualification.Text);
                info.WriteLine("Ancienneté : " + Participant_anciennete.Text);
                info.WriteLine("");
                info.WriteLine("Date PC : " + now.ToString("dd-MM-yyyy HH:mm:ss"));
                info.WriteLine("Date GMT : " + time_GMT.ToString("dd-MM-yyyy HH:mm:ss"));
                info.WriteLine("");
                info.WriteLine("Contexte : " + Contexte_textbox.Text);
                info.Close();

                System.IO.Directory.CreateDirectory(chemin);

                file_name = titre_textbox.Text;

                XmlTextWriter xmlWriter = new XmlTextWriter(titre_textbox.Text + ".xml", Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Analyse");


                    xmlWriter.WriteStartElement("Observateur");
                    xmlWriter.WriteAttributeString("Nom", Organisateur_textbox.Text);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Participant");
                        xmlWriter.WriteStartElement("Nom");
                        xmlWriter.WriteString(Participant_nom.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("Specialite");
                        xmlWriter.WriteString(Participant_specialite.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("Qualification");
                        xmlWriter.WriteString(Participant_qualification.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("Anciennete");
                        xmlWriter.WriteString(Participant_anciennete.Text);
                        xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Date");
                    xmlWriter.WriteString(time_GMT.ToString("yyyy-MM-dd"));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Contexte");
                    xmlWriter.WriteString(Contexte_textbox.Text);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Tags");
                        xmlWriter.WriteStartElement("Tag");
                            xmlWriter.WriteStartElement("Heure");
                            xmlWriter.WriteString("Null");
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteStartElement("Duree");
                            xmlWriter.WriteString("Null");
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteStartElement("Carte");
                            xmlWriter.WriteAttributeString("Categorie", "Null");
                            xmlWriter.WriteAttributeString("Titre", "Null");
                            xmlWriter.WriteAttributeString("Type", "Null");
                                xmlWriter.WriteStartElement("Commentaire");
                                xmlWriter.WriteString("Null");
                                xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();

                File.Move("Informations sur l'analyse.txt", chemin + "\\Informations sur l'analyse.txt");

                Button_menu button_menu = new Button_menu();
                button_menu.Show();
                this.Hide();

            }

            else
            { }
        
        }

    }
}
