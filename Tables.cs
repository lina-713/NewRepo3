using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs14
{
    public partial class Tables : Form
    {
        public NpgsqlConnection connection;
        public Enum key;
        public Tables(NpgsqlConnection connection, Enum key)
        {
            InitializeComponent();
            this.connection = connection;
            this.key = key;
        }
        public Tables(NpgsqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }
        enum Key
        {
            Account,
            Services,
            Status,
            IndivAccount
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            switch (key)
            {
                case Key.Account:
                    var tables = new EnterTables(connection, this);
                    tables.EnterClients();
                    break;

                case Key.Services:
                    tables = new EnterTables(connection, this);
                    tables.EnterServices();
                    break;

                case Key.Status:
                    tables = new EnterTables(connection, this);
                    tables.EnterStatus();
                    break;

                case Key.IndivAccount:
                    tables = new EnterTables(connection, this);
                    tables.EnterIndivAccount();
                    break;
            }
        }
    }
}
