using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionRefugies.role;

namespace GestionRefugies
{
    public class Roles
    {
        #region champs

        /// <summary>
        /// Rôle administrateur
        /// </summary>
        private Administrateur administrateur;

        /// <summary>
        /// Rôle agent
        /// </summary>
        private Agent agent;

        /// <summary>
        /// Rôle magasinier
        /// </summary>
        private Magasinier magasinier;
        #endregion

        #region propriete
        public Administrateur Adminnistrateur
        {
            get
            {
                return administrateur;
            }

        }

        public Agent Agent
        {
            get
            {
                return agent;
            }

        }

        public  Magasinier Magasinier
        {
            get
            {
                return magasinier;
            }

        }
        #endregion

        #region methode
        public Roles(bool administrateur,bool agent, bool magasinier)
        {
            //Role administrateur
            if (administrateur)
            {
                this.administrateur = new Administrateur();
            }
            else
            {
                this.administrateur = null;
            }

            //Role agent
            if (agent)
            {
                this.agent = new Agent();
            }
            else
            {
                this.agent = null;
            }

            //Role magasineir
            if (magasinier)
            {
                this.magasinier = new Magasinier();
            }
            else
            {
                this.magasinier = null;
            }
        }
        #endregion


    }
}
