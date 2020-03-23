using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Moniteur
    {
        private int id;
        private string nom;
        private string prenom;
        private string mail;
        private string tel;
        private string mdp;

        public Moniteur(string n, string p, string m, string t, string mp)
        {
            this.nom = n;
            this.prenom = p;
            this.mail = m;
            this.tel = t;
            this.mdp = mp;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mdp { get => mdp; set => mdp = value; }
    }
}