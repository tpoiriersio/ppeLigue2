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
            DateTime debut = dtp_debut.Value;
            DateTime fin = dtp_fin.Value;

            int jourDebut = debut.Day;
            int moiDebut = debut.Month;
            int anneeDebut = debut.Year;

            int jourFin = fin.Day;
            int moifin = fin.Month;
            int anneeeFin = fin.Year;

            int heureDebut = Convert.ToInt16(cb_heureDebut.Text);
            int minuteDebut = Convert.ToInt16(cb_minuteDebut.Text);
            int heureFin = Convert.ToInt16(cb_heureFin.Text);
            int minuteFin = Convert.ToInt16(cb_minuteFin.Text);

            string jour = cb_jour.Text;
            string description = tb_descriptif.Text;
            string categorie = cb_categorie.Text;
            var dateDebut = new DateTime(anneeDebut, moiDebut, jourDebut, heureDebut, minuteDebut, 00);
            var dateFin = new DateTime(anneeeFin, moifin, jourFin, heureFin, minuteFin, 00);

            Sql sql = new Sql();
            sql.insertSeance(jour, description, dateDebut, dateFin, categorie);
        }
    }
}
