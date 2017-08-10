namespace Prise_Note
{
    partial class form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.securite_button = new System.Windows.Forms.Button();
            this.comportement_button = new System.Windows.Forms.Button();
            this.performance_button = new System.Windows.Forms.Button();
            this.sa_button = new System.Windows.Forms.Button();
            this.commentaire_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.valid_button = new System.Windows.Forms.Button();
            this.timeline = new WindowsFormsControlLibrary1.ControlBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.commentaire_icon = new System.Windows.Forms.Button();
            this.sa_moins = new System.Windows.Forms.Button();
            this.performance_moins = new System.Windows.Forms.Button();
            this.comportement_moins = new System.Windows.Forms.Button();
            this.securite_moins = new System.Windows.Forms.Button();
            this.sa_plus = new System.Windows.Forms.Button();
            this.performance_plus = new System.Windows.Forms.Button();
            this.comportement_plus = new System.Windows.Forms.Button();
            this.securite_plus = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // securite_button
            // 
            this.securite_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.securite_button.BackColor = System.Drawing.Color.White;
            this.securite_button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securite_button.Location = new System.Drawing.Point(155, 23);
            this.securite_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.securite_button.Name = "securite_button";
            this.securite_button.Size = new System.Drawing.Size(149, 60);
            this.securite_button.TabIndex = 9;
            this.securite_button.Text = "Sécurité";
            this.securite_button.UseVisualStyleBackColor = false;
            this.securite_button.Click += new System.EventHandler(this.securite_button_Click);
            // 
            // comportement_button
            // 
            this.comportement_button.BackColor = System.Drawing.Color.White;
            this.comportement_button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comportement_button.Location = new System.Drawing.Point(155, 155);
            this.comportement_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comportement_button.Name = "comportement_button";
            this.comportement_button.Size = new System.Drawing.Size(149, 60);
            this.comportement_button.TabIndex = 10;
            this.comportement_button.Text = "Comportement";
            this.comportement_button.UseVisualStyleBackColor = false;
            this.comportement_button.Click += new System.EventHandler(this.comportement_button_Click);
            // 
            // performance_button
            // 
            this.performance_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.performance_button.BackColor = System.Drawing.Color.White;
            this.performance_button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performance_button.Location = new System.Drawing.Point(585, 23);
            this.performance_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.performance_button.Name = "performance_button";
            this.performance_button.Size = new System.Drawing.Size(149, 60);
            this.performance_button.TabIndex = 11;
            this.performance_button.Text = "Performance";
            this.performance_button.UseVisualStyleBackColor = false;
            this.performance_button.Click += new System.EventHandler(this.performance_button_Click);
            // 
            // sa_button
            // 
            this.sa_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sa_button.BackColor = System.Drawing.Color.White;
            this.sa_button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sa_button.Location = new System.Drawing.Point(585, 155);
            this.sa_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sa_button.Name = "sa_button";
            this.sa_button.Size = new System.Drawing.Size(149, 60);
            this.sa_button.TabIndex = 12;
            this.sa_button.Text = "S.A";
            this.sa_button.UseVisualStyleBackColor = false;
            this.sa_button.Click += new System.EventHandler(this.sa_button_Click);
            // 
            // commentaire_button
            // 
            this.commentaire_button.BackColor = System.Drawing.Color.White;
            this.commentaire_button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentaire_button.Location = new System.Drawing.Point(155, 287);
            this.commentaire_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentaire_button.Name = "commentaire_button";
            this.commentaire_button.Size = new System.Drawing.Size(149, 60);
            this.commentaire_button.TabIndex = 13;
            this.commentaire_button.Text = "Commentaire";
            this.commentaire_button.UseVisualStyleBackColor = false;
            this.commentaire_button.Click += new System.EventHandler(this.commentaire_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_button.BackColor = System.Drawing.Color.White;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(201, 385);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(149, 60);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Annuler";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // valid_button
            // 
            this.valid_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valid_button.BackColor = System.Drawing.Color.White;
            this.valid_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_button.Location = new System.Drawing.Point(551, 385);
            this.valid_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valid_button.Name = "valid_button";
            this.valid_button.Size = new System.Drawing.Size(149, 60);
            this.valid_button.TabIndex = 17;
            this.valid_button.Text = "Valider";
            this.valid_button.UseVisualStyleBackColor = false;
            this.valid_button.Click += new System.EventHandler(this.valid_button_Click);
            // 
            // timeline
            // 
            this.timeline.Location = new System.Drawing.Point(51, 510);
            this.timeline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeline.Maximum = ((long)(60));
            this.timeline.Minimum = ((long)(0));
            this.timeline.Name = "timeline";
            this.timeline.ProgressBarColor = System.Drawing.Color.Blue;
            this.timeline.Size = new System.Drawing.Size(771, 58);
            this.timeline.TabIndex = 21;
            this.timeline.Value = ((long)(0));
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // commentaire_icon
            // 
            this.commentaire_icon.BackColor = System.Drawing.Color.Transparent;
            this.commentaire_icon.BackgroundImage = global::Prise_Note.Properties.Resources.keyboard;
            this.commentaire_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commentaire_icon.FlatAppearance.BorderSize = 0;
            this.commentaire_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentaire_icon.Location = new System.Drawing.Point(60, 287);
            this.commentaire_icon.Margin = new System.Windows.Forms.Padding(0);
            this.commentaire_icon.Name = "commentaire_icon";
            this.commentaire_icon.Size = new System.Drawing.Size(60, 60);
            this.commentaire_icon.TabIndex = 14;
            this.commentaire_icon.UseVisualStyleBackColor = false;
            this.commentaire_icon.Click += new System.EventHandler(this.commentaire_icon_Click);
            // 
            // sa_moins
            // 
            this.sa_moins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sa_moins.BackColor = System.Drawing.Color.Transparent;
            this.sa_moins.BackgroundImage = global::Prise_Note.Properties.Resources.minus_symbol;
            this.sa_moins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sa_moins.FlatAppearance.BorderSize = 0;
            this.sa_moins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sa_moins.Location = new System.Drawing.Point(491, 155);
            this.sa_moins.Margin = new System.Windows.Forms.Padding(0);
            this.sa_moins.Name = "sa_moins";
            this.sa_moins.Size = new System.Drawing.Size(60, 60);
            this.sa_moins.TabIndex = 8;
            this.sa_moins.UseVisualStyleBackColor = false;
            this.sa_moins.Click += new System.EventHandler(this.sa_moins_Click);
            // 
            // performance_moins
            // 
            this.performance_moins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.performance_moins.BackColor = System.Drawing.Color.Transparent;
            this.performance_moins.BackgroundImage = global::Prise_Note.Properties.Resources.minus_symbol;
            this.performance_moins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.performance_moins.FlatAppearance.BorderSize = 0;
            this.performance_moins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performance_moins.Location = new System.Drawing.Point(491, 23);
            this.performance_moins.Margin = new System.Windows.Forms.Padding(0);
            this.performance_moins.Name = "performance_moins";
            this.performance_moins.Size = new System.Drawing.Size(60, 60);
            this.performance_moins.TabIndex = 7;
            this.performance_moins.UseVisualStyleBackColor = false;
            this.performance_moins.Click += new System.EventHandler(this.performance_moins_Click);
            // 
            // comportement_moins
            // 
            this.comportement_moins.BackColor = System.Drawing.Color.Transparent;
            this.comportement_moins.BackgroundImage = global::Prise_Note.Properties.Resources.minus_symbol;
            this.comportement_moins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comportement_moins.FlatAppearance.BorderSize = 0;
            this.comportement_moins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comportement_moins.Location = new System.Drawing.Point(60, 155);
            this.comportement_moins.Margin = new System.Windows.Forms.Padding(0);
            this.comportement_moins.Name = "comportement_moins";
            this.comportement_moins.Size = new System.Drawing.Size(60, 60);
            this.comportement_moins.TabIndex = 6;
            this.comportement_moins.UseVisualStyleBackColor = false;
            this.comportement_moins.Click += new System.EventHandler(this.comportement_moins_Click);
            // 
            // securite_moins
            // 
            this.securite_moins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.securite_moins.BackColor = System.Drawing.Color.Transparent;
            this.securite_moins.BackgroundImage = global::Prise_Note.Properties.Resources.minus_symbol;
            this.securite_moins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.securite_moins.FlatAppearance.BorderSize = 0;
            this.securite_moins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securite_moins.Location = new System.Drawing.Point(60, 23);
            this.securite_moins.Margin = new System.Windows.Forms.Padding(0);
            this.securite_moins.Name = "securite_moins";
            this.securite_moins.Size = new System.Drawing.Size(60, 60);
            this.securite_moins.TabIndex = 5;
            this.securite_moins.UseVisualStyleBackColor = false;
            this.securite_moins.Click += new System.EventHandler(this.securite_moins_Click);
            // 
            // sa_plus
            // 
            this.sa_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sa_plus.BackColor = System.Drawing.Color.Transparent;
            this.sa_plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sa_plus.BackgroundImage")));
            this.sa_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sa_plus.FlatAppearance.BorderSize = 0;
            this.sa_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sa_plus.Location = new System.Drawing.Point(771, 155);
            this.sa_plus.Margin = new System.Windows.Forms.Padding(0);
            this.sa_plus.Name = "sa_plus";
            this.sa_plus.Size = new System.Drawing.Size(60, 60);
            this.sa_plus.TabIndex = 4;
            this.sa_plus.UseVisualStyleBackColor = false;
            this.sa_plus.Click += new System.EventHandler(this.sa_plus_Click);
            // 
            // performance_plus
            // 
            this.performance_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.performance_plus.BackColor = System.Drawing.Color.Transparent;
            this.performance_plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("performance_plus.BackgroundImage")));
            this.performance_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.performance_plus.FlatAppearance.BorderSize = 0;
            this.performance_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performance_plus.Location = new System.Drawing.Point(771, 23);
            this.performance_plus.Margin = new System.Windows.Forms.Padding(0);
            this.performance_plus.Name = "performance_plus";
            this.performance_plus.Size = new System.Drawing.Size(60, 60);
            this.performance_plus.TabIndex = 3;
            this.performance_plus.UseVisualStyleBackColor = false;
            this.performance_plus.Click += new System.EventHandler(this.performance_plus_Click);
            // 
            // comportement_plus
            // 
            this.comportement_plus.BackColor = System.Drawing.Color.Transparent;
            this.comportement_plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comportement_plus.BackgroundImage")));
            this.comportement_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comportement_plus.FlatAppearance.BorderSize = 0;
            this.comportement_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comportement_plus.Location = new System.Drawing.Point(340, 155);
            this.comportement_plus.Margin = new System.Windows.Forms.Padding(0);
            this.comportement_plus.Name = "comportement_plus";
            this.comportement_plus.Size = new System.Drawing.Size(60, 60);
            this.comportement_plus.TabIndex = 2;
            this.comportement_plus.UseVisualStyleBackColor = false;
            this.comportement_plus.Click += new System.EventHandler(this.comportement_plus_Click);
            // 
            // securite_plus
            // 
            this.securite_plus.BackColor = System.Drawing.Color.Transparent;
            this.securite_plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("securite_plus.BackgroundImage")));
            this.securite_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.securite_plus.FlatAppearance.BorderSize = 0;
            this.securite_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securite_plus.Location = new System.Drawing.Point(340, 23);
            this.securite_plus.Margin = new System.Windows.Forms.Padding(0);
            this.securite_plus.Name = "securite_plus";
            this.securite_plus.Size = new System.Drawing.Size(60, 60);
            this.securite_plus.TabIndex = 20;
            this.securite_plus.UseVisualStyleBackColor = false;
            this.securite_plus.Click += new System.EventHandler(this.securite_plus_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prise_Note.Properties.Resources.LOGO_SPYPlan_de_travail_1_3x;
            this.pictureBox1.Location = new System.Drawing.Point(586, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeline);
            this.Controls.Add(this.valid_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.commentaire_icon);
            this.Controls.Add(this.commentaire_button);
            this.Controls.Add(this.sa_button);
            this.Controls.Add(this.performance_button);
            this.Controls.Add(this.comportement_button);
            this.Controls.Add(this.securite_button);
            this.Controls.Add(this.sa_moins);
            this.Controls.Add(this.performance_moins);
            this.Controls.Add(this.comportement_moins);
            this.Controls.Add(this.securite_moins);
            this.Controls.Add(this.sa_plus);
            this.Controls.Add(this.performance_plus);
            this.Controls.Add(this.comportement_plus);
            this.Controls.Add(this.securite_plus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Capture de Données d\'Activité";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.form1_Shown);
            this.Click += new System.EventHandler(this.form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button securite_plus;
        private System.Windows.Forms.Button comportement_plus;
        private System.Windows.Forms.Button performance_plus;
        private System.Windows.Forms.Button sa_plus;
        private System.Windows.Forms.Button securite_moins;
        private System.Windows.Forms.Button comportement_moins;
        private System.Windows.Forms.Button performance_moins;
        private System.Windows.Forms.Button sa_moins;
        private System.Windows.Forms.Button securite_button;
        private System.Windows.Forms.Button comportement_button;
        private System.Windows.Forms.Button performance_button;
        private System.Windows.Forms.Button sa_button;
        private System.Windows.Forms.Button commentaire_button;
        private System.Windows.Forms.Button commentaire_icon;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button valid_button;
        private WindowsFormsControlLibrary1.ControlBar timeline;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

