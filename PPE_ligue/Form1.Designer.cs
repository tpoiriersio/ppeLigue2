﻿namespace PPE_ligue
{
    partial class Form1
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
            this.lb_descriptif = new System.Windows.Forms.Label();
            this.lb_debut = new System.Windows.Forms.Label();
            this.lb_fin = new System.Windows.Forms.Label();
            this.lb_categorie = new System.Windows.Forms.Label();
            this.dtp_debut = new System.Windows.Forms.DateTimePicker();
            this.tb_descriptif = new System.Windows.Forms.TextBox();
            this.cb_categorie = new System.Windows.Forms.ComboBox();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.bt_valider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_heureDebut = new System.Windows.Forms.ComboBox();
            this.cb_minuteDebut = new System.Windows.Forms.ComboBox();
            this.cb_heureFin = new System.Windows.Forms.ComboBox();
            this.cb_minuteFin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_descriptif
            // 
            this.lb_descriptif.AutoSize = true;
            this.lb_descriptif.Location = new System.Drawing.Point(31, 105);
            this.lb_descriptif.Name = "lb_descriptif";
            this.lb_descriptif.Size = new System.Drawing.Size(51, 13);
            this.lb_descriptif.TabIndex = 1;
            this.lb_descriptif.Text = "Descriptif";
            // 
            // lb_debut
            // 
            this.lb_debut.AutoSize = true;
            this.lb_debut.Location = new System.Drawing.Point(31, 178);
            this.lb_debut.Name = "lb_debut";
            this.lb_debut.Size = new System.Drawing.Size(36, 13);
            this.lb_debut.TabIndex = 2;
            this.lb_debut.Text = "Début";
            // 
            // lb_fin
            // 
            this.lb_fin.AutoSize = true;
            this.lb_fin.Location = new System.Drawing.Point(31, 238);
            this.lb_fin.Name = "lb_fin";
            this.lb_fin.Size = new System.Drawing.Size(21, 13);
            this.lb_fin.TabIndex = 3;
            this.lb_fin.Text = "Fin";
            // 
            // lb_categorie
            // 
            this.lb_categorie.AutoSize = true;
            this.lb_categorie.Location = new System.Drawing.Point(31, 315);
            this.lb_categorie.Name = "lb_categorie";
            this.lb_categorie.Size = new System.Drawing.Size(52, 13);
            this.lb_categorie.TabIndex = 4;
            this.lb_categorie.Text = "Catégorie";
            // 
            // dtp_debut
            // 
            this.dtp_debut.Location = new System.Drawing.Point(112, 178);
            this.dtp_debut.Name = "dtp_debut";
            this.dtp_debut.Size = new System.Drawing.Size(200, 20);
            this.dtp_debut.TabIndex = 5;
            // 
            // tb_descriptif
            // 
            this.tb_descriptif.Location = new System.Drawing.Point(112, 102);
            this.tb_descriptif.Name = "tb_descriptif";
            this.tb_descriptif.Size = new System.Drawing.Size(100, 20);
            this.tb_descriptif.TabIndex = 6;
            // 
            // cb_categorie
            // 
            this.cb_categorie.FormattingEnabled = true;
            this.cb_categorie.Location = new System.Drawing.Point(112, 315);
            this.cb_categorie.Name = "cb_categorie";
            this.cb_categorie.Size = new System.Drawing.Size(121, 21);
            this.cb_categorie.TabIndex = 8;
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(112, 251);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(200, 20);
            this.dtp_fin.TabIndex = 9;
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(360, 384);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(174, 61);
            this.bt_valider.TabIndex = 10;
            this.bt_valider.Text = "Valider la séance";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ajouter un entrainement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fin";
            // 
            // cb_heureDebut
            // 
            this.cb_heureDebut.FormattingEnabled = true;
            this.cb_heureDebut.Location = new System.Drawing.Point(497, 185);
            this.cb_heureDebut.Name = "cb_heureDebut";
            this.cb_heureDebut.Size = new System.Drawing.Size(61, 21);
            this.cb_heureDebut.TabIndex = 14;
            // 
            // cb_minuteDebut
            // 
            this.cb_minuteDebut.FormattingEnabled = true;
            this.cb_minuteDebut.Location = new System.Drawing.Point(614, 190);
            this.cb_minuteDebut.Name = "cb_minuteDebut";
            this.cb_minuteDebut.Size = new System.Drawing.Size(57, 21);
            this.cb_minuteDebut.TabIndex = 15;
            // 
            // cb_heureFin
            // 
            this.cb_heureFin.FormattingEnabled = true;
            this.cb_heureFin.Location = new System.Drawing.Point(497, 254);
            this.cb_heureFin.Name = "cb_heureFin";
            this.cb_heureFin.Size = new System.Drawing.Size(61, 21);
            this.cb_heureFin.TabIndex = 16;
            // 
            // cb_minuteFin
            // 
            this.cb_minuteFin.FormattingEnabled = true;
            this.cb_minuteFin.Location = new System.Drawing.Point(614, 262);
            this.cb_minuteFin.Name = "cb_minuteFin";
            this.cb_minuteFin.Size = new System.Drawing.Size(57, 21);
            this.cb_minuteFin.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Heures";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Heures";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Minutes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_minuteFin);
            this.Controls.Add(this.cb_heureFin);
            this.Controls.Add(this.cb_minuteDebut);
            this.Controls.Add(this.cb_heureDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.dtp_fin);
            this.Controls.Add(this.cb_categorie);
            this.Controls.Add(this.tb_descriptif);
            this.Controls.Add(this.dtp_debut);
            this.Controls.Add(this.lb_categorie);
            this.Controls.Add(this.lb_fin);
            this.Controls.Add(this.lb_debut);
            this.Controls.Add(this.lb_descriptif);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_descriptif;
        private System.Windows.Forms.Label lb_debut;
        private System.Windows.Forms.Label lb_fin;
        private System.Windows.Forms.Label lb_categorie;
        private System.Windows.Forms.DateTimePicker dtp_debut;
        private System.Windows.Forms.TextBox tb_descriptif;
        private System.Windows.Forms.ComboBox cb_categorie;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_heureDebut;
        private System.Windows.Forms.ComboBox cb_minuteDebut;
        private System.Windows.Forms.ComboBox cb_heureFin;
        private System.Windows.Forms.ComboBox cb_minuteFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

