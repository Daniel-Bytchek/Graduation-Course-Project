using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1._1
{
    class DB
    {
        //  MySqlConnection connection = new MySqlConnection("server=sql11.freesqldatabase.com;port=3306;username=sql11417728;password=hJsNluekuU;database=sql11417728");
        //  MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=librarydata");
        MySqlConnection connection = new MySqlConnection("server=remotemysql.com;port=3306;username=T1CgZwYVcR;password=CHOltRE0sn;database=T1CgZwYVcR");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void updateDB(DataGridView GridView, String TableName)
        {
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            this.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `" + TableName + "` ", this.getConnection());

            

            DataSet data = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(data);
            adapter.Fill(table);


            GridView.DataSource = data.Tables[0];


            this.closeConnection();
        }

        public void update_users_db(DataGridView GridView, String TableName)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            this.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT `id`,`firstName`, `secondName`, `thirdName`, `phoneNumber`, `email`, `admin`  FROM `" + TableName + "` ", this.getConnection());



            DataSet data = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(data);
            adapter.Fill(table);


            GridView.DataSource = data.Tables[0];


            this.closeConnection();
        }
    }
}
