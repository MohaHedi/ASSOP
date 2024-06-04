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


namespace gestion_associations
{
    partial class FrmModifierPro : Form
    {
        //  public professionnel ProfessionnelModifie { get; private set; }
        private professionnel professionnel;
        public FrmModifierPro(professionnel professionnel)
        {
            this.professionnel = professionnel;
            InitializeComponent();
            txt_id.Text = this.professionnel.IdIndividu.ToString();
            txt_nom.Text = this.professionnel.Nom.ToString();
            txt_prenom.Text = this.professionnel.Prenom.ToString();
            txt_email.Text = this.professionnel.Email.ToString();
            txt_num.Text = this.professionnel.Num.ToString();
            txt_SecteurActivite.Text = this.professionnel.SecteurActivite.ToString();
            dateTimePicker_ddn.Value = this.professionnel.DateDeNaissance;
            dtp_DateEntreMondePro.Value = this.professionnel.DateEntreeMondePro;
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmModifierPro_Load(object sender, EventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            professionnel Professionnel = new professionnel
            {
                IdIndividu = int.Parse(txt_id.Text),
                Nom = txt_nom.Text,
                Prenom = txt_prenom.Text,
                Email = txt_email.Text,
                Num = int.Parse(txt_num.Text),
                DateDeNaissance = dateTimePicker_ddn.Value,
                SecteurActivite = txt_SecteurActivite.Text,
                DateEntreeMondePro = dtp_DateEntreMondePro.Value,
            };

            Program.crud.MettreAJourProfessionnel(Professionnel);
            // Effacer les labels
            txt_nom.Text = "";
            txt_SecteurActivite.Text = "";


            // Afficher le formulaire principal et masquer le formulaire de modification
            frmProfessionnel frm = (frmProfessionnel)Application.OpenForms["frmProfessionnel"];
            frm.Show();
            this.Hide();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            new frmProfessionnel().Show();
            this.Hide();
        }
    }

}
