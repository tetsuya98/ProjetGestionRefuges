using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    abstract class Role
    {
        #region champs
        private String nom;
        #endregion

        #region propriete
        public string Nom
        {
            get
            {
                return nom;
            }
        }
        #endregion

        #region methode

        /// <summary>
        /// Ajoute les informations du role dans la base de donnée
        /// </summary>
        /// <returns>Retourne false si la requete echoue, sinon retourne vrai</returns>
        public abstract bool ajouter();

        /// <summary>
        /// Modifie les informations du role dans la base de donnée
        /// </summary>
        /// <returns>Retourne false si la requete echoue, sinon retourne vrai</returns>
        public abstract bool modifier();

        /// <summary>
        /// Supprime les informations du role dans la base de donnée
        /// </summary>
        /// <returns>Retourne false si la requete echoue, sinon retourne vrai</returns>
        public abstract bool supprimer();

        /// <summary>
        /// Récupère les informations sur le role dans la base de donnée
        /// </summary>
        /// <returns>Retourne un objet role</returns>
        public abstract List<Role> affiche();

        #endregion

    }
}
