using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    class MagasinierManage
    {
        public static void ajouterMagasinier(string login, string nom, string adresse)
        {
            string sqlCommand = $"INSERT INTO magasinier (clef, nom, adresse) VALUES ('{login}', '{nom}', '{adresse})";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            read.Close();
        }

        public static void supprimerMagasinier(string login)
        {
            string sqlCommand = $"DELETE FROM magasinier WHERE clef = '{login}'";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            read.Close();
        }

        public static void updateMagasinier(string login, string nom, string adresse)
        {
            string sqlCommand = $"UPDATE magasinier nom = '{nom}', adresse = '{adresse}' WHERE clef = '{login}'";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            read.Close();
        }
    }
}
