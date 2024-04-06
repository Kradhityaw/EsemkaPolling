using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootcampProject1
{
    public partial class UserControlAdmin : UserControl
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();

        FormLogin FormLogin { get; set; }
        public UserControlAdmin()
        {
            InitializeComponent();
            FormLogin = new FormLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = db.Admins.Any(f => f.UserName == textBox1.Text);

            if (data == true)
            {
                new AppContext(new FormAdminMain());
            }
            else
            {
                MessageBox.Show("Kamu Tidak Terdaftar Sebagai Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
