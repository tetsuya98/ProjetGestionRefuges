using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{


    class AgentAcceuil
    {
        #region variables
        
        /// <summary>
        /// nom de l'Agent d'acceuil
        /// </summary>
        string nom;
        /// <summary>
        /// prénom de l'agent d'acceuil
        /// </summary>
        string prenom;
        /// <summary>
        /// identifiant de l'agent d'acceuil
        /// </summary>
        string id;
        /// <summary>
        /// mot de passe du réfugié
        /// </summary>
        string motdepasse;
        #endregion

        #region constructeur
        public AgentAcceuil(string nom, string prenom, string motdepasse)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Motdepasse = motdepasse;
        }

        #endregion

        #region accesseurs
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

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Motdepasse
        {
            get
            {
                return motdepasse;
            }

            set
            {
                motdepasse = value;
            }
        }
        #endregion


        #region méthode








        #endregion
    }
}
