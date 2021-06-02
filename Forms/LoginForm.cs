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
    public partial class LoginForm : Form
    {
         Librarian CurrentUser1 = new Librarian();
        Reader CurrentUser2 = new Reader();
        public LoginForm()
        {
            InitializeComponent();
        }

        //очищаем поле логина для ввода
        private void textBox1_Click(object sender, EventArgs e)
        {
            if(loginBox.Text == "Логін")
            loginBox.Text = "";
        }

        //очищаем поле пароля для ввода
        private void textBox2_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            if (passwordBox.Text == "Пароль")
            passwordBox.Text = "";
        }
  

        //закрытие окна логина
        private void closeLabel_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        //подсветка иконки закрытия
        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
           closeLabel.ForeColor = Color.Black;
        }

        //подсветка иконки закрытия
        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Silver;
        }

        //перетаскивание окна мышкой

        Point lastpoint;

        private void authorizationLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void authorizationLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        //проверка наличия пользователя в БД
        private void loginButton_Click(object sender, EventArgs e)
        {
            String login = loginBox.Text;
            String password = passwordBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User AUTHORIZED");
                foreach (DataRow row in table.Rows)
                {
                    // получаем все ячейки строки
                    var cells = row.ItemArray;
                   

                    if ((Boolean)cells[8] == false)
                    {
                        CurrentUser2.setID(Convert.ToInt32(cells[0]));
                        CurrentUser2.setFName((string)cells[1]);
                        CurrentUser2.setSName((string)cells[2]);
                        CurrentUser2.setTName((string)cells[3]);
                        CurrentUser2.setPhone((string)cells[4]);
                        CurrentUser2.setLogin((string)cells[5]);
                        CurrentUser2.setPassword((string)cells[6]);
                        CurrentUser2.setMail((string)cells[7]);
                        CurrentUser2.setAdmin((Boolean)cells[8]);

                        UserForm form1 = new UserForm(CurrentUser2);
                        this.Hide();
                        form1.ShowDialog();
                        form1.Close();
                        this.Show();
                    }
                    else if ((Boolean)cells[8] == true)
                    {

                        CurrentUser1.setID(Convert.ToInt32(cells[0]));
                        CurrentUser1.setFName((string)cells[1]);
                        CurrentUser1.setSName((string)cells[2]);
                        CurrentUser1.setTName((string)cells[3]);
                        CurrentUser1.setPhone((string)cells[4]);
                        CurrentUser1.setLogin((string)cells[5]);
                        CurrentUser1.setPassword((string)cells[6]);
                        CurrentUser1.setMail((string)cells[7]);
                        CurrentUser1.setAdmin((Boolean)cells[8]);

                        AdminForm form2 = new AdminForm(CurrentUser1);
                        this.Hide();
                        form2.ShowDialog();
                        form2.Close();
                        this.Show();
                    }

                   
                   
                }
            }
            else
                MessageBox.Show("По введеним даним користувача не існує");
        }

        private void loginBox_Leave(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
                loginBox.Text = "Логін";
        }


        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.UseSystemPasswordChar = false;
                passwordBox.Text = "Пароль";
            }
        }

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            RegisterForm1 f1 = new RegisterForm1();
            this.Hide();
            f1.ShowDialog();
            Application.Exit();
        }

      
    }
}
