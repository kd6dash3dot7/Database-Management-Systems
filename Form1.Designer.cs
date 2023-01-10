
namespace KutuphaneSQL
{
    partial class KutuphaneArayuz
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnUyeIslem = new System.Windows.Forms.Button();
            this.btnKitapIslem = new System.Windows.Forms.Button();
            this.btnOduncIslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUyeIslem
            // 
            this.btnUyeIslem.Location = new System.Drawing.Point(116, 142);
            this.btnUyeIslem.Name = "btnUyeIslem";
            this.btnUyeIslem.Size = new System.Drawing.Size(140, 68);
            this.btnUyeIslem.TabIndex = 0;
            this.btnUyeIslem.Text = "Üye İşlemleri";
            this.btnUyeIslem.UseVisualStyleBackColor = true;
            this.btnUyeIslem.Click += new System.EventHandler(this.btnUyeIslem_Click);
            // 
            // btnKitapIslem
            // 
            this.btnKitapIslem.Location = new System.Drawing.Point(342, 142);
            this.btnKitapIslem.Name = "btnKitapIslem";
            this.btnKitapIslem.Size = new System.Drawing.Size(140, 68);
            this.btnKitapIslem.TabIndex = 1;
            this.btnKitapIslem.Text = "Kitap İşlemleri";
            this.btnKitapIslem.UseVisualStyleBackColor = true;
            this.btnKitapIslem.Click += new System.EventHandler(this.btnKitapIslem_Click);
            // 
            // btnOduncIslem
            // 
            this.btnOduncIslem.Location = new System.Drawing.Point(556, 142);
            this.btnOduncIslem.Name = "btnOduncIslem";
            this.btnOduncIslem.Size = new System.Drawing.Size(140, 68);
            this.btnOduncIslem.TabIndex = 2;
            this.btnOduncIslem.Text = "Ödünç İşlemleri";
            this.btnOduncIslem.UseVisualStyleBackColor = true;
            this.btnOduncIslem.Click += new System.EventHandler(this.btnOduncIslem_Click);
            // 
            // KutuphaneArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOduncIslem);
            this.Controls.Add(this.btnKitapIslem);
            this.Controls.Add(this.btnUyeIslem);
            this.Name = "KutuphaneArayuz";
            this.Text = "Kütüphane Arayüzü";
            this.Load += new System.EventHandler(this.KutuphaneArayuz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnUyeIslem;
        private System.Windows.Forms.Button btnKitapIslem;
        private System.Windows.Forms.Button btnOduncIslem;
    }
}

