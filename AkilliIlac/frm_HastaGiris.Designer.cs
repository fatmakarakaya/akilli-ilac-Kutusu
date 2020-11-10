namespace AkilliIlac
{
    partial class frm_HastaGiris
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
            this.lbl_hastaId = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_hastaID = new System.Windows.Forms.TextBox();
            this.txt_hasataSifre = new System.Windows.Forms.TextBox();
            this.btn_HastaGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_hastaId
            // 
            this.lbl_hastaId.AutoSize = true;
            this.lbl_hastaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hastaId.Location = new System.Drawing.Point(39, 47);
            this.lbl_hastaId.Name = "lbl_hastaId";
            this.lbl_hastaId.Size = new System.Drawing.Size(62, 17);
            this.lbl_hastaId.TabIndex = 0;
            this.lbl_hastaId.Text = "Hasta ID";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(64, 98);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(37, 17);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre";
            // 
            // txt_hastaID
            // 
            this.txt_hastaID.Location = new System.Drawing.Point(107, 46);
            this.txt_hastaID.Name = "txt_hastaID";
            this.txt_hastaID.Size = new System.Drawing.Size(133, 20);
            this.txt_hastaID.TabIndex = 2;
            // 
            // txt_hasataSifre
            // 
            this.txt_hasataSifre.Location = new System.Drawing.Point(107, 97);
            this.txt_hasataSifre.Name = "txt_hasataSifre";
            this.txt_hasataSifre.Size = new System.Drawing.Size(133, 20);
            this.txt_hasataSifre.TabIndex = 3;
            this.txt_hasataSifre.UseSystemPasswordChar = true;
            // 
            // btn_HastaGiris
            // 
            this.btn_HastaGiris.BackColor = System.Drawing.Color.White;
            this.btn_HastaGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HastaGiris.Location = new System.Drawing.Point(127, 138);
            this.btn_HastaGiris.Name = "btn_HastaGiris";
            this.btn_HastaGiris.Size = new System.Drawing.Size(87, 25);
            this.btn_HastaGiris.TabIndex = 4;
            this.btn_HastaGiris.Text = "Giriş";
            this.btn_HastaGiris.UseVisualStyleBackColor = false;
            this.btn_HastaGiris.Click += new System.EventHandler(this.btn_HastaGiris_Click);
            // 
            // frm_HastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(322, 204);
            this.Controls.Add(this.btn_HastaGiris);
            this.Controls.Add(this.txt_hasataSifre);
            this.Controls.Add(this.txt_hastaID);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_hastaId);
            this.Name = "frm_HastaGiris";
            this.Text = "frm_HastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hastaId;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_hastaID;
        private System.Windows.Forms.TextBox txt_hasataSifre;
        private System.Windows.Forms.Button btn_HastaGiris;
    }
}