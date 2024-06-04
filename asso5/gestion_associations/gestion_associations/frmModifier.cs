using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_associations
{
    partial class frmModifier : Form
    {

        private Etudiant etudiant;
        public frmModifier(Etudiant etudiant)
        {
            this.etudiant = etudiant;
            InitializeComponent();
            txt_Id.Text = etudiant.IdIndividu.ToString();
            txt_email.Text = etudiant.Email;
            txt_lycee.Text = etudiant.LyceeOrigine;
            txt_nom.Text = etudiant.Nom;
            txt_prenom.Text = etudiant.Prenom;
            txt_spe.Text = etudiant.SpecialiteBac;
            txt_spebts.Text = etudiant.SpecialiteBts;
            txt_num.Text = etudiant.Num.ToString();
            dateTimePicker_anneebac.Value = etudiant.AnneeObtentionBac;
            dateTimePicker_dateentrebts.Value = etudiant.DateEntreeBts;
            dateTimePicker_ddn.Value = etudiant.DateDeNaissance;
            dateTimePicker_obtbts.Value = etudiant.DateObtentionBts;
            dateTimePicker_sortiebts.Value = etudiant.DateSortieBts;
            txt_rang.Text = etudiant.Rang;

        }

        public int IdEtudiant { get; set; }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            new frmAcceuil().Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmModifier_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant
            {
                IdIndividu = int.Parse(txt_Id.Text),
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



            Program.crud.MettreAJourEtudiant(etudiant);

            // Effacer les labels
            txt_nom.Text = "";
            txt_prenom.Text = "";
            txt_email.Text = "";
            txt_num.Text = "";
            txt_rang.Text = "";

            // Afficher le formulaire principal et masquer le formulaire de modification
            frmAcceuil frm = (frmAcceuil)Application.OpenForms["frmAcceuil"];
            frm.Show();
            this.Hide();
        
        }

        public void DefinirInformationsEtudiant(string nom, string prenom, string email, string num, string lyceeOrigine, string specialiteBac, DateTime anneeObtentionBac, DateTime dateEntreeBts, DateTime dateSortieBts, DateTime promoBts, string specialiteBts, DateTime dateObtentionBts, string rang)
        {
            txt_nom.Text = nom;
            txt_prenom.Text = prenom;
            txt_email.Text = email;
            txt_num.Text = num;
            txt_lycee.Text = lyceeOrigine;
            txt_spe.Text = specialiteBac;
            dateTimePicker_anneebac.Value = anneeObtentionBac;
            dateTimePicker_dateentrebts.Value = dateEntreeBts;
            dateTimePicker_sortiebts.Value = dateSortieBts;
            dtp_promo.Value = promoBts;
            txt_spebts.Text = specialiteBts;
            dateTimePicker_obtbts.Value = dateObtentionBts;
            txt_rang.Text = rang; 
        }

        private void txt_spe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_rang_CheckedChanged(object sender, EventArgs e)
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
