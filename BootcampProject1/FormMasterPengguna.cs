using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootcampProject1
{
    public partial class FormMasterPengguna : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public FormMasterPengguna()
        {
            InitializeComponent();
        }

        private void FormMasterPengguna_Load(object sender, EventArgs e)
        {
            identityCodeMaskedTextBox.Enabled = true;
            userBindingSource.Clear();
            userBindingSource.DataSource = db.Users.ToList();
            // Masuk Ke mode create
            bindingSource1.AddNew();
        }

        private void userDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (userDataGridView.Rows[e.RowIndex].DataBoundItem is User user)
            {
                if (e.ColumnIndex == editCol.Index)
                {
                    e.Value = "Edit";
                }
                if (e.ColumnIndex == delCol.Index)
                {
                    e.Value = "Delete";
                }
            }
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userDataGridView.Rows[e.RowIndex].DataBoundItem is User user)
            {
                if (e.ColumnIndex == editCol.Index)
                {
                    // Buat Nanti Ambil Currect nya
                    bindingSource1.DataSource = db.Users.Where(f => f.UserID == user.UserID).AsNoTracking().First();
                    // identity Code Tidak Boleh Diedit
                    identityCodeMaskedTextBox.Enabled = false;
                }
                if (e.ColumnIndex == delCol.Index)
                {
                    if (MessageBox.Show($"Apakah Kamu Yakin Mau Mengapus {user.Name} Dari Daftar?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var data = db.PollResponses.Where(f => f.UserID == user.UserID);

                        // Mengahapus data dari user yang di hapus di poll response
                        db.PollResponses.RemoveRange(data);
                        db.Users.Remove(user);
                        db.SaveChanges();
                        OnLoad(EventArgs.Empty);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Data yang kosong wajib diisi");
                return;
            }

            if (bindingSource1.Current is User user)
            {
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnLoad(EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AppContext(new FormAdminMain());
            Close();
        }
    }
}
