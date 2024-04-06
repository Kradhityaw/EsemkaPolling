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
    
    public partial class FormLaporanAdmin : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public FormLaporanAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Untuk Kembali ke halaman sebelumnya
            new AppContext(new FormAdminMain());
            Close();
        }

        private void FormLaporanAdmin_Load(object sender, EventArgs e)
        {
            // Pada binding source datanya hanya ambil Poll yang dibuat oleh masing masing admin
            bindingSource1.DataSource = db.Polls.Where(f => f.AdminID == Session.AdminID).ToList();

            if (comboBox1.SelectedItem is Poll poll)
            {
                // Hitung Semua Total Responder Dari Setiap Poll
                var totalsemuaVotes = poll.PollResponses.Count;

                // Menampilkan di label
                label3.Text = $"Total Responder : {totalsemuaVotes} Orang";

                var data = poll.PollOptions.Select(option =>
                {
                    // Total responder dari setiap Option
                    var totalOptionVotes = option.PollResponses.Count;

                    // Mejadikan persen, disisni pakai IF ELSE satu baris menggunakan operator TERNARY
                    // IF totalsemuaVotes > 0 {(double)totalOptionVotes / totalsemuaVotes * 100} ELSE {0}
                    var percentage = totalsemuaVotes > 0 ? (double)totalOptionVotes / totalsemuaVotes * 100 : 0;

                    return new
                    {
                        // Mengambil Option Text
                        Nama = option.OptionText,
                        // Total responder dari setiap Option
                        TotalVote = option.PollResponses.Count,
                        // Jumlah Dalam Persen
                        Percentage = percentage,
                        // Format Menjadi Decimal
                        //PercentageLabel = $"{percentage:F2}%"
                    };
                }).ToList();

                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.DataBind(data, "Nama", "Percentage", null); // Tooltip=PercentageLabel

                // Menampilkan Nilai Y sebagai Label
                chart1.Series[0].IsValueShownAsLabel = true;
                // Format Supaya ada %
                chart1.Series[0].LabelFormat = "{}%";

                // Looping semua data yang ada di chart
                foreach (var point in chart1.Series[0].Points)
                {
                    // Axis Label Itu Yang Ada Di Kanan Atas Chart
                    var optionName = point.AxisLabel;
                    // Ambil total responder dari setiap Option
                    var totalVote = data.FirstOrDefault(item => item.Nama == optionName)?.TotalVote ?? 0;
                    // Buat Variabel Untuk ditampilkan di axis label
                    var customLabel = $"{optionName}: {totalVote} / {totalsemuaVotes} Orang";

                    // Set axislabel ke variabel yang dibuat
                    point.AxisLabel = customLabel;
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Poll poll)
            {
                // Hitung Semua Total Responder Dari Setiap Poll
                var totalsemuaVotes = poll.PollResponses.Count;

                // Menampilkan di label
                label3.Text = $"Total Responder : {totalsemuaVotes} Orang";

                var data = poll.PollOptions.Select(option =>
                {
                    // Total responder dari setiap Option
                    var totalOptionVotes = option.PollResponses.Count;

                    // Mejadikan persen, disisni pakai IF ELSE satu baris menggunakan operator TERNARY
                    // IF totalsemuaVotes > 0 {(double)totalOptionVotes / totalsemuaVotes * 100} ELSE {0}
                    var percentage = totalsemuaVotes > 0 ? (double)totalOptionVotes / totalsemuaVotes * 100 : 0;

                    return new
                    {
                        // Mengambil Option Text
                        Nama = option.OptionText,
                        // Total responder dari setiap Option
                        TotalVote = option.PollResponses.Count,
                        // Jumlah Dalam Persen
                        Percentage = percentage,
                        // Format Menjadi Decimal
                        //PercentageLabel = $"{percentage:F2}%"
                    };
                }).ToList();

                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.DataBind(data, "Nama", "Percentage", null); // Tooltip=PercentageLabel

                // Menampilkan Nilai Y sebagai Label
                chart1.Series[0].IsValueShownAsLabel = true;
                // Format Supaya ada %
                chart1.Series[0].LabelFormat = "{}%";

                // Looping semua data yang ada di chart
                foreach (var point in chart1.Series[0].Points)
                {
                    // Axis Label Itu Yang Ada Di Kanan Atas Chart
                    var optionName = point.AxisLabel;
                    // Ambil total responder dari setiap Option
                    var totalVote = data.FirstOrDefault(item => item.Nama == optionName)?.TotalVote ?? 0;
                    // Buat Variabel Untuk ditampilkan di axis label
                    var customLabel = $"{optionName}: {totalVote} / {totalsemuaVotes} Orang";

                    // Set axislabel ke variabel yang dibuat
                    point.AxisLabel = customLabel;
                }
            }
        }
    }
}
