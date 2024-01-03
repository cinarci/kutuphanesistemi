namespace Kutuphane_Projesi
{
    partial class Form1
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
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.bntOduncKitap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKitap
            // 
            this.btnKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitap.Location = new System.Drawing.Point(12, 248);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(283, 55);
            this.btnKitap.TabIndex = 0;
            this.btnKitap.Text = "Kitap İşlemleri";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Location = new System.Drawing.Point(301, 248);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(283, 55);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnTur
            // 
            this.btnTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTur.Location = new System.Drawing.Point(12, 309);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(283, 55);
            this.btnTur.TabIndex = 2;
            this.btnTur.Text = "Tür İşlemleri";
            this.btnTur.UseVisualStyleBackColor = true;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // bntOduncKitap
            // 
            this.bntOduncKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntOduncKitap.Location = new System.Drawing.Point(303, 309);
            this.bntOduncKitap.Name = "bntOduncKitap";
            this.bntOduncKitap.Size = new System.Drawing.Size(283, 55);
            this.bntOduncKitap.TabIndex = 3;
            this.bntOduncKitap.Text = "Ödünç Kitap İşlemleri";
            this.bntOduncKitap.UseVisualStyleBackColor = true;
            this.bntOduncKitap.Click += new System.EventHandler(this.bntOduncKitap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kütüphane Sistemi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntOduncKitap);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button bntOduncKitap;
        private System.Windows.Forms.Label label1;
    }
}

