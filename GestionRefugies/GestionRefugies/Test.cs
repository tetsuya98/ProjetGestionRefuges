using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRefugies
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void BT_login_Click(object sender, EventArgs e)
        {
            User tmp = User.login("useru63", "mdp");
            MessageBox.Show(User.Hashage("mdp", "useru637"));
            if (tmp != null)
            {
                MessageBox.Show("Vous êtes connecté en tant que " + tmp.Nom + " " + tmp.Prenom);
            }
            else
            {
                MessageBox.Show("Erreur");
            }
            
        }

        private void BT_add_Click(object sender, EventArgs e)
        {
            if (User.add(new User("user", "user", "mdp", false, false, false)))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
