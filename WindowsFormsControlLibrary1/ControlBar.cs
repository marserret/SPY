using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Drawing2D;


namespace WindowsFormsControlLibrary1
{

    public partial class ControlBar: UserControl
    {

        long min = 0;// Minimum value for progress range
        public long max = 60;// Maximum value for progress range
        long val = 0;// Current progress
        private Color BarColor = Color.Blue;// Color of progress meter
        private Color color_refresh = Color.White;// Color of progress meter
        public PictureBox pb = new PictureBox();
        private Label HeureActuelle = new Label();
        public Label heureFin = new Label();
        private Label heureDebut = new Label();
        public bool refresh = false;

        public TimeSpan result;
        public DateTime begin;
        public DateTime end;
        private int i = 0;
        public Rectangle rect = new Rectangle();

        public System.Windows.Forms.Timer timer;


        protected override void OnResize(EventArgs e)
        {
           // Invalidate the control to get a repaint.
            this.Invalidate();
        }

        public ControlBar()
        {
            DateTime first_time = DateTime.Now;
            begin = first_time.ToUniversalTime();

            end = new DateTime();

            HeureActuelle.AutoSize = false;
            heureFin.AutoSize = false;
            heureDebut.AutoSize = false;

            var mf = new Font("Arial", 12,FontStyle.Bold);
            heureDebut.Font = mf ;
            heureFin.Font = mf;
            HeureActuelle.Font = mf;

            pb.Location = new Point(0, 2);
            pb.Width=20;
            pb.Height = 40;

            Bitmap bmp = new Bitmap(Properties.Resources.timeline);
           // bmp.MakeTransparent();
           //pb.BackColor = Color.FromArgb(50, 0, 0, 0);
            pb.Image = bmp;
            this.Controls.Add(pb);
            this.Controls.Add(HeureActuelle);
            this.Controls.Add(heureFin);
            this.Controls.Add(heureDebut);
            heureDebut.Left = 25;
            heureDebut.Top = 60;
            heureFin.Top = 60;
            HeureActuelle.Top = 60;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // specify interval time as you want
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        }

        private void moveCursor(object sender, MouseEventArgs e)
        {
            Value = Convert.ToInt64((e.Location.X * (max - min)) / this.Width);
        }

        protected override void OnPaint(PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            //heureFin.Text = this.end.ToString("HH:mm:ss");
            heureDebut.Text = begin.ToString("HH:mm:ss");

            heureFin.Left = this.ClientRectangle.Width - 25 - heureFin.Width;
            HeureActuelle.Left = this.ClientRectangle.Width / 2 - HeureActuelle.Width / 2;

            SolidBrush brush = new SolidBrush(BarColor);

            float percent = (float)(val - min) / (float)(max - min);
            rect = this.ClientRectangle;
            rect.Height =10;
            rect.Y =15;

                // Calculate area for drawing the progress.

            rect.Width = (int)(float)(this.Width * percent);
            pb.Location = new Point((int) (float) (this.Width * percent), 2);


            if (!refresh)
            {      
                // Draw the progress meter.
                g.FillRectangle(brush, rect);
                // Draw a three-dimensional border around the control.
                Draw3DBorder(g);
                // Clean up.
                brush.Dispose();
                g.Dispose();
                
            }

            if (refresh)
            {
                Graphics gra = this.CreateGraphics();

                brush = new SolidBrush(Color.White);
                gra.FillRectangle(brush, this.Width/2, 15, this.Width/2, 10);
                Draw3DBorder(g);
            }


            pb.Visible = true;
            HeureActuelle.Show();
            HeureActuelle.Visible = true;
            HeureActuelle.Refresh();

        }

        public long Minimum
        {
            get
            {
                return min;
            }

            set
            {
                // Prevent a negative value.
                if (value < 0)
                {
                    min = 0;
                }

                // Make sure that the minimum value is never set higher than the maximum value.
                if (value > max)
                {
                    min = value;
                    min = value;
                }

                // Ensure value is still in range
                if (val < min)
                {
                    val = min;
                }

                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        public long Maximum
        {
            get
            {
                return max;
            }

            set
            {
                // Make sure that the maximum value is never set lower than the minimum value.
                if (value < min)
                {
                    min = value;
                }

                max = value;

                // Make sure that value is still in range.
                if (val > max)
                {
                    val = max;
                }

                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        public long Value
        {
            get
            {
                return val;
            }

            set
            {
                long oldValue = val;

                // Make sure that the value does not stray outside the valid range.
                if (value < min)
                {
                    val = min;
                }
                else if (value > max)
                {
                    val = max;
                }
                else
                {
                    val = value;
                }

                // Invalidate only the changed area.
                float percent;

                Rectangle newValueRect = this.ClientRectangle;
                Rectangle oldValueRect = this.ClientRectangle;

                // Use a new value to calculate the rectangle for progress.
                percent = (float)(val - min) / (float)(max - min);
                newValueRect.Width = (int)((float)newValueRect.Width * percent);

                // Use an old value to calculate the rectangle for progress.
                percent = (float)(oldValue - min) / (float)(max - min);
                oldValueRect.Width = (int)((float)oldValueRect.Width * percent);

                Rectangle updateRect = new Rectangle();

                // Find only the part of the screen that must be updated.
                if (newValueRect.Width > oldValueRect.Width)
                {
                    updateRect.X = oldValueRect.Size.Width;
                    updateRect.Width = newValueRect.Width - oldValueRect.Width;
                }
                else
                {
                    updateRect.X = newValueRect.Size.Width;
                    updateRect.Width = oldValueRect.Width - newValueRect.Width;
                }

                updateRect.Height = this.Height;


                // Invalidate the intersection region only.
                this.Invalidate(updateRect);
            }
        }

        public Color ProgressBarColor
        {
            get
            {
                return BarColor;
            }

            set
            {
                BarColor = value;

                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        private void Draw3DBorder(Graphics g)
        {
            int PenWidth = (int)Pens.White.Width;

            g.DrawLine(Pens.DarkGray,
            new Point(this.ClientRectangle.Left, this.ClientRectangle.Top),
            new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Top));
            g.DrawLine(Pens.DarkGray,
            new Point(this.ClientRectangle.Left, this.ClientRectangle.Top),
            new Point(this.ClientRectangle.Left, this.ClientRectangle.Height - PenWidth));
            g.DrawLine(Pens.DarkGray,
            new Point(this.ClientRectangle.Left, this.ClientRectangle.Height - PenWidth),
            new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Height - PenWidth));
            g.DrawLine(Pens.DarkGray,
            new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Top),
            new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Height - PenWidth));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            result = TimeSpan.FromSeconds(i);
            string fromTimeString = result.ToString(@"hh\:mm\:ss");
            HeureActuelle.Text = fromTimeString;
            Value++;
            end = begin + result;
            heureFin.Text = end.ToString("HH:mm:ss");
            refresh = false;

            if(Value == max)
            {
                max = max * 2;
                refresh = true;
                
            }
        }

        public void finish ()
        {
            Graphics gra = this.CreateGraphics();

            SolidBrush square_brush = new SolidBrush(Color.White);
            gra.FillRectangle(square_brush, this.Location.X, this.Location.Y - 200, this.Width, 200);
        }
    }
    
}
