using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prise_Note
{
    public class OverlayControl : UserControl
    {
        public Pen pen = new Pen(Color.Green, 2);

        public Point point1 = new Point(2 + Screen.PrimaryScreen.WorkingArea.Bottom * 20 / 600, 2 + Screen.PrimaryScreen.WorkingArea.Bottom * 40 / 600);
        public Point point2 = new Point(2 + Screen.PrimaryScreen.WorkingArea.Bottom * 20 / 600, 60 + Screen.PrimaryScreen.WorkingArea.Bottom * 40 / 600);
        public Label title_tag = new Label();
        public Color inside_color = Color.Purple;
        public Info_tag info;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP =  base.CreateParams;
                CP.ExStyle |= 0x20;
                return CP;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //base.OnPaintBackground(pevent);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(inside_color);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(2, 2, Screen.PrimaryScreen.WorkingArea.Bottom * 40 / 600, Screen.PrimaryScreen.WorkingArea.Bottom * 40 / 600);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, rect);
            myBrush.Dispose();


            e.Graphics.DrawEllipse(pen, rect);
            e.Graphics.DrawLine(pen, point1, point2);

            title_tag.Size = new Size(Screen.PrimaryScreen.WorkingArea.Bottom * 34 / 600, Screen.PrimaryScreen.WorkingArea.Bottom * 13 / 600);
            title_tag.AutoSize = false;
            title_tag.TextAlign = ContentAlignment.MiddleCenter;
            title_tag.Font = new Font("Arial Narrow", 9 * Screen.PrimaryScreen.WorkingArea.Bottom/600);
            title_tag.Location = new Point(Screen.PrimaryScreen.WorkingArea.Bottom * 5 / 600, Screen.PrimaryScreen.WorkingArea.Bottom * 15 / 600);
            this.Controls.Add(title_tag);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OverlayControl
            // 
            this.Name = "OverlayControl";
            this.ResumeLayout(false);
            info.Visible = false;
        }



    }
}
