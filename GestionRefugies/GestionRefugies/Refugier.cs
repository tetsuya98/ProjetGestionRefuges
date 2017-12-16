using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace GestionRefugies
{
    partial class Refugier
    {
        #region champs
        /// <summary>
        /// nom du refugier
        /// </summary>
        protected string nom;

        /// <summary>
        /// prénom du refugier
        /// </summary>
        protected string prenom;

        /// <summary>
        /// identifiant du refugier
        /// </summary>
        protected int id;

        /// <summary>
        /// sexe du refugier
        /// </summary>
        private String sexe;

        /// <summary>
        /// Date de naissance du refugier
        /// </summary>
        private DateTime dateNais;

        /// <summary>
        /// Adresse du refugier
        /// </summary>
        private int adresse;

        /// <summary>
        /// Nationnalité du refugier
        /// </summary>
        private string nationalite;

        /// <summary>
        /// taille du refugiers en cm
        /// </summary>
        private int taille;

        /// <summary>
        /// Couleur de peau du refugier
        /// </summary>
        private string couleurPeau;

        /// <summary>
        /// Couleur de cheveux du refugier
        /// </summary>
        private string couleurCheveux;

        /// <summary>
        /// Type de cheveux du refugier
        /// </summary>
        private string typeCheveux;

        /// <summary>
        /// Couleur des yeux
        /// </summary>
        private string couleurYeux;

        /// <summary>
        /// Blessure éventuelle du refugier
        /// </summary>
        private string blessure;

        /// <summary>
        /// Allergie éventuelle du refugier
        /// </summary>
        private string allergie;

        /// <summary>
        /// handicap éventuelle du refugier
        /// </summary>
        private string handicap;

        /// <summary>
        /// autre description du refugier
        /// </summary>
        private string autre;

        #endregion

        #region propriete
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
        public int Id
        {
            get
            {
                return id;
            }
        }
        public String Sexe
        {
            get
            {
                return sexe;
            }
        }
        public DateTime DateNais
        {
            get
            {
                return dateNais;
            }
        }
        public int Adresse
        {
            get
            {
                return adresse;
            }
        }
        public string Nationalite
        {
            get
            {
                return nationalite;
            }
        }

        public int Taille
        {
            get
            {
                return taille;
            }
        }

        public string CouleurPeau
        {
            get
            {
                return couleurPeau;
            }
        }
        public string CouleurCheveux
        {
            get
            {
                return couleurCheveux;
            }
        }

        public string TypeCheveux
        {
            get
            {
                return typeCheveux;
            }
        }

        public string CouleurYeux
        {
            get
            {
                return couleurYeux;
            }
        }

        public string Blessure
        {
            get
            {
                return blessure;
            }
        }

        public string Allergie
        {
            get
            {
                return allergie;
            }
        }

        public string Handicap
        {
            get
            {
                return handicap;
            }
        }

        public string Autre
        {
            get
            {
                return autre;
            }
        }

        #endregion

        #region methode
        /// <summary>
        /// Créer un réfugier
        /// </summary>
        /// <param name="nom">Nom du réfugier</param>
        /// <param name="prenom">Prénom du réfugier</param>
        /// <param name="sexe">Sexe du réfugier</param>
        /// <param name="dateNais">Date de naissance du réfugier</param>
        /// <param name="nationalite">nationnalité du réfugier</param>
        /// <param name="adresse">Adresse du réfugié</param>
        /// <param name="taille">Taille du réfugier en cm</param>
        /// <param name="couleurPeau">Courleur de peau du réfugier</param>
        /// <param name="couleurCheveux">Couleur de cheuveux du réfugier</param>
        /// <param name="typeCheveux">Type de cheuveux du réfugier</param>
        /// <param name="couleurYeux">Couleur de yeux du réfugier</param>
        /// <param name="blessure">Blessure éventuelle du réfugier</param>
        /// <param name="allergie">Allergie éventuelle du réfugier</param>
        /// <param name="handicap">Handicap éventuelle du réfugier</param>
        /// <param name="autre">Autre élément de description du réfugier</param>
        /// <param name="id">Identifiant du réfugier</param>
        public Refugier(
            string nom,
            string prenom,
            String sexe,
            DateTime dateNais,
            string nationalite,
            int adresse,
            int taille,
            string couleurPeau,
            string couleurCheveux,
            string typeCheveux,
            string couleurYeux,
            string blessure,
            string allergie,
            string handicap,
            string autre,
            int id = 0
            )
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.dateNais = dateNais;
            this.nationalite = nationalite;
            this.adresse = adresse;
            this.taille = taille;
            this.couleurPeau = couleurPeau;
            this.couleurCheveux = couleurCheveux;
            this.typeCheveux = typeCheveux;
            this.couleurYeux = couleurYeux;
            this.blessure = blessure;
            this.allergie = allergie;
            this.handicap = handicap;
            this.autre = autre;
            this.id = id;
        }

        /// <summary>
        /// Ajoute dun réfugier dans la base de donnée
        /// </summary>
        /// <param name="refugier">Référence du réfugier</param>
        /// <returns>True si la requete s'execute correctement sinon false</returns>
        public static bool add(Refugier refugier)
        {

            ///finir la requete sql
            string sqlCommand = "INSERT INTO refugiers (nom, prenom, nationalite, sexe, adresse, dateNais, taille, couleurPeau, couleurCheveux, typeCheveux, couleurYeux, blessure, allergie, handicap, autre) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@nom", refugier.Nom);
            cmd.Parameters.AddWithValue("@prenom", refugier.Prenom);
            cmd.Parameters.AddWithValue("@nationalite", refugier.Nationalite);
            cmd.Parameters.AddWithValue("@sexe", refugier.Sexe);
            cmd.Parameters.AddWithValue("@adresse", refugier.Adresse);
            cmd.Parameters.AddWithValue("@dateNais", refugier.DateNais.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@taille", refugier.Taille);
            cmd.Parameters.AddWithValue("@couleurPeau", refugier.CouleurPeau);
            cmd.Parameters.AddWithValue("@couleurCheveux", refugier.CouleurCheveux);
            cmd.Parameters.AddWithValue("@typeCheveux", refugier.TypeCheveux);
            cmd.Parameters.AddWithValue("@couleurYeux", refugier.CouleurYeux);
            cmd.Parameters.AddWithValue("@blessure", refugier.Blessure);
            cmd.Parameters.AddWithValue("@allergie", refugier.Allergie);
            cmd.Parameters.AddWithValue("@handicap", refugier.Handicap);
            cmd.Parameters.AddWithValue("@autre", refugier.Autre);


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
        /// Modifie un réfugié dans la base de donnée
        /// </summary>
        /// <param name="refugier">réfugier à modifié</param>
        /// <returns>Retourne true si la requete réussi sinon false</returns>
        public static bool update(Refugier refugier)
        {

            string sqlCommand = "UPDATE refugiers  SET nom = ?, prenom = ?, nationalite = ?, sexe = ?, adresse = ?, dateNais = ?, taille = ?, couleurPeau = ?, couleurCheveux = ?, typeCheveux = ?, couleurYeux = ?, blessure = ?, allergie = ?, handicap = ?, autre = ? WHERE id = ?";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@nom", refugier.Nom);
            cmd.Parameters.AddWithValue("@prenom", refugier.Prenom);
            cmd.Parameters.AddWithValue("@nationalite", refugier.Nationalite);
            cmd.Parameters.AddWithValue("@sexe", refugier.Sexe);
            cmd.Parameters.AddWithValue("@adresse", refugier.Adresse);
            cmd.Parameters.AddWithValue("@dateNais", refugier.DateNais.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@taille", refugier.Taille);
            cmd.Parameters.AddWithValue("@couleurPeau", refugier.CouleurPeau);
            cmd.Parameters.AddWithValue("@couleurCheveux", refugier.CouleurCheveux);
            cmd.Parameters.AddWithValue("@typeCheveux", refugier.TypeCheveux);
            cmd.Parameters.AddWithValue("@couleurYeux", refugier.CouleurYeux);
            cmd.Parameters.AddWithValue("@blessure", refugier.Blessure);
            cmd.Parameters.AddWithValue("@allergie", refugier.Allergie);
            cmd.Parameters.AddWithValue("@handicap", refugier.Handicap);
            cmd.Parameters.AddWithValue("@autre", refugier.Autre);
            cmd.Parameters.AddWithValue("@id", refugier.Id);


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
        /// Supprime un refugier dans la base de donnée
        /// </summary>
        /// <param name="refugier">Id du réfugier à supprimmer</param>
        /// <returns>Retourne true si la requete réussi sinon false</returns>
        public static bool delete(int id)
        {
            string sqlCommand = "DELETE FROM refugiers WHERE id = ?";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@id", id);

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
        /// Récupère la liste des réfugier dans la base de donnée
        /// </summary>
        /// <returns>Retourne la liste de réfugier</returns>
        public static List<Refugier> select()
        {
            List<Refugier> refugiers = new List<Refugier>();
            string sqlCommand = "SELECT * FROM refugiers";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());

            cmd.CommandText = sqlCommand;
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
            }catch(MySqlException ex)
            {
                return null;
            }
            
            while (reader.Read())
            {                
                    Refugier tmp = new Refugier(
                    reader.GetFieldValue<String>(reader.GetOrdinal("nom")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("prenom")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("sexe")),
                    reader.GetDateTime(reader.GetOrdinal("dateNais")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("nationalite")),
                    reader.GetFieldValue<int>(reader.GetOrdinal("adresse")),
                    reader.GetFieldValue<int>(reader.GetOrdinal("taille")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("couleurPeau")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("couleurCheveux")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("typeCheveux")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("couleurYeux")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("blessure")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("allergie")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("handicap")),
                    reader.GetFieldValue<String>(reader.GetOrdinal("autre")),
                    reader.GetFieldValue<int>(reader.GetOrdinal("id"))

                );
                refugiers.Add(tmp);
            }
            reader.Close();
            return refugiers;
        }
        #region Rechercher un refugier
        public static List<Refugier> Rechercher(List<Refugier> refugiers,
            string optName = "",
            string optPrenom = "",
            String optsex = "",
            DateTime optdatenaissn = new DateTime(),
            string optnat = "",
            int optadre = 0,
            int opttaille = 0,
            string optskin = "",
            string optHairColor = "",
            string optHairType = "",
            string opteyes = "",
            string optwound = "",
            string optAllerg = "",
            string optHandicap = "",
            string optOther = "")
        {
            List<Refugier> liste = new List<Refugier>();

            foreach (var refugier in refugiers)
            {
                int nom = 2;
                int prenom = 2;
                int sex = 2;
                int date = 2;
                int nat = 2;
                int adresse = 2;
                int taille = 2;
                int Skin = 2;
                int HairCol = 2;
                int HairType = 2;
                int eyes = 2;
                int wound = 2;
                int allerg = 2;
                int handi = 2;
                int other = 2;

                if (optName.Length <= refugier.Nom.Length)
                {
                    if (optName.ToLower() == refugier.Nom.ToLower().Substring(0, optName.Length) & optName.Length >= 0)
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

                if (optPrenom.Length <= refugier.Prenom.Length)
                {
                    if (optPrenom.ToLower() == refugier.Prenom.ToLower().Substring(0, optPrenom.Length) & optPrenom.Length >= 0)
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

                if (optsex.Length <= refugier.Sexe.Length)
                {
                    if (optsex.ToLower() == refugier.Sexe.ToLower().Substring(0, optsex.Length) & optsex.Length >= 0)
                    {
                        sex = 0;
                        if (optsex.Length == 0)
                        {
                            sex = 2;
                        }
                    }
                    else
                    {
                        sex = 1;
                    }
                }
                else { sex = 1; }


                if (optdatenaissn == new DateTime(1900, 01, 01))
                {
                    date = 2;
                }
                else
                {
                    if (optdatenaissn == refugier.DateNais)
                    {
                        date = 0;
                    }
                    else
                    {
                        date = 1;
                        System.Diagnostics.Debug.WriteLine(DateTime.Now);
                    }
                }

                if (optnat.Length <= refugier.Nationalite.Length)
                {
                    if (optnat.ToLower() == refugier.Nationalite.ToLower().Substring(0, optnat.Length) & optnat.Length >= 0)
                    {
                        nat = 0;
                        if (optnat.Length == 0)
                        {
                            nat = 2;
                        }
                    }
                    else
                    {
                        nat = 1;
                    }
                }
                else { nat = 1; }

                if (optadre != 0)
                {
                    adresse = 1;
                    if (optadre == refugier.adresse)
                    {
                        adresse = 0;
                    }
                }
                else { adresse = 2; }

                if (opttaille != 0)
                {
                    taille = 1;
                    if (opttaille == refugier.Taille)
                    {
                        taille = 0;
                    }
                }
                else { taille = 2; }

                if (optskin.Length <= refugier.CouleurPeau.Length)
                {
                    if (optskin.ToLower() == refugier.CouleurPeau.ToLower().Substring(0, optskin.Length) & optskin.Length >= 0)
                    {
                        Skin = 0;
                        if (optskin.Length == 0)
                        {
                            Skin = 2;
                        }
                    }
                    else
                    {
                        Skin = 1;
                    }
                }
                else { Skin = 1; }

                if (optHairColor.Length <= refugier.couleurCheveux.Length)
                {
                    if (optHairColor.ToLower() == refugier.couleurCheveux.ToLower().Substring(0, optHairColor.Length) & optHairColor.Length >= 0)
                    {
                        HairCol = 0;
                        if (optHairColor.Length == 0)
                        {
                            HairCol = 2;
                        }
                    }
                    else
                    {
                        HairCol = 1;
                    }
                }
                else { HairCol = 1; }

                if (optHairType.Length <= refugier.typeCheveux.Length)
                {
                    if (optHairType.ToLower() == refugier.typeCheveux.ToLower().Substring(0, optHairType.Length) & optHairType.Length >= 0)
                    {
                        HairType = 0;
                        if (optHairType.Length == 0)
                        {
                            HairType = 2;
                        }
                    }
                    else
                    {
                        HairType = 1;
                    }
                }
                else { HairType = 1; }

                if (opteyes.Length <= refugier.couleurYeux.Length)
                {
                    if (opteyes.ToLower() == refugier.couleurYeux.ToLower().Substring(0, opteyes.Length) & opteyes.Length >= 0)
                    {
                        eyes = 0;
                        if (opteyes.Length == 0)
                        {
                            eyes = 2;
                        }
                    }
                    else
                    {
                        eyes = 1;
                    }
                }
                else { eyes = 1; }


                if (optwound.Length <= refugier.blessure.Length)
                {
                    if (optwound.ToLower() == refugier.blessure.ToLower().Substring(0, optwound.Length) & optwound.Length >= 0)
                    {
                        wound = 0;
                        if (optwound.Length == 0)
                        {
                            wound = 2;
                        }
                    }
                    else
                    {
                        wound = 1;
                    }
                }
                else { wound = 1; }


                if (optAllerg.Length <= refugier.Allergie.Length)
                {
                    if (optAllerg.ToLower() == refugier.Allergie.ToLower().Substring(0, optAllerg.Length) & optAllerg.Length >= 0)
                    {
                        allerg = 0;
                        if (optAllerg.Length == 0)
                        {
                            allerg = 2;
                        }
                    }
                    else
                    {
                        allerg = 1;
                    }
                }
                else { allerg = 1; }

                if (optHandicap.Length <= refugier.Handicap.Length)
                {
                    if (optHandicap.ToLower() == refugier.Handicap.ToLower().Substring(0, optHandicap.Length) & optHandicap.Length >= 0)
                    {
                        handi = 0;
                        if (optHandicap.Length == 0)
                        {
                            handi = 2;
                        }
                    }
                    else
                    {
                        handi = 1;
                    }
                }
                else { handi = 1; }

                if (optOther.Length <= refugier.Autre.Length)
                {
                    if (optOther.ToLower() == refugier.Autre.ToLower().Substring(0, optOther.Length) & optOther.Length >= 0)
                    {
                        other = 0;
                        if (optOther.Length == 0)
                        {
                            other = 2;
                        }
                    }
                    else
                    {
                        other = 1;
                    }
                }
                else { other = 1; }







                //1 = pas bon
                //2 = rien mis
                //0 = mis et ok

                if (nom != 1 & prenom != 1 & nat != 1 & sex != 1 & date != 1 & adresse != 1 & taille != 1 & Skin != 1 & HairCol != 1 & HairType != 1 & eyes != 1 & wound != 1 & allerg != 1 & handi != 1 & other != 1)
                {
                    liste.Add(refugier);
                    System.Diagnostics.Debug.WriteLine("Ref ADDED");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Ref non ADDED");
                }


            }

            return liste;
        }

        #endregion

#endregion
    }
}
