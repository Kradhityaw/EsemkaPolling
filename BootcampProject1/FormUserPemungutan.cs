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
    public partial class FormUserPemungutan : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public FormUserPemungutan()
        {
            InitializeComponent();
        }

        private void FormUserPemungutan_Load(object sender, EventArgs e)
        {
            var data = db.Polls.AsQueryable();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                data = data.Where(f => f.Question.Contains(textBox1.Text));
            }

            pollBindingSource.DataSource = data.Where(f => f.IsClosed == false).ToList();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var data = db.Polls.AsQueryable();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                data = data.Where(f => f.Question.Contains(textBox1.Text));
            }

            pollBindingSource.DataSource = data.Where(f => f.IsClosed == false).ToList();
        }

        private void pollDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (pollDataGridView.Rows[e.RowIndex].DataBoundItem is Poll poll)
            {
                if (e.ColumnIndex == voteCol.Index)
                {
                    e.Value = "Ikuti Polling";
                }
                if (e.ColumnIndex == iscloseCol.Index)
                {
                    if (poll.IsClosed == true)
                    {
                        e.Value = "Telah Berakhir";
                    }
                    else
                    {
                        e.Value = "Sedang Berlangsung";
                    }
                }
            }
        }

        private void pollDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pollDataGridView.Rows[e.RowIndex].DataBoundItem is Poll poll)
            {
                if (e.ColumnIndex == voteCol.Index)
                {
                    // Validasi dulu biar user yang sudah vote tidak bisa vote lagi
                    var validate = db.PollResponses.Any(f => f.UserID == Session.userID && f.PollID == poll.PollID);

                    if (validate)
                    {
                        MessageBox.Show("Kamu Sudah Memilih Polling Ini");
                        return;
                    }
                    else
                    {
                        Session.pollID = poll.PollID;
                        new AppContext(new FormUserPemilihan());
                        Close();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AppContext(new FormUserMain());
            Close();
        }
    }
}
