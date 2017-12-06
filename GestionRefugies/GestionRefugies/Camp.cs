using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GestionRefugies
{
    class Camp
    {
        #region champs
        /// <summary>
        /// Identifiant du camp
        /// </summary>
        private int id;

        /// <summary>
        /// Adresse du camp
        /// </summary>
        private string adresse;

        /// <summary>
        /// Nombre de réfugier maximal du camp
        /// </summary>
        private int capacite;
        #endregion

        #region propriete
        public int Id{
            get
            {
                return id;
            }
        }
        public string Adresse
        {
            get
            {
                return adresse;
            }
        }
        public int Capacite
        {
            get
            {
                return capacite;
            }
        }
        #endregion
        
        #region methode
        /// <summary>
        /// Constructeur de camp
        /// </summary>
        /// <param name="capacite">Nombre de réfugier maximal du camp</param>
        /// <param name="adresse">Adresse du camp</param>
        /// <param name="id">Identifiant du camp</param>
        public Camp(int capacite, string adresse, int id = 0)
        {
            this.capacite = capacite;
            this.adresse = adresse;
            this.id = id;
        }
        #endregion
    }
}