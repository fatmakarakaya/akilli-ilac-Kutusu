namespace AkilliIlac
{
    partial class frm_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_giris));
            this.lbl_EczId = new System.Windows.Forms.Label();
            this.lbl_Eczsifre = new System.Windows.Forms.Label();
            this.txt_EczaciId = new System.Windows.Forms.TextBox();
            this.txt_Eczacısifre = new System.Windows.Forms.TextBox();
            this.lbl_kullanıcıgiriş = new System.Windows.Forms.Label();
            this.btn_EczGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_EczId
            // 
            this.lbl_EczId.AutoSize = true;
            this.lbl_EczId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_EczId.Location = new System.Drawing.Point(23, 61);
            this.lbl_EczId.Name = "lbl_EczId";
            this.lbl_EczId.Size = new System.Drawing.Size(66, 17);
            this.lbl_EczId.TabIndex = 0;
            this.lbl_EczId.Text = "Eczacı ID";
            // 
            // lbl_Eczsifre
            // 
            this.lbl_Eczsifre.AutoSize = true;
            this.lbl_Eczsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Eczsifre.Location = new System.Drawing.Point(46, 109);
            this.lbl_Eczsifre.Name = "lbl_Eczsifre";
            this.lbl_Eczsifre.Size = new System.Drawing.Size(37, 17);
            this.lbl_Eczsifre.TabIndex = 1;
            this.lbl_Eczsifre.Text = "Şifre";
            // 
            // txt_EczaciId
            // 
            this.txt_EczaciId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_EczaciId.Location = new System.Drawing.Point(95, 55);
            this.txt_EczaciId.Name = "txt_EczaciId";
            this.txt_EczaciId.Size = new System.Drawing.Size(130, 23);
            this.txt_EczaciId.TabIndex = 2;
            // 
            // txt_Eczacısifre
            // 
            this.txt_Eczacısifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Eczacısifre.Location = new System.Drawing.Point(95, 109);
            this.txt_Eczacısifre.Name = "txt_Eczacısifre";
            this.txt_Eczacısifre.Size = new System.Drawing.Size(130, 23);
            this.txt_Eczacısifre.TabIndex = 3;
            this.txt_Eczacısifre.UseSystemPasswordChar = true;
            // 
            // lbl_kullanıcıgiriş
            // 
            this.lbl_kullanıcıgiriş.AutoSize = true;
            this.lbl_kullanıcıgiriş.Font = new System.Drawing.Font("Microsoft YaHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullanıcıgiriş.Location = new System.Drawing.Point(117, 275);
            this.lbl_kullanıcıgiriş.Name = "lbl_kullanıcıgiriş";
            this.lbl_kullanıcıgiriş.Size = new System.Drawing.Size(84, 20);
            this.lbl_kullanıcıgiriş.TabIndex = 4;
            this.lbl_kullanıcıgiriş.Text = "Hasta Girişi";
            this.lbl_kullanıcıgiriş.Click += new System.EventHandler(this.lbl_kullanıcıgiriş_Click);
            // 
            // btn_EczGiris
            // 
            this.btn_EczGiris.BackColor = System.Drawing.Color.White;
            this.btn_EczGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_EczGiris.Location = new System.Drawing.Point(114, 155);
            this.btn_EczGiris.Name = "btn_EczGiris";
            this.btn_EczGiris.Size = new System.Drawing.Size(87, 29);
            this.btn_EczGiris.TabIndex = 5;
            this.btn_EczGiris.Text = "Giriş";
            this.btn_EczGiris.UseVisualStyleBackColor = false;
            this.btn_EczGiris.Click += new System.EventHandler(this.btn_EczGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(317, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_EczGiris);
            this.Controls.Add(this.lbl_kullanıcıgiriş);
            this.Controls.Add(this.txt_Eczacısifre);
            this.Controls.Add(this.txt_EczaciId);
            this.Controls.Add(this.lbl_Eczsifre);
            this.Controls.Add(this.lbl_EczId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_giris";
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EczId;
        private System.Windows.Forms.Label lbl_Eczsifre;
        private System.Windows.Forms.TextBox txt_EczaciId;
        private System.Windows.Forms.TextBox txt_Eczacısifre;
        private System.Windows.Forms.Label lbl_kullanıcıgiriş;
        private System.Windows.Forms.Button btn_EczGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

