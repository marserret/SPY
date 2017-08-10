namespace Prise_Note
{
    partial class Initialisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initialisation));
            this.label1 = new System.Windows.Forms.Label();
            this.Organisateur_label = new System.Windows.Forms.Label();
            this.Participant_label = new System.Windows.Forms.Label();
            this.Contexte_label = new System.Windows.Forms.Label();
            this.Organisateur_textbox = new System.Windows.Forms.TextBox();
            this.Participant_nom = new System.Windows.Forms.TextBox();
            this.Contexte_textbox = new System.Windows.Forms.TextBox();
            this.Participant_specialite = new System.Windows.Forms.TextBox();
            this.Participant_qualification = new System.Windows.Forms.TextBox();
            this.Participant_anciennete = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.titre_textbox = new System.Windows.Forms.TextBox();
            this.label_titre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Système de Prise de note Immédiate et Intéractive";
            // 
            // Organisateur_label
            // 
            this.Organisateur_label.AutoSize = true;
            this.Organisateur_label.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Organisateur_label.Location = new System.Drawing.Point(303, 136);
            this.Organisateur_label.Name = "Organisateur_label";
            this.Organisateur_label.Size = new System.Drawing.Size(77, 17);
            this.Organisateur_label.TabIndex = 1;
            this.Organisateur_label.Text = "Organisateur :";
            // 
            // Participant_label
            // 
            this.Participant_label.AutoSize = true;
            this.Participant_label.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participant_label.Location = new System.Drawing.Point(311, 182);
            this.Participant_label.Name = "Participant_label";
            this.Participant_label.Size = new System.Drawing.Size(64, 17);
            this.Participant_label.TabIndex = 2;
            this.Participant_label.Text = "Participant :";
            // 
            // Contexte_label
            // 
            this.Contexte_label.AutoSize = true;
            this.Contexte_label.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contexte_label.Location = new System.Drawing.Point(319, 322);
            this.Contexte_label.Name = "Contexte_label";
            this.Contexte_label.Size = new System.Drawing.Size(56, 17);
            this.Contexte_label.TabIndex = 3;
            this.Contexte_label.Text = "Contexte :";
            // 
            // Organisateur_textbox
            // 
            this.Organisateur_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.Organisateur_textbox.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Organisateur_textbox.ForeColor = System.Drawing.Color.Gray;
            this.Organisateur_textbox.Location = new System.Drawing.Point(410, 133);
            this.Organisateur_textbox.Name = "Organisateur_textbox";
            this.Organisateur_textbox.Size = new System.Drawing.Size(220, 23);
            this.Organisateur_textbox.TabIndex = 4;
            this.Organisateur_textbox.Enter += new System.EventHandler(this.textBox1_Enter_1);
            this.Organisateur_textbox.Leave += new System.EventHandler(this.textBox1_Leave_1);
            // 
            // Participant_nom
            // 
            this.Participant_nom.BackColor = System.Drawing.SystemColors.Window;
            this.Participant_nom.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participant_nom.ForeColor = System.Drawing.Color.Gray;
            this.Participant_nom.Location = new System.Drawing.Point(410, 179);
            this.Participant_nom.Name = "Participant_nom";
            this.Participant_nom.Size = new System.Drawing.Size(220, 23);
            this.Participant_nom.TabIndex = 5;
            this.Participant_nom.Enter += new System.EventHandler(this.Participant_nom_Enter);
            this.Participant_nom.Leave += new System.EventHandler(this.Participant_nom_Leave);
            // 
            // Contexte_textbox
            // 
            this.Contexte_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.Contexte_textbox.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contexte_textbox.ForeColor = System.Drawing.Color.Gray;
            this.Contexte_textbox.Location = new System.Drawing.Point(410, 319);
            this.Contexte_textbox.Multiline = true;
            this.Contexte_textbox.Name = "Contexte_textbox";
            this.Contexte_textbox.Size = new System.Drawing.Size(220, 134);
            this.Contexte_textbox.TabIndex = 6;
            this.Contexte_textbox.Enter += new System.EventHandler(this.Contexte_textbox_Enter);
            this.Contexte_textbox.Leave += new System.EventHandler(this.Contexte_textbox_Leave);
            // 
            // Participant_specialite
            // 
            this.Participant_specialite.BackColor = System.Drawing.SystemColors.Window;
            this.Participant_specialite.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participant_specialite.ForeColor = System.Drawing.Color.Gray;
            this.Participant_specialite.Location = new System.Drawing.Point(410, 208);
            this.Participant_specialite.Name = "Participant_specialite";
            this.Participant_specialite.Size = new System.Drawing.Size(220, 23);
            this.Participant_specialite.TabIndex = 7;
            this.Participant_specialite.Enter += new System.EventHandler(this.Participant_specialite_Enter);
            this.Participant_specialite.Leave += new System.EventHandler(this.Participant_specialite_Leave);
            // 
            // Participant_qualification
            // 
            this.Participant_qualification.BackColor = System.Drawing.SystemColors.Window;
            this.Participant_qualification.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participant_qualification.ForeColor = System.Drawing.Color.Gray;
            this.Participant_qualification.Location = new System.Drawing.Point(410, 237);
            this.Participant_qualification.Name = "Participant_qualification";
            this.Participant_qualification.Size = new System.Drawing.Size(220, 23);
            this.Participant_qualification.TabIndex = 8;
            this.Participant_qualification.Enter += new System.EventHandler(this.Participant_qualification_Enter);
            this.Participant_qualification.Leave += new System.EventHandler(this.Participant_qualification_Leave);
            // 
            // Participant_anciennete
            // 
            this.Participant_anciennete.BackColor = System.Drawing.SystemColors.Window;
            this.Participant_anciennete.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participant_anciennete.ForeColor = System.Drawing.Color.Gray;
            this.Participant_anciennete.Location = new System.Drawing.Point(410, 266);
            this.Participant_anciennete.Name = "Participant_anciennete";
            this.Participant_anciennete.Size = new System.Drawing.Size(220, 23);
            this.Participant_anciennete.TabIndex = 9;
            this.Participant_anciennete.Enter += new System.EventHandler(this.Participant_anciennete_Enter);
            this.Participant_anciennete.Leave += new System.EventHandler(this.Participant_anciennete_Leave);
            // 
            // Valider
            // 
            this.Valider.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.Location = new System.Drawing.Point(455, 483);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(112, 38);
            this.Valider.TabIndex = 10;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // titre_textbox
            // 
            this.titre_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.titre_textbox.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_textbox.ForeColor = System.Drawing.Color.Gray;
            this.titre_textbox.Location = new System.Drawing.Point(410, 86);
            this.titre_textbox.Name = "titre_textbox";
            this.titre_textbox.Size = new System.Drawing.Size(220, 23);
            this.titre_textbox.TabIndex = 1;
            this.titre_textbox.Enter += new System.EventHandler(this.titre_textbox_Enter);
            this.titre_textbox.Leave += new System.EventHandler(this.titre_textbox_Leave);
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titre.Location = new System.Drawing.Point(345, 89);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(35, 17);
            this.label_titre.TabIndex = 11;
            this.label_titre.Text = "Titre :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Prise_Note.Properties.Resources.LOGO_SPYPlan_de_travail_1_3x;
            this.pictureBox1.Location = new System.Drawing.Point(79, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Prise_Note.Properties.Resources.logo_armelair1479824774;
            this.pictureBox2.Location = new System.Drawing.Point(61, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Prise_Note.Properties.Resources.CEAM2_1;
            this.pictureBox3.Location = new System.Drawing.Point(79, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Initialisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titre_textbox);
            this.Controls.Add(this.label_titre);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Participant_anciennete);
            this.Controls.Add(this.Participant_qualification);
            this.Controls.Add(this.Participant_specialite);
            this.Controls.Add(this.Contexte_textbox);
            this.Controls.Add(this.Participant_nom);
            this.Controls.Add(this.Organisateur_textbox);
            this.Controls.Add(this.Contexte_label);
            this.Controls.Add(this.Participant_label);
            this.Controls.Add(this.Organisateur_label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Initialisation";
            this.Text = "SPY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Organisateur_label;
        private System.Windows.Forms.Label Participant_label;
        private System.Windows.Forms.Label Contexte_label;
        private System.Windows.Forms.TextBox Organisateur_textbox;
        private System.Windows.Forms.TextBox Participant_nom;
        private System.Windows.Forms.TextBox Contexte_textbox;
        private System.Windows.Forms.TextBox Participant_specialite;
        private System.Windows.Forms.TextBox Participant_qualification;
        private System.Windows.Forms.TextBox Participant_anciennete;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TextBox titre_textbox;
        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}