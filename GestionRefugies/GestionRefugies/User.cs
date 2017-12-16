using System;
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
        private Roles roles;

        #endregion

        #region constructeur

        /// <summary>
        /// constructeur de la classe Agent d'accueil
        /// </summary>
        /// <param name="nom">nom de l'agent d'acceuil</param>
        /// <param name="prenom">prénom de l'agent</param>
        /// <param name="motdepasse">mot de passe de l'utilisateur</param>
        public User(string nom, string prenom, string motdepasse, bool admin, bool agent , bool magasinier)
        {
            Random aleatoire = new Random();
            this.id = (nom + prenom[0]).ToLower() + aleatoire.Next(1000);
            this.nom = nom;
            this.prenom = prenom;
            this.motdepasse = Hashage(motdepasse, id);
            this.roles = new Roles(admin, agent, magasinier);
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

        public Roles Roles
        {
            get
            {
                return roles;
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
            string sqlCommand = "INSERT INTO users (nom, prenom, agent, magasinier, administrateur, mdp, login) VALUES (?,?,?,?,?,?,?)";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@nom", user.Nom);
            cmd.Parameters.AddWithValue("@prenom", user.Prenom);
                
            //Agent
            if (user.Roles.Agent != null)
                cmd.Parameters.AddWithValue("@agent", true);
            else
                cmd.Parameters.AddWithValue("@agent", false);
            //Magasinier
            if (user.Roles.Magasinier != null)
                cmd.Parameters.AddWithValue("@magasinier", true);
            else
                cmd.Parameters.AddWithValue("@magasinier", false);

            //Administrateur
            if (user.Roles.Adminnistrateur != null)
                cmd.Parameters.AddWithValue("@administrateur", true);
            else
                cmd.Parameters.AddWithValue("@administrateur", false);

            cmd.Parameters.AddWithValue("@mdp", user.Motdepasse);
            cmd.Parameters.AddWithValue("@login", user.Id);


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
        public static bool delete(string login)
        {
            //requete SQL
            String sql = "DELETE FROM users WHERE login = ? ";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@login", login);
            
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
        public static bool update(User user)
        {
            //requete SQL
            String sql = "UPDATE users SET nom = ?, prenom = ?, mdp = ?, agent = ?, magasinier = ?, administrateur = ? WHERE login = ? ";

            MySqlCommand cmd = new MySqlCommand(sql, Database.getBD());

            cmd.CommandText = sql;
            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@Nom", user.Nom);
            cmd.Parameters.AddWithValue("@Prenom", user.Prenom);
            cmd.Parameters.AddWithValue("@Motdepasse", user.Motdepasse);

            //Agent
            if (user.Roles.Agent != null)
                cmd.Parameters.AddWithValue("@agent", true);
            else
                cmd.Parameters.AddWithValue("@agent", false);
            //Magasinier
            if (user.Roles.Magasinier != null)
                cmd.Parameters.AddWithValue("@magasinier", true);
            else
                cmd.Parameters.AddWithValue("@magasinier", false);

            //Administrateur
            if (user.Roles.Adminnistrateur != null)
                cmd.Parameters.AddWithValue("@administrateur", true);
            else
                cmd.Parameters.AddWithValue("@administrateur", false);

            cmd.Parameters.AddWithValue("@login", user.Id);

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
        public static List<User> select()
        {
            List<User> users = new List<User>();
            string sqlCommand = "SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                return null;
            }

            while (reader.Read())
            {
                System.Diagnostics.Debug.Write("===============================");
                System.Diagnostics.Debug.Write(reader.GetFieldValue<String>(reader.GetOrdinal("nom")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<String>(reader.GetOrdinal("prenom")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<bool>(reader.GetOrdinal("agent")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<bool>(reader.GetOrdinal("magasinier")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<bool>(reader.GetOrdinal("administrateur")));
                System.Diagnostics.Debug.Write(reader.GetFieldValue<String>(reader.GetOrdinal("mdp")));

                User tmp = new User(
                reader.GetFieldValue<String>(reader.GetOrdinal("nom")),
                reader.GetFieldValue<String>(reader.GetOrdinal("prenom")),
                reader.GetFieldValue<String>(reader.GetOrdinal("mdp")),
                reader.GetFieldValue<bool>(reader.GetOrdinal("administrateur")),
                reader.GetFieldValue<bool>(reader.GetOrdinal("agent")),
                reader.GetFieldValue<bool>(reader.GetOrdinal("magasinier"))
            );
                users.Add(tmp);
            }
            reader.Close();
            return users;
        }

        /// <summary>
        /// Fonction qui indique la validité du login et du mot de passe dans la base de donnée
        /// </summary>
        /// <param name="login">Login de l'utilisateur</param>
        /// <param name="mdp">Mot de passe de l'utilisateur</param>
        /// <returns>retoutne un objet User de l'utilisateur qui veut se connecte</returns>
        public static User login(string login, string mdp)
        {
            //requete SQL
            String sqlCommand = "SELECT * FROM users WHERE login = ? AND mdp = ?";

            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;
            MySqlDataReader reader;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@mdp", User.Hashage(mdp, login));

            try
            {
                reader = cmd.ExecuteReader();
                System.Diagnostics.Debug.Write("===============================");
                System.Diagnostics.Debug.Write(reader.HasRows);

            }
            catch (MySqlException ex)
            {
                return null;
            }

            //récupération de l'utiisateur
            if (reader.HasRows == true)
            {
                reader.Read();
                User tmp = new User(
                    reader.GetFieldValue<String>(reader.GetOrdinal("nom")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("prenom")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("mdp")),
                    reader.GetFieldValue<bool>(reader.GetOrdinal("administrateur")),
                    reader.GetFieldValue<bool>(reader.GetOrdinal("agent")),
                    reader.GetFieldValue<bool>(reader.GetOrdinal("magasinier"))
                );
                reader.Close();
                return tmp;
            }
            else
            {
                reader.Close();
                return null;
            }


        }

        #endregion

        #region Fonction recherche user
        public static List<User> Rechercher(List<User> users,
            string optName = "",
            string optPrenom = "",
            string optid = "",
            bool optadmin = false,
            bool optmaga = false,
            bool optagent = false)
        {
            List<User> liste = new List<User>();

            foreach (var user in users)
            {
                int nom = 2;
                int prenom = 2;
                int id = 2;
                int role = 2;
                Roles roles = new Roles(optadmin, optagent, optmaga);

                if (optName.Length <= user.Nom.Length)
                {
                    if (optName.ToLower() == user.Nom.ToLower().Substring(0, optName.Length) & optName.Length >= 0)
                    {
                        nom = 0;
                        if (optName.Length == 0)
                        {
                            nom = 2;
                        }
                    }
                    else
                    {
                        nom = 1;
                    }
                }
                else { nom = 1; }

                if (optPrenom.Length <= user.Prenom.Length)
                {
                    if (optPrenom.ToLower() == user.Prenom.ToLower().Substring(0, optPrenom.Length) & optPrenom.Length >= 0)
                    {
                        prenom = 0;
                        if (optPrenom.Length == 0)
                        {
                            prenom = 2;
                        }
                    }
                    else
                    {
                        prenom = 1;
                    }
                }
                else { prenom = 1; }

                if (optid.Length <= user.Id.Length)
                {
                    if (optid.ToLower() == user.Id.ToLower().Substring(0, optid.Length) & optid.Length >= 0)
                    {
                        id = 0;
                        if (optid.Length == 0)
                        {
                            id = 2;
                        }
                    }
                    else
                    {
                        id = 1;
                    }
                }
                else { id = 1; }

                if (user.Roles == roles)
                {
                    role = 0;
                }
                else { role = 1; }










                //1 = pas bon
                //2 = rien mis
                //0 = mis et ok

                if (nom != 1 & prenom != 1 & id != 1 & role != 1)
                {
                    liste.Add(user);
                    System.Diagnostics.Debug.WriteLine("User ADDED");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("User non ADDED");
                }


            }

            return liste;
        }
        #endregion
    }
}
