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
        private Administrateur admin;

        private Agent agent;

        private Magasinier magasinier;

        public Administrateur Admin
        {
            get
            {
                return admin;
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

        public Roles(Administrateur admin,Agent agent,Magasinier magasinier)
        {
            this.admin = admin;
            this.agent = agent;
            this.magasinier = magasinier;
        }

        public Roles()
        {
            this.admin = null;
            this.agent = null;
            this.magasinier = null;
        }

        
    }
}
