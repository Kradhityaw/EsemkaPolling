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
    public partial class FormUserMain : Form
    {
        public FormUserMain()
        {
            InitializeComponent();
        }

        private void FormUserMain_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome, {Session.userName}";
            label3.Text = $"Sekarang Hari {DateTime.Now.ToString("dddd, dd-MM-yyyy", new CultureInfo("id-ID"))}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AppContext(new FormUserPemungutan());
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AppContext(new FormLaporanUser());
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu yakin mau Log Out?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new AppContext(new FormLogin());
                Close();
            }
        }
    }
}
