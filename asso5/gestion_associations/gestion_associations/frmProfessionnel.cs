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
    public partial class frmProfessionnel : Form
    {
        public frmProfessionnel()
        {
            InitializeComponent();
        }
        private MySqlConnection connection;

        private void frmProfessionnel_Load(object sender, EventArgs e)
        {
            string connectionString = "server = localhost; user id = root; persistsecurityinfo = True; database = mlr3";

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Sélectionner toutes les données de la table "Professionnel"
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT individu.*, professionnel.Id, professionnel.SecteurActivite, professionnel.DateEntreeMondePro  FROM professionnel INNER JOIN individu ON professionnel.IdIndividu = individu.IdIndividu", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Associer le DataTable au DataGridView
                dgv_pro.DataSource = dataTable;

                // Fermer la connexion lorsque vous avez terminé d'utiliser la base de données
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }
        }

       

        private void btn_raffraichir_Click(object sender, EventArgs e)
        {

            try
            {
                // Effacer les données existantes dans le DataGridView
                dgv_pro.DataSource = null;
                dgv_pro.Rows.Clear();
                dgv_pro.Columns.Clear();

                // Rétablir la connexion à la base de données
                string chaineConnexion = "server=localhost; user id=root; persistsecurityinfo=True; database=mlr3";
                using (MySqlConnection connexion = new MySqlConnection(chaineConnexion))
                {
                    connexion.Open();

                    // Sélectionner toutes les données de la table "ETUDIANT"
                    MySqlDataAdapter adaptateur = new MySqlDataAdapter("SELECT individu.*, professionnel.Id, professionnel.SecteurActivite, professionnel.DateEntreeMondePro  FROM professionnel INNER JOIN individu ON professionnel.IdIndividu = individu.IdIndividu", connexion);
                    DataTable dataTable = new DataTable();
                    adaptateur.Fill(dataTable);

                    // Associer le DataTable au DataGridView
                    dgv_pro.DataSource = dataTable;

                    // Fermer la connexion à la base de données
                    connexion.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }
        }

        private void ico_btn_quitter_Click_1(object sender, EventArgs e)
        {
            new frmConnexion().Show();
            this.Hide();
        }

        //private void btn_modifier_Click(object sender, EventArgs e)
        //{
        //    professionnel professionnel = new professionnel
        //    {
        //        IdIndividu = int.Parse(txt_IdIndividu.Text),
        //        SecteurActivite = txt_SecteurActivite.Text,
        //        DateEntreMondePro = dtp_DateEntreMondePro.Value,

        //    };

        //    Program.crud.MettreAJourProfessionnel(professionnel);

        //    // Effacer les champs de saisie
        //    txt_IdIndividu.Text = "";
        //    txt_SecteurActivite.Text = "";

        //    // Afficher le formulaire principal et masquer le formulaire de modification
        //    frmAcceuil frm = (frmAcceuil)Application.OpenForms["frmAcceuil"];
        //    frm.Show();
        //    this.Hide();
        //}



        private void btn_modifier_Click(object sender, EventArgs e)
        {
            //if (dgv_pro.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dgv_pro.SelectedRows[0];

            //    // Récupérer les valeurs du professionnel sélectionné depuis le DataGridView
            //    int idIndividu = Convert.ToInt32(selectedRow.Cells["IdIndividu"].Value);
            //    string secteurActivite = selectedRow.Cells["SecteurActivite"].Value.ToString();
            //    DateTime dateEntreMondePro = DateTime.Parse(selectedRow.Cells["DateEntreMondePro"].Value.ToString());
            //    // ... récupérer les autres valeurs des colonnes nécessaires

            //    // Transmettre les informations du professionnel au formulaire "Modifier"
            //    FrmModifierPro modifierForm = new FrmModifierPro();
            //    modifierForm.DefinirInformationsProfessionnel(idIndividu, secteurActivite, dateEntreMondePro);
            //    modifierForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Veuillez sélectionner un professionnel à modifier.");
            //}

            if (dgv_pro.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_pro.SelectedRows[0];

                professionnel pro = new professionnel
                {
                    IdIndividu = Convert.ToInt32(selectedRow.Cells["IdIndividu"].Value),
                    Nom = selectedRow.Cells["Nom"].Value.ToString(),
                    Prenom = selectedRow.Cells["Prenom"].Value.ToString(),
                    Email = selectedRow.Cells["Email"].Value.ToString(),
                    Num = (int)selectedRow.Cells["Num"].Value,
                    DateDeNaissance = (DateTime)selectedRow.Cells["DateDeNaissance"].Value,
                    SecteurActivite = selectedRow.Cells["SecteurActivite"].Value.ToString(),
                    DateEntreeMondePro = (DateTime)selectedRow.Cells["DateEntreeMondePro"].Value,
                };


                // Créer une instance du formulaire frmModifier
                FrmModifierPro modifierForm = new FrmModifierPro(pro);

                // Afficher le formulaire frmModifier
                modifierForm.ShowDialog();

                // Mettre à jour le DataGridView
                // ...
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }
        }

        private void ModifierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*FrmModifierPro modifierForm = (FrmModifierPro)sender;
            if (modifierForm.ProfessionnelModifie != null)
            {
                // Obtenir les informations modifiées du professionnel
                professionnel professionnelModifie = modifierForm.ProfessionnelModifie;

                // Mettre à jour la ligne correspondante dans le DataGridView
                DataGridViewRow selectedRow = dgv_pro.SelectedRows[0];
                selectedRow.Cells["Id"].Value = professionnelModifie.IdProfessionnel;
                selectedRow.Cells["Secteur"].Value = professionnelModifie.SecteurActivite;
                // Mettre à jour les autres cellules si nécessaire

                // Afficher le formulaire et masquer le formulaire de modification
                this.Show();
                modifierForm.Hide();
            }*/
        }

        private void dgv_pro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dgv_pro.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_pro.SelectedRows[0];

                // Récupérer les valeurs des colonnes pour construire un objet Etudiant
                string Id = Convert.ToString(selectedRow.Cells["Id"].Value);
                string IdIndividu = Convert.ToString(selectedRow.Cells["IdIndividu"].Value);




                // Créer un nouvel objet Etudiant avec les valeurs récupérées
                Etudiant etudiant = new Etudiant
                {


                    Id = int.Parse(Id),
                    IdIndividu = int.Parse(IdIndividu),


                };


                // Appeler la méthode SupprimerEtudiant en passant l'objet Etudiant
                Program.crud.SupprimerEtudiant(etudiant);
            }

            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.");
            }

        }

        private void btn_jury_Click(object sender, EventArgs e)
        {
            new frmJury().Show();
            this.Hide();
        }

        private void btn_postbts_Click(object sender, EventArgs e)
        {
            new frmPostBts().Show();
            this.Hide();
        }

        private void btn_bureau_Click(object sender, EventArgs e)
        {
            new frmBureau().Show();
            this.Hide();
        }

        private void btn_petitidej_Click(object sender, EventArgs e)
        {
            new frmPetitDejeuner().Show();
            this.Hide();
        }

        private void btn_etudiant_Click(object sender, EventArgs e)
        {
            new frmAcceuil().Show();
            this.Hide();
        }

        private void ico_btn_quitter_Click(object sender, EventArgs e)
        {

        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            new FrmAjouterPro().Show();
            this.Hide();
        }

    }

}
 

