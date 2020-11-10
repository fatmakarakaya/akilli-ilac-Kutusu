using System;

namespace AkilliIlac
{
    partial class EczaciSayfasi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EczaciSayfasi));
            this.akilliIlacKutusuDataSet = new AkilliIlac.AkilliIlacKutusuDataSet();
            this.akilliIlacKutusuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rctekle = new System.Windows.Forms.Button();
            this.btn_hstekle = new System.Windows.Forms.Button();
            this.btn_rct = new System.Windows.Forms.Button();
            this.btn_ilaclar = new System.Windows.Forms.Button();
            this.btn_hastalar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.akilliIlacKutusuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akilliIlacKutusuDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // akilliIlacKutusuDataSet
            // 
            this.akilliIlacKutusuDataSet.DataSetName = "AkilliIlacKutusuDataSet";
            this.akilliIlacKutusuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akilliIlacKutusuDataSetBindingSource
            // 
            this.akilliIlacKutusuDataSetBindingSource.DataSource = this.akilliIlacKutusuDataSet;
            this.akilliIlacKutusuDataSetBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_rctekle);
            this.panel1.Controls.Add(this.btn_hstekle);
            this.panel1.Controls.Add(this.btn_rct);
            this.panel1.Controls.Add(this.btn_ilaclar);
            this.panel1.Controls.Add(this.btn_hastalar);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 564);
            this.panel1.TabIndex = 0;
            // 
            // btn_rctekle
            // 
            this.btn_rctekle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rctekle.Location = new System.Drawing.Point(6, 365);
            this.btn_rctekle.Name = "btn_rctekle";
            this.btn_rctekle.Size = new System.Drawing.Size(120, 57);
            this.btn_rctekle.TabIndex = 3;
            this.btn_rctekle.Text = "Reçete Ekle";
            this.btn_rctekle.UseVisualStyleBackColor = false;
            this.btn_rctekle.Click += new System.EventHandler(this.btn_rctekle_Click);
            // 
            // btn_hstekle
            // 
            this.btn_hstekle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_hstekle.Location = new System.Drawing.Point(6, 283);
            this.btn_hstekle.Name = "btn_hstekle";
            this.btn_hstekle.Size = new System.Drawing.Size(120, 57);
            this.btn_hstekle.TabIndex = 2;
            this.btn_hstekle.Text = "Hasta Ekle";
            this.btn_hstekle.UseVisualStyleBackColor = false;
            this.btn_hstekle.Click += new System.EventHandler(this.btn_hstekle_Click);
            // 
            // btn_rct
            // 
            this.btn_rct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rct.Location = new System.Drawing.Point(6, 192);
            this.btn_rct.Name = "btn_rct";
            this.btn_rct.Size = new System.Drawing.Size(120, 57);
            this.btn_rct.TabIndex = 2;
            this.btn_rct.Text = "Reçete";
            this.btn_rct.UseVisualStyleBackColor = false;
            this.btn_rct.Click += new System.EventHandler(this.btn_rct_Click);
            // 
            // btn_ilaclar
            // 
            this.btn_ilaclar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ilaclar.Location = new System.Drawing.Point(6, 110);
            this.btn_ilaclar.Name = "btn_ilaclar";
            this.btn_ilaclar.Size = new System.Drawing.Size(120, 57);
            this.btn_ilaclar.TabIndex = 1;
            this.btn_ilaclar.Text = "İlaçlar";
            this.btn_ilaclar.UseVisualStyleBackColor = false;
            this.btn_ilaclar.Click += new System.EventHandler(this.btn_ilaclar_Click);
            // 
            // btn_hastalar
            // 
            this.btn_hastalar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_hastalar.Location = new System.Drawing.Point(6, 29);
            this.btn_hastalar.Name = "btn_hastalar";
            this.btn_hastalar.Size = new System.Drawing.Size(120, 57);
            this.btn_hastalar.TabIndex = 0;
            this.btn_hastalar.Text = "Hastalar";
            this.btn_hastalar.UseVisualStyleBackColor = false;
            this.btn_hastalar.Click += new System.EventHandler(this.btn_hastalar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 564);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(6, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(6, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "İlaç Kutusu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EczaciSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(807, 574);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EczaciSayfasi";
            this.Text = "Eczaci Sayfasi";
            this.Load += new System.EventHandler(this.EczaciSayfasi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.akilliIlacKutusuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akilliIlacKutusuDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource akilliIlacKutusuDataSetBindingSource;
        private AkilliIlacKutusuDataSet akilliIlacKutusuDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_hstekle;
        private System.Windows.Forms.Button btn_rct;
        private System.Windows.Forms.Button btn_ilaclar;
        private System.Windows.Forms.Button btn_hastalar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private readonly EventHandler EczaciSayfasi_Load;
        private System.Windows.Forms.Button btn_rctekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}