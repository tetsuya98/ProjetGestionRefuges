using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GestionRefugies.stock
{
    /// <summary>
    /// Représente un item dans les stocks
    /// </summary>
    class Item
    {
        #region champs
        /// <summary>
        /// Id de l'item
        /// </summary>
        private int id;

        /// <summary>
        /// Nom de l'item
        /// </summary>
        private string nom;

        /// <summary>
        /// Description de l'item
        /// </summary>
        private string description;

        /// <summary>
        /// Date de péremtion de l'item
        /// </summary>
        private DateTime datePeremtion;
        #endregion

        #region propriete
        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public DateTime DatePeremtion
        {
            get
            {
                return datePeremtion;
            }
        }
        #endregion

        #region methode
        /// <summary>
        /// Constructeur d'un item
        /// </summary>
        /// <param name="id">Id de l'item</param>
        /// <param name="nom">Nom de l'item</param>
        /// <param name="description">Description de l'item</param>
        /// <param name="datePeremtion">Date de péremtion de l'item</param>
        public Item(int id, string nom, string description, DateTime datePeremtion)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.datePeremtion = datePeremtion;
        }
        #endregion


    }
}