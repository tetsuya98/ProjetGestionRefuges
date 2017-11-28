using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionRefugies
{
    public partial class Form3 : Form
    {
       
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1", ("odRAn"), ("lariviere"), ("Français"), ("MaSculIn"), ("1 chemin des aubivaTS"), ("11/08/1998"));
            dataGridView1.Rows.Add("2", ("corentin"), ("elpatron"), ("Français"), ("MaSculIn"), ("somewhere over the raindow"), ("11/08/1998"));
            dataGridView1.Rows.Add("3", ("dgodRAn"), ("dufour"), ("Français"), ("MaSculIn"), ("cave"), ("11/08/1998"));
            dataGridView1.Rows.Add("4", ("odgfdgRAn"), ("larreeiviere"), ("Français"), ("MaSculIn"), ("maison du pape"), ("11/08/1998"));
            dataGridView1.Rows.Add("5", ("odRAfghdn"), ("larierzviere"), ("Français"), ("MaSculIn"), ("3 chemin du chevalier"), ("11/08/1998"));
            dataGridView1.Rows.Add("6", ("odRAfghn"), ("larivsdfsiere"), ("Français"), ("MaSculIn"), ("4 chemin des aubivaTS"), ("11/08/1998"));
            dataGridView1.Rows.Add("7", ("odRfghAn"), ("larivgbfiere"), ("Français"), ("MaSculIn"), ("6 chemin des aubivaTS"), ("11/08/1998"));
        }
    }
}
