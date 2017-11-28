using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies.role
{
    public class Magasinier : Role
    {
        #region champs
        #endregion

        #region propriete
        #endregion

        #region methode
        /// <summary>
        /// Ajoute les informations du magasinier dans la base de donnée
        /// </summary>
        /// <returns>Retourne false si la requete echoue, sinon retourne vrai</returns>
        public override bool ajouter()
        {
            return true;
        }

        /// <summary>
        /// Modifie les informations du magasinier dans la base de donnée
        /// </summary>
        /// <returns>Retourne false si la requete echoue, sinon retourne vrai</returns>
        public override bool modifier()
        {
            return true;
        }

        /// <summary>
        /// Supprime les informations le magasinier dans la base de donnée
        /// </summary>
        /// <returns>Retourne false si la requete echoue, sinon retourne vrai</returns>
        public override bool supprimer()
        {
            return true;
        }

        /// <summary>
        /// Récupère les informations sur le magasinier dans la base de donnée
        /// </summary>
        /// <returns>Retourne un objet magasinier</returns>
        public override List<Role> affiche()
        {
            return null;
        }
        #endregion
    }
}
