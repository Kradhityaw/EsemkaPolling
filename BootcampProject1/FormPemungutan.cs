using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootcampProject1
{
    public partial class FormPemungutan : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        int pollid = 0;
        public FormPemungutan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi
            if (string.IsNullOrEmpty(questionTextBox.Text))
            {
                MessageBox.Show("Question Wajib Diisi");
                return;
            }

            if (bindingSource1.Current is Poll poll)
            {
                // Ambil tanggal admin membuat pollnya
                poll.CreatedAt = DateTime.Now;
                // Ini cuma tambah di tampilan, tidak nambah ke database
                pollBindingSource.Add(poll);

                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                button3.Enabled = true;

                //db.Polls.AddOrUpdate(poll);
                //db.SaveChanges();
                //OnLoad(EventArgs.Empty);
                //isClosedCheckBox.Visible = false;
            }
        }

        private void FormPemungutan_Load(object sender, EventArgs e)
        {
            pollBindingSource.Clear();
            // Tampilkan data polls ke datagridview
            pollBindingSource.DataSource = db.Polls.ToList();
            // Masuk ke mode create 
            bindingSource1.AddNew();
            bindingSource2.AddNew();

            button4.Enabled = false;
            button1.Enabled = true;
            pollOptionBindingSource.Clear();
        }

        private void pollDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (pollDataGridView.Rows[e.RowIndex].DataBoundItem is Poll poll)
            {
                if (e.ColumnIndex == delCol.Index)
                {
                    e.Value = "Delete";
                }
                if (e.ColumnIndex == editCol.Index)
                {
                    e.Value = "Edit";
                }
                if (e.ColumnIndex == isclosecol.Index)
                {
                    if (poll.IsClosed == null)
                    {
                        e.Value = "Mulai Polling";
                    }
                    if (poll.IsClosed == false)
                    {
                        e.Value = "Tutup Polling";
                    }
                    if (poll.IsClosed == true)
                    {
                        e.Value = "Mulai Polling";
                    }
                }
                if (e.ColumnIndex == isclosedcolumn.Index)
                {
                    if (poll.IsClosed == null)
                    {
                        e.Value = "Polling Belum Dimulai";
                    }
                    if (poll.IsClosed == false)
                    {
                        e.Value = "Sedang Berlangsung";
                    }
                    if (poll.IsClosed == true)
                    {
                        e.Value = "Sudah Berakhir";
                    }
                }
            }
        }

        private void pollDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pollDataGridView.Rows[e.RowIndex].DataBoundItem is Poll poll)
            {
                if (e.ColumnIndex == delCol.Index)
                {
                    if (pollBindingSource.Current is Poll polll)
                    {
                        // Ini untuk mengatasi masalah semisal kita tambah data ke polldatagridviw terus klik delete
                        if (polll.PollID == 0)
                        {
                            return;
                        }

                        // Jika Dalam poll tersebut sudah ada yang merespon maka tidak bisa dihapus
                        if (poll.PollResponses.Count > 0)
                        {
                            MessageBox.Show("Polling ini sudah ada yang memilih tidak dapat dihapus!");
                            return;
                        }

                        // Harus Menghapus dulu polloption nya, karena ada relasi
                        try
                        {
                            var data = poll.PollOptions.Where(f => f.PollID == poll.PollID).FirstOrDefault();

                            db.PollOptions.Remove(data);
                            db.SaveChanges();
                        }
                        catch
                        {
                        }

                        db.Polls.Remove(polll);
                        db.SaveChanges();

                        OnLoad(EventArgs.Empty);
                        //pollBindingSource.Remove(polll);
                    }
                }
                if (e.ColumnIndex == editCol.Index)
                {
                    // Ketika di poll tersebuat sudah ada responden
                    if (poll.PollResponses.Count > 0)
                    {
                        MessageBox.Show("Polling ini sudah ada yang memilih tidak dapat diubah!");
                        return;
                    }

                    if (pollBindingSource.Current is Poll poll1)
                    {
                        // Untuk Mengatasi Masalah Ketika tambah poll baru lalu klik edit
                        if (poll1.PollID == 0)
                        {
                            return;
                        }

                        groupBox2.Enabled = true;
                        button4.Enabled = true;
                        button3.Enabled = true;
                        button1.Enabled = false;

                        // Ini buat nampilkan di Form buat poll nya
                        bindingSource1.DataSource = db.Polls.AsNoTracking().First(f => f.PollID == poll.PollID);
                        // Ini buat nampilin opsi di polloption datagridview
                        pollOptionBindingSource.DataSource = db.PollOptions.AsNoTracking().Where(f => f.PollID == poll.PollID).ToList();
                    }
                }
                if (e.ColumnIndex == isclosecol.Index)
                {
                    if (poll.PollID == 0)
                    {
                        //MessageBox.Show("masih belum");
                        return;
                    }

                    if (poll.IsClosed == null)
                    {
                        poll.IsClosed = false;
                        db.Polls.AddOrUpdate(poll);
                        db.SaveChanges();
                        OnLoad(EventArgs.Empty);
                        return;
                    }

                    if (poll.IsClosed == false)
                    {
                        poll.IsClosed = true;
                    }
                    else
                    {
                        poll.IsClosed = false;
                    }

                    db.Polls.AddOrUpdate(poll);
                    db.SaveChanges();
                    OnLoad(EventArgs.Empty);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(optionTextTextBox.Text))
            {
                MessageBox.Show("Data tidak boleh kosong");
                return;
            }

            if (bindingSource2.Current is PollOption pollOption)
            {
                // Fungsi Create PollOption
                if (pollOption.OptionID == 0)
                {
                    PollOption polup = new PollOption
                    {
                        OptionText = pollOption.OptionText
                    };
                    pollOptionBindingSource.Add(polup);
                }
                // Fungsi Update PollOption
                else
                {
                    db.PollOptions.AddOrUpdate(pollOption);
                    db.SaveChanges();
                    OnLoad(EventArgs.Empty);
                }
                button4.Enabled = true;
            }

            optionTextTextBox.Text = "";
        }

        // Fungsi Cancel
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;

            OnLoad(EventArgs.Empty);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pollOptionBindingSource.List is PollOption pollOption)
            {
                Console.WriteLine(pollOption.OptionID);
            }

            if (bindingSource1.Current is Poll poll)
            {
                // Memasukkan Poll ke dalam database
                poll.AdminID = Session.AdminID;
                db.Polls.AddOrUpdate(poll);
                db.SaveChanges();

                // Iterasi melalui bindingSource2 untuk memasukkan setiap PollOption ke dalam database
                foreach (PollOption item in pollOptionBindingSource)
                {
                    // Memasukkan PollOption ke dalam database
                    item.PollID = poll.PollID;
                    db.PollOptions.AddOrUpdate(item);
                }

                // Menyimpan semua perubahan ke dalam database setelah iterasi selesai
                db.SaveChanges();

                button4.Enabled = false;
                groupBox2.Enabled = false;
                button3.Enabled = false;
                groupBox1.Enabled = true;

                OnLoad(EventArgs.Empty);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AppContext(new FormAdminMain());
            Close();
        }

        private void pollOptionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pollOptionDataGridView.Rows[e.RowIndex].DataBoundItem is PollOption pollOption)
            {
                if (e.ColumnIndex == removeCol.Index)
                {
                    if (pollOption.OptionID == 0)
                    {
                        return;
                    }

                    if (MessageBox.Show($"Apakah kamu yakin mau menghapus {pollOption.OptionText} dari {pollOption.Poll.Question}?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (MessageBox.Show($"Konfirmasi Sekali lagi, Yakin Menghapus {pollOption.OptionText} dari {pollOption.Poll.Question}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            var data = db.PollOptions.Find(pollOption.OptionID);
                            db.PollOptions.Remove(data);
                            db.SaveChanges();
                            OnLoad(EventArgs.Empty);
                        }
                    }
                }
                if (e.ColumnIndex == editoptionCol.Index)
                {
                    if (pollOption.OptionID == 0)
                    {
                        return;
                    }

                    if (pollOptionBindingSource.Current is PollOption pollOption1)
                    {
                        bindingSource2.DataSource = db.PollOptions.AsNoTracking().First(f => f.OptionID == pollOption1.OptionID);
                    }
                }
            }
        }

        private void pollOptionDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (pollOptionDataGridView.Rows[e.RowIndex].DataBoundItem is PollOption pollOption)
            {
                if (e.ColumnIndex == removeCol.Index)
                {
                    e.Value = "Remove";
                }
                if (e.ColumnIndex == editoptionCol.Index)
                {
                    e.Value = "Edit";
                }
            }
        }
    }
}
