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
    public partial class Button_menu : Form
    {
        bool etat = false;
        choix_etiquette menu_etiquette = new choix_etiquette(new Point(0, 0));
        public static form1 menu_principal;
        public static int button_menu_width;

        public Button_menu()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.WorkingArea.Right;
            this.Height = Screen.PrimaryScreen.WorkingArea.Bottom;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            this.Location = new Point(0, 0);

            Open_menu.Size = new Size(this.Width / 30, this.Height / 5);
            button_menu_width = Open_menu.Width;
            Open_menu.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - Open_menu.Width, (Screen.PrimaryScreen.WorkingArea.Bottom / 2) - Open_menu.Height / 2);
            menu_principal = new form1(menu_etiquette, this);
        }

        public void Open_menu_Click(object sender, EventArgs e)
        {
            menu_principal.Close_color();
            Methode_to_close();
        }

        public void Methode_to_close()
        {
            if (!etat)
            {
                menu_principal.Show();
                this.Refresh();
                do
                {
                    Open_menu.Location = new Point(Open_menu.Location.X - 1, Open_menu.Location.Y);
                    menu_principal.Location = new Point(menu_principal.Location.X - 1, menu_principal.Location.Y);
                    System.Threading.Thread.Sleep(0);
                } while (Open_menu.Location.X != Screen.PrimaryScreen.WorkingArea.Left);

                this.TopMost = true;
                etat = true;
                menu_principal.clear_list_tags();
            }

            else
            {
                if (menu_principal.Visible == true)
                {
                    this.Refresh();
                    do
                    {
                        Open_menu.Location = new Point(Open_menu.Location.X + 1, Open_menu.Location.Y);
                        menu_principal.Location = new Point(menu_principal.Location.X + 1, menu_principal.Location.Y);
                    } while (Open_menu.Location.X != Screen.PrimaryScreen.WorkingArea.Right - Open_menu.Width);

                    menu_principal.Hide();
                    etat = false;
                    menu_etiquette.clear_list();
                    menu_principal.clear_list_tags();
                }

                else
                {
                    do
                    {
                        Open_menu.Location = new Point(Open_menu.Location.X + 1, Open_menu.Location.Y);
                        menu_etiquette.Location = new Point(menu_etiquette.Location.X + 1, menu_etiquette.Location.Y);
                    } while (Open_menu.Location.X != Screen.PrimaryScreen.WorkingArea.Right - Open_menu.Width);

                    menu_principal.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right, 0);
                    menu_etiquette.Hide();
                    etat = false;
                    menu_etiquette.clear_list();
                    menu_principal.clear_list_tags();
                }
            }

        }
    }
}
