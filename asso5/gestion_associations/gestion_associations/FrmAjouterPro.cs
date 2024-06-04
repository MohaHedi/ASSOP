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
    public partial class FrmAjouterPro : Form
    {
        public FrmAjouterPro()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {


            professionnel professionnel = new professionnel
            {
                SecteurActivite = txt_SecteurActivite.Text,
                DateEntreeMondePro = dtp_DateEntreMondePro.Value,
                Nom = txt_nom.Text,
                Prenom = txt_prenom.Text,
                Email = txt_email.Text,
                Num = int.Parse(txt_num.Text),
                DateDeNaissance = dateTimePicker_ddn.Value,
            };


            Program.crud.CreerProfessionnel(professionnel);

            // Effacer les champs de saisie
            txt_nom.Text = "";
            txt_prenom.Text = "";
            txt_email.Text = "";
            txt_num.Text = "";
            txt_SecteurActivite.Text = "";

        }



        private void btn_retour_Click(object sender, EventArgs e)
        {
            new frmProfessionnel().Show();
            this.Hide();
        }

        private void FrmAjouterPro_Load(object sender, EventArgs e)
        {

        }
    }
}
