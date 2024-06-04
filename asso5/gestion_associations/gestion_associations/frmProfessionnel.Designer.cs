
namespace gestion_associations
{
    partial class frmProfessionnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessionnel));
            this.dgv_pro = new System.Windows.Forms.DataGridView();
            this.btn_ajouter = new FontAwesome.Sharp.IconButton();
            this.btn_raffraichir = new FontAwesome.Sharp.IconButton();
            this.btn_supprimer = new FontAwesome.Sharp.IconButton();
            this.btn_modifier = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_jury = new FontAwesome.Sharp.IconButton();
            this.btn_postbts = new FontAwesome.Sharp.IconButton();
            this.ico_btn_quitter = new FontAwesome.Sharp.IconButton();
            this.btn_etudiant = new FontAwesome.Sharp.IconButton();
            this.btn_bureau = new FontAwesome.Sharp.IconButton();
            this.btn_petitidej = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_print_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pro
            // 
            this.dgv_pro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_pro.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_pro.Location = new System.Drawing.Point(314, 113);
            this.dgv_pro.Name = "dgv_pro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pro.Size = new System.Drawing.Size(666, 351);
            this.dgv_pro.TabIndex = 0;
            this.dgv_pro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pro_CellContentClick);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.White;
            this.btn_ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ajouter.FlatAppearance.BorderSize = 0;
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btn_ajouter.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_ajouter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ajouter.Location = new System.Drawing.Point(694, 508);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(110, 73);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_raffraichir
            // 
            this.btn_raffraichir.BackColor = System.Drawing.Color.White;
            this.btn_raffraichir.FlatAppearance.BorderSize = 0;
            this.btn_raffraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raffraichir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raffraichir.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btn_raffraichir.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_raffraichir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_raffraichir.Location = new System.Drawing.Point(788, 504);
            this.btn_raffraichir.Name = "btn_raffraichir";
            this.btn_raffraichir.Size = new System.Drawing.Size(110, 75);
            this.btn_raffraichir.TabIndex = 13;
            this.btn_raffraichir.Text = "Raffraîchir";
            this.btn_raffraichir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raffraichir.UseVisualStyleBackColor = false;
            this.btn_raffraichir.Click += new System.EventHandler(this.btn_raffraichir_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.White;
            this.btn_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_supprimer.FlatAppearance.BorderSize = 0;
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_supprimer.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_supprimer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_supprimer.Location = new System.Drawing.Point(978, 508);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(110, 73);
            this.btn_supprimer.TabIndex = 15;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_supprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.White;
            this.btn_modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_modifier.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_modifier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_modifier.Location = new System.Drawing.Point(889, 508);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(110, 73);
            this.btn_modifier.TabIndex = 14;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_modifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(307, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Professionnel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_jury);
            this.panel1.Controls.Add(this.btn_postbts);
            this.panel1.Controls.Add(this.ico_btn_quitter);
            this.panel1.Controls.Add(this.btn_etudiant);
            this.panel1.Controls.Add(this.btn_bureau);
            this.panel1.Controls.Add(this.btn_petitidej);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 623);
            this.panel1.TabIndex = 32;
            // 
            // btn_jury
            // 
            this.btn_jury.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_jury.FlatAppearance.BorderSize = 0;
            this.btn_jury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jury.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jury.ForeColor = System.Drawing.Color.White;
            this.btn_jury.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btn_jury.IconColor = System.Drawing.Color.White;
            this.btn_jury.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_jury.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_jury.Location = new System.Drawing.Point(10, 493);
            this.btn_jury.Name = "btn_jury";
            this.btn_jury.Size = new System.Drawing.Size(228, 65);
            this.btn_jury.TabIndex = 37;
            this.btn_jury.Text = "Jury";
            this.btn_jury.UseVisualStyleBackColor = false;
            this.btn_jury.Click += new System.EventHandler(this.btn_jury_Click);
            // 
            // btn_postbts
            // 
            this.btn_postbts.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_postbts.FlatAppearance.BorderSize = 0;
            this.btn_postbts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_postbts.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_postbts.ForeColor = System.Drawing.Color.White;
            this.btn_postbts.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btn_postbts.IconColor = System.Drawing.Color.White;
            this.btn_postbts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_postbts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_postbts.Location = new System.Drawing.Point(12, 422);
            this.btn_postbts.Name = "btn_postbts";
            this.btn_postbts.Size = new System.Drawing.Size(228, 65);
            this.btn_postbts.TabIndex = 36;
            this.btn_postbts.Text = "Post BTS";
            this.btn_postbts.UseVisualStyleBackColor = false;
            this.btn_postbts.Click += new System.EventHandler(this.btn_postbts_Click);
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
            this.ico_btn_quitter.Location = new System.Drawing.Point(4, 546);
            this.ico_btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.ico_btn_quitter.Name = "ico_btn_quitter";
            this.ico_btn_quitter.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ico_btn_quitter.Size = new System.Drawing.Size(228, 64);
            this.ico_btn_quitter.TabIndex = 35;
            this.ico_btn_quitter.Text = "Déconnexion ";
            this.ico_btn_quitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ico_btn_quitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ico_btn_quitter.UseVisualStyleBackColor = true;
            this.ico_btn_quitter.Click += new System.EventHandler(this.ico_btn_quitter_Click_1);
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
            this.btn_etudiant.Location = new System.Drawing.Point(12, 138);
            this.btn_etudiant.Name = "btn_etudiant";
            this.btn_etudiant.Size = new System.Drawing.Size(228, 65);
            this.btn_etudiant.TabIndex = 34;
            this.btn_etudiant.Text = "Étudiant";
            this.btn_etudiant.UseVisualStyleBackColor = true;
            this.btn_etudiant.Click += new System.EventHandler(this.btn_etudiant_Click);
            // 
            // btn_bureau
            // 
            this.btn_bureau.FlatAppearance.BorderSize = 0;
            this.btn_bureau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bureau.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bureau.ForeColor = System.Drawing.Color.White;
            this.btn_bureau.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btn_bureau.IconColor = System.Drawing.Color.White;
            this.btn_bureau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_bureau.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bureau.Location = new System.Drawing.Point(12, 351);
            this.btn_bureau.Name = "btn_bureau";
            this.btn_bureau.Size = new System.Drawing.Size(228, 65);
            this.btn_bureau.TabIndex = 33;
            this.btn_bureau.Text = "Bureau";
            this.btn_bureau.UseVisualStyleBackColor = true;
            this.btn_bureau.Click += new System.EventHandler(this.btn_bureau_Click);
            // 
            // btn_petitidej
            // 
            this.btn_petitidej.FlatAppearance.BorderSize = 0;
            this.btn_petitidej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_petitidej.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_petitidej.ForeColor = System.Drawing.Color.White;
            this.btn_petitidej.IconChar = FontAwesome.Sharp.IconChar.MugSaucer;
            this.btn_petitidej.IconColor = System.Drawing.Color.White;
            this.btn_petitidej.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_petitidej.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_petitidej.Location = new System.Drawing.Point(12, 280);
            this.btn_petitidej.Name = "btn_petitidej";
            this.btn_petitidej.Size = new System.Drawing.Size(228, 65);
            this.btn_petitidej.TabIndex = 32;
            this.btn_petitidej.Text = "Petit déjeuner";
            this.btn_petitidej.UseVisualStyleBackColor = true;
            this.btn_petitidej.Click += new System.EventHandler(this.btn_petitidej_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(12, 209);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(228, 65);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = "Professionnel ";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
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
            // frmProfessionnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 612);
            this.Controls.Add(this.btn_raffraichir);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.dgv_pro);
            this.Controls.Add(this.btn_modifier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProfessionnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfessionnel";
            this.Load += new System.EventHandler(this.frmProfessionnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pro;
        private FontAwesome.Sharp.IconButton btn_ajouter;
        private FontAwesome.Sharp.IconButton btn_raffraichir;
        private FontAwesome.Sharp.IconButton btn_supprimer;
        private FontAwesome.Sharp.IconButton btn_modifier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_print_user;
        private FontAwesome.Sharp.IconButton btn_etudiant;
        private FontAwesome.Sharp.IconButton btn_bureau;
        private FontAwesome.Sharp.IconButton btn_petitidej;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ico_btn_quitter;
        private FontAwesome.Sharp.IconButton btn_jury;
        private FontAwesome.Sharp.IconButton btn_postbts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}