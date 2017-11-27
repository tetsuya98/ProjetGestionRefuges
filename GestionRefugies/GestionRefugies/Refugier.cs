using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    partial class Refugier
    {
        #region champs
        /// <summary>
        /// nom du refugier
        /// </summary>
        protected string nom;

        /// <summary>
        /// prénom du refugier
        /// </summary>
        protected string prenom;

        /// <summary>
        /// identifiant du refugier
        /// </summary>
        protected int id;

        /// <summary>
        /// sexe du refugier
        /// </summary>
        private string sexe;

        /// <summary>
        /// Date de naissance du refugier
        /// </summary>
        private DateTime dateNais;

        /// <summary>
        /// Adresse du refugier
        /// </summary>
        private int adresse;

        /// <summary>
        /// Nationnalité du refugier
        /// </summary>
        private string nationalite;

        #endregion

        #region propriete
        public string Nom
        {
            get
            {
                return nom;
            }
        }
        public string Prenom
        {
            get
            {
                return nom;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Sexe
        {
            get
            {
                return sexe;
            }
        }
        public DateTime DateNais
        {
            get
            {
                return dateNais;
            }
        }
        public int Adresse
        {
            get
            {
                return adresse;
            }
        }
        public string Nationalite
        {
            get
            {
                return nationalite;
            }
        }
        #endregion

        #region methode
        public Refugier(string nom, string prenom, string motdepasse, string sexe, DateTime dateNais, string nationalite, int adresse, int id = 0)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.dateNais = dateNais;
            this.nationalite = nationalite;
            this.adresse = adresse;
            this.id = id;
        }

        public static bool add(Refugier refugier)
        {

            ///finir la requete sql
            string sqlCommand = "INSERT INTO refugiers (nom, prenom, nationalite, sexe, adresse, dateNais) VALUES (?,?,?,?,?,?)";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@nom", refugier.Nom);
            cmd.Parameters.AddWithValue("@prenom", refugier.Prenom);
            cmd.Parameters.AddWithValue("@nationalite", refugier.Nationalite);
            cmd.Parameters.AddWithValue("@sexe", refugier.Sexe);
            cmd.Parameters.AddWithValue("@adresse", refugier.Adresse);
            cmd.Parameters.AddWithValue("@dateNais", refugier.DateNais.Date.ToString("yyyy-MM-dd"));
            

            try
            {
                //Execution de la commande SQL qui peut provoquer des exceptions
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                //traitement de l'exception...
                return false;
            }
            #endregion
        }
    }
}
