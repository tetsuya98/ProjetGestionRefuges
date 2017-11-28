using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    public class MagasinierManage
    {
        public static bool AjouterMagasinier(Magasinier maga)
        {

            String sql = "INSERT INTO magasinier (clef, nom, adresse, mdp) VALUES (?,?,?,?)";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@clef", maga.Id);
            cmd.Parameters.AddWithValue("@nom", maga.Nom);
            cmd.Parameters.AddWithValue("@adresse", maga.Adresse);
            cmd.Parameters.AddWithValue("@mdp", maga.Motdepasse);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public static bool supprimerMagasinier(string id)
        {
            String sql = "DELETE FROM magasinier WHERE clef = ?";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@clef", id);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            } 
        }

        public static bool updateMagasinier(Magasinier maga)
        {
            String sql = "UPDATE magasinier nom = ?, adresse = ? WHERE clef = ?";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@nom", maga.Nom);
            cmd.Parameters.AddWithValue("@adresse", maga.Adresse);
            cmd.Parameters.AddWithValue("@clef", maga.Id);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }

            
        }
    }
}
