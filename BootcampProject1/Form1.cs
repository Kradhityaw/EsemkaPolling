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
    public partial class Form1 : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public Form1()
        {
            InitializeComponent();
        }

        // Menampilkan Data Dari binding source
        void loaddata()
        {
            bindingSource1.DataSource = db.PollOptions.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is PollOption pollOption)
            {
                if (e.ColumnIndex == pollcol.Index)
                {
                    // Tampil Nama Polling
                    e.Value = pollOption.Poll.Question;
                }
                if (e.ColumnIndex == pollResponsesDataGridViewTextBoxColumn.Index)
                {
                    // Tampil Jumlah Responder
                    var count = pollOption.PollResponses.Count;
                    e.Value = $"{count} Orang";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Masuk Ke Halaman Login
            new AppContext(new FormLogin());
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Cuma Buat konfirmasi saja (Opsional)
            if (checkBox1.Checked)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
