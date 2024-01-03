namespace Kutuphane_Projesi
{
    partial class formOduncKitap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboKitapAdi = new System.Windows.Forms.ComboBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOduncArama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.gridOdunc = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdunc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboKitapAdi);
            this.groupBox1.Controls.Add(this.txtOgrenciNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Girişi";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(416, 33);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(242, 44);
            this.txtAciklama.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama : ";
            // 
            // comboKitapAdi
            // 
            this.comboKitapAdi.FormattingEnabled = true;
            this.comboKitapAdi.Location = new System.Drawing.Point(103, 56);
            this.comboKitapAdi.Name = "comboKitapAdi";
            this.comboKitapAdi.Size = new System.Drawing.Size(144, 21);
            this.comboKitapAdi.TabIndex = 3;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(103, 30);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(144, 20);
            this.txtOgrenciNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOduncArama);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Kitap Alma";
            // 
            // txtOduncArama
            // 
            this.txtOduncArama.Location = new System.Drawing.Point(127, 33);
            this.txtOduncArama.Name = "txtOduncArama";
            this.txtOduncArama.Size = new System.Drawing.Size(144, 20);
            this.txtOduncArama.TabIndex = 4;
            this.txtOduncArama.TextChanged += new System.EventHandler(this.txtOduncArama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğrenci Adı :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapAl);
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btnKitapVer);
            this.groupBox3.Location = new System.Drawing.Point(356, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Location = new System.Drawing.Point(209, 26);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(87, 23);
            this.btnKitapAl.TabIndex = 2;
            this.btnKitapAl.Text = "Kitap Al";
            this.btnKitapAl.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(116, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.Location = new System.Drawing.Point(23, 26);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(87, 23);
            this.btnKitapVer.TabIndex = 0;
            this.btnKitapVer.Text = "Kitap Ver";
            this.btnKitapVer.UseVisualStyleBackColor = true;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKitapVer_Click);
            // 
            // gridOdunc
            // 
            this.gridOdunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOdunc.Location = new System.Drawing.Point(12, 197);
            this.gridOdunc.Name = "gridOdunc";
            this.gridOdunc.Size = new System.Drawing.Size(671, 241);
            this.gridOdunc.TabIndex = 3;
            this.gridOdunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOdunc_CellClick);
            // 
            // formOduncKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.gridOdunc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formOduncKitap";
            this.Text = "Ödünç İşlemleri";
            this.Load += new System.EventHandler(this.formOduncKitap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOdunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboKitapAdi;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOduncArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.DataGridView gridOdunc;
    }
}