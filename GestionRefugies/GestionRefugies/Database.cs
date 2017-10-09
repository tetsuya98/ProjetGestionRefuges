using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    class Database
    {
        static MySqlConnection bd = null;

        static MySqlConnection getBD()
        {
            if (bd == null)
                bd = new MySqlConnection("database=test; server=localhost; user id=root; pwd=");
            return bd;
        }
    }
}
