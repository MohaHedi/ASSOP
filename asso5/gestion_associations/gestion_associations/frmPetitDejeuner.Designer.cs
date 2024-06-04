
namespace gestion_associations
{
    partial class frmPetitDejeuner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPetitDejeuner));
            this.dtp_petitdejeuner = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_petitdej = new System.Windows.Forms.DataGridView();
            this.btn_ajouterDej = new FontAwesome.Sharp.IconButton();
            this.btn_supprimer = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_pro = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_jury2 = new FontAwesome.Sharp.IconButton();
            this.btn_postbts2 = new FontAwesome.Sharp.IconButton();
            this.ico_btn_quitter = new FontAwesome.Sharp.IconButton();
            this.btn_etudiant = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btn_petitdej = new FontAwesome.Sharp.IconButton();
            this.btn_professionnel = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_print_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_petitdej)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_petitdejeuner
            // 
            this.dtp_petitdejeuner.CustomFormat = "yyyy";
            this.dtp_petitdejeuner.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_petitdejeuner.Location = new System.Drawing.Point(383, 486);
            this.dtp_petitdejeuner.Name = "dtp_petitdejeuner";
            this.dtp_petitdejeuner.Size = new System.Drawing.Size(91, 20);
            this.dtp_petitdejeuner.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date";
            // 
            // dgv_petitdej
            // 
            this.dgv_petitdej.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_petitdej.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_petitdej.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_petitdej.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_petitdej.Location = new System.Drawing.Point(330, 171);
            this.dgv_petitdej.Name = "dgv_petitdej";
            this.dgv_petitdej.Size = new System.Drawing.Size(696, 252);
            this.dgv_petitdej.TabIndex = 22;
            // 
            // btn_ajouterDej
            // 
            this.btn_ajouterDej.BackColor = System.Drawing.Color.White;
            this.btn_ajouterDej.FlatAppearance.BorderSize = 0;
            this.btn_ajouterDej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouterDej.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterDej.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouterDej.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btn_ajouterDej.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_ajouterDej.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ajouterDej.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ajouterDej.Location = new System.Drawing.Point(594, 465);
            this.btn_ajouterDej.Name = "btn_ajouterDej";
            this.btn_ajouterDej.Size = new System.Drawing.Size(113, 79);
            this.btn_ajouterDej.TabIndex = 21;
            this.btn_ajouterDej.Text = "Ajouter";
            this.btn_ajouterDej.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ajouterDej.UseVisualStyleBackColor = false;
            this.btn_ajouterDej.Click += new System.EventHandler(this.btn_ajouterDej_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.White;
            this.btn_supprimer.FlatAppearance.BorderSize = 0;
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.Black;
            this.btn_supprimer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_supprimer.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_supprimer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_supprimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_supprimer.Location = new System.Drawing.Point(913, 465);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(113, 79);
            this.btn_supprimer.TabIndex = 20;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(323, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Petit Déjeuner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Professionnel";
            // 
            // cb_pro
            // 
            this.cb_pro.FormattingEnabled = true;
            this.cb_pro.Location = new System.Drawing.Point(451, 512);
            this.cb_pro.Name = "cb_pro";
            this.cb_pro.Size = new System.Drawing.Size(121, 21);
            this.cb_pro.TabIndex = 27;
            this.cb_pro.SelectedIndexChanged += new System.EventHandler(this.cb_pro_SelectedIndexChanged);
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
            this.panel1.Controls.Add(this.btn_professionnel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 614);
            this.panel1.TabIndex = 31;
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
            this.btn_jury2.Location = new System.Drawing.Point(11, 484);
            this.btn_jury2.Name = "btn_jury2";
            this.btn_jury2.Size = new System.Drawing.Size(228, 65);
            this.btn_jury2.TabIndex = 41;
            this.btn_jury2.Text = "Jury";
            this.btn_jury2.UseVisualStyleBackColor = false;
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
            this.btn_postbts2.Location = new System.Drawing.Point(13, 413);
            this.btn_postbts2.Name = "btn_postbts2";
            this.btn_postbts2.Size = new System.Drawing.Size(228, 65);
            this.btn_postbts2.TabIndex = 40;
            this.btn_postbts2.Text = "Post BTS";
            this.btn_postbts2.UseVisualStyleBackColor = false;
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
            this.ico_btn_quitter.Location = new System.Drawing.Point(13, 535);
            this.ico_btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.ico_btn_quitter.Name = "ico_btn_quitter";
            this.ico_btn_quitter.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ico_btn_quitter.Size = new System.Drawing.Size(228, 64);
            this.ico_btn_quitter.TabIndex = 35;
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
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
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
            this.btn_professionnel.Location = new System.Drawing.Point(13, 209);
            this.btn_professionnel.Name = "btn_professionnel";
            this.btn_professionnel.Size = new System.Drawing.Size(228, 65);
            this.btn_professionnel.TabIndex = 31;
            this.btn_professionnel.Text = "Professionnel ";
            this.btn_professionnel.UseVisualStyleBackColor = true;
            this.btn_professionnel.Click += new System.EventHandler(this.btn_professionnel_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
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
            // frmPetitDejeuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_pro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_petitdejeuner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_petitdej);
            this.Controls.Add(this.btn_ajouterDej);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPetitDejeuner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPetitDejeuner";
            this.Load += new System.EventHandler(this.frmPetitDejeuner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_petitdej)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_petitdejeuner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_petitdej;
        private FontAwesome.Sharp.IconButton btn_ajouterDej;
        private FontAwesome.Sharp.IconButton btn_supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_pro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_print_user;
        private FontAwesome.Sharp.IconButton btn_etudiant;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btn_petitdej;
        private FontAwesome.Sharp.IconButton btn_professionnel;
        private FontAwesome.Sharp.IconButton ico_btn_quitter;
        private FontAwesome.Sharp.IconButton btn_jury2;
        private FontAwesome.Sharp.IconButton btn_postbts2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}