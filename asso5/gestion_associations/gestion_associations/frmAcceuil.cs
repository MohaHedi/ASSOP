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
    public partial class frmAcceuil : Form
    {


        public frmAcceuil()
        {
            InitializeComponent();
         
        }


        public int IdEtudiant { get; set; }


        private MySqlConnection connection; //
        private void frmAcceuil_Load(object sender, EventArgs e)
        {
            string connectionString = "server = localhost; user id = root; persistsecurityinfo = True; database = mlr3";

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Sélectionner toutes les données de la table "ÉTUDIANT"
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT individu.*, etudiant.Id, etudiant.LyceeOrigine, etudiant.Baccalaureat, etudiant.SpecialiteBac, etudiant.AnneeObtentionBac, etudiant.DateEntreeBts, etudiant.DateSortieBts, etudiant.PromoBts, etudiant.SpecialiteBts, etudiant.DateObtentionBts, etudiant.role, etudiant.Rang FROM etudiant INNER JOIN individu ON etudiant.IdIndividu = individu.IdIndividu", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Associer le DataTable au DataGridView
                dgv_etudiant.DataSource = dataTable;

                // Fermer la connexion lorsque vous avez terminé d'utiliser la base de données
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }
        }

        private void ico_btn_quitter_Click(object sender, EventArgs e)
        {
            new frmConnexion().Show();
            this.Hide();
        }


        private void btn_ajouter_Click(object sender, EventArgs e)
        {
           new frmAjouter().Show();
           this.Hide();
                   
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (dgv_etudiant.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_etudiant.SelectedRows[0];
                // Récupérer les valeurs des colonnes pour construire un objet Etudiant
                int idIndividu = Convert.ToInt32(selectedRow.Cells["IdIndividu"].Value);
                string NomIndividu = selectedRow.Cells["Nom"].Value.ToString();
                string PrenomIndividu = selectedRow.Cells["Prenom"].Value.ToString();
                string EmailIndividu = selectedRow.Cells["Email"].Value.ToString();
                string NumIndividut = selectedRow.Cells["Num"].Value.ToString();
                string LyceeOrigineEtudiant = selectedRow.Cells["LyceeOrigine"].Value.ToString();
                string SpecialiteBacEtudiant = selectedRow.Cells["SpecialiteBac"].Value.ToString();
                DateTime AnneeObtentionBacEtudiant = Convert.ToDateTime(selectedRow.Cells["AnneeObtentionBac"].Value);
                DateTime DateEntreeBtsEtudiant = Convert.ToDateTime(selectedRow.Cells["DateEntreeBts"].Value);
                DateTime DateSortieBtsEtudiant = Convert.ToDateTime(selectedRow.Cells["DateSortieBts"].Value);
                DateTime PromoBtsEtudiant = Convert.ToDateTime(selectedRow.Cells["PromoBts"].Value);
                string SpecialiteBtsEtudiant = selectedRow.Cells["SpecialiteBts"].Value.ToString();
                DateTime DateObtentionBtsEtudiant = Convert.ToDateTime(selectedRow.Cells["DateObtentionBts"].Value);
                DateTime DateDeNaissanceEtudiant = Convert.ToDateTime(selectedRow.Cells["DateDeNaissance"].Value);
                string RangEtudiant = selectedRow.Cells["Rang"].Value.ToString();


                // Créer un nouvel objet Etudiant avec les valeurs récupérées
                Etudiant etudiant = new Etudiant
                {
                    IdIndividu = idIndividu,
                    LyceeOrigine = LyceeOrigineEtudiant,
                    SpecialiteBac = SpecialiteBacEtudiant,
                    AnneeObtentionBac = AnneeObtentionBacEtudiant,
                    DateEntreeBts = DateEntreeBtsEtudiant,
                    DateSortieBts = DateSortieBtsEtudiant,
                    PromoBts = PromoBtsEtudiant,
                    SpecialiteBts = SpecialiteBtsEtudiant,
                    DateObtentionBts = DateObtentionBtsEtudiant,
                    Nom = NomIndividu,
                    Prenom = PrenomIndividu,
                    Email = EmailIndividu,
                    Num = int.Parse(NumIndividut),
                    DateDeNaissance = DateDeNaissanceEtudiant,
                    Rang = RangEtudiant,
                };
                frmModifier modifierForm = new frmModifier(etudiant);
                modifierForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {


            if (dgv_etudiant.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_etudiant.SelectedRows[0];

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }
        public DataGridView DataGridView1
        {
            get { return dgv_etudiant; }
        }
        

        private void btn_raffraichir_Click(object sender, EventArgs e)
        {
            try
            {
                // Effacer les données existantes dans le DataGridView
                dgv_etudiant.DataSource = null;
                dgv_etudiant.Rows.Clear();
                dgv_etudiant.Columns.Clear();

                // Rétablir la connexion à la base de données
                string chaineConnexion = "server=localhost; user id=root; persistsecurityinfo=True; database=mlr3";
                using (MySqlConnection connexion = new MySqlConnection(chaineConnexion))
                {
                    connexion.Open();

                    // Sélectionner toutes les données de la table "ETUDIANT"
                    MySqlDataAdapter adaptateur = new MySqlDataAdapter("SELECT individu.*, etudiant.Id, etudiant.LyceeOrigine, etudiant.Baccalaureat, etudiant.SpecialiteBac, etudiant.AnneeObtentionBac, etudiant.DateEntreeBts, etudiant.DateSortieBts, etudiant.PromoBts, etudiant.SpecialiteBts, etudiant.DateObtentionBts, etudiant.role, etudiant.Rang FROM etudiant INNER JOIN individu ON etudiant.IdIndividu = individu.IdIndividu", connexion);
                    DataTable dataTable = new DataTable();
                    adaptateur.Fill(dataTable);

                    // Associer le DataTable au DataGridView
                    dgv_etudiant.DataSource = dataTable;

                    // Fermer la connexion à la base de données
                    connexion.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            new frmProfessionnel().Show();
            this.Hide();
        }



        private void iconButton3_Click(object sender, EventArgs e)
        {
            new frmBureau().Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            new frmPetitDejeuner().Show();
            this.Hide();
        }

        private void lbl_bvn_Click(object sender, EventArgs e)
        {

        }

        private void btn_postbts_Click(object sender, EventArgs e)
        {
            new frmPostBts().Show();
            this.Hide();
        }

        private void btn_jury_Click(object sender, EventArgs e)
        {
            new frmJury().Show();
            this.Hide();
        }

    }
}
