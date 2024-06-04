
namespace gestion_associations
{
    partial class frmAcceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceuil));
            this.lbl_bvn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_jury = new FontAwesome.Sharp.IconButton();
            this.btn_postbts = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ico_btn_quitter = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_print_user = new System.Windows.Forms.Label();
            this.btn_ajouter = new FontAwesome.Sharp.IconButton();
            this.btn_modifier = new FontAwesome.Sharp.IconButton();
            this.btn_supprimer = new FontAwesome.Sharp.IconButton();
            this.dgv_etudiant = new System.Windows.Forms.DataGridView();
            this.btn_raffraichir = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bvn
            // 
            this.lbl_bvn.AutoSize = true;
            this.lbl_bvn.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_bvn.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bvn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_bvn.Location = new System.Drawing.Point(286, 9);
            this.lbl_bvn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bvn.Name = "lbl_bvn";
            this.lbl_bvn.Size = new System.Drawing.Size(581, 30);
            this.lbl_bvn.TabIndex = 0;
            this.lbl_bvn.Text = "Bienvenue sur notre application de Gestion d\'Association ";
            this.lbl_bvn.Click += new System.EventHandler(this.lbl_bvn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_jury);
            this.panel1.Controls.Add(this.btn_postbts);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.ico_btn_quitter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 612);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btn_jury.Location = new System.Drawing.Point(21, 495);
            this.btn_jury.Name = "btn_jury";
            this.btn_jury.Size = new System.Drawing.Size(228, 65);
            this.btn_jury.TabIndex = 12;
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
            this.btn_postbts.Location = new System.Drawing.Point(23, 424);
            this.btn_postbts.Name = "btn_postbts";
            this.btn_postbts.Size = new System.Drawing.Size(228, 65);
            this.btn_postbts.TabIndex = 11;
            this.btn_postbts.Text = "Post BTS";
            this.btn_postbts.UseVisualStyleBackColor = false;
            this.btn_postbts.Click += new System.EventHandler(this.btn_postbts_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.Location = new System.Drawing.Point(21, 140);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(228, 65);
            this.iconButton4.TabIndex = 10;
            this.iconButton4.Text = "Étudiant";
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.Location = new System.Drawing.Point(23, 353);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(228, 65);
            this.iconButton3.TabIndex = 9;
            this.iconButton3.Text = "Bureau";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MugSaucer;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(23, 282);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(228, 65);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "Petit déjeuner";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(21, 211);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(228, 65);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Professionnel ";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.ico_btn_quitter.Location = new System.Drawing.Point(4, 548);
            this.ico_btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.ico_btn_quitter.Name = "ico_btn_quitter";
            this.ico_btn_quitter.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ico_btn_quitter.Size = new System.Drawing.Size(228, 64);
            this.ico_btn_quitter.TabIndex = 2;
            this.ico_btn_quitter.Text = "Déconnexion ";
            this.ico_btn_quitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ico_btn_quitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ico_btn_quitter.UseVisualStyleBackColor = true;
            this.ico_btn_quitter.Click += new System.EventHandler(this.ico_btn_quitter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_print_user);
            this.panel2.Location = new System.Drawing.Point(0, -7);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 142);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
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
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.White;
            this.btn_ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ajouter.FlatAppearance.BorderSize = 0;
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btn_ajouter.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_ajouter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ajouter.Location = new System.Drawing.Point(757, 526);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(110, 73);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.White;
            this.btn_modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_modifier.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_modifier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_modifier.Location = new System.Drawing.Point(841, 526);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(110, 73);
            this.btn_modifier.TabIndex = 3;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_modifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.White;
            this.btn_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_supprimer.FlatAppearance.BorderSize = 0;
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_supprimer.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_supprimer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_supprimer.Location = new System.Drawing.Point(922, 526);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(110, 73);
            this.btn_supprimer.TabIndex = 4;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_supprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // dgv_etudiant
            // 
            this.dgv_etudiant.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_etudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_etudiant.Location = new System.Drawing.Point(318, 117);
            this.dgv_etudiant.Name = "dgv_etudiant";
            this.dgv_etudiant.Size = new System.Drawing.Size(701, 391);
            this.dgv_etudiant.TabIndex = 5;
            this.dgv_etudiant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_raffraichir
            // 
            this.btn_raffraichir.FlatAppearance.BorderSize = 0;
            this.btn_raffraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raffraichir.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btn_raffraichir.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_raffraichir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_raffraichir.Location = new System.Drawing.Point(675, 524);
            this.btn_raffraichir.Name = "btn_raffraichir";
            this.btn_raffraichir.Size = new System.Drawing.Size(110, 75);
            this.btn_raffraichir.TabIndex = 6;
            this.btn_raffraichir.Text = "Raffraîchir";
            this.btn_raffraichir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raffraichir.UseVisualStyleBackColor = true;
            this.btn_raffraichir.Click += new System.EventHandler(this.btn_raffraichir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(311, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Etudiant";
            // 
            // frmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_raffraichir);
            this.Controls.Add(this.dgv_etudiant);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_bvn);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAcceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcceuil";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAcceuil_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bvn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ico_btn_quitter;
        private FontAwesome.Sharp.IconButton btn_ajouter;
        private FontAwesome.Sharp.IconButton btn_modifier;
        private FontAwesome.Sharp.IconButton btn_supprimer;
        private System.Windows.Forms.DataGridView dgv_etudiant;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_raffraichir;
        private System.Windows.Forms.Label lbl_print_user;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_jury;
        private FontAwesome.Sharp.IconButton btn_postbts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}