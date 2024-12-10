using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace uts_714230032
{
    public partial class Form2 : Form
    {

        private IMongoCollection<BsonDocument> _userCollection;
        public Form2()
        {
            InitializeComponent();
            InitializeMongoDB();
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("user");
            _userCollection = database.GetCollection<BsonDocument>("user");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string ageText = textBox2.Text;
            string username = textBox4.Text;
            string password = textBox3.Text;

            // Validasi input (pastikan password tidak kosong)
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau password tidak boleh kosong!");
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Umur harus berupa angka!");
                return;
            }

            // Hash password menggunakan bcrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            var userDocument = new BsonDocument
            {
                { "name", name },
                { "age", age },
                { "username", username },
                { "password", hashedPassword }  // Simpan password yang sudah di-hash jika perlu
            };

            _userCollection.InsertOne(userDocument);
            MessageBox.Show("User berhasil terdaftar!");
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
