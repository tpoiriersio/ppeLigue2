using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Seance
    {
        private int id;
        private string jour;
        private string descriptif;
        private DateTime debut;
        private DateTime fin;
        private int categorie;

        public Seance(string j, string des, DateTime d, DateTime f, int c)
        {
            this.jour = j;
            this.descriptif = des;
            this.debut = d;
            this.fin = f;
            this.categorie = c;
        }

        public int Id { get => id; set => id = value; }
        public string Jour { get => jour; set => jour = value; }
        public string Descriptif { get => descriptif; set => descriptif = value; }
        public DateTime Debut { get => debut; set => debut = value; }
        public DateTime Fin { get => fin; set => fin = value; }
        public int Categorie { get => categorie; set => categorie = value; }
    }
}