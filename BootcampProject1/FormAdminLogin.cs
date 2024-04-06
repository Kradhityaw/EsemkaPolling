using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BootcampProject1
{
    public partial class FormAdminLogin : Form
    {
        // Db Context
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        // Buat Fungsi Untuk Generate MD5
        private string getMD5(string hash)
        {
            using (MD5 sha = MD5.Create())
            {
                byte[] inputbyte = Encoding.UTF8.GetBytes(hash);
                byte[] hashbyte = sha.ComputeHash(inputbyte);

                return BitConverter.ToString(hashbyte).Replace("-", "").ToLower();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Convert TextBoxt Input Ke MD5
            var hashes = getMD5(textBox2.Text);

            // Mecocokkan data dari textboxt
            var data = db.Admins.Where(f => f.UserName == textBox1.Text && f.Password == hashes).FirstOrDefault();

            if (data != null)
            {
                if (this.MdiParent != null)
                {
                    // Mengambil Nama Admin
                    Session.AdminName = data.UserName;
                    // Mengambil ID admin
                    Session.AdminID = data.AdminID;
                    new AppContext(new FormAdminMain());
                    // Menutup MDI PARENT nya
                    this.MdiParent.Close();
                }
            }
            else
            {
                MessageBox.Show("Kamu tidak terdaftar sebagai admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {
            textBox1.Text = "admin1";
            textBox2.Text = "admin1";
        }
    }
}
