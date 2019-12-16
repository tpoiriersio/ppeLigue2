namespace PPE_ligue
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
            this.lb_jour = new System.Windows.Forms.Label();
            this.lb_descriptif = new System.Windows.Forms.Label();
            this.lb_debut = new System.Windows.Forms.Label();
            this.lb_fin = new System.Windows.Forms.Label();
            this.lb_categorie = new System.Windows.Forms.Label();
            this.dtp_debut = new System.Windows.Forms.DateTimePicker();
            this.tb_descriptif = new System.Windows.Forms.TextBox();
            this.cb_jour = new System.Windows.Forms.ComboBox();
            this.cb_categorie = new System.Windows.Forms.ComboBox();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.bt_valider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_jour
            // 
            this.lb_jour.AutoSize = true;
            this.lb_jour.Location = new System.Drawing.Point(30, 73);
            this.lb_jour.Name = "lb_jour";
            this.lb_jour.Size = new System.Drawing.Size(27, 13);
            this.lb_jour.TabIndex = 0;
            this.lb_jour.Text = "Jour";
            // 
            // lb_descriptif
            // 
            this.lb_descriptif.AutoSize = true;
            this.lb_descriptif.Location = new System.Drawing.Point(30, 167);
            this.lb_descriptif.Name = "lb_descriptif";
            this.lb_descriptif.Size = new System.Drawing.Size(51, 13);
            this.lb_descriptif.TabIndex = 1;
            this.lb_descriptif.Text = "Descriptif";
            // 
            // lb_debut
            // 
            this.lb_debut.AutoSize = true;
            this.lb_debut.Location = new System.Drawing.Point(30, 275);
            this.lb_debut.Name = "lb_debut";
            this.lb_debut.Size = new System.Drawing.Size(36, 13);
            this.lb_debut.TabIndex = 2;
            this.lb_debut.Text = "Début";
            // 
            // lb_fin
            // 
            this.lb_fin.AutoSize = true;
            this.lb_fin.Location = new System.Drawing.Point(30, 361);
            this.lb_fin.Name = "lb_fin";
            this.lb_fin.Size = new System.Drawing.Size(21, 13);
            this.lb_fin.TabIndex = 3;
            this.lb_fin.Text = "Fin";
            // 
            // lb_categorie
            // 
            this.lb_categorie.AutoSize = true;
            this.lb_categorie.Location = new System.Drawing.Point(30, 435);
            this.lb_categorie.Name = "lb_categorie";
            this.lb_categorie.Size = new System.Drawing.Size(52, 13);
            this.lb_categorie.TabIndex = 4;
            this.lb_categorie.Text = "Catégorie";
            // 
            // dtp_debut
            // 
            this.dtp_debut.Location = new System.Drawing.Point(112, 275);
            this.dtp_debut.Name = "dtp_debut";
            this.dtp_debut.Size = new System.Drawing.Size(200, 20);
            this.dtp_debut.TabIndex = 5;
            // 
            // tb_descriptif
            // 
            this.tb_descriptif.Location = new System.Drawing.Point(112, 164);
            this.tb_descriptif.Name = "tb_descriptif";
            this.tb_descriptif.Size = new System.Drawing.Size(100, 20);
            this.tb_descriptif.TabIndex = 6;
            // 
            // cb_jour
            // 
            this.cb_jour.FormattingEnabled = true;
            this.cb_jour.Location = new System.Drawing.Point(112, 73);
            this.cb_jour.Name = "cb_jour";
            this.cb_jour.Size = new System.Drawing.Size(121, 21);
            this.cb_jour.TabIndex = 7;
            // 
            // cb_categorie
            // 
            this.cb_categorie.FormattingEnabled = true;
            this.cb_categorie.Location = new System.Drawing.Point(112, 435);
            this.cb_categorie.Name = "cb_categorie";
            this.cb_categorie.Size = new System.Drawing.Size(121, 21);
            this.cb_categorie.TabIndex = 8;
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(112, 361);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(200, 20);
            this.dtp_fin.TabIndex = 9;
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(112, 492);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(100, 23);
            this.bt_valider.TabIndex = 10;
            this.bt_valider.Text = "Valider la séance";
            this.bt_valider.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.dtp_fin);
            this.Controls.Add(this.cb_categorie);
            this.Controls.Add(this.cb_jour);
            this.Controls.Add(this.tb_descriptif);
            this.Controls.Add(this.dtp_debut);
            this.Controls.Add(this.lb_categorie);
            this.Controls.Add(this.lb_fin);
            this.Controls.Add(this.lb_debut);
            this.Controls.Add(this.lb_descriptif);
            this.Controls.Add(this.lb_jour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_jour;
        private System.Windows.Forms.Label lb_descriptif;
        private System.Windows.Forms.Label lb_debut;
        private System.Windows.Forms.Label lb_fin;
        private System.Windows.Forms.Label lb_categorie;
        private System.Windows.Forms.DateTimePicker dtp_debut;
        private System.Windows.Forms.TextBox tb_descriptif;
        private System.Windows.Forms.ComboBox cb_jour;
        private System.Windows.Forms.ComboBox cb_categorie;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Label label1;
    }
}

