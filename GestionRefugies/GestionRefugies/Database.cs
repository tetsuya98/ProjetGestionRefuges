using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    public class Database
    {
        public static MySqlConnection bd = null;

        public static MySqlConnection getBD()
        {
            if (bd == null)
            {
                bd = new MySqlConnection("database=gestionrefugie; server=localhost; user id=root; pwd=");
                try
                {
                    bd.Open();
                }
                catch (MySqlException exp)
                {
                    System.Diagnostics.Debug.WriteLine(exp.ToString());
                    return null;
                }
            }
            return bd;
        }
    }
}
