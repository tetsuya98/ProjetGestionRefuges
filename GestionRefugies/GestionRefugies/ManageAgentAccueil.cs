using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    public class ManageAgentAccueil
    {
   /*
        public static bool ajoutAgentAcceuil(string nom,string prenom,string motdepasse)
        {
            ///fctn verfi champs
            AgentAccueil ag1 = new AgentAccueil(nom,prenom,motdepasse);



            string sqlCommand = "INSERT INTO agents (clef, prenom, nom,  mdp) VALUES ("+ag1.Id+","+ag1.Prenom+", "+ag1.Nom+", "+ag1.Motdepasse+")";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            read.Close();
            return true;


        }*/
        
        public static bool add(AgentAccueil Aga)
        {
            //requete SQL
            String sql = "INSERT INTO agents (clef, prenom, nom, mdp) VALUES (?,?,?,?)";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@Id", Aga.Id);
            cmd.Parameters.AddWithValue("@Prenom", Aga.Prenom);
            cmd.Parameters.AddWithValue("@Nom", Aga.Nom);
            cmd.Parameters.AddWithValue("@Motdepasse", Aga.Motdepasse);

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

        public static bool supp(string id)
        {
            //requete SQL
            String sql = "DELETE FROM `agents` WHERE `agents`.`clef` =? " ;

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@Id", id);



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
/*
        public static bool supressionAgentAcceuil(AgentAccueil ag)
        {

            string sqlCommand = ("DELETE FROM `agents` WHERE `agents`.`clef` = 'AgAlesagec'");
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            read.Close();
            return true;

        }

        public static bool modificationAgentAcceuil(AgentAccueil ag)
        {
            string sqlCommand = ("DELETE from refuiges WHERE id = " + ag.Id);
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            read.Close();
            return true;
        }*/
    }
}
