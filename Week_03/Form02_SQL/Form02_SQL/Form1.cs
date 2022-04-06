using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form02_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=DESKTOP-5JA1DBH; Database=Sirket50; User=sa; Pwd=123";
                //ÜStteki satır SQL Server Authentication için kullanılır.
                //baglanti.ConnectionString = @"Server=DESKTOP-5JA1DBH; Database=Sirket50; Trusted_Connection=true";
                //ÜStteki satır Windows Authentication için kullanılır.

                baglanti.Open();
                //işlemler
                baglanti.Close();
                MessageBox.Show("Bağlantı başarılı");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Olmadı yar, su testisine dolmadı yar");
                //throw;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
