
namespace KutuphaneSQL
{
    partial class OduncIslemleri
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOkitap = new System.Windows.Forms.TextBox();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.txtOuye = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOalma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOverme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOduncListele = new System.Windows.Forms.Button();
            this.btnOduncGuncelle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(351, 12);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(819, 336);
            this.dataGridView4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(108, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID:";
            // 
            // txtOkitap
            // 
            this.txtOkitap.Location = new System.Drawing.Point(207, 26);
            this.txtOkitap.Name = "txtOkitap";
            this.txtOkitap.Size = new System.Drawing.Size(100, 22);
            this.txtOkitap.TabIndex = 2;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.Location = new System.Drawing.Point(120, 390);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(136, 60);
            this.btnOduncVer.TabIndex = 3;
            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.UseVisualStyleBackColor = true;
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // txtOuye
            // 
            this.txtOuye.Location = new System.Drawing.Point(207, 91);
            this.txtOuye.Name = "txtOuye";
            this.txtOuye.Size = new System.Drawing.Size(100, 22);
            this.txtOuye.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(116, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üye ID:";
            // 
            // txtOalma
            // 
            this.txtOalma.Location = new System.Drawing.Point(207, 147);
            this.txtOalma.Name = "txtOalma";
            this.txtOalma.Size = new System.Drawing.Size(100, 22);
            this.txtOalma.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ödünç Alma Tarihi:";
            // 
            // txtOverme
            // 
            this.txtOverme.Location = new System.Drawing.Point(207, 207);
            this.txtOverme.Name = "txtOverme";
            this.txtOverme.Size = new System.Drawing.Size(100, 22);
            this.txtOverme.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Geri Verme Tarihi:";
            // 
            // btnOduncListele
            // 
            this.btnOduncListele.Location = new System.Drawing.Point(331, 390);
            this.btnOduncListele.Name = "btnOduncListele";
            this.btnOduncListele.Size = new System.Drawing.Size(136, 60);
            this.btnOduncListele.TabIndex = 10;
            this.btnOduncListele.Text = "Listele";
            this.btnOduncListele.UseVisualStyleBackColor = true;
            this.btnOduncListele.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOduncGuncelle
            // 
            this.btnOduncGuncelle.Location = new System.Drawing.Point(544, 390);
            this.btnOduncGuncelle.Name = "btnOduncGuncelle";
            this.btnOduncGuncelle.Size = new System.Drawing.Size(136, 60);
            this.btnOduncGuncelle.TabIndex = 11;
            this.btnOduncGuncelle.Text = "Güncelle";
            this.btnOduncGuncelle.UseVisualStyleBackColor = true;
            this.btnOduncGuncelle.Click += new System.EventHandler(this.btnOduncGuncelle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(758, 390);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(136, 60);
            this.btnKayitSil.TabIndex = 12;
            this.btnKayitSil.Text = "Kayıt Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // txtOid
            // 
            this.txtOid.Location = new System.Drawing.Point(1070, 479);
            this.txtOid.Name = "txtOid";
            this.txtOid.Size = new System.Drawing.Size(100, 22);
            this.txtOid.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(902, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "İşlem yapılacak IDyi giriniz:";
            // 
            // OduncIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 529);
            this.Controls.Add(this.txtOid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnOduncGuncelle);
            this.Controls.Add(this.btnOduncListele);
            this.Controls.Add(this.txtOverme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOalma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOuye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOduncVer);
            this.Controls.Add(this.txtOkitap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Name = "OduncIslemleri";
            this.Text = "Ödünç İşlemleri";
            this.Load += new System.EventHandler(this.OduncIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOkitap;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.TextBox txtOuye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOalma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOverme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOduncListele;
        private System.Windows.Forms.Button btnOduncGuncelle;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.Label label5;
    }
}