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
            if (Refugier.add(new Refugier("Lakraa", "Omer", "M", DateTime.Now, "français", 3, 1)) == true)
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
            if (Refugier.update(new Refugier("Lakraa", "Omer", "M", DateTime.Now, "français", 3, 1)) == true)
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
            if (Refugier.delete(new Refugier("Lakraa", "Omer", "M", DateTime.Now, "français", 3, 1)) == true)
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
            if (User.login("lakraao", "md"))
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
                if (tmp.Roles.Admin != null)
                {
                    MessageBox.Show("Je suis administrateur");
                }
                else {
                    MessageBox.Show("Je ne suis pas administrateur");
                }
            }
        }
    }
}
