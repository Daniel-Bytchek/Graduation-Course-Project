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
    public partial class AdminForm : Form
    {
        public AdminForm(Librarian user)
        {
            InitializeComponent();
            authorizationLabel.Text = "Вітаю " + user.getFName();
           
        }

        
        
        private void AdminForm_Load(object sender, EventArgs e)
        {
            /*
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());

            DataSet data = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(data);
            adapter.Fill(table);

            //DeleteGrid.DataSource = data.Tables[0];
            UsersGridView.DataSource = data.Tables[0];
            dataGridView3.DataSource = table;

            db.closeConnection();
            */

            DB db = new DB();


            db.update_users_db(UsersGridView, "users");
            db.updateDB(booksGridView, "books");


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks`", db.getConnection());

            



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

        //ФОРМА ДЛЯ РОБОТИ З КОРИСТУВАЧАМИ

        private void idBox_TextChanged_1(object sender, EventArgs e)
        {
            
            (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"firstName LIKE '%{fNameBox.Text}%' AND secondName LIKE '%{sNameBox.Text}%' AND thirdName LIKE '%{tNameBox.Text}%' AND email LIKE '%{MailBox.Text}%' AND phoneNumber LIKE '%{PhoneBox.Text}%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.update_users_db(UsersGridView, "users");
        }

        private void IDBox_TextChanged_2(object sender, EventArgs e)
        {

            int num;
            bool isNum = int.TryParse(IDBox.Text, out num);
            if (isNum)
            {
                fNameBox.ReadOnly = true;
                sNameBox.ReadOnly = true;
                tNameBox.ReadOnly = true;
                PhoneBox.ReadOnly = true;
                MailBox.ReadOnly = true;
                int number = Convert.ToInt32(IDBox.Text);
                (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"id = " + number;
            }
            else
            {
                fNameBox.ReadOnly = false;
                sNameBox.ReadOnly = false;
                tNameBox.ReadOnly = false;
                PhoneBox.ReadOnly = false;
                MailBox.ReadOnly = false;
                (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"id >= " + 0;
            }
        }

        private void SearchIDBox_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(SearchDeleteIdBox.Text, out num);
            if (isNum)
            {
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `firstName`, `secondName`, `thirdName`, `login` FROM `users` WHERE `id` = @iD", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = SearchDeleteIdBox.Text;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {
                    int rowindex = UsersGridView.CurrentCell.RowIndex;
                    int columnindex = UsersGridView.CurrentCell.ColumnIndex;
                    //    (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"id = " + num;

                    UserInfoLabel.Visible = true;
                    UserInfoLabel.Text = "Користувач:";
                    //UserInfoLabel.Text = UsersGridView.Rows[0].Cells[0].Value.ToString();

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            UserInfoLabel.Text += "\n" + cell;

                    }
                    DeleteUserButton.Visible = true;
                }
                else if (SearchDeleteIdBox.Text != "")
                {
                    UserInfoLabel.Text = "Даного користувача не існє!";
                    DeleteUserButton.Visible = false;
                }
                else
                {
                    UserInfoLabel.Text = "";
                    DeleteUserButton.Visible = false;
                }

            }
            else
            {
                UserInfoLabel.Text = "";
                DeleteUserButton.Visible = false;
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataSet data = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `id` = @iD", db.getConnection());

            command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = SearchDeleteIdBox.Text;


            

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Користувача видалено");
            else
                MessageBox.Show("Користувача не вдалося видалити");

            db.closeConnection();



            db.update_users_db(UsersGridView, "users");

        }

        private void ChangeIDBox_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(ChangeIDBox.Text, out num);
            if (isNum)
            {
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `firstName`, `secondName`, `thirdName`, `email`, `phoneNumber`, `admin` FROM `users` WHERE `id` = @iD", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = ChangeIDBox.Text;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {
                    int rowindex = UsersGridView.CurrentCell.RowIndex;
                    int columnindex = UsersGridView.CurrentCell.ColumnIndex;
                    //    (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"id = " + num;

                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    fNameChangeBox.Visible = true;
                    sNameChangeBox.Visible = true;
                    tNameChangeBox.Visible = true;
                    emailChangeBox.Visible = true;
                    phoneChangeBox.Visible = true;
                    adminCheckBox.Visible = true;

                    //UserInfoLabel.Text = UsersGridView.Rows[0].Cells[0].Value.ToString();

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            UserInfoLabel.Text += "\n" + cell;

                        fNameChangeBox.Text = (string)cells[0];
                        sNameChangeBox.Text = (string)cells[1];
                        tNameChangeBox.Text = (string)cells[2];
                        emailChangeBox.Text = (string)cells[3];
                        phoneChangeBox.Text = (string)cells[4];
                        if ((Boolean)cells[5] == false)
                            adminCheckBox.Checked = false;
                        else
                            adminCheckBox.Checked = true;
                    }

                  
                    ChangeUserButton.Visible = true;
                }
                else if (ChangeIDBox.Text != "")
                {
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    fNameChangeBox.Visible = false;
                    sNameChangeBox.Visible = false;
                    tNameChangeBox.Visible = false;
                    emailChangeBox.Visible = false;
                    phoneChangeBox.Visible = false;
                    ChangeUserButton.Visible = false;
                    adminCheckBox.Visible = false;
                }
                else
                {
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    fNameChangeBox.Visible = false;
                    sNameChangeBox.Visible = false;
                    tNameChangeBox.Visible = false;
                    emailChangeBox.Visible = false;
                    phoneChangeBox.Visible = false;
                    ChangeUserButton.Visible = false;
                    adminCheckBox.Visible = false;
                }

            }
            else
            {
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                fNameChangeBox.Visible = false;
                sNameChangeBox.Visible = false;
                tNameChangeBox.Visible = false;
                emailChangeBox.Visible = false;
                phoneChangeBox.Visible = false;
                ChangeUserButton.Visible = false;
                adminCheckBox.Visible = false;
            }
        }

        private void ChangeUserButton_Click(object sender, EventArgs e)
        {

            DB db = new DB();



            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `firstName` = @fName,`secondName` = @sName,`thirdName` = @tName,`phoneNumber` = @phone, `email` = @mail,`admin` = @admin WHERE `id` = @id", db.getConnection());
            command.Parameters.Add("@fName", MySqlDbType.VarChar).Value = fNameChangeBox.Text;
            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = sNameChangeBox.Text;
            command.Parameters.Add("@tName", MySqlDbType.VarChar).Value = tNameChangeBox.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneChangeBox.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = emailChangeBox.Text;
            command.Parameters.Add("@admin", MySqlDbType.Int16).Value = adminCheckBox.Checked;
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = ChangeIDBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Зміни про користувача внесені");
            else
                MessageBox.Show("Зміни про користувача не вдалося внести");

            db.closeConnection();

            db.update_users_db(UsersGridView, "users");

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (fNameAddBox.Text != "" && sNameAddBox.Text != "" && tNameAddBox.Text != "" && phoneAddBox.Text != "" && mailAddBox.Text != "" && loginAddBox.Text != "" && passwordAddBox.Text != "")
            {
                if (isUserExists() == true)
                    return;

                DB db = new DB();



                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`firstName`, `secondName`, `thirdName`, `phoneNumber`, `login`, `password`, `email`, `admin`) VALUES (@fName, @sName, @tName, @phone, @login, @password, @mail, @admin)", db.getConnection());
                command.Parameters.Add("@fName", MySqlDbType.VarChar).Value = fNameAddBox.Text;
                command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = sNameAddBox.Text;
                command.Parameters.Add("@tName", MySqlDbType.VarChar).Value = tNameAddBox.Text;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneAddBox.Text;
                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mailAddBox.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginAddBox.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordAddBox.Text;
                command.Parameters.Add("@admin", MySqlDbType.Int16).Value = adminAddCheckBox.Checked;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Реєстрацію завершено");
                else
                    MessageBox.Show("Реєстрацію не вдалося завершити");

                db.closeConnection();
                db.update_users_db(UsersGridView, "users");
                fNameAddBox.Text = "";
                sNameAddBox.Text = "";
                tNameAddBox.Text = "";
                phoneAddBox.Text = "";
                mailAddBox.Text = "";
                loginAddBox.Text = "";
                passwordAddBox.Text = "";
            }
            else
                MessageBox.Show("Не всі поля заповнені для реєстрації!");
        }

        private Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginAddBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вказаний логін вже є в системі");
                return true;
            }
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.update_users_db(UsersGridView, "users");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.update_users_db(UsersGridView, "users");
        }

        // ФОРМА ДЛЯ РОБОТИ З КНИГАМИ

        private void bookSearchNameBox_TextChanged(object sender, EventArgs e)
        {
            (booksGridView.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE '%{bookSearchNameBox.Text}%' AND genre LIKE '%{bookSearchGenreBox.Text}%' AND author LIKE '%{bookSearchAuthorBox.Text}%' AND language LIKE '%{bookSearchLanguageBox.Text}%' AND publisher LIKE '%{bookSearchPublishingBox.Text}%' ";
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
            DB db = new DB();

            DataSet data = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("DELETE FROM `books` WHERE `id` = @iD", db.getConnection());

            command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = bookDeleteIdBox.Text;




            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Книгу видалено");
            else
                MessageBox.Show("Книгу не вдалося видалити");

            db.closeConnection();



            db.updateDB(booksGridView, "books");
        }

        private void bookChangeBox_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(bookChangeBox.Text, out num);
            if (isNum)
            {
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `name`, `genre`, `author`, `language`, `publisher`, `pages`, `year` FROM `books` WHERE `id` = @iD", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = bookChangeBox.Text;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {
                  
                    //    (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"id = " + num;

                    label36.Visible = true;
                    label37.Visible = true;
                    label38.Visible = true;
                    label39.Visible = true;
                    label40.Visible = true;
                    label41.Visible = true;
                    label52.Visible = true;
                    bookChangeNameBox.Visible = true;
                    bookChangeGenreBox.Visible = true;
                    bookChangeAuthorBox.Visible = true;
                    bookChangeLanguageBox.Visible = true;
                    bookChangePublishingBox.Visible = true;
                    bookChangePagesBox.Visible = true;
                    bookChangeYearBox.Visible = true;

                    //UserInfoLabel.Text = UsersGridView.Rows[0].Cells[0].Value.ToString();

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            UserInfoLabel.Text += "\n" + cell;

                        bookChangeNameBox.Text = (string) cells[0];
                        bookChangeGenreBox.Text = (string)cells[1];
                        bookChangeAuthorBox.Text = (string)cells[2];
                        bookChangeLanguageBox.Text = (string)cells[3];
                        bookChangePublishingBox.Text = (string)cells[4];
                        int pages = Convert.ToInt32(cells[5]);
                        int year = Convert.ToInt32(cells[6]);
                        bookChangePagesBox.Text = Convert.ToString(pages);
                        bookChangeYearBox.Text = Convert.ToString(year);
                    }


                    bookChangeButton.Visible = true;
                }
                else if (bookChangeBox.Text != "")
                {
                    label36.Visible = false;
                    label37.Visible = false;
                    label38.Visible = false;
                    label39.Visible = false;
                    label40.Visible = false;
                    label41.Visible = false;
                    label52.Visible = false;
                    bookChangeNameBox.Visible = false;
                    bookChangeGenreBox.Visible = false;
                    bookChangeAuthorBox.Visible = false;
                    bookChangeLanguageBox.Visible = false;
                    bookChangePublishingBox.Visible = false;
                    bookChangePagesBox.Visible = false;
                    bookChangeYearBox.Visible = false;
                    bookChangeButton.Visible = false;
                }
                else
                {
                    label36.Visible = false;
                    label37.Visible = false;
                    label38.Visible = false;
                    label39.Visible = false;
                    label40.Visible = false;
                    label41.Visible = false;
                    label52.Visible = false;
                    bookChangeNameBox.Visible = false;
                    bookChangeGenreBox.Visible = false;
                    bookChangeAuthorBox.Visible = false;
                    bookChangeLanguageBox.Visible = false;
                    bookChangePublishingBox.Visible = false;
                    bookChangePagesBox.Visible = false;
                    bookChangeYearBox.Visible = false;
                    bookChangeButton.Visible = false;
                }

            }
            else
            {
                label36.Visible = false;
                label37.Visible = false;
                label38.Visible = false;
                label39.Visible = false;
                label40.Visible = false;
                label41.Visible = false;
                label52.Visible = false;
                bookChangeNameBox.Visible = false;
                bookChangeGenreBox.Visible = false;
                bookChangeAuthorBox.Visible = false;
                bookChangeLanguageBox.Visible = false;
                bookChangePublishingBox.Visible = false;
                bookChangePagesBox.Visible = false;
                bookChangeYearBox.Visible = false;
                bookChangeButton.Visible = false;
            }
        }

        private void bookChangeButton_Click(object sender, EventArgs e)
        {

            DB db = new DB();



            MySqlCommand command = new MySqlCommand("UPDATE `books` SET `name` = @name,`genre` = @genre,`author` = @author,`language` = @language, `publisher` = @publisher,`pages` = @pages, `year` = @year WHERE `id` = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = bookChangeBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = bookChangeNameBox.Text;
            command.Parameters.Add("@genre", MySqlDbType.VarChar).Value = bookChangeGenreBox.Text;
            command.Parameters.Add("@author", MySqlDbType.VarChar).Value = bookChangeAuthorBox.Text;
            command.Parameters.Add("@language", MySqlDbType.VarChar).Value = bookChangeLanguageBox.Text ;
            command.Parameters.Add("@publisher", MySqlDbType.VarChar).Value = bookChangePublishingBox.Text;
            command.Parameters.Add("@pages", MySqlDbType.Int32).Value = bookChangePagesBox.Text;
            command.Parameters.Add("@year", MySqlDbType.Int32).Value = bookChangeYearBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Зміни про книгу внесені");
            else
                MessageBox.Show("Зміни про книгу не вдалося внести");

            db.closeConnection();

         

            db.updateDB(UsersGridView, "users");

        }









    

        private void bookAddButton_Click(object sender, EventArgs e)
        {
            if (bookAddNameBox.Text != "" && bookAddGenreBox.Text != "" && bookAddAuthorBox.Text != "" && bookAddLanguageBox.Text != "" && bookAddPublisherBox.Text != "" && bookAddPagesBox.Text != "" && bookAddYearBox.Text != "")
            {
                if (isBookExists() == true)
                    return;

                DB db = new DB();



                MySqlCommand command = new MySqlCommand("INSERT INTO `books` (`name`, `genre`, `author`, `language`, `publisher`, `pages`, `year`) VALUES (@name, @genre, @author, @language, @publisher, @pages, @year)", db.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = bookAddNameBox.Text;
                command.Parameters.Add("@genre", MySqlDbType.VarChar).Value = bookAddGenreBox.Text;
                command.Parameters.Add("@author", MySqlDbType.VarChar).Value = bookAddAuthorBox.Text;
                command.Parameters.Add("@language", MySqlDbType.VarChar).Value = bookAddLanguageBox.Text;
                command.Parameters.Add("@publisher", MySqlDbType.VarChar).Value = bookAddPublisherBox.Text;
                command.Parameters.Add("@pages", MySqlDbType.VarChar).Value = bookAddPagesBox.Text;
                command.Parameters.Add("@year", MySqlDbType.VarChar).Value = bookAddYearBox.Text;
               
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Реєстрацію завершено");
                    

                    db.updateDB(UsersGridView, "users");
                   
                }
                else
                    MessageBox.Show("Реєстрацію не вдалося завершити");

                db.closeConnection();
                update_method();
                bookAddNameBox.Text = "";
                bookAddGenreBox.Text = "";
                bookAddAuthorBox.Text = "";
                bookAddLanguageBox.Text = "";
                bookAddPublisherBox.Text = "";
                bookAddPagesBox.Text = "";
                bookAddYearBox.Text = "";
            }
            else
                MessageBox.Show("Не всі поля заповнені для реєстрації!");


        }

        void update_method()
        {
            DB db = new DB();

            db.updateDB(UsersGridView, "users");
            db.updateDB(booksGridView, "books");


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks`", db.getConnection());





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


        private Boolean isBookExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `books` WHERE `name` = @name AND `publisher` = @publishing AND `year` = @year", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = bookAddNameBox.Text;
            command.Parameters.Add("@publishing", MySqlDbType.VarChar).Value = bookAddPublisherBox.Text;
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = bookAddYearBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
           
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вказана книга вже є в системі");
                return true;
            }
            else
                return false;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.updateDB(UsersGridView, "users");
            db.updateDB(booksGridView, "books");


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks`", db.getConnection());





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

        private void button7_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.updateDB(UsersGridView, "users");
            db.updateDB(booksGridView, "books");


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks`", db.getConnection());





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

        private void button8_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.updateDB(UsersGridView, "users");
            db.updateDB(booksGridView, "books");


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks`", db.getConnection());





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

        private void authorizationLabel_Click(object sender, EventArgs e)
        {



        }

        private void textBox10_TextChanged(object sender, EventArgs e)
       {

            int num;
            bool isNum = int.TryParse(textBox10.Text, out num);
            if (isNum)
            {
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `UserLogin`, `BookId` FROM `borrowedbooks` WHERE `BorrowID` = @iD AND `BorrowedStatus` = 1", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = textBox10.Text;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        String userLogin;
                        int bookID;
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            UserInfoLabel.Text += "\n" + cell;

                       userLogin = (string)cells[0];
                       bookID = Convert.ToInt32(cells[1]);



                        showUser(userLogin, label61);
                        showBook(bookID, label62);
                        button12.Visible = true;
                    }


                   
                }
                else if (textBox10.Text != "")
                {
                    label61.Text = "ID не дійсний";
                    label62.Text = "ID не дійсний";
                    button12.Visible = false;
                }
                else
                {
                    button12.Visible = false;
                }

            }
            else
            {
                label61.Text = "";
                label62.Text = "";
                button12.Visible = false;
            }

        }

        void showUser(String login, Label label)
        {
            
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `firstName`, `secondName`, `thirdName`, `login` FROM `users` WHERE `login` = @iD", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = login;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {
                 
                    //    (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"id = " + num;

                    label.Visible = true;
                label.Text = "Користувач:";
                    //UserInfoLabel.Text = UsersGridView.Rows[0].Cells[0].Value.ToString();

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                        label.Text += "\n" + cell;

                    }
                    DeleteUserButton.Visible = true;
                }
                else if (SearchDeleteIdBox.Text != "")
                {
                label.Text = "Даного користувача не існє!";
                    DeleteUserButton.Visible = false;
                }
                else
                {
                label.Text = "";
                    DeleteUserButton.Visible = false;
                }


        }


        void showBook(int id, Label label)
        {
           
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `name`, `author`, `publisher` FROM `books` WHERE `id` = @iD", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = id;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {

                    //    (UsersGridView.DataSource as DataTable).DefaultView.RowFilter = $"id = " + num;

                    label.Visible = true;
                label.Text = "Книга:";
                    //UserInfoLabel.Text = UsersGridView.Rows[0].Cells[0].Value.ToString();

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                        label.Text += "\n" + cell;

                    }
                    bookDeleteButton.Visible = true;
                }
                else if (bookDeleteIdBox.Text != "")
                {
                label.Text = "Даної книги не має в бібліотеці!";
                    bookDeleteButton.Visible = false;
                }
                else
                {
                label.Text = "";
                    bookDeleteButton.Visible = false;
                }

            }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Видайте книгу користувачу по даним які наведені на інтерфейсі");
            textBox10.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            int num;
            bool isNum = int.TryParse(textBox7.Text, out num);
            if (isNum)
            {
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `UserLogin`, `BookId` FROM `borrowedbooks` WHERE `BorrowID` = @iD AND `BorrowedStatus` = 1", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = textBox7.Text;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        String userLogin;
                        int bookID;
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            UserInfoLabel.Text += "\n" + cell;

                        userLogin = (string)cells[0];
                        bookID = Convert.ToInt32(cells[1]);



                        showUser(userLogin, label58);
                        showBook(bookID, label67);
                        button9.Visible = true;
                    }



                }
                else if (textBox10.Text != "")
                {
                    label58.Text = "ID не дійсний";
                    label67.Text = "ID не дійсний";
                    button9.Visible = false;
                }
                else
                {
                    button9.Visible = false;
                }

            }
            else
            {
                label58.Text = "";
                label67.Text = "";
                button9.Visible = false;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int num;
            bool isNum = int.TryParse(textBox1.Text, out num);
            if (isNum)
            {
                DB db = new DB();

                DataSet data = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT `UserLogin`, `BookId` FROM `borrowedbooks` WHERE `BorrowID` = @iD AND `BorrowedStatus` = 1", db.getConnection());

                command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = textBox1.Text;


                adapter.SelectCommand = command;
                adapter.Fill(data);




                if (data.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in data.Tables[0].Rows)
                    {
                        String userLogin;
                        int bookID;
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            UserInfoLabel.Text += "\n" + cell;

                        userLogin = (string)cells[0];
                        bookID = Convert.ToInt32(cells[1]);



                        showUser(userLogin, label64);
                        showBook(bookID, label63);
                        button14.Visible = true;
                    }



                }
                else if (textBox10.Text != "")
                {
                    label64.Text = "ID не дійсний";
                    label63.Text = "ID не дійсний";
                    button14.Visible = false;
                }
                else
                {
                    button14.Visible = false;
                }

            }
            else
            {
                label64.Text = "";
                label63.Text = "";
                button14.Visible = false;
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.updateDB(UsersGridView, "users");
            db.updateDB(booksGridView, "books");


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks`", db.getConnection());





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

        private void button10_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.updateDB(UsersGridView, "users");
            db.updateDB(booksGridView, "books");


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks`", db.getConnection());





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

        private void button13_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.updateDB(UsersGridView, "users");
            db.updateDB(booksGridView, "books");


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `borrowedbooks`", db.getConnection());





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

        private void button9_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataSet data = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("DELETE FROM `borrowedbooks` WHERE `BorrowID` = @iD", db.getConnection());

            command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = textBox7.Text;




            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запит видалено");
            else
                MessageBox.Show("Запит не вдалося видалити");

            db.closeConnection();
            textBox7.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataSet data = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `borrowedbooks` SET `BorrowedStatus` = 0, `borrowDateRealEnd` = @date WHERE `borrowedbooks`.`BorrowID` = @iD;", db.getConnection());

            command.Parameters.Add("@iD", MySqlDbType.VarChar).Value = textBox1.Text;
            DateTime thisDay = DateTime.Today;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = thisDay;



            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Книгу повернено");
            else
                MessageBox.Show("Книгу не вдалося повернути");

            db.closeConnection();

            textBox1.Text = "";
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







        /*
         * UPDATE `users` SET `id` = 1, `firstName` = "test",`secondName` = "test",`thirdName` = "test",`phoneNumber` = "test",`login` = "test",`password` = "test",`email` = "test",`admin` = false WHERE `id` = 1
         */
    }
}
