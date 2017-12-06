using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    class Camp
    {
        #region champs
        /// <summary>
        /// Identifiant du camp
        /// </summary>
        private int id;

        /// <summary>
        /// Adresse du camp
        /// </summary>
        private string adresse;

        /// <summary>
        /// Nombre de réfugier maximal du camp
        /// </summary>
        private int capacite;
        #endregion

        #region propriete
        public int Id{
            get
            {
                return id;
            }
        }
        public string Adresse
        {
            get
            {
                return adresse;
            }
        }
        public int Capacite
        {
            get
            {
                return capacite;
            }
        }
        #endregion
        
        #region methode
        /// <summary>
        /// Constructeur de camp
        /// </summary>
        /// <param name="capacite">Nombre de réfugier maximal du camp</param>
        /// <param name="adresse">Adresse du camp</param>
        /// <param name="id">Identifiant du camp</param>
        public Camp(int capacite, string adresse, int id = 0)
        {
            this.capacite = capacite;
            this.adresse = adresse;
            this.id = id;
        }

        /// <summary>
        /// Récupère un camp dans la base de donnée
        /// </summary>
        /// <param name="id">Identifiant du camp à récupérer</param>
        /// <returns>Retourne un camp</returns>
        public static Camp select(int id)
        {
            string sqlCommand = "SELECT * FROM camps WHERE id = ?";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                return null;
            }

            reader.Read();
            Camp tmp = new Camp(
                reader.GetFieldValue<int>(reader.GetOrdinal("capacite")),
                reader.GetFieldValue<String>(reader.GetOrdinal("adresse")),
                id
            );
            reader.Close();
            return tmp;
        }

        /// <summary>
        /// Fonction affiche
        /// </summary>
        /// <returns>Retourne l'objet sous forme d'une chaine de caractère</returns>
        public override string ToString()
        {
            return " => Camp\n capacite : " + capacite + "\n adresse : " + adresse;
        }
        #endregion
    }
}