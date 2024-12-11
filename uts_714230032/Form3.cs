using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms.DataVisualization;


namespace uts_714230032
{
    public partial class Form3 : Form
    {
        private IMongoCollection<BsonDocument> _userDailyDataCollection;
        public Form3()
        {
            InitializeComponent();
            InitializeMongoDB();
        }
        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("uts");
            _userDailyDataCollection = database.GetCollection<BsonDocument>("user_daily_data");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            dataGridView1.Visible = false;
            search.Visible = false;
            textBoxSearch.Visible = false;
            button2.Visible = false;
            chartAnalysis.Visible = false;
            label11.Visible = false;
            button2_Click_1(sender, e);
            LoadChartData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox2.Visible = true;
            dataGridView1.Visible = true;
            search.Visible = true;
            textBoxSearch.Visible = true;
            button2.Visible = true;
            label10.Visible = false;
            chartAnalysis.Visible = false;
            label11.Visible = false;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox2.Visible = false;
            dataGridView1.Visible = false;
            search.Visible = false;
            textBoxSearch.Visible = false;
            button2.Visible = false;
            label10.Visible = false;
            chartAnalysis.Visible = true;
            label11.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userID = textBox1.Text;
            string name = textBox2.Text;
            int age;
            if (!int.TryParse(textBox3.Text, out age))
            {
                MessageBox.Show("Usia harus berupa angka!");
                return;
            }
            DateTime date = dateTimePicker1.Value;
            double weight;
            if (!double.TryParse(textBox5.Text, out weight))
            {
                MessageBox.Show("Berat badan harus berupa angka!");
                return;
            }
            int systolic, diastolic;
            if (!int.TryParse(textBoxSystolic.Text, out systolic) || !int.TryParse(textBoxDiastolic.Text, out diastolic))
            {
                MessageBox.Show("Tekanan darah harus berupa angka (sistolik dan diastolik)!");
                return;
            }
            double bloodSugarLevel;
            if (!double.TryParse(textBox7.Text, out bloodSugarLevel))
            {
                MessageBox.Show("Kadar gula darah harus berupa angka!");
                return;
            }

            // Validasi input
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Semua kolom harus diisi!");
                return;
            }

            // Membuat BsonDocument untuk menyimpan data harian
            var dailyDataDocument = new BsonDocument
            {
                { "userID", userID },
                { "name", name },
                { "age", age },
                { "date", date },
                { "weight", weight },
                { "bloodPressure",  new BsonDocument {
                    { "systolic", systolic },
                    { "diastolic", diastolic }
                }},
                { "bloodSugarLevel", bloodSugarLevel }
            };

            try
            {
                _userDailyDataCollection.InsertOne(dailyDataDocument);
                MessageBox.Show("Data berhasil disimpan!");
                resetForm();
                button2_Click_1(sender, e); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan data: {ex.Message}");
            }
        }

        private void resetForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBoxSystolic.Clear();
            textBoxDiastolic.Clear();
            textBox7.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Silakan masukkan UserID atau Nama untuk pencarian.");
                return;
            }

            var filter = Builders<BsonDocument>.Filter.Eq("userID", searchTerm) | Builders<BsonDocument>.Filter.Eq("name", searchTerm);
            var results = _userDailyDataCollection.Find(filter).ToList();

            // Tampilkan hasil pencarian pada DataGridView
            dataGridView1.DataSource = results.Select(d => new
            {
                UserID = d["userID"].AsString,
                Name = d["name"].AsString,
                Age = d["age"].AsInt32,
                Date = d["date"].ToUniversalTime().ToString("yyyy-MM-dd"),
                Weight = d["weight"].AsDouble,
                Systolic = d["bloodPressure"]["systolic"].AsInt32,
                Diastolic = d["bloodPressure"]["diastolic"].AsInt32,
                BloodSugarLevel = d["bloodSugarLevel"].AsDouble
            }).ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Ambil data dari DataGridView
                textBox1.Text = selectedRow.Cells["UserID"].Value?.ToString() ?? "";
                textBox2.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                textBox3.Text = selectedRow.Cells["Age"].Value?.ToString() ?? "";
                dateTimePicker1.Value = DateTime.TryParse(selectedRow.Cells["Date"].Value?.ToString(), out var date)
                    ? date
                    : DateTime.Now;
                textBox5.Text = selectedRow.Cells["Weight"].Value?.ToString() ?? "";
                textBoxSystolic.Text = selectedRow.Cells["Systolic"].Value?.ToString() ?? "";
                textBoxDiastolic.Text = selectedRow.Cells["Diastolic"].Value?.ToString() ?? "";
                textBox7.Text = selectedRow.Cells["BloodSugarLevel"].Value?.ToString() ?? "";
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            // Ambil data dari input form
            string userID = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();

            // Validasi input age
            int age;
            if (string.IsNullOrEmpty(textBox3.Text) || !int.TryParse(textBox3.Text, out age))
            {
                MessageBox.Show("Usia harus berupa angka!");
                return;
            }

            // Validasi input lainnya
            double weight;
            if (string.IsNullOrEmpty(textBox5.Text) || !double.TryParse(textBox5.Text, out weight))
            {
                MessageBox.Show("Berat badan harus berupa angka!");
                return;
            }

            int systolic, diastolic;
            if (string.IsNullOrEmpty(textBoxSystolic.Text) || !int.TryParse(textBoxSystolic.Text, out systolic) ||
                string.IsNullOrEmpty(textBoxDiastolic.Text) || !int.TryParse(textBoxDiastolic.Text, out diastolic))
            {
                MessageBox.Show("Tekanan darah (sistolik dan diastolik) harus berupa angka!");
                return;
            }

            double bloodSugarLevel;
            if (string.IsNullOrEmpty(textBox7.Text) || !double.TryParse(textBox7.Text, out bloodSugarLevel))
            {
                MessageBox.Show("Kadar gula darah harus berupa angka!");
                return;
            }

            // Update data di MongoDB
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("userID", userID);
                var update = Builders<BsonDocument>.Update
                    .Set("name", name)
                    .Set("age", age)
                    .Set("weight", weight)
                    .Set("bloodPressure", new BsonDocument
                    {
                { "systolic", systolic },
                { "diastolic", diastolic }
                    })
                    .Set("bloodSugarLevel", bloodSugarLevel);

                _userDailyDataCollection.UpdateOne(filter, update);
                MessageBox.Show("Data berhasil diperbarui!");
                button2_Click_1(sender, e); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengupdate data: {ex.Message}");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            string userID = dataGridView1.SelectedRows[0].Cells["UserID"].Value.ToString();

            var filter = Builders<BsonDocument>.Filter.Eq("userID", userID);
            _userDailyDataCollection.DeleteOne(filter);

            MessageBox.Show("Data berhasil dihapus!");
            search.PerformClick(); // Refresh hasil pencarian
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Mengambil semua data dari koleksi MongoDB
                var allData = _userDailyDataCollection.Find(new BsonDocument()).ToList();

                // Mengonversi data ke format yang bisa ditampilkan di DataGridView
                var dataSource = allData.Select(d => new
                {
                    UserID = d["userID"].AsString,
                    Name = d["name"].AsString,
                    Age = d["age"].AsInt32,
                    Date = d["date"].ToUniversalTime().ToString("yyyy-MM-dd"),
                    Weight = d["weight"].AsDouble,
                    Systolic = d["bloodPressure"]["systolic"].AsInt32,
                    Diastolic = d["bloodPressure"]["diastolic"].AsInt32,
                    BloodSugarLevel = d["bloodSugarLevel"].AsDouble
                }).ToList();

                // Mengatur DataGridView untuk menampilkan data
                dataGridView1.DataSource = dataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}");
            }
        }

        private void LoadChartData()
        {
            try
            {
                // Ambil semua data dari MongoDB, diurutkan berdasarkan tanggal
                var allData = _userDailyDataCollection.Find(new BsonDocument())
                    .Sort(Builders<BsonDocument>.Sort.Ascending("date"))
                    .ToList();

                // Bersihkan seri sebelumnya pada chart
                chartAnalysis.Series.Clear();

                // Tambahkan seri untuk Sistolik, Diastolik, dan Gula Darah
                var seriesSystolic = new System.Windows.Forms.DataVisualization.Charting.Series("Systolic")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    BorderWidth = 2
                };
                var seriesDiastolic = new System.Windows.Forms.DataVisualization.Charting.Series("Diastolic")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    BorderWidth = 2
                };
                var seriesBloodSugar = new System.Windows.Forms.DataVisualization.Charting.Series("Blood Sugar Level")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    BorderWidth = 2
                };

                // Tambahkan data ke dalam seri
                foreach (var record in allData)
                {
                    var date = record["date"].ToUniversalTime().ToString("yyyy-MM-dd");
                    var systolic = record["bloodPressure"]["systolic"].AsInt32;
                    var diastolic = record["bloodPressure"]["diastolic"].AsInt32;
                    var bloodSugarLevel = record["bloodSugarLevel"].AsDouble;

                    seriesSystolic.Points.AddXY(date, systolic);
                    seriesDiastolic.Points.AddXY(date, diastolic);
                    seriesBloodSugar.Points.AddXY(date, bloodSugarLevel);
                }

                // Tambahkan seri ke chart
                chartAnalysis.Series.Add(seriesSystolic);
                chartAnalysis.Series.Add(seriesDiastolic);
                chartAnalysis.Series.Add(seriesBloodSugar);

                // Konfigurasi chart
                chartAnalysis.ChartAreas[0].AxisX.Title = "Date";
                chartAnalysis.ChartAreas[0].AxisY.Title = "Value";
                chartAnalysis.ChartAreas[0].AxisX.Interval = 1; // Tampilkan setiap tanggal
                chartAnalysis.ChartAreas[0].RecalculateAxesScale();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data grafik: {ex.Message}");
            }
        }
    }
}
