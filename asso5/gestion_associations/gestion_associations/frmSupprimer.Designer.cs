
namespace gestion_associations
{
    partial class frmSupprimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_retour = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.btn_confirm_supp = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Êtes vous sûr de vouloir supprimer cette étudiant ?";
            // 
            // btn_retour
            // 
            this.btn_retour.BackColor = System.Drawing.Color.White;
            this.btn_retour.FlatAppearance.BorderSize = 0;
            this.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_retour.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_retour.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_retour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_retour.IconSize = 40;
            this.btn_retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_retour.Location = new System.Drawing.Point(13, 316);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(187, 60);
            this.btn_retour.TabIndex = 3;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = false;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.Location = new System.Drawing.Point(992, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_confirm_supp
            // 
            this.btn_confirm_supp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_confirm_supp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm_supp.FlatAppearance.BorderSize = 0;
            this.btn_confirm_supp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm_supp.ForeColor = System.Drawing.Color.White;
            this.btn_confirm_supp.Location = new System.Drawing.Point(338, 202);
            this.btn_confirm_supp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirm_supp.Name = "btn_confirm_supp";
            this.btn_confirm_supp.Size = new System.Drawing.Size(119, 30);
            this.btn_confirm_supp.TabIndex = 16;
            this.btn_confirm_supp.Text = "Supprimer";
            this.btn_confirm_supp.UseVisualStyleBackColor = false;
            this.btn_confirm_supp.Click += new System.EventHandler(this.btn_confirm_supp_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.White;
            this.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_annuler.Location = new System.Drawing.Point(230, 202);
            this.btn_annuler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(100, 30);
            this.btn_annuler.TabIndex = 15;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(601, -1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 17;
            this.iconButton1.Text = "X";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 389);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_confirm_supp);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSupprimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupprimer";
            this.Load += new System.EventHandler(this.frmSupprimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_retour;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Button btn_confirm_supp;
        private System.Windows.Forms.Button btn_annuler;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}