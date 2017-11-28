using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

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
        private String sexe;

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
                return prenom;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public String Sexe
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
        public Refugier(string nom, string prenom, String sexe, DateTime dateNais, string nationalite, int adresse, int id = 0)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.dateNais = dateNais;
            this.nationalite = nationalite;
            this.adresse = adresse;
            this.id = id;
        }

        /// <summary>
        /// Ajoute dun réfugier dans la base de donnée
        /// </summary>
        /// <param name="refugier">Référence du réfugier</param>
        /// <returns>True si la requete s'execute correctement sinon false</returns>
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

        /// <summary>
        /// Modifie un réfugié dans la base de donnée
        /// </summary>
        /// <param name="refugier">réfugier à modifié</param>
        /// <returns>Retourne true si la requete réussi sinon false</returns>
        public static bool update(Refugier refugier)
        {

            string sqlCommand = "UPDATE refugiers  SET nom = ?, prenom = ?, nationalite = ?, sexe = ?, adresse = ?, dateNais = ? WHERE id = ?";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@nom", refugier.Nom);
            cmd.Parameters.AddWithValue("@prenom", refugier.Prenom);
            cmd.Parameters.AddWithValue("@nationalite", refugier.Nationalite);
            cmd.Parameters.AddWithValue("@sexe", refugier.Sexe);
            cmd.Parameters.AddWithValue("@adresse", refugier.Adresse);
            cmd.Parameters.AddWithValue("@dateNais", refugier.DateNais.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@id", refugier.Id);



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
        }

        /// <summary>
        /// Supprime un refugier dans la base de donnée
        /// </summary>
        /// <param name="refugier">Réfugier à supprimmer</param>
        /// <returns>Retourne true si la requete réussi sinon false</returns>
        public static bool delete(Refugier refugier)
        {
            string sqlCommand = "DELETE FROM refugiers WHERE id = ?";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@id", refugier.Id);

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
        }

        /// <summary>
        /// Récupère la liste des réfugier dans la base de donnée
        /// </summary>
        /// <returns>Retourne la liste de réfugier</returns>
        public static List<Refugier> select()
        {
            List<Refugier> refugiers = new List<Refugier>();
            string sqlCommand = "SELECT * FROM refugiers";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
            }catch(MySqlException ex)
            {
                return null;
            }
            
            while (reader.Read())
            {
                System.Diagnostics.Debug.Write("===============================");
                System.Diagnostics.Debug.Write(reader.GetFieldValue<String>(reader.GetOrdinal("nom")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<String>(reader.GetOrdinal("prenom")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<String>(reader.GetOrdinal("sexe")));
                System.Diagnostics.Debug.Write(reader.GetDateTime(reader.GetOrdinal("dateNais")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<String>(reader.GetOrdinal("nationalite")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<int>(reader.GetOrdinal("adresse")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<int>(reader.GetOrdinal("id")));
                
                    Refugier tmp = new Refugier(
                    reader.GetFieldValue<String>(reader.GetOrdinal("nom")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("prenom")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("sexe")),
                    reader.GetDateTime(reader.GetOrdinal("dateNais")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("nationalite")),
                    reader.GetFieldValue<int>(reader.GetOrdinal("adresse")),
                    reader.GetFieldValue<int>(reader.GetOrdinal("id"))
                );
                refugiers.Add(tmp);
            }
            reader.Close();
            return refugiers;
        }
    }                                                             
}
