using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1._1
{
    public partial class UserForm : Form
    {
        Reader CurrentUser = new Reader();
        public UserForm(Reader user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void bookSearchNameBox_TextChanged(object sender, EventArgs e)
        {
            (booksGridView.DataSource as DataTable).DefaultView.RowFilter = $"назва LIKE '%{bookSearchNameBox.Text}%' AND жанр LIKE '%{bookSearchGenreBox.Text}%' AND автор LIKE '%{bookSearchAuthorBox.Text}%' AND мова LIKE '%{bookSearchLanguageBox.Text}%' AND видавництво LIKE '%{bookSearchPublishingBox.Text}%' ";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            authorizationLabel.Text = "Вітаю " + CurrentUser.getFName();
            DB db = new DB();
           
            ////////

            DataTable table1 = new DataTable();

            MySqlDataAdapter adapter1 = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `books`", db.getConnection());



            DataSet data1 = new DataSet();

            adapter1.SelectCommand = command1;
            adapter1.Fill(data1);
            adapter1.Fill(table1);

            data1.Tables[0].Columns[0].ColumnName = "ID";
            data1.Tables[0].Columns[1].ColumnName = "Назва";
            data1.Tables[0].Columns[2].ColumnName = "Жанр";
            data1.Tables[0].Columns[3].ColumnName = "Автор";
            data1.Tables[0].Columns[4].ColumnName = "Мова";
            data1.Tables[0].Columns[5].ColumnName = "Видавництво";
            data1.Tables[0].Columns[6].ColumnName = "Сторінки";
            data1.Tables[0].Columns[7].ColumnName = "Рік";
            
           

            booksGridView.DataSource = data1.Tables[0];
        

            db.closeConnection();

            ////////

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks` WHERE `UserLogin` = @login", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = CurrentUser.getLogin();



            DataSet data = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(data);
            adapter.Fill(table);

            data.Tables[0].Columns[0].ColumnName = "Id запиту";
            data.Tables[0].Columns[1].ColumnName = "Користувач";
            data.Tables[0].Columns[2].ColumnName = "Id книги";
            data.Tables[0].Columns[3].ColumnName = "Заборгованість";
            data.Tables[0].Columns[4].ColumnName = "Видача";
            data.Tables[0].Columns[5].ColumnName = "Очікуване повернення";
            data.Tables[0].Columns[6].ColumnName = "Реальне повернення";
            BorrowedBooksGridView.DataSource = data.Tables[0];


            db.closeConnection();
        }

        private void bookSearchIdBox_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(bookSearchIdBox.Text, out num);
            if (isNum)
            {
                bookSearchNameBox.ReadOnly = true;
                bookSearchGenreBox.ReadOnly = true;
                bookSearchAuthorBox.ReadOnly = true;
                bookSearchLanguageBox.ReadOnly = true;
                bookSearchPublishingBox.ReadOnly = true;
                int number = Convert.ToInt32(bookSearchIdBox.Text);
                (booksGridView.DataSource as DataTable).DefaultView.RowFilter = $"id = " + number;
            }
            else
            {
                bookSearchNameBox.ReadOnly = false;
                bookSearchGenreBox.ReadOnly = false;
                bookSearchAuthorBox.ReadOnly = false;
                bookSearchLanguageBox.ReadOnly = false;
                bookSearchPublishingBox.ReadOnly = false;
                (booksGridView.DataSource as DataTable).DefaultView.RowFilter = $"id >= " + 0;
            }
        }

        private void bookDeleteIdBox_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(bookDeleteIdBox.Text, out num);
            if (isNum)
            {
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `name`, `author`, `publisher` FROM `books` WHERE `id` = @iD", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = bookDeleteIdBox.Text;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {

                    //    (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"id = " + num;

                    bookDeleteLabel.Visible = true;
                    bookDeleteLabel.Text = "Книга:";
                    //UserInfoLabel.Text = UsersGridView.Rows[0].Cells[0].Value.ToString();

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            bookDeleteLabel.Text += "\n" + cell;

                    }
                    bookDeleteButton.Visible = true;
                }
                else if (bookDeleteIdBox.Text != "")
                {
                    bookDeleteLabel.Text = "Даної книги не має в бібліотеці!";
                    bookDeleteButton.Visible = false;
                }
                else
                {
                    bookDeleteLabel.Text = "";
                    bookDeleteButton.Visible = false;
                }

            }
            else
            {
                bookDeleteLabel.Text = "";
                bookDeleteButton.Visible = false;
            }
        }

        private void bookDeleteButton_Click(object sender, EventArgs e)
        {
            if (isBorrowedBookExists())
            {
                return;
            }
            
            DB db = new DB();

            DataSet data = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `borrowedbooks` (`UserLogin`, `BookId`, `borrowDateStart`, `borrowDateEnd`, `borrowDateRealEnd`) VALUES (@userLogin, @bookID, @borrowStart, @borrowEnd, NULL);", db.getConnection());

            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = CurrentUser.getLogin();
            command.Parameters.Add("@bookID", MySqlDbType.VarChar).Value = bookDeleteIdBox.Text;

            DateTime thisDay = DateTime.Today;
            ;
            command.Parameters.Add("@borrowStart", MySqlDbType.Date).Value = thisDay;
            
            command.Parameters.Add("@borrowEnd", MySqlDbType.Date).Value = thisDay.AddDays(14);



            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Книгу зарезервовано");
            else
                MessageBox.Show("Книгу не вдалося зарезервувати");

            db.closeConnection();



            update();
        }
        private Boolean isBorrowedBookExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks` WHERE `BookId` = @bookID AND `BorrowedStatus` = 1", db.getConnection());

            command.Parameters.Add("@bookId", MySqlDbType.VarChar).Value = bookDeleteIdBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Дану книгу вже запозичили");
                return true;
            }
            else
                return false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update();
        }

        void update()
        {
            authorizationLabel.Text = "Вітаю " + CurrentUser.getFName();
            DB db = new DB();

            ////////

            DataTable table1 = new DataTable();

            MySqlDataAdapter adapter1 = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `books`", db.getConnection());



            DataSet data1 = new DataSet();

            adapter1.SelectCommand = command1;
            adapter1.Fill(data1);
            adapter1.Fill(table1);

            data1.Tables[0].Columns[0].ColumnName = "ID";
            data1.Tables[0].Columns[1].ColumnName = "Назва";
            data1.Tables[0].Columns[2].ColumnName = "Жанр";
            data1.Tables[0].Columns[3].ColumnName = "Автор";
            data1.Tables[0].Columns[4].ColumnName = "Мова";
            data1.Tables[0].Columns[5].ColumnName = "Видавництво";
            data1.Tables[0].Columns[6].ColumnName = "Сторінки";
            data1.Tables[0].Columns[7].ColumnName = "Рік";



            booksGridView.DataSource = data1.Tables[0];


            db.closeConnection();

            ////////

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks` WHERE `UserLogin` = @login", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = CurrentUser.getLogin();



            DataSet data = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(data);
            adapter.Fill(table);

            data.Tables[0].Columns[0].ColumnName = "Id запиту";
            data.Tables[0].Columns[1].ColumnName = "Користувач";
            data.Tables[0].Columns[2].ColumnName = "Id книги";
            data.Tables[0].Columns[3].ColumnName = "Заборгованість";
            data.Tables[0].Columns[4].ColumnName = "Видача";
            data.Tables[0].Columns[5].ColumnName = "Очікуване повернення";
            data.Tables[0].Columns[6].ColumnName = "Реальне повернення";
            BorrowedBooksGridView.DataSource = data.Tables[0];


            db.closeConnection();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastpoint;

        private void authorizationLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void authorizationLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
    }
}
