namespace Prise_Note
{
    partial class Button_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Open_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open_menu
            // 
            this.Open_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_menu.Location = new System.Drawing.Point(0, 0);
            this.Open_menu.Name = "Open_menu";
            this.Open_menu.Size = new System.Drawing.Size(60, 175);
            this.Open_menu.TabIndex = 1;
            this.Open_menu.Text = "|||";
            this.Open_menu.UseVisualStyleBackColor = true;
            this.Open_menu.Click += new System.EventHandler(Open_menu_Click);
            // 
            // Button_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1080);
            this.Controls.Add(this.Open_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Button_menu";
            this.Text = "Button_menu";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Open_menu;
    }
}