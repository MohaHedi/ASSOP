
namespace gestion_associations
{
    partial class frmBureau
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBureau));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_secretaire = new FontAwesome.Sharp.IconButton();
            this.btn_tresorier = new FontAwesome.Sharp.IconButton();
            this.btn_president = new FontAwesome.Sharp.IconButton();
            this.dgv_bureau = new System.Windows.Forms.DataGridView();
            this.btn_supprimerBureau = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_promotion = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_jury2 = new FontAwesome.Sharp.IconButton();
            this.btn_postbts2 = new FontAwesome.Sharp.IconButton();
            this.ico_btn_quitter = new FontAwesome.Sharp.IconButton();
            this.btn_etudiant = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btn_petitdej = new FontAwesome.Sharp.IconButton();
            this.btn_professionel = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_print_user = new System.Windows.Forms.Label();
            this.btn_raffraichir = new FontAwesome.Sharp.IconButton();
            this.btn_valider = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bureau)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(505, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bureau de l\'association";
            // 
            // btn_secretaire
            // 
            this.btn_secretaire.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_secretaire.FlatAppearance.BorderSize = 0;
            this.btn_secretaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_secretaire.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_secretaire.ForeColor = System.Drawing.Color.White;
            this.btn_secretaire.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btn_secretaire.IconColor = System.Drawing.Color.White;
            this.btn_secretaire.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_secretaire.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_secretaire.Location = new System.Drawing.Point(299, 410);
            this.btn_secretaire.Name = "btn_secretaire";
            this.btn_secretaire.Size = new System.Drawing.Size(228, 65);
            this.btn_secretaire.TabIndex = 13;
            this.btn_secretaire.Text = "Secrétaire";
            this.btn_secretaire.UseVisualStyleBackColor = false;
            this.btn_secretaire.Click += new System.EventHandler(this.btn_secretaire_Click);
            // 
            // btn_tresorier
            // 
            this.btn_tresorier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_tresorier.FlatAppearance.BorderSize = 0;
            this.btn_tresorier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tresorier.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tresorier.ForeColor = System.Drawing.Color.White;
            this.btn_tresorier.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btn_tresorier.IconColor = System.Drawing.Color.White;
            this.btn_tresorier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_tresorier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tresorier.Location = new System.Drawing.Point(767, 410);
            this.btn_tresorier.Name = "btn_tresorier";
            this.btn_tresorier.Size = new System.Drawing.Size(228, 65);
            this.btn_tresorier.TabIndex = 12;
            this.btn_tresorier.Text = "Trésorier";
            this.btn_tresorier.UseVisualStyleBackColor = false;
            this.btn_tresorier.Click += new System.EventHandler(this.btn_tresorier_Click);
            // 
            // btn_president
            // 
            this.btn_president.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_president.FlatAppearance.BorderSize = 0;
            this.btn_president.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_president.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_president.ForeColor = System.Drawing.Color.White;
            this.btn_president.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btn_president.IconColor = System.Drawing.Color.White;
            this.btn_president.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_president.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_president.Location = new System.Drawing.Point(533, 410);
            this.btn_president.Name = "btn_president";
            this.btn_president.Size = new System.Drawing.Size(228, 65);
            this.btn_president.TabIndex = 11;
            this.btn_president.Text = "Président";
            this.btn_president.UseVisualStyleBackColor = false;
            this.btn_president.Click += new System.EventHandler(this.btn_president_Click);
            // 
            // dgv_bureau
            // 
            this.dgv_bureau.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bureau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bureau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bureau.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bureau.Location = new System.Drawing.Point(299, 133);
            this.dgv_bureau.Name = "dgv_bureau";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bureau.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_bureau.Size = new System.Drawing.Size(696, 252);
            this.dgv_bureau.TabIndex = 14;
            this.dgv_bureau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bureau_CellContentClick);
            // 
            // btn_supprimerBureau
            // 
            this.btn_supprimerBureau.BackColor = System.Drawing.Color.White;
            this.btn_supprimerBureau.FlatAppearance.BorderSize = 0;
            this.btn_supprimerBureau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimerBureau.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimerBureau.ForeColor = System.Drawing.Color.Black;
            this.btn_supprimerBureau.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_supprimerBureau.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_supprimerBureau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_supprimerBureau.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_supprimerBureau.Location = new System.Drawing.Point(934, 525);
            this.btn_supprimerBureau.Name = "btn_supprimerBureau";
            this.btn_supprimerBureau.Size = new System.Drawing.Size(140, 75);
            this.btn_supprimerBureau.TabIndex = 15;
            this.btn_supprimerBureau.Text = "Supprimer le rôle";
            this.btn_supprimerBureau.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_supprimerBureau.UseVisualStyleBackColor = false;
            this.btn_supprimerBureau.Click += new System.EventHandler(this.btn_supprimerBureau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Promotion :";
            // 
            // dtp_promotion
            // 
            this.dtp_promotion.CustomFormat = "yyyy";
            this.dtp_promotion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_promotion.Location = new System.Drawing.Point(419, 87);
            this.dtp_promotion.Name = "dtp_promotion";
            this.dtp_promotion.Size = new System.Drawing.Size(63, 20);
            this.dtp_promotion.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_jury2);
            this.panel1.Controls.Add(this.btn_postbts2);
            this.panel1.Controls.Add(this.ico_btn_quitter);
            this.panel1.Controls.Add(this.btn_etudiant);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.btn_petitdej);
            this.panel1.Controls.Add(this.btn_professionel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 614);
            this.panel1.TabIndex = 30;
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
            this.btn_jury2.Location = new System.Drawing.Point(12, 481);
            this.btn_jury2.Name = "btn_jury2";
            this.btn_jury2.Size = new System.Drawing.Size(228, 65);
            this.btn_jury2.TabIndex = 38;
            this.btn_jury2.Text = "Jury";
            this.btn_jury2.UseVisualStyleBackColor = false;
            this.btn_jury2.Click += new System.EventHandler(this.btn_jury2_Click);
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
            this.btn_postbts2.Location = new System.Drawing.Point(14, 410);
            this.btn_postbts2.Name = "btn_postbts2";
            this.btn_postbts2.Size = new System.Drawing.Size(228, 65);
            this.btn_postbts2.TabIndex = 37;
            this.btn_postbts2.Text = "Post BTS";
            this.btn_postbts2.UseVisualStyleBackColor = false;
            this.btn_postbts2.Click += new System.EventHandler(this.btn_postbts2_Click);
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
            this.ico_btn_quitter.Location = new System.Drawing.Point(0, 536);
            this.ico_btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.ico_btn_quitter.Name = "ico_btn_quitter";
            this.ico_btn_quitter.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ico_btn_quitter.Size = new System.Drawing.Size(228, 64);
            this.ico_btn_quitter.TabIndex = 31;
            this.ico_btn_quitter.Text = "Déconnexion ";
            this.ico_btn_quitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ico_btn_quitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ico_btn_quitter.UseVisualStyleBackColor = true;
            this.ico_btn_quitter.Click += new System.EventHandler(this.ico_btn_quitter_Click);
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
            this.btn_etudiant.Location = new System.Drawing.Point(13, 138);
            this.btn_etudiant.Name = "btn_etudiant";
            this.btn_etudiant.Size = new System.Drawing.Size(228, 65);
            this.btn_etudiant.TabIndex = 34;
            this.btn_etudiant.Text = "Étudiant";
            this.btn_etudiant.UseVisualStyleBackColor = true;
            this.btn_etudiant.Click += new System.EventHandler(this.btn_etudiant_Click);
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
            this.iconButton3.Location = new System.Drawing.Point(13, 351);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(228, 65);
            this.iconButton3.TabIndex = 33;
            this.iconButton3.Text = "Bureau";
            this.iconButton3.UseVisualStyleBackColor = true;
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
            this.btn_petitdej.Location = new System.Drawing.Point(13, 280);
            this.btn_petitdej.Name = "btn_petitdej";
            this.btn_petitdej.Size = new System.Drawing.Size(228, 65);
            this.btn_petitdej.TabIndex = 32;
            this.btn_petitdej.Text = "Petit déjeuner";
            this.btn_petitdej.UseVisualStyleBackColor = true;
            this.btn_petitdej.Click += new System.EventHandler(this.btn_petitdej_Click);
            // 
            // btn_professionel
            // 
            this.btn_professionel.FlatAppearance.BorderSize = 0;
            this.btn_professionel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_professionel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_professionel.ForeColor = System.Drawing.Color.White;
            this.btn_professionel.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btn_professionel.IconColor = System.Drawing.Color.White;
            this.btn_professionel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_professionel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_professionel.Location = new System.Drawing.Point(13, 209);
            this.btn_professionel.Name = "btn_professionel";
            this.btn_professionel.Size = new System.Drawing.Size(228, 65);
            this.btn_professionel.TabIndex = 31;
            this.btn_professionel.Text = "Professionnel ";
            this.btn_professionel.UseVisualStyleBackColor = true;
            this.btn_professionel.Click += new System.EventHandler(this.btn_professionel_Click);
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
            this.panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, -1);
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
            this.lbl_print_user.Size = new System.Drawing.Size(0, 13);
            this.lbl_print_user.TabIndex = 0;
            // 
            // btn_raffraichir
            // 
            this.btn_raffraichir.FlatAppearance.BorderSize = 0;
            this.btn_raffraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raffraichir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raffraichir.ForeColor = System.Drawing.Color.Black;
            this.btn_raffraichir.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btn_raffraichir.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_raffraichir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_raffraichir.Location = new System.Drawing.Point(829, 524);
            this.btn_raffraichir.Name = "btn_raffraichir";
            this.btn_raffraichir.Size = new System.Drawing.Size(110, 75);
            this.btn_raffraichir.TabIndex = 31;
            this.btn_raffraichir.Text = "Raffraîchir";
            this.btn_raffraichir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raffraichir.UseVisualStyleBackColor = true;
            this.btn_raffraichir.Click += new System.EventHandler(this.btn_raffraichir_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.FlatAppearance.BorderSize = 0;
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_valider.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_valider.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_valider.IconSize = 25;
            this.btn_valider.Location = new System.Drawing.Point(488, 84);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(30, 28);
            this.btn_valider.TabIndex = 33;
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // frmBureau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 612);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_raffraichir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_promotion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_supprimerBureau);
            this.Controls.Add(this.dgv_bureau);
            this.Controls.Add(this.btn_secretaire);
            this.Controls.Add(this.btn_tresorier);
            this.Controls.Add(this.btn_president);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBureau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBureau";
            this.Load += new System.EventHandler(this.frmBureau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bureau)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_secretaire;
        private FontAwesome.Sharp.IconButton btn_tresorier;
        private FontAwesome.Sharp.IconButton btn_president;
        private System.Windows.Forms.DataGridView dgv_bureau;
        private FontAwesome.Sharp.IconButton btn_supprimerBureau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_promotion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_print_user;
        private FontAwesome.Sharp.IconButton btn_etudiant;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btn_petitdej;
        private FontAwesome.Sharp.IconButton btn_professionel;
        private FontAwesome.Sharp.IconButton ico_btn_quitter;
        private FontAwesome.Sharp.IconButton btn_raffraichir;
        private FontAwesome.Sharp.IconButton btn_valider;
        private FontAwesome.Sharp.IconButton btn_jury2;
        private FontAwesome.Sharp.IconButton btn_postbts2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}