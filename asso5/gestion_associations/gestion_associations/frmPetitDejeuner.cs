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
    public partial class frmPetitDejeuner : Form
    {
        public frmPetitDejeuner()
        {
            InitializeComponent();
        }

        private void btn_ajouterDej_Click(object sender, EventArgs e)
        {
            PetitDejeuner petitdejeuner = new PetitDejeuner
            {
                DateDej = dtp_petitdejeuner.Value,
            };

            Program.crud.CreerPetitDejeuner(petitdejeuner);

            if (cb_pro.SelectedItem != null && dtp_petitdejeuner.Value != null)
            {
                string idProfessionnel = cb_pro.SelectedValue.ToString();
                DateTime dateDej = dtp_petitdejeuner.Value;

                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO petit_dej (DateDej) VALUES (@DateDej)";
                    command.Parameters.AddWithValue("@DateDej", dateDej);
                    command.ExecuteNonQuery();

                    // Rafraîchir le DataGridView
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT i.Nom, i.Prenom, p.IdDej, p.DateDej FROM individu AS i JOIN petit_dej AS p ON i.IdIndividu = p.IDDEJ WHERE i.IdIndividu IN (SELECT IdIndividu FROM professionnel);", connection);
                    adapter.Fill(dataTable);
                    dgv_petitdej.DataSource = dataTable;

                    // Rafraîchir la ComboBox
                    adapter = new MySqlDataAdapter("SELECT Id FROM professionnel", connection);
                    DataTable comboTable = new DataTable();
                    adapter.Fill(comboTable);
                    cb_pro.DisplayMember = "Id";
                    cb_pro.ValueMember = "Id";
                    cb_pro.DataSource = comboTable;

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de l'ajout au petit déjeuner : {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professionnel et une date.");
            }
        }


        private MySqlConnection connection;

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

        private void iconButton3_Click(object sender, EventArgs e)
        {
            new frmBureau().Show();
            this.Hide();
        }

        private void frmPetitDejeuner_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;userid=root;persistsecurityinfo=True;database=mlr3";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // Sélectionner toutes les données necessaires
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT i.Nom, i.Prenom, p.IdDej, p.DateDej FROM individu AS i JOIN petit_dej AS p ON i.IdIndividu = p.IDDEJ WHERE i.IdIndividu IN (SELECT IdIndividu FROM professionnel);", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Associer le DataTable au DataGridView
                dgv_petitdej.DataSource = dataTable;

                // Lier les noms et prénoms à la ComboBox
                adapter = new MySqlDataAdapter("SELECT Id FROM professionnel", connection);
                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);
                cb_pro.DisplayMember = "Id";
                cb_pro.ValueMember = "Id";
                cb_pro.DataSource = comboTable;
                cb_pro.DropDownStyle = ComboBoxStyle.DropDownList;

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

        private void cb_pro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dgv_petitdej.SelectedRows.Count > 0)
            {
                // Récupérer l'identifiant de la ligne sélectionnée
                int idDej = Convert.ToInt32(dgv_petitdej.SelectedRows[0].Cells["IdDej"].Value);

                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM petit_dej WHERE IdDej = @IdDej";
                    command.Parameters.AddWithValue("@IdDej", idDej);
                    command.ExecuteNonQuery();

                    // Rafraîchir le DataGridView
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT i.Nom, i.Prenom, p.IdDej, p.DateDej FROM individu AS i JOIN petit_dej AS p ON i.IdIndividu = p.IDDEJ WHERE i.IdIndividu IN (SELECT IdIndividu FROM professionnel);", connection);
                    adapter.Fill(dataTable);
                    dgv_petitdej.DataSource = dataTable;

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
        }

        private void btn_supprimer_Click_1(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dgv_petitdej.SelectedRows.Count > 0)
            {
                // Récupérer l'identifiant de la ligne sélectionnée
                int idDej = Convert.ToInt32(dgv_petitdej.SelectedRows[0].Cells["IdDej"].Value);

                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM petit_dej WHERE IdDej = @IdDej";
                    command.Parameters.AddWithValue("@IdDej", idDej);
                    command.ExecuteNonQuery();

                    // Rafraîchir le DataGridView
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT i.Nom, i.Prenom, p.IdDej, p.DateDej FROM individu AS i JOIN petit_dej AS p ON i.IdIndividu = p.IDDEJ WHERE i.IdIndividu IN (SELECT IdIndividu FROM professionnel);", connection);
                    adapter.Fill(dataTable);
                    dgv_petitdej.DataSource = dataTable;

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
        }
    }
}
