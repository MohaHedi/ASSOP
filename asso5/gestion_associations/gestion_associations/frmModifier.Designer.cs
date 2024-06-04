
namespace gestion_associations
{
    partial class frmModifier
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
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_promo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_spebts = new System.Windows.Forms.TextBox();
            this.dateTimePicker_sortiebts = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateentrebts = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ddn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_anneebac = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_spe = new System.Windows.Forms.TextBox();
            this.txt_lycee = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.Label();
            this.btn_retour = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cbx_rang = new System.Windows.Forms.CheckBox();
            this.lbl_rang = new System.Windows.Forms.Label();
            this.txt_rang = new System.Windows.Forms.TextBox();
            this.dateTimePicker_obtbts = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateobt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.Location = new System.Drawing.Point(1014, -3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(924, 554);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(119, 30);
            this.btn_modifier.TabIndex = 34;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(417, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(388, 40);
            this.label14.TabIndex = 35;
            this.label14.Text = "Modification d\'un étudiant";
            // 
            // dtp_promo
            // 
            this.dtp_promo.CustomFormat = "yyyy";
            this.dtp_promo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_promo.Location = new System.Drawing.Point(830, 265);
            this.dtp_promo.Name = "dtp_promo";
            this.dtp_promo.Size = new System.Drawing.Size(62, 25);
            this.dtp_promo.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Promotion";
            // 
            // txt_spebts
            // 
            this.txt_spebts.Location = new System.Drawing.Point(830, 305);
            this.txt_spebts.Name = "txt_spebts";
            this.txt_spebts.Size = new System.Drawing.Size(100, 25);
            this.txt_spebts.TabIndex = 62;
            // 
            // dateTimePicker_sortiebts
            // 
            this.dateTimePicker_sortiebts.Location = new System.Drawing.Point(830, 387);
            this.dateTimePicker_sortiebts.Name = "dateTimePicker_sortiebts";
            this.dateTimePicker_sortiebts.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_sortiebts.TabIndex = 61;
            // 
            // dateTimePicker_dateentrebts
            // 
            this.dateTimePicker_dateentrebts.Location = new System.Drawing.Point(830, 343);
            this.dateTimePicker_dateentrebts.Name = "dateTimePicker_dateentrebts";
            this.dateTimePicker_dateentrebts.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_dateentrebts.TabIndex = 60;
            // 
            // dateTimePicker_ddn
            // 
            this.dateTimePicker_ddn.Location = new System.Drawing.Point(446, 377);
            this.dateTimePicker_ddn.Name = "dateTimePicker_ddn";
            this.dateTimePicker_ddn.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_ddn.TabIndex = 59;
            // 
            // dateTimePicker_anneebac
            // 
            this.dateTimePicker_anneebac.CustomFormat = "yyyy";
            this.dateTimePicker_anneebac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_anneebac.Location = new System.Drawing.Point(830, 225);
            this.dateTimePicker_anneebac.Name = "dateTimePicker_anneebac";
            this.dateTimePicker_anneebac.Size = new System.Drawing.Size(62, 25);
            this.dateTimePicker_anneebac.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(671, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Annee obtention BAC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(714, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Spécialité BTS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Date de naissance";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(446, 294);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 25);
            this.txt_num.TabIndex = 52;
            // 
            // txt_spe
            // 
            this.txt_spe.Location = new System.Drawing.Point(830, 188);
            this.txt_spe.Name = "txt_spe";
            this.txt_spe.Size = new System.Drawing.Size(100, 25);
            this.txt_spe.TabIndex = 51;
            this.txt_spe.TextChanged += new System.EventHandler(this.txt_spe_TextChanged);
            // 
            // txt_lycee
            // 
            this.txt_lycee.Location = new System.Drawing.Point(446, 418);
            this.txt_lycee.Name = "txt_lycee";
            this.txt_lycee.Size = new System.Drawing.Size(100, 25);
            this.txt_lycee.TabIndex = 50;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(446, 334);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 25);
            this.txt_email.TabIndex = 49;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(446, 254);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 25);
            this.txt_prenom.TabIndex = 48;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(446, 218);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 25);
            this.txt_nom.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(705, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Date sortie BTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Date d\'entré BTS ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Spécialité Bac";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Lycée d\'origine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nom";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(391, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 17);
            this.label15.TabIndex = 65;
            this.label15.Text = "ID";
            // 
            // txt_Id
            // 
            this.txt_Id.AutoSize = true;
            this.txt_Id.Location = new System.Drawing.Point(463, 191);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(0, 17);
            this.txt_Id.TabIndex = 66;
            // 
            // btn_retour
            // 
            this.btn_retour.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_retour.FlatAppearance.BorderSize = 0;
            this.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retour.ForeColor = System.Drawing.Color.White;
            this.btn_retour.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_retour.IconColor = System.Drawing.Color.White;
            this.btn_retour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_retour.IconSize = 40;
            this.btn_retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_retour.Location = new System.Drawing.Point(13, 539);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(187, 60);
            this.btn_retour.TabIndex = 2;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = false;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_retour);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 613);
            this.panel1.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(333, 455);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 17);
            this.label16.TabIndex = 72;
            this.label16.Text = "Avez vous obtenu le BTS ?";
            // 
            // cbx_rang
            // 
            this.cbx_rang.AutoSize = true;
            this.cbx_rang.Location = new System.Drawing.Point(508, 454);
            this.cbx_rang.Name = "cbx_rang";
            this.cbx_rang.Size = new System.Drawing.Size(53, 21);
            this.cbx_rang.TabIndex = 71;
            this.cbx_rang.Text = "Oui ";
            this.cbx_rang.UseVisualStyleBackColor = true;
            this.cbx_rang.CheckedChanged += new System.EventHandler(this.cbx_rang_CheckedChanged);
            // 
            // lbl_rang
            // 
            this.lbl_rang.AutoSize = true;
            this.lbl_rang.Location = new System.Drawing.Point(358, 493);
            this.lbl_rang.Name = "lbl_rang";
            this.lbl_rang.Size = new System.Drawing.Size(39, 17);
            this.lbl_rang.TabIndex = 70;
            this.lbl_rang.Text = "Rang";
            this.lbl_rang.Visible = false;
            // 
            // txt_rang
            // 
            this.txt_rang.Location = new System.Drawing.Point(424, 493);
            this.txt_rang.Name = "txt_rang";
            this.txt_rang.Size = new System.Drawing.Size(100, 25);
            this.txt_rang.TabIndex = 69;
            this.txt_rang.Visible = false;
            // 
            // dateTimePicker_obtbts
            // 
            this.dateTimePicker_obtbts.Location = new System.Drawing.Point(433, 537);
            this.dateTimePicker_obtbts.Name = "dateTimePicker_obtbts";
            this.dateTimePicker_obtbts.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_obtbts.TabIndex = 68;
            this.dateTimePicker_obtbts.Visible = false;
            // 
            // lbl_dateobt
            // 
            this.lbl_dateobt.AutoSize = true;
            this.lbl_dateobt.Location = new System.Drawing.Point(297, 543);
            this.lbl_dateobt.Name = "lbl_dateobt";
            this.lbl_dateobt.Size = new System.Drawing.Size(128, 17);
            this.lbl_dateobt.TabIndex = 67;
            this.lbl_dateobt.Text = "Date obtention BTS";
            this.lbl_dateobt.Visible = false;
            // 
            // frmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 612);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbx_rang);
            this.Controls.Add(this.lbl_rang);
            this.Controls.Add(this.txt_rang);
            this.Controls.Add(this.dateTimePicker_obtbts);
            this.Controls.Add(this.lbl_dateobt);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtp_promo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_spebts);
            this.Controls.Add(this.dateTimePicker_sortiebts);
            this.Controls.Add(this.dateTimePicker_dateentrebts);
            this.Controls.Add(this.dateTimePicker_ddn);
            this.Controls.Add(this.dateTimePicker_anneebac);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.txt_spe);
            this.Controls.Add(this.txt_lycee);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifier";
            this.Load += new System.EventHandler(this.frmModifier_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_promo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_spebts;
        private System.Windows.Forms.DateTimePicker dateTimePicker_sortiebts;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateentrebts;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ddn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_anneebac;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_spe;
        private System.Windows.Forms.TextBox txt_lycee;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txt_Id;
        private FontAwesome.Sharp.IconButton btn_retour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbx_rang;
        private System.Windows.Forms.Label lbl_rang;
        private System.Windows.Forms.TextBox txt_rang;
        private System.Windows.Forms.DateTimePicker dateTimePicker_obtbts;
        private System.Windows.Forms.Label lbl_dateobt;
    }
}