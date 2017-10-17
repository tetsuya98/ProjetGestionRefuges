using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    public class User
    {
        #region variables


        /// <summary>
        /// nom de l'utilisateur
        /// </summary>
        protected string nom;
        /// <summary>
        /// prénom de l'utilisateur
        /// </summary>
        protected string prenom;
        /// <summary>
        /// identifiant de l'utilisateur
        /// </summary>
        protected string id;
        /// <summary>
        /// mot de passe de l'utilisateur
        /// </summary>
        protected string motdepasse;
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
            this.Motdepasse = Hashage(motdepasse,prenom);
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


        public static string Hashage(string Password, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] PasswordAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Password, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PasswordAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);

        }







        #endregion
    }
}
