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
    public partial class frmSupprimer : Form
    {
        public frmSupprimer()
        {
            InitializeComponent();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            new frmAcceuil().Show();
            this.Hide();
        
    }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            new frmAcceuil().Show();
            this.Hide();
        }

        private void frmSupprimer_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirm_supp_Click(object sender, EventArgs e)
        {
           
          
        }
            
            /* Récupérer l'ID de l'étudiant sélectionné dans la première colonne
           

            // Demander une confirmation de suppression à l'utilisateur
            DialogResult confirmationResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étudiant ?", "Confirmation de suppression", MessageBoxButtons.YesNo);
            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    // Supprimer l'étudiant de la base de données en utilisant son ID
                    string query = "DELETE FROM Étudiant WHERE IDETUDIANT = @EtudiantID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EtudiantID", étudiantID);

                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Exécuter la commande de suppression
                    command.ExecuteNonQuery();

                    // Fermer la connexion à la base de données
                    connection.Close();

                    // Supprimer la ligne correspondante dans le DataGridView
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    MessageBox.Show("L'étudiant a été supprimé avec succès !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression de l'étudiant : {ex.Message}");
                }
            }
            */


        
        }
    }



