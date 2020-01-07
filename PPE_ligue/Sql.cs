using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ligue
{
    public class Sql
    {
        private string IP = "172.19.0.3";
        private string USER = "root";
        private string PASSWORD = "0550002D";
        private string DATABASE = "ligue";
        private MySqlConnection connexion;

        public Sql()
        {
            string connStr = "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.PASSWORD;
            connexion = new MySqlConnection(connStr);
        }

        public void insertSeance(string jour, string descriptif, string debut, string fin, int categorie)
        {
            string therequest = "INSERT INTO seance(`jour`,`descriptif`,`debut`,`fin`,`la_categorie`) VALUE ('" + jour + "','" + descriptif + "','" + debut.ToString() + "','" + fin.ToString() + "','" + categorie + "')";
            MySqlCommand request = new MySqlCommand(therequest, this.connexion);
            this.connexion.Open();
            MySqlDataReader give = request.ExecuteReader();
            this.connexion.Close();
        }

    }
}
