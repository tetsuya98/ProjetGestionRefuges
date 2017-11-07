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
   
        public static bool ajoutAgentAcceuil(string nom,string prenom,string motdepasse)
        {
            ///fctn verfi champs
            AgentAccueil ag1 = new AgentAccueil(nom,prenom,motdepasse);




            ///finir la requete sql
            string sqlCommand = "INSERT INTO agents (clef, prenom, nom,  mdp) VALUES ("+ag1.Id+","+ag1.Prenom+", "+ag1.Nom+", "+ag1.Motdepasse+")";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            read.Close();
            return true;


        }

        public static bool supressionAgentAcceuil()
        {

        }

        public static bool modificationAgentAcceuil()
        {

        }
    }
}
