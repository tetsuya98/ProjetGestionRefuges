﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    public class User
    {
        #region variables


        /// <summary>
        /// nom de l'utilisateur
        /// </summary>
        private string nom;

        /// <summary>
        /// prénom de l'utilisateur
        /// </summary>
        private string prenom;

        /// <summary>
        /// identifiant de l'utilisateur
        /// </summary>
        private string id;

        /// <summary>
        /// mot de passe de l'utilisateur
        /// </summary>
        private string motdepasse;

        /// <summary>
        /// Liste des roles de l'utilisateur
        /// </summary>
        private Roles user_r; // création de la liste

        #endregion

        #region constructeur

        /// <summary>
        /// constructeur de la classe Agent d'accueil
        /// </summary>
        /// <param name="nom">nom de l'agent d'acceuil</param>
        /// <param name="prenom">prénom de l'agent</param>
        /// <param name="motdepasse">mot de passe de l'utilisateur</param>
        public User(string nom, string prenom, string motdepasse, Administarteur admin, Agent agent , Magasinier magasinier)
        {

            this.id = nom + prenom[0];
            this.nom = nom;
            this.prenom = prenom;
            this.motdepasse = Hashage(motdepasse,prenom);
            this.user_r = new Roles(admin, agent, magasinier);
        }

        #endregion

        #region accesseurs

        public string Nom
        {
            get
            {
                return nom;
            }

        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

        }

        public string Id
        {
            get
            {
                return id;
            }

        }
      
        public string Motdepasse
        {
            get
            {
                return motdepasse;
            }

        }

        public Roles User_r
        {
            get
            {
                return user_r;
            }

        }
        #endregion

        #region méthode

        /// <summary>
        /// fonction de hashage
        /// </summary>
        /// <param name="Password">mot de passe à hasher</param>
        /// <param name="Salt">permet de rendre les mot de passes tous différents</param>
        /// <returns></returns>
        public static string Hashage(string Password, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] PasswordAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Password, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PasswordAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);

        }
    
        /// <summary>
        /// fonction ajout dans BD d'un user
        /// </summary>
        /// <param name="user">prend un utilisateur en paramètre</param>
        /// <returns>true si réussi sinon false</returns>
        public static bool add(User user)
        {
            //requete SQL
            String sql = "INSERT INTO users (clef, prenom, nom, mdp , admin, agent, magasinier) VALUES (?,?,?,?,?,?,?)";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@Id", user.Id);
            cmd.Parameters.AddWithValue("@Prenom", user.Prenom);
            cmd.Parameters.AddWithValue("@Nom", user.Nom);
            cmd.Parameters.AddWithValue("@Motdepasse", user.Motdepasse);

            #region role
            if (User_r.Adminstareur == null)
            {
                cmd.Parameters.AddWithValue("@Administrateur", false);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Administrateur", true);
            }
            if (User_r.Agent == null)
            {
                cmd.Parameters.AddWithValue("@Agent", false);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Agent", true);
            }
            if (User_r.Magasinier == null)
            {
                cmd.Parameters.AddWithValue("@Magasinier", false);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Magasinier", true);
            }

            #endregion role

            try
            {
                //Execution de la commande SQL qui peut provoquer des exceptions
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {

                //traitement de l'exception...
                return false;
            }
        }

        /// <summary>
        /// fonction supression dans BD d'un user
        /// </summary>
        /// <param name="user">prend un utilisateur en paramètre</param>
        /// <returns>true si réussi sinon false</returns>
        public static bool delete(User user)
        {
            //requete SQL
            String sql = "DELETE FROM `users` WHERE `users`.`clef` =? ";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@Id", user.id);



            try
            {
                //Execution de la commande SQL qui peut provoquer des exceptions
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                //traitement de l'exception...
                return false;
            }
        }

        /// <summary>
        /// fonction Màj dans BD d'un user
        /// </summary>
        /// <param name="user">prend un utilisateur en paramètre</param>
        /// <returns>true si réussi sinon false</returns>
        public static bool udapte(User user)
        {
            //requete SQL
            String sql = "UPDATE `users` SET `nom` = '?', `prenom` = '?', `mdp` = '?' , `admin` = '?' ,`agent` = '?' ,`magasinier` = '?' WHERE `users`.`clef` = '?' VALUES(?,?,?,?,?,?,?)";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;
            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@Id", user.Id);
            cmd.Parameters.AddWithValue("@Prenom", user.Prenom);
            cmd.Parameters.AddWithValue("@Nom", user.Nom);
            cmd.Parameters.AddWithValue("@Motdepasse", user.Motdepasse);
            #region role
            if (User_r.Adminstareur == null)
            {
                cmd.Parameters.AddWithValue("@Administrateur", false);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Administrateur", true);
            }
            if (User_r.Agent == null)
            {
                cmd.Parameters.AddWithValue("@Agent", false);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Agent", true);
            }
            if (User_r.Magasinier == null)
            {
                cmd.Parameters.AddWithValue("@Magasinier", false);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Magasinier", true);
            }

            #endregion role

            try
            {
                //Execution de la commande SQL qui peut provoquer des exceptions
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {

                //traitement de l'exception...
                return false;
            }
        }

        /// <summary>
        /// fonction Recherche simple dans BD d'un user
        /// </summary>
        /// <param name="user">prend un utilisateur en paramètre(ne regarde que l'id )</param>
        /// <returns>true si réussi sinon false</returns>
        public static bool select(User user)
        {
            //requete SQL
            String sql = "SELECT * FROM users WHERE 'users'.'clef'= ?";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;
            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@Id", user.id);

            try
            {
                //Execution de la commande SQL qui peut provoquer des exceptions
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {

                //traitement de l'exception...
                return false;
            }
        }

        #endregion
    }
}
