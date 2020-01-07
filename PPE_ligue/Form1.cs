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

            string dateD = debut.Day + "-" + debut.Month + "-" + debut.Year;
            string dateF = fin.Day + "-" + fin.Month + "-" + fin.Year;

            Date t = new Date();
            int resu = t.diffDates(dateD, dateF);
            int i = 0;

            while(i<=resu)
            {
                string d = debut.Year + "-" + debut.Month + "-" + debut.Day  + " " + cb_heureDebut.Text + ":" + cb_minuteDebut.Text + ":00";
                string f = debut.Year + "-" + debut.Month + "-" + debut.Day + " " + cb_heureFin.Text + ":" + cb_minuteFin.Text + ":00";
                string jour = Convert.ToString(dtp_debut.Value.DayOfWeek);
                string description = tb_descriptif.Text;
                int categorie = cb_categorie.SelectedIndex + 1;

                Sql sql = new Sql();
                sql.insertSeance(jour, description, d, f, categorie);
                
                //MessageBox.Show(Convert.ToString(resu));
                //MessageBox.Show(Convert.ToString(i));
                i += 7;
                debut = debut.AddDays(7);
                fin = fin.AddDays(7);
            }
        }
    }
}
