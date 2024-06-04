using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace gestion_associations
{
    class CRUD
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost; user id=root; persistsecurityinfo=True; database=mlr3";

        public CRUD()
        {
            connection = new MySqlConnection(connectionString);
        }


        //////////////////////////////////////////////////////////////////// DEBUT ETUDIANT ////////////////////////////////////////////////////////////////////

        // CREATION D'UN ETUDIANT (CREATE)
        public void CreerEtudiant(Etudiant etudiant)
        {
            string queryIndividu = "INSERT INTO individu (Nom, Prenom, Email, Num, DateDeNaissance) VALUES (@Nom, @Prenom, @Email, @num, @datedenaissance)";
            string queryEtudiant = "INSERT INTO etudiant (IdIndividu, LyceeOrigine, SpecialiteBac, AnneeObtentionBac, DateEntreeBts, DateSortieBts, PromoBts, SpecialiteBts, DateObtentionBts, Rang) VALUES (@IdIndividu, @LyceeOrigine, @SpecialiteBac, @AnneeObtentionBac, @DateEntreeBts, @DateSortieBts, @PromoBts, @SpecialiteBts, @DateObtentionBts, @Rang)";

            using (MySqlCommand commandIndividu = new MySqlCommand(queryIndividu, connection))
            using (MySqlCommand commandEtudiant = new MySqlCommand(queryEtudiant, connection))
            {
                commandIndividu.Parameters.AddWithValue("@Nom", etudiant.Nom);
                commandIndividu.Parameters.AddWithValue("@Prenom", etudiant.Prenom);
                commandIndividu.Parameters.AddWithValue("@Email", etudiant.Email);
                commandIndividu.Parameters.AddWithValue("@num", etudiant.Num);
                commandIndividu.Parameters.AddWithValue("@datedenaissance", etudiant.DateDeNaissance);
                int lastInsertedId = -1;
                try
                {
                    connection.Open();
                    commandIndividu.ExecuteNonQuery();
                    string idQuery = "SELECT LAST_INSERT_ID();";
                    MySqlCommand idCommand = new MySqlCommand(idQuery, connection);
                    lastInsertedId = Convert.ToInt32(idCommand.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la création de l'individu : {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

                if (lastInsertedId >= 0)
                {
                    commandEtudiant.Parameters.AddWithValue("@IdIndividu", lastInsertedId);
                    commandEtudiant.Parameters.AddWithValue("@LyceeOrigine", etudiant.LyceeOrigine);
                    commandEtudiant.Parameters.AddWithValue("@SpecialiteBac", etudiant.SpecialiteBac);
                    commandEtudiant.Parameters.AddWithValue("@AnneeObtentionBac", etudiant.AnneeObtentionBac);
                    commandEtudiant.Parameters.AddWithValue("@DateEntreeBts", etudiant.DateEntreeBts);
                    commandEtudiant.Parameters.AddWithValue("@DateSortieBts", etudiant.DateSortieBts);
                    commandEtudiant.Parameters.AddWithValue("@PromoBts", etudiant.PromoBts);
                    commandEtudiant.Parameters.AddWithValue("@SpecialiteBts", etudiant.SpecialiteBts);
                    commandEtudiant.Parameters.AddWithValue("@DateObtentionBts", etudiant.DateObtentionBts);
                    commandEtudiant.Parameters.AddWithValue("@Rang", etudiant.Rang);

                    try
                    {
                        connection.Open();
                        commandEtudiant.ExecuteNonQuery();
                        MessageBox.Show("L'étudiant a été créé avec succès.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de la création de l'étudiant : {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        // MIS A JOUR D'UN ETUDIANT (UPDATE)
        public void MettreAJourEtudiant(Etudiant etudiant)
        {
            string queryIndividu = "UPDATE individu SET Nom = @Nom, Prenom = @Prenom, Email = @Email, Num = @num, DateDeNaissance = @datedenaissance WHERE IdIndividu = @IdIndividu";
            string queryEtudiant = "UPDATE etudiant SET LyceeOrigine = @LyceeOrigine, SpecialiteBac = @SpecialiteBac, AnneeObtentionBac = @AnneeObtentionBac, DateEntreeBts = @DateEntreeBts, DateSortieBts = @DateSortieBts, PromoBts = @PromoBts, SpecialiteBts = @SpecialiteBts, DateObtentionBts = @DateObtentionBts, Rang = @Rang WHERE IdIndividu = @IdIndividu";

            using (MySqlCommand commandIndividu = new MySqlCommand(queryIndividu, connection))
            using (MySqlCommand commandEtudiant = new MySqlCommand(queryEtudiant, connection))
            {
                commandIndividu.Parameters.AddWithValue("@IdIndividu", etudiant.IdIndividu);
                commandIndividu.Parameters.AddWithValue("@Nom", etudiant.Nom);
                commandIndividu.Parameters.AddWithValue("@Prenom", etudiant.Prenom);
                commandIndividu.Parameters.AddWithValue("@Email", etudiant.Email);
                commandIndividu.Parameters.AddWithValue("@num", etudiant.Num);
                commandIndividu.Parameters.AddWithValue("@datedenaissance", etudiant.DateDeNaissance);

                commandEtudiant.Parameters.AddWithValue("@IdIndividu", etudiant.IdIndividu);
                commandEtudiant.Parameters.AddWithValue("@LyceeOrigine", etudiant.LyceeOrigine);
                commandEtudiant.Parameters.AddWithValue("@SpecialiteBac", etudiant.SpecialiteBac);
                commandEtudiant.Parameters.AddWithValue("@AnneeObtentionBac", etudiant.AnneeObtentionBac);
                commandEtudiant.Parameters.AddWithValue("@DateEntreeBts", etudiant.DateEntreeBts);
                commandEtudiant.Parameters.AddWithValue("@DateSortieBts", etudiant.DateSortieBts);
                commandEtudiant.Parameters.AddWithValue("@PromoBts", etudiant.PromoBts);
                commandEtudiant.Parameters.AddWithValue("@SpecialiteBts", etudiant.SpecialiteBts);
                commandEtudiant.Parameters.AddWithValue("@DateObtentionBts", etudiant.DateObtentionBts);
                commandEtudiant.Parameters.AddWithValue("@Rang", etudiant.Rang);
                connection.Open();
                commandIndividu.ExecuteNonQuery();
                commandEtudiant.ExecuteNonQuery();
                try
                {

                    MessageBox.Show("Les informations de l'étudiant ont été mises à jour avec succès.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour de l'étudiant : {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        // SUPPRESSION D'UN ETUDIANT
        public void SupprimerEtudiant(Etudiant etudiant)
        {

            string queryEtudiant = "DELETE FROM etudiant WHERE Id = @Id";
            string queryIndividu = "DELETE FROM individu WHERE IdIndividu = @IdIndividu";

            using (MySqlCommand commandEtudiant = new MySqlCommand(queryEtudiant, connection))
            using (MySqlCommand commandIndividu = new MySqlCommand(queryIndividu, connection))
            {
                commandEtudiant.Parameters.AddWithValue("@Id", etudiant.Id);
                commandIndividu.Parameters.AddWithValue("@IdIndividu", etudiant.IdIndividu);

                try
                {
                    connection.Open();
                    commandEtudiant.ExecuteNonQuery();
                    commandIndividu.ExecuteNonQuery();
                    MessageBox.Show("L'étudiant a été supprimé avec succès.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression de l'étudiant : {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //////////////////////////////////////////////////////////////////// FIN ETUDIANT ////////////////////////////////////////////////////////////////////








        //////////////////////////////////////////////////////////////////// DEBUT PROFESSIONNEL ////////////////////////////////////////////////////////////////////






        // AJOUT D'UN PROFESSIONNEL
        public void CreerProfessionnel(professionnel professionnel)
        {

            string queryIndividu = "INSERT INTO individu (Nom, Prenom, Email, Num, DateDeNaissance) VALUES (@Nom, @Prenom, @Email, @num, @datedenaissance)";
            string queryProfessionnel = "INSERT INTO professionnel (IdIndividu, SecteurActivite, DateEntreeMondePro) VALUES (@IdIndividu, @SecteurActivite, @DateEntreeMondePro)";

            using (MySqlCommand commandIndividu = new MySqlCommand(queryIndividu, connection))
            using (MySqlCommand commandProfesssionnel = new MySqlCommand(queryProfessionnel, connection))
            {
                commandIndividu.Parameters.AddWithValue("@Nom", professionnel.Nom);
                commandIndividu.Parameters.AddWithValue("@Prenom", professionnel.Prenom);
                commandIndividu.Parameters.AddWithValue("@Email", professionnel.Email);
                commandIndividu.Parameters.AddWithValue("@num", professionnel.Num);
                commandIndividu.Parameters.AddWithValue("@datedenaissance", professionnel.DateDeNaissance);
                int lastInsertedId = -1;
                try
                {
                    connection.Open();
                    commandIndividu.ExecuteNonQuery();
                    string idQuery = "SELECT LAST_INSERT_ID();";
                    MySqlCommand idCommand = new MySqlCommand(idQuery, connection);
                    lastInsertedId = Convert.ToInt32(idCommand.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la création de l'individu : {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

                if (lastInsertedId >= 0)
                {
                    commandProfesssionnel.Parameters.AddWithValue("@IdIndividu", lastInsertedId);
                    commandProfesssionnel.Parameters.AddWithValue("@SecteurActivite", professionnel.SecteurActivite);
                    commandProfesssionnel.Parameters.AddWithValue("@DateEntreeMondePro", professionnel.DateEntreeMondePro);

                    try
                    {
                        connection.Open();
                        commandProfesssionnel.ExecuteNonQuery();
                        MessageBox.Show("Le professionnel a été créé avec succès.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de la création du professionnel : {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }





        // MISE A JOUR D'UN PROFESSIONNEL
        public void MettreAJourProfessionnel(professionnel professionnel)
        {
            string queryIndividu = "UPDATE individu SET Nom = @Nom, Prenom = @Prenom, Num = @Num, Email = @Email, DateDeNaissance = @DateDeNaissance WHERE IdIndividu = @IdIndividu";
            string query = "UPDATE professionnel SET SecteurActivite = @SecteurActivite, DateEntreeMondePro = @DateEntreeMondePro WHERE IdIndividu = @IdIndividu";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlCommand commandInidividu = new MySqlCommand(queryIndividu, connection))
            {
                commandInidividu.Parameters.AddWithValue("@IdIndividu", professionnel.IdIndividu);
                commandInidividu.Parameters.AddWithValue("@Nom", professionnel.Nom);
                commandInidividu.Parameters.AddWithValue("@Prenom", professionnel.Prenom);
                commandInidividu.Parameters.AddWithValue("@Num", professionnel.Num);
                commandInidividu.Parameters.AddWithValue("@Email", professionnel.Email);
                commandInidividu.Parameters.AddWithValue("@DateDeNaissance", professionnel.DateDeNaissance);
                command.Parameters.AddWithValue("@IdIndividu", professionnel.IdIndividu);
                command.Parameters.AddWithValue("@SecteurActivite", professionnel.SecteurActivite);
                command.Parameters.AddWithValue("@DateEntreeMondePro", professionnel.DateEntreeMondePro);
                try
                {
                    connection.Open();
                    commandInidividu.ExecuteNonQuery();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Les informations du professionnel ont été mises à jour avec succès.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour du professionnel : {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        // SUPPRESSION D'UN PROFESSIONNEL
        public void SupprimerProfessionnel(professionnel professionnel)
        {
            string queryProfessionnel = "DELETE FROM professionnel WHERE IdIndividu = @IdIndividu";
            string queryIndividu = "DELETE FROM individu WHERE IdIndividu = @IdIndividu";

            using (MySqlCommand commandProfessionnel = new MySqlCommand(queryProfessionnel, connection))
            using (MySqlCommand commandIndividu = new MySqlCommand(queryIndividu, connection))
            {
                commandProfessionnel.Parameters.AddWithValue("@Id", professionnel.IdProfessionnel);
                commandIndividu.Parameters.AddWithValue("@IdIndividu", professionnel.IdIndividu);

                try
                {
                    connection.Open();
                    commandProfessionnel.ExecuteNonQuery();
                    commandIndividu.ExecuteNonQuery();
                    MessageBox.Show("Le professionnel a été supprimé avec succès.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression d'un Professionnel : {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        //////////////////////////////////////////////////////////////////// FIN PROFESSIONNEL ////////////////////////////////////////////////////////////////////




        //////////////////////////////////////////////////////////////////// DEBUT BUREAU //////////////////////////////////////////////////////////////////////////

        public void CreerPresident(Etudiant etudiant)
        {
            string queryIndividu = "INSERT INTO individu (Nom, Prenom) VALUES (@Nom, @Prenom, @Email, @num, @datedenaissance)";
            string queryEtudiant = "INSERT INTO etudiant (IdIndividu, LyceeOrigine, SpecialiteBac, AnneeObtentionBac, DateEntreeBts, DateSortieBts, PromoBts, SpecialiteBts, DateObtentionBts) VALUES (@IdIndividu, @LyceeOrigine, @SpecialiteBac, @AnneeObtentionBac, @DateEntreeBts, @DateSortieBts, @PromoBts, @SpecialiteBts, @DateObtentionBts)";

            using (MySqlCommand commandIndividu = new MySqlCommand(queryIndividu, connection))
            using (MySqlCommand commandEtudiant = new MySqlCommand(queryEtudiant, connection))
            {
                commandIndividu.Parameters.AddWithValue("@Nom", etudiant.Nom);
                commandIndividu.Parameters.AddWithValue("@Prenom", etudiant.Prenom);
                commandIndividu.Parameters.AddWithValue("@Email", etudiant.Email);
                commandIndividu.Parameters.AddWithValue("@num", etudiant.Num);
                commandIndividu.Parameters.AddWithValue("@datedenaissance", etudiant.DateDeNaissance);
                int lastInsertedId = -1;
                try
                {
                    connection.Open();
                    commandIndividu.ExecuteNonQuery();
                    string idQuery = "SELECT LAST_INSERT_ID();";
                    MySqlCommand idCommand = new MySqlCommand(idQuery, connection);
                    lastInsertedId = Convert.ToInt32(idCommand.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la création de l'individu : {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

                if (lastInsertedId >= 0)
                {
                    commandEtudiant.Parameters.AddWithValue("@IdIndividu", lastInsertedId);
                    commandEtudiant.Parameters.AddWithValue("@LyceeOrigine", etudiant.LyceeOrigine);
                    commandEtudiant.Parameters.AddWithValue("@SpecialiteBac", etudiant.SpecialiteBac);
                    commandEtudiant.Parameters.AddWithValue("@AnneeObtentionBac", etudiant.AnneeObtentionBac);
                    commandEtudiant.Parameters.AddWithValue("@DateEntreeBts", etudiant.DateEntreeBts);
                    commandEtudiant.Parameters.AddWithValue("@DateSortieBts", etudiant.DateSortieBts);
                    commandEtudiant.Parameters.AddWithValue("@PromoBts", etudiant.PromoBts);
                    commandEtudiant.Parameters.AddWithValue("@SpecialiteBts", etudiant.SpecialiteBts);
                    commandEtudiant.Parameters.AddWithValue("@DateObtentionBts", etudiant.DateObtentionBts);

                    try
                    {
                        connection.Open();
                        commandEtudiant.ExecuteNonQuery();
                        MessageBox.Show("L'étudiant a été créé avec succès.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de la création de l'étudiant : {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }





                }

                //////////////////////////////////////////////////////////////////// FIN BUREAU ///////////////////////////////////////////////////////////////////////
            }
        }

        //////////////////////////////////////////////////////////////////// DÉBUT PETITDEJ ///////////////////////////////////////////////////////////////////////

        public void CreerPetitDejeuner(PetitDejeuner petitDejeuner)
        {
            string query = "INSERT INTO petit_dej (DateDej) VALUES (@DateDej)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DateDej", petitDejeuner.DateDej);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Le petit déjeuner a été créé avec succès.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur lors de la création du petit déjeuner : {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //////////////////////////////////////////////////////////////////// FIN PETITDEJ ///////////////////////////////////////////////////////////////////////

    }
}
