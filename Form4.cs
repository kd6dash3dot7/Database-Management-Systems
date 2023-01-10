﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace KutuphaneSQL
{
    public partial class OduncIslemleri : Form
    {
        public OduncIslemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=Kutuphane;user ID=postgres;password=2201");
        void griddoldur()
        {
            string sorgu = "select * from tbodunc";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void OduncIslemleri_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (txtOalma.Text == "" || txtOverme.Text == "" || txtOuye.Text == "" || txtOkitap.Text == "")
            {
                MessageBox.Show("lütfen tüm alanları doldurunuz !!");

            }
            else
            {
                baglanti.Open();

                string kod = "INSERT INTO tbodunc (kitap,uye,\"oduncAlmaTarihi\",\"geriVermeTarihi\") VALUES (@p1,@p2,@p3,@p4)";

                NpgsqlCommand komut = new NpgsqlCommand(kod, baglanti);

                komut.Parameters.AddWithValue("@p1", int.Parse(txtOkitap.Text));
                komut.Parameters.AddWithValue("@p2", int.Parse(txtOuye.Text));
                komut.Parameters.AddWithValue("@p3", DateTime.Parse(txtOalma.Text));
                komut.Parameters.AddWithValue("@p4", DateTime.Parse(txtOverme.Text));


                komut.ExecuteNonQuery();

                baglanti.Close();


                MessageBox.Show("ekleme başarılı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from tbodunc";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnOduncGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kod = "update tbodunc set kitap = @p1 , uye = @p2 , \"oduncAlmaTarihi\" = @p3, \"geriVermeTarihi\" = @p4 where \"oduncNo\" = @p5";

            NpgsqlCommand komut = new NpgsqlCommand(kod, baglanti);

            komut.Parameters.AddWithValue("@p1", int.Parse(txtOkitap.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(txtOuye.Text));
            komut.Parameters.AddWithValue("@p3", DateTime.Parse(txtOalma.Text));
            komut.Parameters.AddWithValue("@p4", DateTime.Parse(txtOverme.Text));
            komut.Parameters.AddWithValue("@p5", int.Parse(txtOid.Text));


            komut.ExecuteNonQuery();
            MessageBox.Show("güncelleme başarılı");
            baglanti.Close();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kod = "delete from tbodunc where \"oduncNo\" = @p1 ";

            NpgsqlCommand komut = new NpgsqlCommand(kod, baglanti);

            komut.Parameters.AddWithValue("@p1", int.Parse(txtOid.Text));

            komut.ExecuteNonQuery();

            MessageBox.Show("silme başarılı");
            baglanti.Close();
        }
    }
}
