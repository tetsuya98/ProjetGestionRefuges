using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{


    class AgentAcceuil : User
    {
        #region variables
        
        #endregion
        
        #region constructeur
        
        public AgentAcceuil(string nom,string prenom,string motdepasse):base(nom,prenom,motdepasse)
        {
             
            Id = "AgA" + Nom + Prenom[0];
        }

        #endregion

        #region accesseurs
      
        #endregion
        

        #region méthode

        public static void supprimerAgentAcceuil(string login)
        {
            MySqlCommand cmd = new MySqlCommand(sqlCommand, DataBase.getBD());
            MySqlDataReader read = cmd.Exe
        }
        

        #endregion
    }
}
