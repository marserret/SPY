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
    public partial class choix_etiquette : Form
    {
        List<Button> buttons = new List<Button>();
        List<Button> buttons_minus = new List<Button>();
        List<Button> buttons_plus = new List<Button>();

        TextBox newTextBox;
        string user_choice;
        Label title = new Label();
        bool result;
        int indice;
        bool statut;

        Button back = new Button();
        Button valid = new Button();

        public choix_etiquette(Point Location)
        {
            InitializeComponent();
            this.Location = Location;
            this.Width = Screen.PrimaryScreen.WorkingArea.Right - Button_menu.button_menu_width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Bottom;
            this.TopMost = true;

            back.BackgroundImage = ((System.Drawing.Image) (Properties.Resources.reply));
            back.BackColor = Color.Transparent;
            back.BackgroundImageLayout = ImageLayout.Stretch;
            back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            back.TabStop = false;
            back.Size = new Size(this.Height * 50 / 600, this.Height * 50 / 600);
            back.FlatAppearance.BorderSize = 0;
            this.Controls.Add(back);
            back.Click += new EventHandler(back_button_Click);


            valid.TabStop = false;
            valid.Size = new Size(this.Height * 150 / 600, this.Height * 40 / 600);
            valid.Font = new Font("Arial Narrow", 12 * this.Width / 900);
            valid.Text = "Terminer";
            valid.Visible = false;
            this.Controls.Add(valid); 
            valid.Click += new EventHandler(valid_button_Click);

            title.BackColor = Color.Transparent;
            this.Controls.Add(title);
        }

        public void true_position(Point true_location)
        {
            this.Location = true_location;
        }

        public void creation_buttons(string choice)
        {
            buttons.Clear();
            buttons_minus.Clear();
            buttons_plus.Clear();
            user_choice = choice;

            if (choice == "sécurité" || choice == "SA" || choice == "performance")
            {
                for (int i = 0; i < 4; i++)
                {         
                    Button newButton = new Button();
                    newButton.BackgroundImage = ((System.Drawing.Image) (Properties.Resources.minus_symbol));
                    newButton.BackColor = Color.Transparent;
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    newButton.TabStop = false;
                    newButton.Size = new Size(this.Height * 60 / 600, this.Height * 60 / 600);           
                    newButton.FlatAppearance.BorderSize = 0;
                    buttons_minus.Add(newButton);
                    this.Controls.Add(newButton);
                }

                for (int i = 0; i < 4; i++)
                {
                    Button newButton = new Button();
                    newButton.BackgroundImage = ((System.Drawing.Image) (Properties.Resources.plus_button));
                    newButton.BackColor = Color.Transparent;
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    newButton.TabStop = false;
                    newButton.Size = new Size(this.Height * 60 / 600, this.Height * 60 / 600);
                    buttons_plus.Add(newButton);
                    this.Controls.Add(newButton);
                }

                if (choice == "sécurité")
                {
                    for (int i = 2; i < form1.securite.Length; i++)
                    {
                        Button newButton = new Button();
                        newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        newButton.FlatAppearance.BorderColor = Color.FromArgb(255, 253, 184, 19);
                        newButton.FlatAppearance.BorderSize = 2;
                        newButton.Font = new Font("Arial Narrow", 12 * this.Width / 900);
                        newButton.ForeColor = Color.FromArgb(255, 253, 184, 19);
                        newButton.Size = new Size(this.Width * 150 / 900, this.Height * 60 / 600);
                        newButton.Text = form1.securite[i][1];
                        buttons.Add(newButton);
                        this.Controls.Add(newButton);
                        i++;
                    }

                    title.Text = "Sécurité";
                    title.Font = new Font("Arial", 30 * this.Width / 900, FontStyle.Underline);
                    title.ForeColor = Color.FromArgb(255, 253, 184, 19);
                    title.Location = new Point(this.Width * 65 / 900, this.Height * 40 / 600);
                    title.Width = TextRenderer.MeasureText(title.Text, title.Font).Width;
                    title.Height = 60 * this.Width / 900;
                    back.Location = new Point(title.Location.X + title.Width, this.Height * 40 / 600);
                }

                else if (choice == "SA")
                {
                    for (int i = 2; i < form1.sa.Length; i++)
                    {
                        Button newButton = new Button();
                        newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        newButton.FlatAppearance.BorderColor = Color.FromArgb(255, 143, 114, 81);
                        newButton.FlatAppearance.BorderSize = 2;
                        newButton.Font = new Font("Arial Narrow", 12 * this.Width / 900);
                        newButton.ForeColor = Color.FromArgb(255, 143, 114, 81);
                        newButton.Size = new Size(this.Width * 150 / 900, this.Height * 60 / 600);
                        newButton.Text = form1.sa[i][1];
                        buttons.Add(newButton);
                        this.Controls.Add(newButton);
                        i++;
                    }

                    title.Text = "S.A";
                    title.Font = new Font("Arial", 30 * this.Width / 900, FontStyle.Underline);
                    title.ForeColor = Color.FromArgb(255, 143, 114, 81);
                    title.Location = new Point(this.Width * 65 / 900, this.Height * 40 / 600);
                    title.Width = TextRenderer.MeasureText(title.Text, title.Font).Width;
                    title.Height = 60 * this.Width / 900;
                    back.Location = new Point(title.Location.X + title.Width, this.Height * 40 / 600);
                }

                else
                {
                    for (int i = 2; i < form1.performance.Length; i++)
                    {
                        Button newButton = new Button();
                        newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        newButton.FlatAppearance.BorderColor = Color.FromArgb(255, 153, 53, 255);
                        newButton.FlatAppearance.BorderSize = 2;
                        newButton.Font = new Font("Arial Narrow", 12 * this.Width / 900);
                        newButton.ForeColor = Color.FromArgb(255, 153, 53, 255);
                        newButton.Size = new Size(this.Width * 150 / 900, this.Height * 60 / 600);
                        newButton.Text = form1.performance[i][1];
                        buttons.Add(newButton);
                        this.Controls.Add(newButton);
                        i++;
                    }

                    title.Text = "Performance";
                    title.Font = new Font("Arial", 30 * this.Width / 900, FontStyle.Underline);
                    title.ForeColor = Color.FromArgb(255, 153, 53, 255);
                    title.Location = new Point(this.Width * 65 / 900, this.Height * 40 / 600);
                    title.Width = TextRenderer.MeasureText(title.Text, title.Font).Width;
                    title.Height = 60 * this.Width / 900;
                    back.Location = new Point(title.Location.X + title.Width, this.Height * 40 / 600);
                }

            }

            else if (choice == "comportement")
            {
                for (int i = 0; i < 8; i++)
                {
                    Button newButton = new Button();
                    newButton.BackgroundImage = ((System.Drawing.Image) (Properties.Resources.minus_symbol));
                    newButton.BackColor = Color.Transparent;
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    newButton.TabStop = false;
                    newButton.Size = new Size(this.Height * 60 / 600, this.Height * 60 / 600);
                    newButton.FlatAppearance.BorderSize = 0;
                    buttons_minus.Add(newButton);
                    this.Controls.Add(newButton);
                }

                for (int i = 0; i < 8; i++)
                {
                    Button newButton = new Button();
                    newButton.BackgroundImage = ((System.Drawing.Image) (Properties.Resources.plus_button));
                    newButton.BackColor = Color.Transparent;
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    newButton.TabStop = false;
                    newButton.Size = new Size(this.Height * 60 / 600, this.Height * 60 / 600);
                    buttons_plus.Add(newButton);
                    this.Controls.Add(newButton);
                }

                for (int i = 2; i < form1.comportement.Length; i++)
                {
                    Button newButton = new Button();
                    newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    newButton.FlatAppearance.BorderColor = Color.FromArgb(255, 6, 159, 219);
                    newButton.FlatAppearance.BorderSize = 2;
                    newButton.Font = new Font("Arial Narrow", 12 * this.Width / 900);
                    newButton.ForeColor = Color.FromArgb(255, 6, 159, 219);
                    newButton.Size = new Size(this.Width * 150 / 900, this.Height * 60 / 600);
                    newButton.Text = form1.comportement[i][1];
                    buttons.Add(newButton);
                    this.Controls.Add(newButton);
                    i++;
                }



                title.Text = "Comportement";
                title.Font = new Font("Arial", 30 * this.Width / 900, FontStyle.Underline);
                title.ForeColor = Color.FromArgb(255, 6, 159, 219);
                title.Location = new Point(this.Width * 65 / 900, this.Height * 40 / 600);
                title.Width = TextRenderer.MeasureText(title.Text, title.Font).Width;
                title.Height = 60 * this.Width / 900;
                back.Location = new Point(title.Location.X + title.Width, this.Height * 40 / 600);
            }

            else
            {
                newTextBox = new TextBox();
                newTextBox.Multiline = true;
                newTextBox.Size = new Size(this.Width - (this.Width * 10 / 100), this.Height - (this.Height * 30 / 100));
                newTextBox.Location = new Point(this.Width * 3 / 100, this.Height * 25 / 100);
                newTextBox.Font = new Font("Arial", 10 * this.Width / 900);
                this.Controls.Add(newTextBox);

                title.Text = "Commentaire";
                title.Font = new Font("Arial", 30 * this.Width / 900, FontStyle.Underline);
                title.ForeColor = Color.FromArgb(255, 0, 0, 0);
                title.Location = new Point(this.Width * 65 / 900, this.Height * 40 / 600);
                title.Width = TextRenderer.MeasureText(title.Text, title.Font).Width;
                title.Height = 60 * this.Width / 900;
                back.Location = new Point(title.Location.X + title.Width, this.Height * 40 / 600);
                valid.Location = new Point(title.Location.X + title.Width + this.Width * 300 / 900, this.Height * 60 / 600);
                valid.Visible = true;
            }    

        }

        public void affichage_buttons()
        {
            if (user_choice == "sécurité" || user_choice == "SA" || user_choice == "performance")
            {
                //first choice
                buttons_minus[0].Location = new Point(this.Width * 65 / 900, this.Height * 200 / 600);
                buttons_minus[0].Click += new EventHandler(Button_securite_click);
                buttons[0].Location = new Point((this.Width / 900) * (buttons_minus[0].Location.X + (35 * this.Width / 900) + buttons_minus[0].Width), this.Height * 200 / 600);
                buttons_plus[0].Location = new Point((this.Width / 900) * (buttons[0].Location.X + (35 * this.Width / 900) + buttons[0].Width), this.Height * 200 / 600);
                buttons_plus[0].Click += new EventHandler(Button_securite_click);

                //second choice
                buttons_plus[1].Location = new Point((this.Width / 900) * (this.Width - (65 * this.Width / 900) - buttons_plus[1].Width), this.Height * 200 / 600);
                buttons_plus[1].Click += new EventHandler(Button_securite_click);
                buttons[1].Location = new Point((this.Width / 900) * (buttons_plus[1].Location.X - (35 * this.Width / 900) - buttons[1].Width), this.Height * 200 / 600);
                buttons_minus[1].Location = new Point((this.Width / 900) * (buttons[1].Location.X - (35 * this.Width / 900) - buttons_minus[1].Width), this.Height * 200 / 600);
                buttons_minus[1].Click += new EventHandler(Button_securite_click);

                //third choice
                buttons_minus[2].Location = new Point(this.Width * 65 / 900, buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 120 / 600));
                buttons_minus[2].Click += new EventHandler(Button_securite_click);
                buttons[2].Location = new Point((this.Width / 900) * (buttons_minus[0].Location.X + (35 * this.Width / 900) + buttons_minus[0].Width), buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 120 / 600));
                buttons_plus[2].Location = new Point((this.Width / 900) * (buttons[2].Location.X + (35 * this.Width / 900) + buttons[2].Width), buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 120 / 600));
                buttons_plus[2].Click += new EventHandler(Button_securite_click);

                //fourth choice
                buttons_plus[3].Location = new Point((this.Width / 900) * (this.Width - (65 * this.Width / 900) - buttons_plus[1].Width), buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 120 / 600));
                buttons_plus[3].Click += new EventHandler(Button_securite_click);
                buttons[3].Location = new Point((this.Width / 900) * (buttons_plus[1].Location.X - (35 * this.Width / 900) - buttons[1].Width), buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 120 / 600));
                buttons_minus[3].Location = new Point((this.Width / 900) * (buttons[1].Location.X - (35 * this.Width / 900) - buttons_minus[1].Width), buttons_minus[0].Location.Y + buttons_minus[1].Height + (this.Height * 120 / 600));
                buttons_minus[3].Click += new EventHandler(Button_securite_click);
            }

            else if(user_choice == "comportement")
            {
                //first choice
                buttons_minus[0].Location = new Point(this.Width * 65 / 900, this.Height * 150 / 600);
                buttons_minus[0].Click += new EventHandler(Button_securite_click);
                buttons[0].Location = new Point((this.Width / 900) * (buttons_minus[0].Location.X + (35 * this.Width / 900) + buttons_minus[0].Width), this.Height * 150 / 600);
                buttons_plus[0].Location = new Point((this.Width / 900) * (buttons[0].Location.X + (35 * this.Width / 900) + buttons[0].Width), this.Height * 150 / 600);
                buttons_plus[0].Click += new EventHandler(Button_securite_click);

                //second choice
                buttons_plus[1].Location = new Point((this.Width / 900) * (this.Width - (65 * this.Width / 900) - buttons_plus[1].Width), this.Height * 150 / 600);
                buttons_plus[1].Click += new EventHandler(Button_securite_click);
                buttons[1].Location = new Point((this.Width / 900) * (buttons_plus[1].Location.X - (35 * this.Width / 900) - buttons[1].Width), this.Height * 150 / 600);
                buttons_minus[1].Location = new Point((this.Width / 900) * (buttons[1].Location.X - (35 * this.Width / 900) - buttons_minus[1].Width), this.Height * 150 / 600);
                buttons_minus[1].Click += new EventHandler(Button_securite_click);

                //third choice
                buttons_minus[2].Location = new Point(this.Width * 65 / 900, buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 50 / 600));
                buttons_minus[2].Click += new EventHandler(Button_securite_click);
                buttons[2].Location = new Point((this.Width / 900) * (buttons_minus[0].Location.X + (35 * this.Width / 900) + buttons_minus[0].Width), buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 50 / 600));
                buttons_plus[2].Location = new Point((this.Width / 900) * (buttons[2].Location.X + (35 * this.Width / 900) + buttons[2].Width), buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 50 / 600));
                buttons_plus[2].Click += new EventHandler(Button_securite_click);

                //fourth choice
                buttons_plus[3].Location = new Point((this.Width / 900) * (this.Width - (65 * this.Width / 900) - buttons_plus[1].Width), buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 50 / 600));
                buttons_plus[3].Click += new EventHandler(Button_securite_click);
                buttons[3].Location = new Point((this.Width / 900) * (buttons_plus[1].Location.X - (35 * this.Width / 900) - buttons[1].Width), buttons_minus[0].Location.Y + buttons_minus[0].Height + (this.Height * 50 / 600));
                buttons_minus[3].Location = new Point((this.Width / 900) * (buttons[1].Location.X - (35 * this.Width / 900) - buttons_minus[1].Width), buttons_minus[0].Location.Y + buttons_minus[1].Height + (this.Height * 50 / 600));
                buttons_minus[3].Click += new EventHandler(Button_securite_click);

                //fifth choice
                buttons_minus[4].Location = new Point(this.Width * 65 / 900, buttons_minus[3].Location.Y + buttons_minus[3].Height + (this.Height * 50 / 600));
                buttons_minus[4].Click += new EventHandler(Button_securite_click);
                buttons[4].Location = new Point((this.Width / 900) * (buttons_minus[2].Location.X + (35 * this.Width / 900) + buttons_minus[2].Width), buttons_minus[3].Location.Y + buttons_minus[3].Height + (this.Height * 50 / 600));
                buttons_plus[4].Location = new Point((this.Width / 900) * (buttons[2].Location.X + (35 * this.Width / 900) + buttons[2].Width), buttons_minus[3].Location.Y + buttons_minus[3].Height + (this.Height * 50 / 600));
                buttons_plus[4].Click += new EventHandler(Button_securite_click);

                //sixth choice
                buttons_plus[5].Location = new Point((this.Width / 900) * (this.Width - (65 * this.Width / 900) - buttons_plus[1].Width), buttons_minus[3].Location.Y + buttons_minus[3].Height + (this.Height * 50 / 600));
                buttons_plus[5].Click += new EventHandler(Button_securite_click);
                buttons[5].Location = new Point((this.Width / 900) * (buttons_plus[1].Location.X - (35 * this.Width / 900) - buttons[1].Width), buttons_minus[3].Location.Y + buttons_minus[3].Height + (this.Height * 50 / 600));
                buttons_minus[5].Location = new Point((this.Width / 900) * (buttons[1].Location.X - (35 * this.Width / 900) - buttons_minus[1].Width), buttons_minus[3].Location.Y + buttons_minus[3].Height + (this.Height * 50 / 600));
                buttons_minus[5].Click += new EventHandler(Button_securite_click);

                //seventh choice
                buttons_minus[6].Location = new Point(this.Width * 65 / 900, buttons_minus[5].Location.Y + buttons_minus[5].Height + (this.Height * 50 / 600));
                buttons_minus[6].Click += new EventHandler(Button_securite_click);
                buttons[6].Location = new Point((this.Width / 900) * (buttons_minus[2].Location.X + (35 * this.Width / 900) + buttons_minus[2].Width), buttons_minus[5].Location.Y + buttons_minus[5].Height + (this.Height * 50 / 600));
                buttons_plus[6].Location = new Point((this.Width / 900) * (buttons[2].Location.X + (35 * this.Width / 900) + buttons[2].Width), buttons_minus[5].Location.Y + buttons_minus[5].Height + (this.Height * 50 / 600));
                buttons_plus[6].Click += new EventHandler(Button_securite_click);

                //eigth choice
                buttons_plus[7].Location = new Point((this.Width / 900) * (this.Width - (65 * this.Width / 900) - buttons_plus[1].Width), buttons_minus[5].Location.Y + buttons_minus[5].Height + (this.Height * 50 / 600));
                buttons_plus[7].Click += new EventHandler(Button_securite_click);
                buttons[7].Location = new Point((this.Width / 900) * (buttons_plus[1].Location.X - (35 * this.Width / 900) - buttons[1].Width), buttons_minus[5].Location.Y + buttons_minus[5].Height + (this.Height * 50 / 600));
                buttons_minus[7].Location = new Point((this.Width / 900) * (buttons[1].Location.X - (35 * this.Width / 900) - buttons_minus[1].Width), buttons_minus[5].Location.Y + buttons_minus[5].Height + (this.Height * 50 / 600));
                buttons_minus[7].Click += new EventHandler(Button_securite_click);
            }

            foreach (string[] tag in form1.list_tags)
            {
                if (user_choice == "sécurité")
                {
                    for (int i = 2; i < form1.securite.Length; i++)
                    {
                        if (tag == form1.securite[i] && i % 2 == 0)
                            buttons_minus[(i / 2) - 1].BackColor = Color.LightGray;

                        else if (tag == form1.securite[i] && i % 2 != 0)
                            buttons_plus[(i / 2) - 1].BackColor = Color.LightGray;
                    }
                }

                else if (user_choice == "comportement")
                {
                    for (int i = 2; i < form1.comportement.Length; i++)
                    {
                        if (tag == form1.comportement[i] && i % 2 == 0)
                            buttons_minus[(i / 2) - 1].BackColor = Color.LightGray;

                        else if (tag == form1.comportement[i] && i % 2 != 0)
                            buttons_plus[(i / 2) - 1].BackColor = Color.LightGray;
                    }
                }


                else if (user_choice == "performance")
                {
                    for (int i = 2; i < form1.performance.Length; i++)
                    {
                        if (tag == form1.performance[i] && i % 2 == 0)
                            buttons_minus[(i / 2) - 1].BackColor = Color.LightGray;

                        else if (tag == form1.performance[i] && i % 2 != 0)
                            buttons_plus[(i / 2) - 1].BackColor = Color.LightGray;
                    }
                }

                else
                {
                    for (int i = 2; i < form1.sa.Length; i++)
                    {
                        if (tag == form1.sa[i] && i % 2 == 0)
                            buttons_minus[(i / 2) - 1].BackColor = Color.LightGray;

                        else if (tag == form1.sa[i] && i % 2 != 0)
                            buttons_plus[(i / 2) - 1].BackColor = Color.LightGray;
                    }
                }
            }
        }


        public void clear_list()
        {
            foreach (Button button in buttons)
            {
                this.Controls.Remove(button);
            }

            foreach (Button button in buttons_minus)
            {
                this.Controls.Remove(button);
            }

            foreach (Button button in buttons_plus)
            {
                this.Controls.Remove(button);
            }

            this.Controls.Remove(newTextBox);

            valid.Visible = false;
            buttons.Clear();
            buttons_minus.Clear();
            buttons_plus.Clear();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            valid.Visible = false;
            clear_list();
            Button_menu.menu_principal.Show();
            this.Hide();
        }

        private void valid_button_Click(object sender, EventArgs e)
        {
            string[] comment = new string[3];
            comment[0] = "Commentaire";
            comment[1] = "Commentaire";
            comment[2] = "Null";
            form1.comment = newTextBox.Text;
            form1.list_tags.Add(comment);
            valid.Visible = false;
            Button_menu.menu_principal.Show();
            this.Hide();
        }

        private void Button_securite_click(object sender, EventArgs e)
        {
                Button button_choice = (Button)sender;
                Attribution_indice(button_choice);

            if (!statut)
            {
                if (result == false)
                {
                    if(user_choice == "sécurité")
                        form1.list_tags.Add(form1.securite[indice]);

                    else if (user_choice == "SA")
                        form1.list_tags.Add(form1.sa[indice]);

                    else if (user_choice == "performance")
                        form1.list_tags.Add(form1.performance[indice]);

                    else
                        form1.list_tags.Add(form1.comportement[indice]);

                    button_choice.BackColor = Color.LightGray;
                }

                else
                {
                    if (user_choice == "sécurité")
                        form1.list_tags.Remove(form1.list_tags.Find(x => x == form1.securite[indice]));

                    else if (user_choice == "SA")
                        form1.list_tags.Remove(form1.list_tags.Find(x => x == form1.sa[indice]));

                    else if (user_choice == "performance")
                        form1.list_tags.Remove(form1.list_tags.Find(x => x == form1.performance[indice]));

                    else
                        form1.list_tags.Remove(form1.list_tags.Find(x => x == form1.comportement[indice]));

                    button_choice.BackColor = Color.Transparent;
                }
            }

            else
            {

                if (result == false)
                {
                    if (user_choice == "sécurité")
                        form1.list_tags.Add(form1.securite[indice]);

                    else if (user_choice == "SA")
                        form1.list_tags.Add(form1.sa[indice]);

                    else if (user_choice == "performance")
                        form1.list_tags.Add(form1.performance[indice]);

                    else
                        form1.list_tags.Add(form1.comportement[indice]);

                    button_choice.BackColor = Color.LightGray;
                }

                else
                {
                    if (user_choice == "sécurité")
                        form1.list_tags.Remove(form1.list_tags.Find(x => x == form1.securite[indice]));

                    else if (user_choice == "SA")
                        form1.list_tags.Remove(form1.list_tags.Find(x => x == form1.sa[indice]));

                    else if (user_choice == "performance")
                        form1.list_tags.Remove(form1.list_tags.Find(x => x == form1.performance[indice]));

                    else
                        form1.list_tags.Remove(form1.list_tags.Find(x => x == form1.comportement[indice]));

                    button_choice.BackColor = Color.Transparent;
                }
            }
        }

        private void Attribution_indice(Button button_choice)
        {

            if (buttons_minus.Exists(x => x == button_choice))
            {
                indice = buttons_minus.IndexOf(button_choice) * 2 + 2;
                statut = false;
            }

            if (buttons_plus.Exists(x => x == button_choice))
            {
                indice = buttons_plus.IndexOf(button_choice) * 2 + 3;
                statut = true;
            }

            if (user_choice == "sécurité")
                result = form1.list_tags.Exists(x => x == form1.securite[indice]);

            if (user_choice == "SA")
                result = form1.list_tags.Exists(x => x == form1.sa[indice]);

            if (user_choice == "performance")
                result = form1.list_tags.Exists(x => x == form1.performance[indice]);

            if (user_choice == "comportement")
                result = form1.list_tags.Exists(x => x == form1.comportement[indice]);
        }

    }
}
