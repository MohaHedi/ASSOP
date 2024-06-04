using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace gestion_associations
{



    public partial class frmConnexion : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;



        MySqlConnection connexion = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo=True;database=mlr3");

 
        // Chaîne de connexion à la base de données


        public frmConnexion()
        {
            InitializeComponent();

        }
        private void btn_switchInscription_Click(object sender, EventArgs e)
        {
            frmInscription frm = new frmInscription();
            frm.Show();
            this.Hide();
        }

        private void btn_SeConnecter_Click(object sender, EventArgs e)
        {
          
            string Identifiant = txt_idt.Text;
            string MotDePasse = txt_mdp.Text;

            try
            {
                string connectionString = "server = localhost; user id = root; persistsecurityinfo = True; database = mlr3";
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Vérifiez les informations d'identification de l'utilisateur ici.
                // Vous pouvez utiliser une requête SELECT pour rechercher l'utilisateur dans votre table d'utilisateurs.

                string query = "SELECT * FROM membre WHERE Identifiant = @Identifiant AND MotDePasse = @MotDePasse";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identifiant", Identifiant);
                command.Parameters.AddWithValue("@MotDePasse", MotDePasse);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // L'utilisateur est authentifié, vous pouvez ouvrir la fenêtre principale de votre application ou effectuer d'autres opérations.
                    frmAcceuil formAcceuil = new frmAcceuil();
                    formAcceuil.Show();
                }
                else
                {

                    // Les informations d'identification sont incorrectes.
                    MessageBox.Show("Identifiant ou mot de passe incorrect !");
                }

                reader.Close();

                // Fermez la connexion lorsque vous avez terminé d'utiliser la base de données.
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
            }

        }

  
        private void frmConnexion_Load(object sender, EventArgs e)
        {
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool MotDePasseVisible = false;

        private void ico_btn_eyes_Click(object sender, EventArgs e)
        {
            if (MotDePasseVisible)
            {
                txt_mdp.PasswordChar = '*';
                MotDePasseVisible = false;
            }
            else
            {
                txt_mdp.PasswordChar = '\0';
                MotDePasseVisible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
