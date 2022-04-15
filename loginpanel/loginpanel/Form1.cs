using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginpanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbKullaniciAdi.Text=="admin"&&tbSifre.Text=="12345")
            {
                MessageBox.Show("Giriş Başarılı..","Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı","HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
