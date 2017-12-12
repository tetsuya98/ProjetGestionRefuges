using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public partial class Ajout : Form
    {
        
        private User connected_user;
        
        public Ajout(User connect_u)
        {
            InitializeComponent();
            connected_user = connect_u;
            label_nameU.Text = connected_user.Nom;

            if(connected_user.Roles.Magasinier == null) { label_MagaAccess.Text = "false"; } else { label_MagaAccess.Text = "true"; }
            if(connected_user.Roles.Agent == null) { label_AgentAccess.Text = "false"; } else { label_AgentAccess.Text = "true"; }
            if(connected_user.Roles.Adminnistrateur == null) { label_AdminAccess.Text = "false"; } else { label_AdminAccess.Text = "true"; }
        }

        
        private void AjoutRefugies_Load(object sender, EventArgs e)
        {
            
        }

        #region tabPageAjoutRefugié

        #region Txt_Nom
        private void Txt_Nom_KeyUp(object sender, KeyEventArgs e)
        {

            if (Txt_Nom.Text == "")
            {
                this.Txt_Nom.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Nom.Text = "Nom";
            }
        }

        private void Txt_Nom_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_Nom.Text == "Nom" || Txt_Nom.Text == "Nom Incorrect")
            {
                this.Txt_Nom.ForeColor = System.Drawing.Color.Black;
                Txt_Nom.Text = "";
            }
        }
        #endregion


        #region Txt_Prenom
        private void Txt_Prenom_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_Prenom.Text == "Prenom" || Txt_Prenom.Text == "Prenom Incorrect")
            {
                this.Txt_Prenom.ForeColor = System.Drawing.Color.Black;
                Txt_Prenom.Text = "";
            }
        }

        private void Txt_Prenom_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Prenom.Text == "")
            {
                this.Txt_Prenom.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Prenom.Text = "Prenom";
            }
        }
        #endregion


        #region Btn_Ajout
        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            
            // ce if est degueulasse ... désolé

            if (txt_typchev_ajoutref.Text != "" && txt_coulpeau_ajoutref.Text != "" && txt_allerg_ajoutref.Text != "" && txt_bless_ajoutref.Text != "" && txt_coulchev_ajoutref.Text != "" && txt_coulyeux_ajoutref.Text != "" && txt_handi_ajoutref.Text != "" &&  Txt_Nom.Text != "Nom" && Txt_Nom.Text != "Nom Incorrect" && Txt_Prenom.Text != "Prenom" && Txt_Prenom.Text != "Prenom Incorrect" && List_Nationalite.Text != "" && (RdBtn_Femme.Checked == true || RdBtn_Homme.Checked == true))
            {
                String sex;
                if (RdBtn_Femme.Checked == true)
                {
                    sex = "F";
                }
                else
                {
                    sex = "M";
                }

                if (Refugier.add(new Refugier(Txt_Nom.Text, Txt_Prenom.Text, sex, DatePicker_DatNaiss.Value, List_Nationalite.Text, (int)num_RefugeRef.Value, (int)num_taille_ajoutref.Value, txt_coulpeau_ajoutref.Text, txt_coulchev_ajoutref.Text, txt_typchev_ajoutref.Text, txt_coulyeux_ajoutref.Text, txt_bless_ajoutref.Text, txt_allerg_ajoutref.Text, txt_handi_ajoutref.Text, txt_autre_ajoutref.Text)) == true)
                {
                    MessageBox.Show("Succes de l'ajout du refugié : " + Txt_Nom.Text + " " + Txt_Prenom.Text);
                }
                else
	            {
                    MessageBox.Show("Echec de l'Ajout du refugié");
                }

            }
            else
            {
                if (txt_typchev_ajoutref.Text == "")
                {
                    lbl_err_typchev_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_typchev_ajoutref.Visible = false;
                }
                if (txt_coulpeau_ajoutref.Text == "")
                {
                    lbl_err_coulpeau_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_coulpeau_ajoutref.Visible = false;
                }
                if (txt_allerg_ajoutref.Text == "")
                {
                    lbl_err_allerg_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_allerg_ajoutref.Visible = false;
                }
                if (txt_bless_ajoutref.Text == "")
                {
                    lbl_err_bless_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_bless_ajoutref.Visible = false;
                }
                if (txt_coulchev_ajoutref.Text == "")
                {
                    lbl_err_coulchev_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_coulchev_ajoutref.Visible = false;
                }
                if (txt_coulyeux_ajoutref.Text == "")
                {
                    lbl_err_coulyeux_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_coulyeux_ajoutref.Visible = false;
                }
                if (txt_handi_ajoutref.Text == "")
                {
                    lbl_err_handi_ajoutref.Visible = true;
                }
                else
                {
                    lbl_err_handi_ajoutref.Visible = false;
                }
                if (Txt_Nom.Text == "" || Txt_Nom.Text == "Nom")
                {
                    this.Txt_Nom.ForeColor = System.Drawing.Color.Red;
                    Txt_Nom.Text = "Nom Incorrect";
                }
                if (Txt_Prenom.Text == "" || Txt_Prenom.Text == "Prenom")
                {
                    this.Txt_Prenom.ForeColor = System.Drawing.Color.Red;
                    Txt_Prenom.Text = "Prenom Incorrect";
                }
                if (List_Nationalite.Text == "")
                {
                    Lbl_ErrNation.Visible = true;
                }
                else
                {
                    Lbl_ErrNation.Visible = false;
                }
                if (RdBtn_Homme.Checked == false && RdBtn_Femme.Checked == false)
                {
                    Lbl_Sexe.Visible = true;
                }
                else
                {
                    Lbl_Sexe.Visible = false;
                }
            }
        }
        #endregion


        #region Datepicker_DateNaiss
        private void DatePicker_DatNaiss_ValueChanged(object sender, EventArgs e)
        {

            if (DatePicker_DatNaiss.Value >= DateTime.Now)
            {
                DatePicker_DatNaiss.Value = DateTime.Now;
            }
        }


        #endregion

        #endregion
        
        #region tabPageAjoutGerant
        #region Txt_Nom
        private void Txt_NomM_KeyUp(object sender, KeyEventArgs e)
        {

            if (Txt_NomM.Text == "")
            {
                this.Txt_NomM.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_NomM.Text = "Nom";
            }
        }

        private void Txt_NomM_KeyDown_1(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_NomM.Text == "Nom" || Txt_NomM.Text == "Nom Incorrect")
            {
                this.Txt_NomM.ForeColor = System.Drawing.Color.Black;
                Txt_NomM.Text = "";
            }
        }
        #endregion
        
        #region Txt_Prenom
        private void Txt_PrenomM_KeyDown_1(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_PrenomM.Text == "Prenom" || Txt_PrenomM.Text == "Prenom Incorrect")
            {
                this.Txt_PrenomM.ForeColor = System.Drawing.Color.Black;
                Txt_PrenomM.Text = "";
            }
        }

        private void Txt_PrenomM_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (Txt_PrenomM.Text == "")
            {
                this.Txt_PrenomM.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_PrenomM.Text = "Prenom";
            }
        }
        #endregion
        
        #region Txt_MDP
        private void Txt_MDPM_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_MDPM.Text == "")
            {
                this.Txt_MDPM.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_MDPM.Text = "Mot de Passe";
            }
        }

        private void Txt_MDPM_KeyDown(object sender, KeyEventArgs e)
        {

            if (Txt_MDPM.Text == "Mot de Passe" || Txt_MDPM.Text == "Mot de Passe Incorrect")
            {
                this.Txt_MDPM.ForeColor = System.Drawing.Color.Black;
                Txt_MDPM.Text = "";
            }
        } 
        #endregion

        #region Btn_Ajout
        
        private void btn_AjoutM_Click_1(object sender, EventArgs e)
        {
            // ce if est degueulasse ... désolé
            if ((check_AgentAccueil.Checked || check_Magasinier.Checked || checkBox1.Checked) && Txt_NomM.Text != "Nom" && Txt_NomM.Text != "Nom Incorrect" && Txt_PrenomM.Text != "Prenom" && Txt_PrenomM.Text != "Prenom Incorrect" && Txt_MDPM.Text != "Mot de passe" && Txt_MDPM.Text != "Mot de passe Incorrect" )
            {
                

                if (checkBox1.Checked)
                {
                    if (check_AgentAccueil.Checked && check_Magasinier.Checked)
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, true, true, true)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else if (check_AgentAccueil.Checked && !(check_Magasinier.Checked))
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, true, true, false)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else if (!(check_AgentAccueil.Checked) && check_Magasinier.Checked)
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, true, false, true)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, true, false, false)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                }
                else
                {
                    if (check_AgentAccueil.Checked && check_Magasinier.Checked)
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, false, true, true)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else if (check_AgentAccueil.Checked && !(check_Magasinier.Checked))
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, false, true, false)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else if (!(check_AgentAccueil.Checked) && check_Magasinier.Checked)
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, false, false, true)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else
                    {
                        if (User.add(new User(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, false, false, false)))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");

                        }
                    }
                }
                
                
                


                //Magasinier maga = new Magasinier(Txt_NomM.Text, Txt_PrenomM.Text, Txt_MDPM.Text, sex, DatePicker_NaissM.Value, list_NationM.Text, 1);
                //bool res = RefugierManage.ajouterRefugier(refu);
                //if (res)
                //{
                //    MessageBox.Show("Ajout validé et enregistré dans la BDD");
                //}
                //else
                //{
                //    MessageBox.Show("erreur creation refugier");
                //}

            }
            else
            {
                if (Txt_NomM.Text == "" || Txt_NomM.Text == "Nom")
                {
                    this.Txt_NomM.ForeColor = System.Drawing.Color.Red;
                    Txt_NomM.Text = "Nom Incorrect";
                }
                if (Txt_PrenomM.Text == "" || Txt_PrenomM.Text == "Prenom")
                {
                    this.Txt_PrenomM.ForeColor = System.Drawing.Color.Red;
                    Txt_PrenomM.Text = "Prenom Incorrect";
                }
                if (Txt_MDPM.Text == "" || Txt_MDPM.Text == "Mot de Passe")
                {
                    this.Txt_MDPM.ForeColor = System.Drawing.Color.Red;
                    Txt_MDPM.Text = "Mot de Passe Incorrect";
                }
                if (!check_AgentAccueil.Checked && !check_Magasinier.Checked)
                {
                    lbl_errRole.Visible = true;
                }
                else
                {
                    lbl_errRole.Visible = false;
                }
            }
        }
        #endregion
        
        
        #endregion

        #region tabPageModif/Suppr_Ref

        #region Txt_nom_modif_ref
        private void Txt_Nom_Modif_ref_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_Nom_Modif_ref.Text == "Nom" || Txt_Nom_Modif_ref.Text == "Nom Incorrect")
            {
                this.Txt_Nom_Modif_ref.ForeColor = System.Drawing.Color.Black;
                Txt_Nom_Modif_ref.Text = "";
            }
        }

        private void Txt_Nom_Modif_ref_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Nom_Modif_ref.Text == "")
            {
                this.Txt_Nom_Modif_ref.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Nom_Modif_ref.Text = "Nom";
            }
        }

        #endregion
        
        #region Txt-premon_modif_ref
        private void Txt_Prenom_Modif_ref_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_Prenom_Modif_ref.Text == "Prenom" || Txt_Prenom_Modif_ref.Text == "Prenom Incorrect")
            {
                this.Txt_Prenom_Modif_ref.ForeColor = System.Drawing.Color.Black;
                Txt_Prenom_Modif_ref.Text = "";
            }
        }

        private void Txt_Prenom_Modif_ref_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Prenom_Modif_ref.Text == "")
            {
                this.Txt_Prenom_Modif_ref.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_Prenom_Modif_ref.Text = "Prenom";
            }
        }
        #endregion
        
        #region DatePicker_Naiss_modif_ref
        private void DatePicker_Naiss_modif_ref_ValueChanged(object sender, EventArgs e)
        {
            if (DatePicker_Naiss_modif_ref.Value >= DateTime.Now)
            {
                DatePicker_Naiss_modif_ref.Value = DateTime.Now;
            }
        }
        #endregion


        #region Boutons Modifier et Supprimer refugié

        #region btn recherche
        private void btn_rechercher_modifref_Click(object sender, EventArgs e)
        {
            DataGrid_modif_ref.Rows.Clear();
            //appel recherche de josselin
            //pour l'instant c celle d'omer
            List<Refugier> refugiers = Refugier.select();
            
            foreach (var refugier in refugiers)
            {
                DataGrid_modif_ref.Rows.Add(refugier.Id, refugier.Nom, refugier.Prenom, refugier.Sexe, refugier.DateNais, refugier.Nationalite);
            }
            
        }
        #endregion

        #region btn_modifref
        private void btn_Modif_ref_Click(object sender, EventArgs e)
        {
            lbl_err_btn_modif_ref.Visible = false;
            if ((Txt_Nom_Modif_ref.Text != "Nom" && Txt_Nom_Modif_ref.Text != "Nom Incorrect" && Txt_Prenom_Modif_ref.Text != "Prenom" && Txt_Prenom_Modif_ref.Text != "Prenom Incorrect" && list_nation_modif_ref.Text != "" && (rdn_Homme_Modif_ref.Checked == true || rdn_Femme_Modif_ref.Checked == true)))
            {
                String sex;
                if (rdn_FemmeM.Checked == true)
                {
                    sex = "F";
                }
                else
                {
                    sex = "M";
                }
                if (DataGrid_modif_ref.SelectedRows.Count == 1)
                {

                    foreach (System.Windows.Forms.DataGridViewRow refugier in DataGrid_modif_ref.SelectedRows)
                    {
                        var result = MessageBox.Show("Voulez vous vraiment modifier l'utilisateur " + refugier.Cells[1].Value + " " + refugier.Cells[2].Value, " ", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            if ((Refugier.update(new Refugier(Txt_Nom_Modif_ref.Text, Txt_Prenom_Modif_ref.Text, sex, DatePicker_Naiss_modif_ref.Value, list_nation_modif_ref.Text, (int)num_refugeref_modif_ref.Value, 150, "", "", "", "", "", "", "", "", int.Parse(refugier.Cells[0].Value.ToString()))) == true))
                        {
                            MessageBox.Show("Modification Effectuée");
                            btn_rechercher_modifref_Click(sender, e);
                        }
                    }
                }
                else
                {
                    lbl_err_btn_modif_ref.Visible = true;
                }
               

            }
            else
            {
                if (Txt_Nom_Modif_ref.Text == "" || Txt_Nom_Modif_ref.Text == "Nom")
                {
                    this.Txt_Nom_Modif_ref.ForeColor = System.Drawing.Color.Red;
                    Txt_Nom_Modif_ref.Text = "Nom Incorrect";
                }
                if (Txt_Prenom_Modif_ref.Text == "" || Txt_Prenom_Modif_ref.Text == "Prenom")
                {
                    this.Txt_Prenom_Modif_ref.ForeColor = System.Drawing.Color.Red;
                    Txt_Prenom_Modif_ref.Text = "Prenom Incorrect";
                }
                if (list_nation_modif_ref.Text == "")
                {
                    lbl_err_nation_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_nation_modif_ref.Visible = false;
                }
                if (rdn_HommeM.Checked == false && rdn_FemmeM.Checked == false)
                {
                    lbl_err_sex_modif_ref.Visible = true;
                }
                else
                {
                    lbl_err_sex_modif_ref.Visible = false;
                }

            }
        }
        #endregion

        #region supp-ref
        private void btn_Suppr_ref_Click(object sender, EventArgs e)
        {

            foreach (System.Windows.Forms.DataGridViewRow refugier in DataGrid_modif_ref.SelectedRows)
            {
                var result = MessageBox.Show("Voulez vous vraiment supprimer l'utilisateur "+refugier.Cells[1].Value+ " "+refugier.Cells[2].Value," " , MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (Refugier.delete((int.Parse(refugier.Cells[0].Value.ToString()))) == true)
                    {
                        MessageBox.Show("Suppression Effectuée");
                        btn_rechercher_modifref_Click(sender,e);
                    }
                    
                }
               
            }

        } 
        #endregion

        #endregion

        #endregion

        #region tabpageModif/Suppr_Gerant

        #region Txt_nom_modif_gerant
        private void Txt_nom_modif_gerant_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_nom_modif_gerant.Text == "Nom" || Txt_nom_modif_gerant.Text == "Nom Incorrect")
            {
                this.Txt_nom_modif_gerant.ForeColor = System.Drawing.Color.Black;
                Txt_nom_modif_gerant.Text = "";
            }
        }

        private void Txt_nom_modif_gerant_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_nom_modif_gerant.Text == "")
            {
                this.Txt_nom_modif_gerant.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_nom_modif_gerant.Text = "Nom";
            }
        }
        #endregion

        #region  Txt_prenom_modif_gerant
        private void Txt_prenom_modif_gerant_KeyDown(object sender, KeyEventArgs e)
        {
            // si on appuie sur un numero ou un caractere special => on supprime l'evenement 
            if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue == 49 || e.KeyValue >= 51 && e.KeyValue <= 53 || e.KeyValue == 56 || e.KeyValue == 106 || e.KeyValue == 107 || e.KeyValue == 110 || e.KeyValue == 111)
            {
                e.SuppressKeyPress = true;
            }
            if (Txt_prenom_modif_gerant.Text == "Prenom" || Txt_prenom_modif_gerant.Text == "Prenom Incorrect")
            {
                this.Txt_prenom_modif_gerant.ForeColor = System.Drawing.Color.Black;
                Txt_prenom_modif_gerant.Text = "";
            }
        }

        private void Txt_prenom_modif_gerant_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_prenom_modif_gerant.Text == "")
            {
                this.Txt_prenom_modif_gerant.ForeColor = System.Drawing.SystemColors.WindowFrame;
                Txt_prenom_modif_gerant.Text = "Prenom";
            }
        }
        #endregion

        #region datePicker_Naiss_modif_gerant
        private void datePicker_Naiss_modif_gerant_ValueChanged(object sender, EventArgs e)
        {
            if (datePicker_Naiss_modif_gerant.Value >= DateTime.Now)
            {
                datePicker_Naiss_modif_gerant.Value = DateTime.Now;
            }
        }
        #endregion

        #region Boutons Modifier et Supprimer gerant
        private void btn_modif_gerant_Click(object sender, EventArgs e)
        {

        }

        private void btn_suppr_gerant_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion



        #region restrictions
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Check Credentials Here

            if ((connected_user.Roles.Adminnistrateur == null))
            {

                //save de la page selectionné avant les test
                TabPage selectPage = new TabPage();
                selectPage = tabControl1.SelectedTab;

                //test des droit d'accée de l'individu
                if ((connected_user.Roles.Agent == null) && ((tabControl1.SelectedTab == tabPageAjoutRef) || (tabControl1.SelectedTab == tabPageAjoutGérant) || (tabControl1.SelectedTab == tabPagemodifGerant) || (tabControl1.SelectedTab == tabPageModifRef)))
                {
                    tabControl1.SelectedTab = tabPageAccueil;
                    MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                }
                else
                {
                    tabControl1.SelectedTab = selectPage;
                }

                if ((connected_user.Roles.Magasinier == null) && (tabControl1.SelectedTab == tabPageStock))
                {
                    tabControl1.SelectedTab = tabPageAccueil;
                    MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                    
                }

            }




        } 
        #endregion
        
        private void label_nameU_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// modifie la datagridview au load de la tabpagemodifref
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageModifRef)
            {
                btn_rechercher_modifref_Click(sender,e);
            }
        }

        private void Txt_MDPM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
