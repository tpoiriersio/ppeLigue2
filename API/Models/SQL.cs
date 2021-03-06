﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace API.Models
{
    public class SQL
    {
        private MySqlConnection conn;
        public SQL()
        {
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=ligue;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }

        //-------Moniteur-------//

        public List<Moniteur> getAllMoniteurs()
        {
            List<Moniteur> lesMoniteurs = new List<Moniteur>();
            string requete = "select * from moniteur";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Moniteur c = new Moniteur(rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());
                lesMoniteurs.Add(c);
            }
            rdr.Close();
            return lesMoniteurs;
        }
        public Moniteur getById(int id)
        {
            string requete = "select * from moniteur where id=" + id;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Moniteur c = new Moniteur(rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());
            rdr.Close();
            return c;
        }
        public void addMoniteur(Moniteur c)
        {
            string requete = "insert into moniteur(id, nom, prenom, email, tel, mdp) values ("+ c.Nom + "', '" + c.Prenom + "', '" + c.Mail + "', '+" + c.Tel + "', " + c.Mdp +")";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }
        public void deleteMoniteur(int id)
        {
            deleteAnimerMoniteur(id);
            string requete = "delete from moniteur where id=" + id;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }
        public void upMoniteur(int id, string mdp)
        {
            string requete = "update moniteur set mdp='" + mdp + "' where id=" + id;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }

        //-------Séance-------//

        public List<Seance> getAllSeance()
        {
            List<Seance> lesSeances = new List<Seance>();
            string requete = "select * from seance";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Seance c = new Seance(rdr[1].ToString(), rdr[2].ToString(), Convert.ToDateTime(rdr[3]), Convert.ToDateTime(rdr[4]), Convert.ToInt16(rdr[5]));
                lesSeances.Add(c);
            }
            rdr.Close();
            return lesSeances;
        }
        public Seance getByIdSeance(int id)
        {
            string requete = "select * from seance where id=" + id;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Seance c = new Seance(rdr[1].ToString(), rdr[2].ToString(), Convert.ToDateTime(rdr[3]), Convert.ToDateTime(rdr[4]), Convert.ToInt16(rdr[5]));
            rdr.Close();
            return c;
        }
        public void addSeance(int id, int moni)
        {
            string requete = "insert into proposer(id_seande, id_moniteur) values ("+id+", "+moni+")";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }
        public void deleteSeance(int id, int moni)
        {
            deleteAnimerSeance(id);
            string requete = "delete from proposer where id_seande=" + id + " AND id_moniteur=" + moni;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }

        //-------Animer-------//

        public void insertAnimer(int idSeance, int idMoniteur){
            string requete = "insert into animer(id_seance, id_moniteur) VALUES (" + idSeance + ", " + idMoniteur + ")";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }
        public void deleteAnimerSeance(int id){
            string requete = "delete from animer where id_seance=" + id;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }
        public void deleteAnimerMoniteur(int id){
            string requete = "delete from animer where id_moniteur=" + id;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }

        //-------Connexion-------//

        public Moniteur utilisateurAutorise(string login, string mdp)
        {
            string requete = "select * from moniteur where email=" + login + "AND mdp=" + mdp;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Moniteur c = new Moniteur(rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());
            rdr.Close();
            return c;
        }
        public void testConnexion()
        {
            string messageDErreur;
            bool lAccesAutorise = true;

            if ((login.Text == "") || (motDePasse.Text == ""))
            {
                messageDErreur = "Veuillez rentrer un identifiant ou un mot de passe";
                lAccesAutorise = false;
            }

            try
            {
                if (lAccesAutorise)
                {
                    utilisateurAutorise(login.Text, motDePasse.Text);
                    if (utilisateurAutorise().Mail == login.Text && utilisateurAutorise().Mdp == motDePasse.Text)
                    {
                        messageDErreur = "Accès autorisé";
                        lAccesAutorise = true;
                    }
                }
                else
                {
                    messageDErreur = "Accès non autorisé";
                    lAccesAutorise = false;
                }
            }
            catch (Exception ex)
            {
                messageDErreur = "Erreur lors de l'identification<br>" + ex.ToString();
                lAccesAutorise = false;
            }

        }
    }
}