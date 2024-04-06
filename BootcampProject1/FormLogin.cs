using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootcampProject1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Fungsi Buat Menampilkan MDI
        void addMDi(Form f)
        {
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            f.ControlBox = false;
        }

        // Fungsi Supaya MDI tidak Numpuk
        void clearMdi()
        {
            this.ActiveMdiChild?.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormAdminLogin form = new FormAdminLogin();
            //form.ShowDialog();
            //Close();

            clearMdi();
            addMDi(new FormAdminLogin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormUserLogin form = new FormUserLogin();
            ////this.Hide(); 
            //form.ShowDialog();

            //UserControlUser login = new UserControlUser();
            ////loadUserControl(login);
            clearMdi();
            addMDi(new FormUserLogin());
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms.Count == 0)
            //{
            //    Application.Exit();
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AppContext(new Form1());
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Agar Tidak kosongan
        private void FormLogin_Load(object sender, EventArgs e)
        {
            clearMdi();
            addMDi(new FormUserLogin());
        }
    }
}
