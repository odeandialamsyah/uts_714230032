using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using BCrypt.Net;

namespace uts_714230032
{
    public partial class Form1 : Form
    {

        private IMongoCollection<BsonDocument> _userCollection;

        public Form1()
        {
            InitializeComponent();
            InitializeMongoDB();
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("uts");
            _userCollection = database.GetCollection<BsonDocument>("user");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox3.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login Berhasil!");
                Form3 mainForm = new Form3();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }
        }

        bool AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var user = _userCollection.Find(filter).FirstOrDefault();
            if (user != null)
            {
                // Verifikasi password dengan hash yang tersimpan
                string storedHashedPassword = user["password"].AsString;
                return BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);
            }

            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 regisForm = new Form2();
            regisForm.Show();
            this.Hide();
        }
    }
}
