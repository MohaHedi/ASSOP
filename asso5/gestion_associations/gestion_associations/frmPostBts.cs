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
    public partial class frmPostBts : Form
    {
        private MySqlConnection connection;

        public frmPostBts()
        {
            InitializeComponent();
        }


        private void btn_etudiant_Click(object sender, EventArgs e)
        {
            new frmAcceuil().Show();
            this.Hide();
        }

        private void ico_btn_quitter_Click(object sender, EventArgs e)
        {
            new frmConnexion().Show();
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

        private void frmPostBts_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=mlr3";

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Sélectionner les données nécessaires de la table "formation_post_bts" et "individu"
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT f.IDFORMATION, f.LIBELLEFORMATION, f.NIVEAU, f.LIEU, i.Nom, i.Prenom FROM formation_post_bts f JOIN poursuivre p ON f.IDFORMATION = p.IDFORMATION JOIN etudiant e ON p.IDETUDIANT = e.Id JOIN individu i ON e.IdIndividu = i.IdIndividu;", connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Associer le DataTable au DataGridView
                dgv_postbts.DataSource = dataTable;
               
                // Sélectionner les noms et prénoms des étudiants de la table "individu"
                adapter = new MySqlDataAdapter("SELECT CONCAT(i.Nom, ' ', i.Prenom) AS NomPrenom FROM etudiant AS e JOIN individu AS i ON e.IdIndividu = i.IdIndividu", connection);

                DataTable comboTable = new DataTable();
                adapter.Fill(comboTable);

                // Ajouter les noms des étudiants à la ComboBox
                cb_etudiant.DisplayMember = "NomPrenom";
                cb_etudiant.DataSource = comboTable;

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
            PostBts postbts = new PostBts
            {
                LibelleInformation = txt_libelle.Text,
                Niveau = txt_niveau.Text,
                Lieu = txt_lieu.Text,
            };

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO formation_post_bts (LIBELLEFORMATION, NIVEAU, LIEU) VALUES (@LibelleFormation, @Niveau, @Lieu)";
                command.Parameters.AddWithValue("@LibelleFormation", postbts.LibelleInformation);
                command.Parameters.AddWithValue("@Niveau", postbts.Niveau);
                command.Parameters.AddWithValue("@Lieu", postbts.Lieu);
                command.ExecuteNonQuery();

                // Rafraîchir le DataGridView en ajoutant une nouvelle ligne avec les informations saisies
                DataTable dataTable = (DataTable)dgv_postbts.DataSource;
                DataRow newRow = dataTable.NewRow();
                newRow["IDFORMATION"] = command.LastInsertedId; // Utiliser l'ID généré automatiquement par la base de données
                newRow["LIBELLEFORMATION"] = postbts.LibelleInformation;
                newRow["NIVEAU"] = postbts.Niveau;
                newRow["LIEU"] = postbts.Lieu;
                newRow["Nom"] = cb_etudiant.Text.Split(' ')[0]; // Récupérer le nom à partir du texte de la ComboBox
                newRow["Prenom"] = cb_etudiant.Text.Split(' ')[1]; // Récupérer le prénom à partir du texte de la ComboBox
                dataTable.Rows.Add(newRow);

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout au PostBts : {ex.Message}");
            }

            // Réinitialiser les champs de saisie
            txt_libelle.Text = string.Empty;
            txt_niveau.Text = string.Empty;
            txt_lieu.Text = string.Empty;
        }

    }
}
