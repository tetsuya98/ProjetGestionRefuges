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
            set
            {
                nom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
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
            set
            {
                sexe = value;
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
            set
            {
                adresse = value;
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
            }
            catch (MySqlException ex)
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

        public static List<Refugier> Rechercher(List<Refugier> refugiers, string optName = "", string optPrenom = "", String optsex = "", DateTime optdatenaissn = new DateTime(), string optnat = "")
        {
            List<Refugier> liste = new List<Refugier>();
            int nom = 2;
            int prenom = 2;
            int sex = 2;
            int date = 2;
            int nat= 2;

            foreach (var refugier in refugiers)
            {
                if(optName.Length <= refugier.Nom.Length)
                {
                    if (optName.ToLower() == refugier.Nom.ToLower().Substring(0, optName.Length) & optName.Length >= 0)
                    {
                        nom = 0;
                        if (optName.Length == 0)
                        {
                            nom = 2;
                        }
                    }
                    else
                    {
                        nom = 1;
                    }
                }else { nom = 1; }
                
                if(optPrenom.Length <= refugier.Prenom.Length)
                {
                    if (optPrenom.ToLower() == refugier.Prenom.ToLower().Substring(0, optPrenom.Length) & optPrenom.Length >= 0)
                    {
                        prenom = 0;
                        if (optPrenom.Length == 0)
                        {
                            prenom = 2;
                        }
                    }
                    else
                    {
                        prenom = 1;
                    }
                }
                else { prenom = 1; }
                
                if(optsex.Length <= refugier.Sexe.Length)
                {
                    if (optsex.ToLower() == refugier.Sexe.ToLower().Substring(0, optsex.Length) & optsex.Length >= 0)
                    {
                        sex = 0;
                        if (optsex.Length == 0)
                        {
                            sex = 2;
                        }
                    }
                    else
                    {
                        sex = 1;
                    }
                }else { sex = 1; }
                
                if ( optdatenaissn == refugier.DateNais | optdatenaissn == DateTime.Today | optdatenaissn == new DateTime())
                {
                    date = 0;  
                }
                else
                {
                    date = 1;
                }

                if(optnat.Length <= refugier.Nationalite.Length)
                {
                    if (optnat.ToLower() == refugier.Nationalite.ToLower().Substring(0, optnat.Length) & optnat.Length >= 0)
                    {
                        nat = 0;
                        if (optnat.Length == 0)
                        {
                            nat = 2;
                        }
                    }
                    else
                    {
                        nat = 1;
                    }
                }
                else { nat = 1; }


                //1 = pas bon
                //2 = rien mis
                //0 = mis et ok

                if (nom != 2 | prenom != 2 | nat != 2 | sex != 2 | date != 2)
                {
                    if (nom != 1 & prenom != 1 & nat != 1 & sex != 1 & date != 1)
                    {
                        liste.Add(refugier);
                    }
                }
                else
                {
                    liste.Add(refugier);
                }
                nom = 2;
                prenom = 2;
                sex = 2;
                date = 2;
                nat = 2;

            }

            return liste;
        }

        #endregion
    }
}
