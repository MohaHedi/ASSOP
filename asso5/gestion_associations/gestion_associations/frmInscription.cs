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
using System.Text.RegularExpressions;


namespace gestion_associations
{
    public partial class frmInscription : Form
    {

        private MySqlConnection connection;
        private string connectionString = "server=localhost; user id=root; persistsecurityinfo=True; database=mlr3";



        public frmInscription()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void btn_switchConnexion_Click(object sender, EventArgs e)
        {
            new frmConnexion().Show();
            this.Hide();
        }

        private void cbx_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_admin.Checked)
            {
                lbl_admin.Visible = true;
                txt_code.Visible = true;
                btn_validercode.Visible = true;

                cbx_mbrebureau.Checked = false;
                cbx_membre.Checked = false;
            }
            else
            {
                lbl_admin.Visible = false;
                txt_code.Visible = false;
                btn_validercode.Visible = false;
                lbl_msg.Visible = false;
            }
        }

        private void cbx_mbrebureau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_mbrebureau.Checked)
            {
                lbl_admin.Visible = true;
                txt_code.Visible = true;
                btn_validercode.Visible = true;

                cbx_admin.Checked = false;
                cbx_membre.Checked = false;
            }
            else
            {
                lbl_admin.Visible = false;
                txt_code.Visible = false;
                btn_validercode.Visible = false;
                lbl_msg.Visible = false;
            }
        }

        private void cbx_membre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_membre.Checked)
            {
                lbl_admin.Visible = false;
                txt_code.Visible = false;
                btn_validercode.Visible = false;
                lbl_msg.Visible = false;

                cbx_admin.Checked = false;
                cbx_mbrebureau.Checked = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_validercode_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "azerty")
            {
                lbl_msg.Visible = true;

            }
            else
            {
                MessageBox.Show("Mauvais code !");
            }
        }

        private void frmInscription_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
        public string IdentifiantText
        {
            get { return txt_idt.Text; }
        }

        private void btn_inscrire_Click(object sender, EventArgs e)
        {
            string Identifiant = txt_idt.Text;
            string MotDePasse = txt_mdp.Text;
            string Permission = txt_code.Text;

            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).{12,}$";
            bool isPasswordValid = Regex.IsMatch(MotDePasse, pattern);

            if (!isPasswordValid)
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 12 caractères, une majuscule, une minuscule, un chiffre et un caractère spécial.");
                return;
            }

            if (lbl_msg.Visible == true)
            {
                string queryMembre = "INSERT INTO membre (Identifiant, MotDePasse, Permission) VALUES (@Identifiant, @MotDePasse, 'admin')";

                // Supposons que vous avez initialisé 'connection' ailleurs dans votre code
                using (MySqlCommand commandMembre = new MySqlCommand(queryMembre, connection))
                {
                    commandMembre.Parameters.AddWithValue("@Identifiant", Identifiant);
                    commandMembre.Parameters.AddWithValue("@MotDePasse", MotDePasse);


                    try
                    {
                        connection.Open();
                        int lignesModifiees = commandMembre.ExecuteNonQuery();

                        if (lignesModifiees > 0)
                        {
                            MessageBox.Show("Le compte a été créé avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la création du compte.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de la création d'un compte : {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                string queryMembre = "INSERT INTO membre (Identifiant, MotDePasse, Permission) VALUES (@Identifiant, @MotDePasse, '')";

                // Supposons que vous avez initialisé 'connection' ailleurs dans votre code
                using (MySqlCommand commandMembre = new MySqlCommand(queryMembre, connection))
                {
                    commandMembre.Parameters.AddWithValue("@Identifiant", Identifiant);
                    commandMembre.Parameters.AddWithValue("@MotDePasse", MotDePasse);

                    try
                    {
                        connection.Open();
                        int lignesModifiees = commandMembre.ExecuteNonQuery();

                        if (lignesModifiees > 0)
                        {
                            MessageBox.Show("Le compte a été créé avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la création du compte.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de la création d'un compte : {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
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

        private void txt_mdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}      
  
          
