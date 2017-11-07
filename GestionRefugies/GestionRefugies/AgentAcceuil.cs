using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{


    class AgentAccueil : User
    {
        #region variables
        
        #endregion
        
        #region constructeur
        
        public AgentAccueil(string nom,string prenom,string motdepasse):base(nom,prenom,motdepasse)
        {
             
            Id = "AgA" + Nom + Prenom[0];
        }

        #endregion

        #region accesseurs
      
        #endregion
        

        #region méthode

     
        #endregion
    }
}
