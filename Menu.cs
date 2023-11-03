using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Numerics;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kurs14
{
    public partial class Menu : Form
    {
        public NpgsqlConnection connection;
        public int key;

        public Menu(NpgsqlConnection connection)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var table = new Tables(connection, Key.Account);
            table.Show();       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var table = new Tables(connection, Key.Services);
            table.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var table = new Tables(connection, Key.Status);
            table.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var table = new Tables(connection, Key.IndivAccount);
            table.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var insert = new InsertUpdateClient(connection, this, 0);
            insert.Show();
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
        //    var update = new InsertUpdateClient(connection, this, id);
        //    update.Show();
        //}


        //private void button7_Click(object sender, EventArgs e)
        //{
        //    var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
        //    switch (key)
        //    {
        //        case 1:
        //            var delete = new DeleteClass(connection, key, this);
        //            delete.Delete_Client(id);
        //            break;

        //        case 2:
        //            delete = new DeleteClass(connection, key, this);
        //            delete.Delete_Services(id);
        //            break;

        //        case 3:
        //            delete = new DeleteClass(connection, key, this);
        //            delete.Delete_Status(id);
        //            break;

        //        case 4:
        //            delete = new DeleteClass(connection, key, this);
        //            delete.Delete_IndivAcc(id);
        //            break;
        //    }
        //}

    }
}