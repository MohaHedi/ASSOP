
namespace gestion_associations
{
    partial class frmPromo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_valider = new FontAwesome.Sharp.IconButton();
            this.dtp_promotion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_valider
            // 
            this.btn_valider.FlatAppearance.BorderSize = 0;
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_valider.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_valider.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_valider.IconSize = 25;
            this.btn_valider.Location = new System.Drawing.Point(460, 83);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(30, 28);
            this.btn_valider.TabIndex = 36;
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // dtp_promotion
            // 
            this.dtp_promotion.CustomFormat = "yyyy";
            this.dtp_promotion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_promotion.Location = new System.Drawing.Point(391, 86);
            this.dtp_promotion.Name = "dtp_promotion";
            this.dtp_promotion.Size = new System.Drawing.Size(63, 20);
            this.dtp_promotion.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Promotion :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = " ";
            // 
            // frmPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.dtp_promotion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPromo";
            this.Text = "frmPromo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btn_valider;
        private System.Windows.Forms.DateTimePicker dtp_promotion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}