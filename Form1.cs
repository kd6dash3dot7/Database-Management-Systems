using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSQL
{
    public partial class KutuphaneArayuz : Form
    {
        public KutuphaneArayuz()
        {
            InitializeComponent();
        }

        private void KutuphaneArayuz_Load(object sender, EventArgs e)
        {

        }

        private void btnUyeIslem_Click(object sender, EventArgs e)
        {
            UyeIslem frm = new UyeIslem();
            frm.ShowDialog();
        }

        private void btnKitapIslem_Click(object sender, EventArgs e)
        {
            KitapIslemleri frm = new KitapIslemleri();
            frm.ShowDialog();
        }

        private void btnOduncIslem_Click(object sender, EventArgs e)
        {
            OduncIslemleri frm = new OduncIslemleri();
            frm.ShowDialog();
        }
    }
}
