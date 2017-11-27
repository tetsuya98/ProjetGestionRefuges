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
            if (Refugier.add(new Refugier("Lakraa", "Omer", "mdp", "M", DateTime.Now, "français", 3, 1)) == true)
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
            if (Refugier.update(new Refugier("Lakraa", "Omer", "mdp", "M", DateTime.Now, "français", 3, 1)) == true)
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
            if (Refugier.delete(new Refugier("Lakraa", "Omer", "mdp", "M", DateTime.Now, "français", 3, 1)) == true)
            {
                MessageBox.Show("Sucess");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
