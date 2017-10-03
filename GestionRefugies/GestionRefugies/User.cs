using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    class User
    {
        #region variables

        /// <summary>
        /// nom de l'utilisateur
        /// </summary>
        string nom;
        /// <summary>
        /// prénom de l'utilisateur
        /// </summary>
        string prenom;
        /// <summary>
        /// identifiant de l'utilisateur
        /// </summary>
        string id;
        /// <summary>
        /// mot de passe de l'utilisateur
        /// </summary>
        string motdepasse;
        #endregion
        /// <summary>
        /// constructeur de la classe Agent d'accueil
        /// </summary>
        /// <param name="nom">nom de l'agent d'acceuil</param>
        /// <param name="prenom">prénom de l'agent</param>
        /// <param name="motdepasse">mot de passe de l'utilisateur</param>
        #region constructeur
        public User(string nom, string prenom, string motdepasse)
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
