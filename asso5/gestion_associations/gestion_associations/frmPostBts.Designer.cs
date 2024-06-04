
namespace gestion_associations
{
    partial class frmPostBts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostBts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_print_user = new System.Windows.Forms.Label();
            this.btn_jury2 = new FontAwesome.Sharp.IconButton();
            this.btn_retour = new FontAwesome.Sharp.IconButton();
            this.btn_postbts2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.ico_btn_quitter = new FontAwesome.Sharp.IconButton();
            this.btn_professionnel = new FontAwesome.Sharp.IconButton();
            this.btn_etudiant = new FontAwesome.Sharp.IconButton();
            this.btn_petitdej = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_postbts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.txt_libelle = new System.Windows.Forms.TextBox();
            this.txt_niveau = new System.Windows.Forms.TextBox();
            this.txt_lieu = new System.Windows.Forms.TextBox();
            this.cb_etudiant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_postbts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_jury2);
            this.panel1.Controls.Add(this.btn_retour);
            this.panel1.Controls.Add(this.btn_postbts2);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.ico_btn_quitter);
            this.panel1.Controls.Add(this.btn_professionnel);
            this.panel1.Controls.Add(this.btn_etudiant);
            this.panel1.Controls.Add(this.btn_petitdej);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 623);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_print_user);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 131);
            this.panel2.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_print_user
            // 
            this.lbl_print_user.AutoSize = true;
            this.lbl_print_user.ForeColor = System.Drawing.Color.White;
            this.lbl_print_user.Location = new System.Drawing.Point(98, 70);
            this.lbl_print_user.Name = "lbl_print_user";
            this.lbl_print_user.Size = new System.Drawing.Size(0, 17);
            this.lbl_print_user.TabIndex = 0;
            // 
            // btn_jury2
            // 
            this.btn_jury2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_jury2.FlatAppearance.BorderSize = 0;
            this.btn_jury2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jury2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jury2.ForeColor = System.Drawing.Color.White;
            this.btn_jury2.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btn_jury2.IconColor = System.Drawing.Color.White;
            this.btn_jury2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_jury2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_jury2.Location = new System.Drawing.Point(10, 494);
            this.btn_jury2.Name = "btn_jury2";
            this.btn_jury2.Size = new System.Drawing.Size(228, 65);
            this.btn_jury2.TabIndex = 48;
            this.btn_jury2.Text = "Jury";
            this.btn_jury2.UseVisualStyleBackColor = false;
            this.btn_jury2.Click += new System.EventHandler(this.btn_jury2_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_retour.FlatAppearance.BorderSize = 0;
            this.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retour.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.ForeColor = System.Drawing.Color.White;
            this.btn_retour.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_retour.IconColor = System.Drawing.Color.White;
            this.btn_retour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_retour.IconSize = 40;
            this.btn_retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_retour.Location = new System.Drawing.Point(17, 705);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(5);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(249, 78);
            this.btn_retour.TabIndex = 2;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = false;
            // 
            // btn_postbts2
            // 
            this.btn_postbts2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_postbts2.FlatAppearance.BorderSize = 0;
            this.btn_postbts2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_postbts2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_postbts2.ForeColor = System.Drawing.Color.White;
            this.btn_postbts2.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btn_postbts2.IconColor = System.Drawing.Color.White;
            this.btn_postbts2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_postbts2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_postbts2.Location = new System.Drawing.Point(12, 423);
            this.btn_postbts2.Name = "btn_postbts2";
            this.btn_postbts2.Size = new System.Drawing.Size(228, 65);
            this.btn_postbts2.TabIndex = 47;
            this.btn_postbts2.Text = "Post BTS";
            this.btn_postbts2.UseVisualStyleBackColor = false;
            this.btn_postbts2.Click += new System.EventHandler(this.btn_postbts2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.Location = new System.Drawing.Point(12, 361);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(228, 65);
            this.iconButton3.TabIndex = 44;
            this.iconButton3.Text = "Bureau";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // ico_btn_quitter
            // 
            this.ico_btn_quitter.FlatAppearance.BorderSize = 0;
            this.ico_btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ico_btn_quitter.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ico_btn_quitter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ico_btn_quitter.ForeColor = System.Drawing.Color.White;
            this.ico_btn_quitter.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.ico_btn_quitter.IconColor = System.Drawing.Color.White;
            this.ico_btn_quitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ico_btn_quitter.IconSize = 32;
            this.ico_btn_quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ico_btn_quitter.Location = new System.Drawing.Point(12, 545);
            this.ico_btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.ico_btn_quitter.Name = "ico_btn_quitter";
            this.ico_btn_quitter.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ico_btn_quitter.Size = new System.Drawing.Size(228, 64);
            this.ico_btn_quitter.TabIndex = 46;
            this.ico_btn_quitter.Text = "Déconnexion ";
            this.ico_btn_quitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ico_btn_quitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ico_btn_quitter.UseVisualStyleBackColor = true;
            this.ico_btn_quitter.Click += new System.EventHandler(this.ico_btn_quitter_Click);
            // 
            // btn_professionnel
            // 
            this.btn_professionnel.FlatAppearance.BorderSize = 0;
            this.btn_professionnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_professionnel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_professionnel.ForeColor = System.Drawing.Color.White;
            this.btn_professionnel.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btn_professionnel.IconColor = System.Drawing.Color.White;
            this.btn_professionnel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_professionnel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_professionnel.Location = new System.Drawing.Point(12, 219);
            this.btn_professionnel.Name = "btn_professionnel";
            this.btn_professionnel.Size = new System.Drawing.Size(228, 65);
            this.btn_professionnel.TabIndex = 42;
            this.btn_professionnel.Text = "Professionnel ";
            this.btn_professionnel.UseVisualStyleBackColor = true;
            this.btn_professionnel.Click += new System.EventHandler(this.btn_professionnel_Click);
            // 
            // btn_etudiant
            // 
            this.btn_etudiant.FlatAppearance.BorderSize = 0;
            this.btn_etudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_etudiant.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_etudiant.ForeColor = System.Drawing.Color.White;
            this.btn_etudiant.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btn_etudiant.IconColor = System.Drawing.Color.White;
            this.btn_etudiant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_etudiant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_etudiant.Location = new System.Drawing.Point(12, 148);
            this.btn_etudiant.Name = "btn_etudiant";
            this.btn_etudiant.Size = new System.Drawing.Size(228, 65);
            this.btn_etudiant.TabIndex = 45;
            this.btn_etudiant.Text = "Étudiant";
            this.btn_etudiant.UseVisualStyleBackColor = true;
            this.btn_etudiant.Click += new System.EventHandler(this.btn_etudiant_Click);
            // 
            // btn_petitdej
            // 
            this.btn_petitdej.FlatAppearance.BorderSize = 0;
            this.btn_petitdej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_petitdej.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_petitdej.ForeColor = System.Drawing.Color.White;
            this.btn_petitdej.IconChar = FontAwesome.Sharp.IconChar.MugSaucer;
            this.btn_petitdej.IconColor = System.Drawing.Color.White;
            this.btn_petitdej.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_petitdej.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_petitdej.Location = new System.Drawing.Point(12, 290);
            this.btn_petitdej.Name = "btn_petitdej";
            this.btn_petitdej.Size = new System.Drawing.Size(228, 65);
            this.btn_petitdej.TabIndex = 43;
            this.btn_petitdej.Text = "Petit déjeuner";
            this.btn_petitdej.UseVisualStyleBackColor = true;
            this.btn_petitdej.Click += new System.EventHandler(this.btn_petitdej_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(589, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Post BTS";
            // 
            // dgv_postbts
            // 
            this.dgv_postbts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_postbts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_postbts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_postbts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_postbts.Location = new System.Drawing.Point(314, 115);
            this.dgv_postbts.Name = "dgv_postbts";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_postbts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_postbts.Size = new System.Drawing.Size(696, 252);
            this.dgv_postbts.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Libelle information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Niveau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lieu";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouter.FlatAppearance.BorderSize = 0;
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(891, 481);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(119, 30);
            this.btn_ajouter.TabIndex = 95;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // txt_libelle
            // 
            this.txt_libelle.Location = new System.Drawing.Point(424, 407);
            this.txt_libelle.Name = "txt_libelle";
            this.txt_libelle.Size = new System.Drawing.Size(100, 25);
            this.txt_libelle.TabIndex = 107;
            // 
            // txt_niveau
            // 
            this.txt_niveau.Location = new System.Drawing.Point(406, 478);
            this.txt_niveau.Name = "txt_niveau";
            this.txt_niveau.Size = new System.Drawing.Size(100, 25);
            this.txt_niveau.TabIndex = 108;
            // 
            // txt_lieu
            // 
            this.txt_lieu.Location = new System.Drawing.Point(702, 407);
            this.txt_lieu.Name = "txt_lieu";
            this.txt_lieu.Size = new System.Drawing.Size(100, 25);
            this.txt_lieu.TabIndex = 109;
            // 
            // cb_etudiant
            // 
            this.cb_etudiant.FormattingEnabled = true;
            this.cb_etudiant.Location = new System.Drawing.Point(702, 485);
            this.cb_etudiant.Name = "cb_etudiant";
            this.cb_etudiant.Size = new System.Drawing.Size(110, 25);
            this.cb_etudiant.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 111;
            this.label5.Text = "IdEtudiant";
            // 
            // frmPostBts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 612);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_etudiant);
            this.Controls.Add(this.txt_lieu);
            this.Controls.Add(this.txt_niveau);
            this.Controls.Add(this.txt_libelle);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_postbts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPostBts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPostBts";
            this.Load += new System.EventHandler(this.frmPostBts_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_postbts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_retour;
        private FontAwesome.Sharp.IconButton btn_jury2;
        private FontAwesome.Sharp.IconButton btn_postbts2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton ico_btn_quitter;
        private FontAwesome.Sharp.IconButton btn_professionnel;
        private FontAwesome.Sharp.IconButton btn_etudiant;
        private FontAwesome.Sharp.IconButton btn_petitdej;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_print_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_postbts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.TextBox txt_libelle;
        private System.Windows.Forms.TextBox txt_niveau;
        private System.Windows.Forms.TextBox txt_lieu;
        private System.Windows.Forms.ComboBox cb_etudiant;
        private System.Windows.Forms.Label label5;
    }
}