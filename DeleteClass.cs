using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs14
{
    internal class DeleteClass
    {
        public Enum key;
        public NpgsqlConnection connection;
        public Menu menu;
        public DeleteClass(NpgsqlConnection connection, Enum key, Menu menu)
        {
            this.connection = connection;
            this.key = key;
            this.menu = menu;
        }
        public void Delete_Client(int id)
        {
            var tables = new Tables(connection, key);
            var enterTables = new EnterTables(connection, tables);
            var result = MessageBox.Show("Вы действительно хотите удалить данного клиента?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete_subs", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@new_id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Клиент удален!");
                enterTables.EnterClients();
            }
        }

        public void Delete_Services(int id)
        {
            var tables = new Tables(connection, key);
            var enterTables = new EnterTables(connection, tables);
            var result = MessageBox.Show("Вы действительно хотите удалить данную услугу?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete_service", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@new_id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Услуга удалена!");
                enterTables.EnterStatus();
            }
        }

        public void Delete_Status(int id)
        {
            var tables = new Tables(connection, key);
            var enterTables = new EnterTables(connection, tables);
            var result = MessageBox.Show("Вы действительно хотите удалить данный статус?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete_status", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@new_id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Статус удален!");
                enterTables.EnterStatus();
            }
        }

        public void Delete_IndivAcc(int id)
        {
            var tables = new Tables(connection, key);
            var enterTables = new EnterTables(connection, tables);
            var result = MessageBox.Show("Вы действительно хотите удалить данную услугу у данного клиента?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete_indacc", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@new_id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Услуга у клиента удалена!");
                enterTables.EnterStatus();
            }
        }
    }
}
