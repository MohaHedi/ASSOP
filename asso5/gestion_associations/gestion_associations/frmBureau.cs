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

    public partial class frmBureau : Form
    {

        public frmBureau()
        {
            InitializeComponent();

        }
        private MySqlConnection connection;



        private void frmBureau_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=mlr3";

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Définir la valeur de la promotion à utiliser pour filtrer les résultats


                // Sélectionner toutes les données de la table "ÉTUDIANT" triées par la colonne "Promotion" en ordre croissant
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT etudiant.id, individu.Nom, individu.Prenom, etudiant.PromoBts, etudiant.role FROM etudiant INNER JOIN individu ON etudiant.IdIndividu = individu.IdIndividu", connection);
  

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Associer le DataTable au DataGridView
                dgv_bureau.DataSource = dataTable;

                // Fermer la connexion lorsque vous avez terminé d'utiliser la base de données
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }
        }

   



        private void btn_secretaire_Click(object sender, EventArgs e)
        {
            if (dgv_bureau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_bureau.SelectedRows[0];
                int etudiantId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Vérifier s'il existe déjà un étudiant avec le rôle de secrétaire
                string selectQuery = "SELECT COUNT(*) FROM etudiant WHERE role = 'Secrétaire'";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);

                connection.Open();
                int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                connection.Close();

                if (count > 0)
                {
                    MessageBox.Show("Il existe déjà un étudiant avec le rôle de secrétaire.");
                }
                else
                {
                    // Mettre à jour la base de données avec le nouveau rôle
                    string updateQuery = "UPDATE etudiant SET role = 'Secrétaire' WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Id", etudiantId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }
        }



        private void btn_tresorier_Click(object sender, EventArgs e)
        {
            if (dgv_bureau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_bureau.SelectedRows[0];

                int etudiantId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Vérifier s'il existe déjà un étudiant avec le rôle de trésorier
                string selectQuery = "SELECT COUNT(*) FROM etudiant WHERE role = 'Trésorier'";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);

                connection.Open();
                int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                connection.Close();

                if (count > 0)
                {
                    MessageBox.Show("Il existe déjà un étudiant avec le rôle de trésorier.");
                }
                else
                {
                    // Mettre à jour la base de données avec le nouveau rôle
                    string updateQuery = "UPDATE etudiant SET role = 'Trésorier' WHERE Id = @Id";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Id", etudiantId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }
        }

        private void btn_supprimerBureau_Click(object sender, EventArgs e)
        {
            if (dgv_bureau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_bureau.SelectedRows[0];
                int etudiantId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Supprimer le rôle de l'étudiant en le mettant à vide
                string updateQuery = "UPDATE etudiant SET role = '' WHERE ID = @Id";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Id", etudiantId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                // Mettre à jour l'affichage dans le DataGridView en mettant à jour la valeur de la colonne "role" pour la ligne sélectionnée
                selectedRow.Cells["role"].Value = string.Empty;

                MessageBox.Show("Le rôle de l'étudiant a été supprimé avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.");
            }
        }

        private void btn_president_Click(object sender, EventArgs e)
        {
            if (dgv_bureau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_bureau.SelectedRows[0];
                int etudiantId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Vérifier s'il existe déjà un étudiant avec le rôle de président
                string selectQuery = "SELECT COUNT(*) FROM etudiant WHERE role = 'Président'";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);

                connection.Open();
                int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                connection.Close();

                if (count > 0)
                {
                    MessageBox.Show("Il existe déjà un étudiant avec le rôle de président.");
                }
                else
                {
                    // Mettre à jour la base de données avec le nouveau rôle
                    string updateQuery = "UPDATE etudiant SET role = 'Président' WHERE ID = @Id";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Id", etudiantId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }
        }

        private void btn_raffraichir_Click(object sender, EventArgs e)
        {
            try
            {
                // Effacer les données existantes dans le DataGridView
                dgv_bureau.DataSource = null;
                dgv_bureau.Rows.Clear();
                dgv_bureau.Columns.Clear();

                // Rétablir la connexion à la base de données
                string chaineConnexion = "server=localhost; user id=root; persistsecurityinfo=True; database=mlr3";
                using (MySqlConnection connexion = new MySqlConnection(chaineConnexion))
                {
                    connexion.Open();

                    // Sélectionner toutes les données de la table "ETUDIANT"
                    MySqlDataAdapter adaptateur = new MySqlDataAdapter("SELECT etudiant.id, individu.Nom, individu.Prenom, etudiant.PromoBts, etudiant.role FROM etudiant INNER JOIN individu ON etudiant.IdIndividu = individu.IdIndividu", connexion);
                    DataTable dataTable = new DataTable();
                    adaptateur.Fill(dataTable);

                    // Associer le DataTable au DataGridView
                    dgv_bureau.DataSource = dataTable;

                    // Fermer la connexion à la base de données
                    connexion.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=mlr3";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Récupérer l'année sélectionnée dans le DateTimePicker
                    int selectedYear = dtp_promotion.Value.Year;

                    // Sélectionner les données de la table "étudiant" avec le filtre sur la promotion
                    string query = "SELECT individu.Nom, individu.Prenom, etudiant.PromoBts, etudiant.role FROM etudiant INNER JOIN individu ON etudiant.IdIndividu = individu.IdIndividu WHERE YEAR(etudiant.PromoBts) = @PromoBts";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PromoBts", selectedYear);

                    // Exécuter la requête et obtenir les résultats dans un DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Associer le DataTable au DataGridView
                    dgv_bureau.DataSource = dataTable;

                    // Fermer la connexion lorsque vous avez terminé d'utiliser la base de données
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }
        }

        private void btn_professionel_Click(object sender, EventArgs e)
        {
            new frmProfessionnel().Show();
            this.Hide();
        }

        private void btn_etudiant_Click(object sender, EventArgs e)
        {
            new frmAcceuil().Show();
            this.Hide();
        }

        private void btn_petitdej_Click(object sender, EventArgs e)
        {
            new frmPetitDejeuner().Show();
            this.Hide();
        }

        private void ico_btn_quitter_Click(object sender, EventArgs e)
        {
            new frmConnexion().Show();
            this.Hide();
        }

        private void btn_jury2_Click(object sender, EventArgs e)
        {
            new frmJury().Show();
            this.Hide();
        }

        private void dgv_bureau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_postbts2_Click(object sender, EventArgs e)
        {
            new frmPostBts().Show();
            this.Hide();
        }
    }
}

