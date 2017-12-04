using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Refugier> liste = new List<Refugier>();
            liste = Refugier.select();
            liste = Refugier.Rechercher(liste, "la", "", "");
            foreach (var refu in liste)
            {
                label1.Text += refu.Nom;
            }
        }
    }
}
