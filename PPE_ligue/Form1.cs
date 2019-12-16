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
        }
    }
}
