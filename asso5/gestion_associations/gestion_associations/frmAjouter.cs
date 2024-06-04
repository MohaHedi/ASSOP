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
using System.Data.SqlClient;



namespace gestion_associations
{
    public partial class frmAjouter : Form
    {

        public frmAjouter()
        {
            InitializeComponent();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            new frmAcceuil().Show();
            this.Hide();
        }

        private void frmAjouter_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant
            {
                LyceeOrigine = txt_lycee.Text,
                SpecialiteBac = txt_spe.Text,
                AnneeObtentionBac = dateTimePicker_anneebac.Value,
                DateEntreeBts = dateTimePicker_dateentrebts.Value,
                DateSortieBts = dateTimePicker_sortiebts.Value,
                PromoBts = dtp_promo.Value,
                SpecialiteBts = txt_spebts.Text,
                DateObtentionBts = dateTimePicker_obtbts.Value,
                Nom = txt_nom.Text,
                Prenom = txt_prenom.Text,
                Email = txt_email.Text,
                Num = int.Parse(txt_num.Text),
                DateDeNaissance = dateTimePicker_ddn.Value,
                Rang = txt_rang.Text,
            };

            Program.crud.CreerEtudiant(etudiant);

            // Effacer les champs de saisie
            txt_nom.Text = "";
            txt_prenom.Text = "";
            txt_email.Text = "";
            txt_num.Text = "";
            txt_lycee.Text = "";
            txt_spe.Text = "";
            txt_spebts.Text = "";
            txt_rang.Text = "";

            frmAcceuil frm = (frmAcceuil)Application.OpenForms["frmAcceuil"];
            frm.Show();
            this.Hide();


        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }



        private void cbx_rang_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbx_rang.Checked)
            {
                txt_rang.Visible = true;
                dateTimePicker_obtbts.Visible = true;
                lbl_rang.Visible = true;
                lbl_dateobt.Visible = true;
            }
            else
            {
                txt_rang.Visible = false;
                dateTimePicker_obtbts.Visible = false;
                lbl_rang.Visible = false;
                lbl_dateobt.Visible = false;
            }
        }
    }   
}