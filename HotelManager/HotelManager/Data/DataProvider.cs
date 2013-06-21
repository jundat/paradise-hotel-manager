using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManager.Data
{
    /// <summary>
    /// The Singleton class
    /// use need call DataProvider.getInstance() to get unique instance of this class
    /// </summary>
    class DataProvider
    {
        /// <summary>
        /// The unique instance of this class
        /// </summary>
        private static DataProvider _instance;

        private MySqlConnection _connection;
        private String _connectString;
        private MySqlCommand _command;

        /// <summary>
        /// Prepare for all variable of connection
        /// </summary>
        private DataProvider()
        {
            _connectString = @"server=localhost;userid=root;password=cvbnmcvbnm;database=qlnhks";
        }

        /// <summary>
        /// Get unique instance object of DataProvider class
        /// </summary>
        /// <returns></returns>
        public static DataProvider getInstance()
        {
            if (_instance == null)
            {
                _instance = new DataProvider();
            }

            return DataProvider._instance;
        }

        /// <summary>
        /// Close Connection
        /// </summary>
        public void CloseConnection()
        {
            if (_connection != null)
            {
                _connection.Close();
                //MessageBox.Show("We have Closeed QLNHKS database connection !", "Close Connect Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Open connection use must call it when software is start runinng
        /// (use can put it into function handle Form Loading Event)
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                _connection = new MySqlConnection(_connectString);
                _connection.Open();
                //MessageBox.Show("We have connected with QLNHKS database", "Connect Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Lỗi kết nỗi CSDL hãy liên hệ với nhà phát triển để được tạo và cài đặt CSDL trước khi sử dụng !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get the MySqlCommand of connetion was created by OpenConnection() function
        /// you must call it to create and execute SQL query
        ///
        /// If connection have not open, we open it
        /// </summary>
        /// <returns></returns>
        public MySqlCommand getCommand()
        {
            OpenConnection();
            _command = new MySqlCommand();
            _command.Connection = _connection;
            return _command;
        }


        public MySqlConnection getConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                this.OpenConnection();
            }

            return _connection;
        }
    }
}
