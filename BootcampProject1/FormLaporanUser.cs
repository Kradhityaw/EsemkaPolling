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
    public partial class FormLaporanUser : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public FormLaporanUser()
        {
            InitializeComponent();
        }

        private void FormLaporanUser_Load(object sender, EventArgs e)
        {
            // Binding Source 1 yang terhubung ke combobox Hanya menampilkan Polls yang Sudah Di vote oleh User Tersebut
            bindingSource1.DataSource = db.PollResponses.Where(f => f.UserID == Session.userID).Select(f => new { Display = f.Poll.Question, Value = f.PollID }).ToList();
            comboBox1.DisplayMember = "Display";
            comboBox1.ValueMember = "Value";

            // Mengambil Value Member Dari combobox
            var id = (int)comboBox1.SelectedValue;

            // Menampilkan Jawaban User Dari Polling Tersebut
            var selectedPollResponse = db.PollResponses.Where(f => f.PollID == id).First(f => f.UserID == Session.userID).PollOption.OptionText;

            label3.Text = $"Kamu Memilih : {selectedPollResponse}";

            // Variabel untuk hitung jumlah keseluruhan responden pada polling yang dipilih
            var total = db.PollResponses.Count(f => f.PollID == id);

            label4.Text = $"Total Responden : {total}";

            // Query
            var data = db.PollOptions
                // Mencocokkan PollID dengan ValueMember di Combobox
                .Where(f => f.PollID == id)
                .Select(f => new
                {
                    // Mengambil OptionText dari setiap option
                    Nama = f.OptionText,
                    // Menghitung Jumlah Responder dari setiap option
                    TotalVote = f.PollResponses.Count,
                    // Mejadikan persen, disisni pakai IF ELSE satu baris menggunakan operator TERNARY
                    // IF totalsemuaVotes > 0 {(double)totalOptionVotes / totalsemuaVotes * 100} ELSE {0}
                    Persen = total > 0 ? (double)f.PollResponses.Count / total * 100 : 0,
                })
                .ToList();

            chart1.Series[0].Points.DataBind(data, "Nama", "Persen", null);
            // Format supaya ada %
            chart1.Series[0].LabelFormat = "{}%";

            // Ambil Semua Data Yang Ada Di Charts
            foreach (var point in chart1.Series[0].Points)
            {
                // Axis Label Itu Yang Ada Di Kanan Atas Chart
                var optionName = point.AxisLabel;
                // Ambil total responder dari setiap Option
                var totalVote = data.FirstOrDefault(item => item.Nama == optionName)?.TotalVote ?? 0;
                // Buat Variabel Untuk ditampilkan di axis label
                var customLabel = $"{optionName}: {totalVote} / {total} Orang";

                // Set axislabel ke variabel yang dibuat
                point.AxisLabel = customLabel;
            }
        }
    

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Mengambil Value Member Dari combobox
            var id = (int)comboBox1.SelectedValue;

            // Menampilkan Jawaban User Dari Polling Tersebut
            var selectedPollResponse = db.PollResponses.Where(f => f.PollID == id).First(f => f.UserID == Session.userID).PollOption.OptionText;

            label3.Text = $"Kamu Memilih : {selectedPollResponse}";

            // Variabel untuk hitung jumlah keseluruhan responden pada polling yang dipilih
            var total = db.PollResponses.Count(f => f.PollID == id);

            label4.Text = $"Total Responden : {total}";

            // Query
            var data = db.PollOptions
                // Mencocokkan PollID dengan ValueMember di Combobox
                .Where(f => f.PollID == id)
                .Select(f => new
                {
                    // Mengambil OptionText dari setiap option
                    Nama = f.OptionText,
                    // Menghitung Jumlah Responder dari setiap option
                    TotalVote = f.PollResponses.Count,
                    // Mejadikan persen, disisni pakai IF ELSE satu baris menggunakan operator TERNARY
                    // IF totalsemuaVotes > 0 {(double)totalOptionVotes / totalsemuaVotes * 100} ELSE {0}
                    Persen = total > 0 ? (double)f.PollResponses.Count / total * 100 : 0,
                })
                .ToList();

            chart1.Series[0].Points.DataBind(data, "Nama", "Persen", null);
            // Format supaya ada %
            chart1.Series[0].LabelFormat = "{}%";

            // Ambil Semua Data Yang Ada Di Charts
            foreach (var point in chart1.Series[0].Points)
            {
                // Axis Label Itu Yang Ada Di Kanan Atas Chart
                var optionName = point.AxisLabel;
                // Ambil total responder dari setiap Option
                var totalVote = data.FirstOrDefault(item => item.Nama == optionName)?.TotalVote ?? 0;
                // Buat Variabel Untuk ditampilkan di axis label
                var customLabel = $"{optionName}: {totalVote} / {total} Orang";

                // Set axislabel ke variabel yang dibuat
                point.AxisLabel = customLabel;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AppContext(new FormUserMain());
            Close();
        }
    }
}
