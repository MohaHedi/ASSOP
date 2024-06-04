
namespace gestion_associations
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_idt = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.btn_switchInscription = new System.Windows.Forms.Button();
            this.txt_idt = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.btn_SeConnecter = new System.Windows.Forms.Button();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.ico_btn_eyes = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(591, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";
            // 
            // lbl_idt
            // 
            this.lbl_idt.AutoSize = true;
            this.lbl_idt.Location = new System.Drawing.Point(626, 219);
            this.lbl_idt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idt.Name = "lbl_idt";
            this.lbl_idt.Size = new System.Drawing.Size(73, 17);
            this.lbl_idt.TabIndex = 1;
            this.lbl_idt.Text = "Identifiant";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(626, 294);
            this.lbl_mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(90, 17);
            this.lbl_mdp.TabIndex = 2;
            this.lbl_mdp.Text = "Mot de passe";
            // 
            // btn_switchInscription
            // 
            this.btn_switchInscription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_switchInscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_switchInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_switchInscription.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_switchInscription.Location = new System.Drawing.Point(754, 418);
            this.btn_switchInscription.Margin = new System.Windows.Forms.Padding(4);
            this.btn_switchInscription.Name = "btn_switchInscription";
            this.btn_switchInscription.Size = new System.Drawing.Size(100, 30);
            this.btn_switchInscription.TabIndex = 3;
            this.btn_switchInscription.Text = "Inscription";
            this.btn_switchInscription.UseVisualStyleBackColor = false;
            this.btn_switchInscription.Click += new System.EventHandler(this.btn_switchInscription_Click);
            // 
            // txt_idt
            // 
            this.txt_idt.BackColor = System.Drawing.Color.White;
            this.txt_idt.Location = new System.Drawing.Point(629, 240);
            this.txt_idt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idt.Name = "txt_idt";
            this.txt_idt.Size = new System.Drawing.Size(132, 25);
            this.txt_idt.TabIndex = 6;
            // 
            // txt_mdp
            // 
            this.txt_mdp.BackColor = System.Drawing.Color.White;
            this.txt_mdp.Location = new System.Drawing.Point(629, 315);
            this.txt_mdp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.Size = new System.Drawing.Size(132, 25);
            this.txt_mdp.TabIndex = 7;
            // 
            // btn_SeConnecter
            // 
            this.btn_SeConnecter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_SeConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SeConnecter.FlatAppearance.BorderSize = 0;
            this.btn_SeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeConnecter.ForeColor = System.Drawing.Color.White;
            this.btn_SeConnecter.Location = new System.Drawing.Point(862, 418);
            this.btn_SeConnecter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SeConnecter.Name = "btn_SeConnecter";
            this.btn_SeConnecter.Size = new System.Drawing.Size(119, 30);
            this.btn_SeConnecter.TabIndex = 8;
            this.btn_SeConnecter.Text = "Se connecter";
            this.btn_SeConnecter.UseVisualStyleBackColor = false;
            this.btn_SeConnecter.Click += new System.EventHandler(this.btn_SeConnecter_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.Location = new System.Drawing.Point(1012, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 612);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(274, 260);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(282, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "ASSOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(274, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 15;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
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
            this.ico_btn_eyes.Location = new System.Drawing.Point(768, 315);
            this.ico_btn_eyes.Name = "ico_btn_eyes";
            this.ico_btn_eyes.Size = new System.Drawing.Size(35, 24);
            this.ico_btn_eyes.TabIndex = 15;
            this.ico_btn_eyes.UseVisualStyleBackColor = true;
            this.ico_btn_eyes.Click += new System.EventHandler(this.ico_btn_eyes_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(586, 235);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(36, 33);
            this.iconButton2.TabIndex = 33;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(586, 307);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 38);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1086, 612);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ico_btn_eyes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_SeConnecter);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_idt);
            this.Controls.Add(this.btn_switchInscription);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_idt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConnexion";
            this.Load += new System.EventHandler(this.frmConnexion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_idt;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Button btn_switchInscription;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.TextBox txt_idt;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Button btn_SeConnecter;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton ico_btn_eyes;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

