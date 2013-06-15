using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QLNHKS
{
    class DataProvider
    {
        private static DataProvider _instance;

        private MySqlConnection _connection;
        private String _connectString;
        private MySqlCommand _command;

        private DataProvider()
        {
            _connectString = @"server=localhost;userid=root;password=cvbnmcvbnm;database=qlnhks";
            _connection = new MySqlConnection(_connectString);
            _command = new MySqlCommand();
            _command.Connection = _connection;
        }

        public static DataProvider getInstance()
        {
            if (_instance == null)
            {
                _instance = new DataProvider();
            }

            return DataProvider._instance;
        }

        public void CloseConnection()
        {
            if (_connection != null)
            {
                _connection.Close();
                MessageBox.Show("We have Closeed QLNHKS database connection !", "Close Connect Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void OpenConnection()
        {
            try
            {
                _connection.Open();

                MessageBox.Show("We have connected with QLNHKS database", "Connect Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error Connect to QLNHKS database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MySqlCommand getCommand()
        {
            return _command;
        }
    }
}
