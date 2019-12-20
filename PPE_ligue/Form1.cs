using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_ligue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_jour.Items.Add("Lundi");
            cb_jour.Items.Add("Mardi");
            cb_jour.Items.Add("Mercredi");
            cb_jour.Items.Add("Jeudi");
            cb_jour.Items.Add("Vendredi");
            cb_jour.Items.Add("Samedi");
            cb_jour.Items.Add("Dimanche");
            cb_categorie.Items.Add("Initiation");
            cb_categorie.Items.Add("Loisir");
            cb_categorie.Items.Add("Compétition");
            
            for(int i=9; i<23; i++)
            {
                cb_heureDebut.Items.Add(i);
            }

            for (int i = 9; i < 23; i++)
            {
                cb_heureFin.Items.Add(i);
            }

            cb_minuteDebut.Items.Add("00");
            cb_minuteDebut.Items.Add("15");
            cb_minuteDebut.Items.Add("30");
            cb_minuteDebut.Items.Add("45");
            cb_minuteFin.Items.Add("00");
            cb_minuteFin.Items.Add("15");
            cb_minuteFin.Items.Add("30");
            cb_minuteFin.Items.Add("45");
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            string jour = cb_jour.Text;
            string description = tb_descriptif.Text;
            DateTime debut = dtp_debut.Value;
            DateTime fin = dtp_fin.Value;
            string categorie = cb_categorie.Text;

            Sql sql = new Sql();
            sql.insertSeance(jour, description, debut, fin, categorie);
        }

        // il faut rajouter l'heuure à la date de début et de fin
    }
}
