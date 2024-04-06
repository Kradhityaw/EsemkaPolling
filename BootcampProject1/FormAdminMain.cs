using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootcampProject1
{
    public partial class FormAdminMain : Form
    {
        public FormAdminMain()
        {
            InitializeComponent();
        }

        // Fungsi Buat LogOut
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu yakin mau Log Out?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new AppContext(new FormLogin());
                Close();
            }
        }

        private void FormAdminMain_Load(object sender, EventArgs e)
        {
            // Menampilkan nama admin
            label1.Text = $"Welcome, {Session.AdminName}";

            // Menampilkan hari sekarang dengan bahasa indonesia
            label3.Text = $"Sekarang Hari {DateTime.Now.ToString("dddd, dd-MM-yyyy", new CultureInfo("id-ID"))}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buka form pemungutan
            new AppContext(new FormPemungutan());
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Buka form master pengguna
            new AppContext(new FormMasterPengguna());
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Buka form laporan admin
            new AppContext(new FormLaporanAdmin());
            Close();
        }
    }
}
