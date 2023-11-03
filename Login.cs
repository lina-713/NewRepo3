using System;
using System.Windows.Forms;
using Npgsql;

namespace Kurs14
{
    public partial class Login : Form
    {
        public NpgsqlConnection connection;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            string log = textBox1.Text;
            string pass = textBox2.Text;

            switch (log + pass)
            {
                case ("guest" + "guest"):
                    str = "Host=localhost;Port=5432;Database=Telephone_network;Username=guest;Password=guest";
                    break;

                case ("admin" + "admin"):
                    str = "Host=localhost;Port=5432;Database=Telephone_network;Username=admin;Password=admin";
                    break;
                default:
                    MessageBox.Show("Неправильный логин или пароль!");
                    return;
            }

            NpgsqlConnection conn = new NpgsqlConnection(str);
            connection = conn;
            var menu = new Menu(connection);
            menu.Show();
            this.Dispose();

            // MainWindow mainWindow = new MainWindow(connection);
            //mainWindow.Show();
        }
    }
}
