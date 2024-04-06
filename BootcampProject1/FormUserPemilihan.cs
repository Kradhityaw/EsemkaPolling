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
    public partial class FormUserPemilihan : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public FormUserPemilihan()
        {
            InitializeComponent();
        }

        private void FormUserPemilihan_Load(object sender, EventArgs e)
        {
            pollOptionBindingSource.DataSource = db.PollOptions.Where(f => f.PollID == Session.pollID).ToList();
        }

        private void pollOptionDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (pollOptionDataGridView.Rows[e.RowIndex].DataBoundItem is PollOption poll)
            {
                if (e.ColumnIndex == voteCol.Index)
                {
                    e.Value = "Vote";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Kamu Yakin?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new AppContext(new FormUserPemungutan());
                Close();
            }
        }

        private void pollOptionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pollOptionDataGridView.Rows[e.RowIndex].DataBoundItem is PollOption poll)
            {
                if (e.ColumnIndex == voteCol.Index)
                {
                    if (MessageBox.Show($"Apakah Kamu Yakin Memilih {poll.OptionText}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PollRespons respons = new PollRespons
                        {
                            UserID = Session.userID,
                            PollID = Session.pollID,
                            OptionID = poll.OptionID,
                            RespondedAt = DateTime.Now,
                        };

                        db.PollResponses.Add(respons);
                        db.SaveChanges();

                        new AppContext(new FormUserMain());
                        Close();
                    }
                }
            }
        }
    }
}
