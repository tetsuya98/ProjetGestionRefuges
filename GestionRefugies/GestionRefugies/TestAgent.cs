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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Txt_Adress.Text = /*appel de BD*/ "Adresse du Camps";

        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text != null && Txt_ID.Text != "Identifiant" && Txt_MDP.Text != null && Txt_MDP.Text != "Mot de Passe")
            {

                //appel BD
                /*if (BD ok){ this.close; prochainePage.show}
                  else{}*/
            }
        }

       
        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {
            this.Txt_ID.ForeColor = System.Drawing.Color.Black;
        }

        private void Txt_MDP_TextChanged(object sender, EventArgs e)
        {
            //this.Txt_MDP.PasswordChar.ToString("•");
            this.Txt_MDP.ForeColor = System.Drawing.Color.Black;

        }

        private void Txt_ID_Click(object sender, EventArgs e)
        {
            if (this.Txt_ID.Text == "Identifiant" )
            {
                this.Txt_ID.Text = "";
            }
            
        }

        private void Txt_MDP_Click(object sender, EventArgs e)
        {
            if (this.Txt_MDP.Text == "Mot de Passe")
            {
                this.Txt_MDP.Text = "";
            }
        }

        private void creer_Click(object sender, EventArgs e)
        {

            ManageAgentAccueil.add(new AgentAccueil ("lesagedd","corentin","mdp"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageAgentAccueil.supp("AgAlesageddc");
        }
    }
}
