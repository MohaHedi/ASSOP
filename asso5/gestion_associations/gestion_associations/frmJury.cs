using MySql.Data.MySqlClient;
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
    public partial class frmJury : Form
    {
        private MySqlConnection connection;

        public frmJury()
        {
            InitializeComponent();
        }

        private void btn_etudiant_Click(object sender, EventArgs e)
        {
            new frmAcceuil().Show();
            this.Hide();
        }

        private void btn_professionnel_Click(object sender, EventArgs e)
        {
            new frmProfessionnel().Show();
            this.Hide();
        }

        private void btn_petitdej_Click(object sender, EventArgs e)
        {
            new frmPetitDejeuner().Show();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            new frmBureau().Show();
            this.Hide();
        }

        private void btn_postbts2_Click(object sender, EventArgs e)
        {
            new frmPostBts().Show();
            this.Hide();
        }

        private void btn_jury2_Click(object sender, EventArgs e)
        {
            new frmJury().Show();
            this.Hide();
        }

        private void ico_btn_quitter_Click(object sender, EventArgs e)
        {
            new frmConnexion().Show();
            this.Hide();
        }

        private void frmJury_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=mlr3";

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Sélectionner les données nécessaires de la table "formation_post_bts" et "individu"
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT i.Nom, i.Prenom, j.IDJURY, j.DATEJURY FROM individu AS i JOIN jury AS j ON i.IdIndividu = j.IDPROFESSIONEL WHERE i.IdIndividu IN(SELECT IdIndividu FROM professionnel); ", connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Associer le DataTable au DataGridView
                dgv_jury.DataSource = dataTable;

                // Sélectionner les noms et prénoms des étudiants de la table "individu"
                adapter = new MySqlDataAdapter("SELECT CONCAT(Nom, ' ', Prenom) AS NomPrenom FROM individu WHERE IdIndividu IN (SELECT IdIndividu FROM professionnel)", connection);

                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);

                // Ajouter les noms des étudiants à la ComboBox
                cb_professionnel.DisplayMember = "NomPrenom";
                cb_professionnel.DataSource = comboTable;

                // Fermer la connexion lorsque vous avez terminé d'utiliser la base de données
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Jury jury = new Jury
            {
                DateJury = dtp_jury.Value,
            };

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO jury (DateJury) VALUES (@DateJury)";
                command.Parameters.AddWithValue("@DateJury", jury.DateJury);
                command.ExecuteNonQuery();

                // Réexécuter la requête pour récupérer les nouvelles données
                DataTable dataTable = (DataTable)dgv_jury.DataSource;

                // Effacer toutes les lignes existantes
                dataTable.Rows.Clear();

                // Adapter le code ci-dessous pour sélectionner les colonnes appropriées de la table "individu" et "jury"
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT i.Nom, i.Prenom, j.IDJURY, j.DATEJURY FROM individu AS i JOIN jury AS j ON i.IdIndividu = j.IDPROFESSIONEL WHERE i.IdIndividu IN (SELECT IdIndividu FROM professionnel)", connection);
                adapter.Fill(dataTable);

                // Réassocier la DataTable à la source de données du DataGridView
                dgv_jury.DataSource = null;
                dgv_jury.DataSource = dataTable;

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout au jury : {ex.Message}");
            }
        }
    }
}
