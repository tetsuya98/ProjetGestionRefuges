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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Refugier.add(new Refugier(
                "Lakraa",
                "Omer",
                "M",
                DateTime.Now,
                "français",
                3, 
                3, 
                "blue", 
                "rouge", 
                "bouclé", 
                "Orange", 
                "Non", 
                "math", 
                "con", 
                "autre....")) == true)
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Refugier.update(new Refugier(
                "Flipo",
                "Yann",
                "M",
                DateTime.Now,
                "français",
                3,
                3,
                "blue",
                "rouge",
                "bouclé",
                "Orange",
                "Non",
                "math",
                "con",
                "autre....", 
                2)) == true)
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Refugier.delete(1) == true)
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lancement");
            List<Refugier> refugiers = new List<Refugier>();
            refugiers = Refugier.select();
            for (int i = 0; i < refugiers.LongCount(); i++)
            {
                MessageBox.Show(refugiers.ElementAt(i).ToString());
            }
        }

        private void BT_login_Click(object sender, EventArgs e)
        {
            if (User.login("lakraao", "md") != null)
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void BT_selectUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lancement");
            List<User> users = new List<User>();
            users = User.select();
            for (int i = 0; i < users.LongCount(); i++)
            {
                User tmp = users.ElementAt(i);
                MessageBox.Show("Nom : "+tmp.Nom);
                if (tmp.Roles.Administrateur != null)
                {
                    MessageBox.Show("Je suis administrateur");
                }
                else {
                    MessageBox.Show("Je ne suis pas administrateur");
                }
            }
        }

        private void BT_addUser_Click(object sender, EventArgs e)
        {
            if (User.add(new User("Bonjour", "Salut", "mdp", true, false, false)) == true)
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void BT_delUser_Click(object sender, EventArgs e)
        {
            if (User.delete("Lakraa") == true)
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void BT_updateUser_Click(object sender, EventArgs e)
        {
            User tmp = new User("Bonjour", "Elvire", "mdp", true, true, false);
            tmp.Id = "lakraao";
            if (User.update(tmp) == true)
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void BT_update_camp_Click(object sender, EventArgs e)
        {

        }

        private void BT_select_camp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Camp.select(1).ToString());
        }
    }
}
