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
    public partial class FormUserLogin : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public FormUserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var data = db.Users.Where(f => f.IdentityCode == textBox1.Text).FirstOrDefault();

            if (data != null)
            {
                Session.userID = data.UserID;
                Session.userName = data.Name;
                new AppContext(new FormUserMain());

                if (this.MdiParent != null)
                {
                    this.MdiParent.Close();
                }
            }
            else
            {
                MessageBox.Show("Kamu belum terdaftar sebagai user");
                return;
            }
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            textBox1.Text = "63729";
        }
    }
}
