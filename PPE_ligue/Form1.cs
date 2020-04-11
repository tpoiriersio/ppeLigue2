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

            while (i <= resu)
            {
                string d = debut.Year + "-" + debut.Month + "-" + debut.Day + " " + cb_heureDebut.Text + ":" + cb_minuteDebut.Text + ":00";
                string f = debut.Year + "-" + debut.Month + "-" + debut.Day + " " + cb_heureFin.Text + ":" + cb_minuteFin.Text + ":00";
                string description = tb_descriptif.Text;
                int categorie = cb_categorie.SelectedIndex + 1;

                string jour = Convert.ToString(dtp_debut.Value.DayOfWeek);
                if (jour == "Monday") {
                    jour = "Lundi";
                }
                else
                {
                    if (jour == "Tuesday")
                    {
                        jour = "Mardi";
                    }
                    else
                    {
                        if (jour == "Wednesday")
                        {
                            jour = "Mercredi";
                        }
                        else
                        {
                            if (jour == "Thursday")
                            {
                                jour = "Jeudi";
                            }
                            else
                            {
                                if (jour == "Friday")
                                {
                                    jour = "Vendredi";
                                }
                                else
                                {
                                    if (jour == "Saturday")
                                    {
                                        jour = "Samedi";
                                    }
                                    else
                                    {
                                        if (jour == "Sunday")
                                        {
                                            jour = "Dimanche";
                                        }
                                    }
                                }
                            }
                        }
                    }
                } 

                Sql sql = new Sql();
                sql.insertSeance(jour, description, d, f, categorie);
                
                i += 7;
                debut = debut.AddDays(7);
                fin = fin.AddDays(7);
            }
        }
    }
}
