
namespace gestion_associations
{
    partial class frmInscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscription));
            this.btn_inscrire = new System.Windows.Forms.Button();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_idt = new System.Windows.Forms.TextBox();
            this.btn_switchConnexion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ico_btn_eyes = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_fermer = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_validercode = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.cbx_membre = new System.Windows.Forms.CheckBox();
            this.cbx_mbrebureau = new System.Windows.Forms.CheckBox();
            this.cbx_admin = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_inscrire
            // 
            this.btn_inscrire.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_inscrire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inscrire.FlatAppearance.BorderSize = 0;
            this.btn_inscrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscrire.ForeColor = System.Drawing.Color.White;
            this.btn_inscrire.Location = new System.Drawing.Point(739, 485);
            this.btn_inscrire.Margin = new System.Windows.Forms.Padding(5);
            this.btn_inscrire.Name = "btn_inscrire";
            this.btn_inscrire.Size = new System.Drawing.Size(159, 39);
            this.btn_inscrire.TabIndex = 17;
            this.btn_inscrire.Text = "S\'inscrire";
            this.btn_inscrire.UseVisualStyleBackColor = false;
            this.btn_inscrire.Click += new System.EventHandler(this.btn_inscrire_Click);
            // 
            // txt_mdp
            // 
            this.txt_mdp.BackColor = System.Drawing.Color.White;
            this.txt_mdp.Location = new System.Drawing.Point(655, 247);
            this.txt_mdp.Margin = new System.Windows.Forms.Padding(5);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.Size = new System.Drawing.Size(175, 25);
            this.txt_mdp.TabIndex = 16;
            this.txt_mdp.TextChanged += new System.EventHandler(this.txt_mdp_TextChanged);
            // 
            // txt_idt
            // 
            this.txt_idt.BackColor = System.Drawing.Color.White;
            this.txt_idt.Location = new System.Drawing.Point(656, 180);
            this.txt_idt.Margin = new System.Windows.Forms.Padding(5);
            this.txt_idt.Name = "txt_idt";
            this.txt_idt.Size = new System.Drawing.Size(175, 25);
            this.txt_idt.TabIndex = 15;
            // 
            // btn_switchConnexion
            // 
            this.btn_switchConnexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_switchConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_switchConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_switchConnexion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_switchConnexion.Location = new System.Drawing.Point(908, 485);
            this.btn_switchConnexion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_switchConnexion.Name = "btn_switchConnexion";
            this.btn_switchConnexion.Size = new System.Drawing.Size(133, 39);
            this.btn_switchConnexion.TabIndex = 13;
            this.btn_switchConnexion.Text = "Connexion ";
            this.btn_switchConnexion.UseVisualStyleBackColor = false;
            this.btn_switchConnexion.Click += new System.EventHandler(this.btn_switchConnexion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Identifiant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(527, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inscription";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-5, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 621);
            this.panel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(274, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "BTS SIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(296, 582);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Naguib Mze Ali";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(313, 561);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hedi Gombra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(391, 540);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "By ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(274, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "ASSOP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(274, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 15;
            // 
            // ico_btn_eyes
            // 
            this.ico_btn_eyes.FlatAppearance.BorderSize = 0;
            this.ico_btn_eyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ico_btn_eyes.ForeColor = System.Drawing.Color.Transparent;
            this.ico_btn_eyes.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ico_btn_eyes.IconColor = System.Drawing.Color.RoyalBlue;
            this.ico_btn_eyes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ico_btn_eyes.IconSize = 25;
            this.ico_btn_eyes.Location = new System.Drawing.Point(838, 248);
            this.ico_btn_eyes.Name = "ico_btn_eyes";
            this.ico_btn_eyes.Size = new System.Drawing.Size(35, 24);
            this.ico_btn_eyes.TabIndex = 20;
            this.ico_btn_eyes.UseVisualStyleBackColor = true;
            this.ico_btn_eyes.Click += new System.EventHandler(this.ico_btn_eyes_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(542, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "/";
            // 
            // btn_fermer
            // 
            this.btn_fermer.FlatAppearance.BorderSize = 0;
            this.btn_fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fermer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_fermer.IconColor = System.Drawing.Color.Black;
            this.btn_fermer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_fermer.Location = new System.Drawing.Point(1013, 1);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 28;
            this.btn_fermer.Text = "X";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(611, 241);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 38);
            this.iconButton1.TabIndex = 30;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(612, 175);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(36, 33);
            this.iconButton2.TabIndex = 31;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_validercode
            // 
            this.btn_validercode.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_validercode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_validercode.FlatAppearance.BorderSize = 0;
            this.btn_validercode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_validercode.ForeColor = System.Drawing.Color.White;
            this.btn_validercode.Location = new System.Drawing.Point(838, 366);
            this.btn_validercode.Margin = new System.Windows.Forms.Padding(5);
            this.btn_validercode.Name = "btn_validercode";
            this.btn_validercode.Size = new System.Drawing.Size(101, 28);
            this.btn_validercode.TabIndex = 29;
            this.btn_validercode.Text = "Valider";
            this.btn_validercode.UseVisualStyleBackColor = false;
            this.btn_validercode.Visible = false;
            this.btn_validercode.Click += new System.EventHandler(this.btn_validercode_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(542, 421);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(112, 17);
            this.lbl_msg.TabIndex = 27;
            this.lbl_msg.Text = "Validation code !";
            this.lbl_msg.Visible = false;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Location = new System.Drawing.Point(516, 369);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(129, 17);
            this.lbl_admin.TabIndex = 25;
            this.lbl_admin.Text = "Saisir code admin : ";
            this.lbl_admin.Visible = false;
            // 
            // txt_code
            // 
            this.txt_code.BackColor = System.Drawing.Color.White;
            this.txt_code.Location = new System.Drawing.Point(653, 366);
            this.txt_code.Margin = new System.Windows.Forms.Padding(5);
            this.txt_code.Name = "txt_code";
            this.txt_code.PasswordChar = '*';
            this.txt_code.Size = new System.Drawing.Size(175, 25);
            this.txt_code.TabIndex = 26;
            this.txt_code.Visible = false;
            // 
            // cbx_membre
            // 
            this.cbx_membre.AutoSize = true;
            this.cbx_membre.Location = new System.Drawing.Point(861, 328);
            this.cbx_membre.Name = "cbx_membre";
            this.cbx_membre.Size = new System.Drawing.Size(33, 21);
            this.cbx_membre.TabIndex = 23;
            this.cbx_membre.Text = "/";
            this.cbx_membre.UseVisualStyleBackColor = true;
            this.cbx_membre.CheckedChanged += new System.EventHandler(this.cbx_membre_CheckedChanged);
            // 
            // cbx_mbrebureau
            // 
            this.cbx_mbrebureau.AutoSize = true;
            this.cbx_mbrebureau.Location = new System.Drawing.Point(710, 328);
            this.cbx_mbrebureau.Name = "cbx_mbrebureau";
            this.cbx_mbrebureau.Size = new System.Drawing.Size(33, 21);
            this.cbx_mbrebureau.TabIndex = 22;
            this.cbx_mbrebureau.Text = "/";
            this.cbx_mbrebureau.UseVisualStyleBackColor = true;
            this.cbx_mbrebureau.CheckedChanged += new System.EventHandler(this.cbx_mbrebureau_CheckedChanged);
            // 
            // cbx_admin
            // 
            this.cbx_admin.AutoSize = true;
            this.cbx_admin.Location = new System.Drawing.Point(636, 328);
            this.cbx_admin.Name = "cbx_admin";
            this.cbx_admin.Size = new System.Drawing.Size(33, 21);
            this.cbx_admin.TabIndex = 21;
            this.cbx_admin.Text = "/";
            this.cbx_admin.UseVisualStyleBackColor = true;
            this.cbx_admin.CheckedChanged += new System.EventHandler(this.cbx_admin_CheckedChanged);
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1086, 612);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_validercode);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbx_membre);
            this.Controls.Add(this.cbx_mbrebureau);
            this.Controls.Add(this.cbx_admin);
            this.Controls.Add(this.ico_btn_eyes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_inscrire);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_idt);
            this.Controls.Add(this.btn_switchConnexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInscription";
            this.Load += new System.EventHandler(this.frmInscription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_inscrire;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_idt;
        private System.Windows.Forms.Button btn_switchConnexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton ico_btn_eyes;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btn_fermer;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Button btn_validercode;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.CheckBox cbx_membre;
        private System.Windows.Forms.CheckBox cbx_mbrebureau;
        private System.Windows.Forms.CheckBox cbx_admin;
    }
}