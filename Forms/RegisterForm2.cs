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
    public partial class RegisterForm2 : Form
    {
        String fName;
        String sName;
        String tName;
        String phone;
        String email;
        public RegisterForm2(string f1fName, String f1sName, String f1tName, String f1phone, String f1email)
        {
            InitializeComponent();
            fName = f1fName;
            sName = f1sName;
            tName = f1tName;
            phone = f1phone;
            email = f1email;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
           
            if (passwordBox.Text == password2Box.Text)
            {
                passwordStatusLabel.Text = "Паролі співпадають";
                passwordStatusLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                passwordStatusLabel.Text = "Паролі не співпадають";
                passwordStatusLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void password2Box_TextChanged(object sender, EventArgs e)
        {
            
            if (passwordBox.Text == password2Box.Text)
            {
                passwordStatusLabel.Text = "Паролі співпадають";
                passwordStatusLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                passwordStatusLabel.Text = "Паролі не співпадають";
                passwordStatusLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            if(loginBox.Text == "Логін")
            loginBox.Text = "";
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            if (passwordBox.Text == "Пароль")
            {
                passwordBox.Text = "";
            }

        }

        private void password2Box_Click(object sender, EventArgs e)
        {
            password2Box.UseSystemPasswordChar = true;
            if (password2Box.Text == "повтор Паролю")
            {
                password2Box.Text = "";
            }
        }

        //функции иконки закрытия
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
           label1.ForeColor = Color.Silver;
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

        private void password2Box_Leave(object sender, EventArgs e)
        {
            if (password2Box.Text == "")
            {
                password2Box.UseSystemPasswordChar = false;
                password2Box.Text = "повтор Паролю";
            }
        }

        private void registerButton1_Click(object sender, EventArgs e)
        {

            if(loginBox.Text == "Логін" || passwordBox.Text == "Пароль" || password2Box.Text == "повтор Паролю")
            {
                MessageBox.Show("Не всі дані введено");
                return;
            }  
            if(passwordBox.Text != password2Box.Text)
            {
                MessageBox.Show("Паролі не співпадають");
                return;
            }

            if (isUserExists() == true)
                return;

            DB db = new DB();
            


            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`firstName`, `secondName`, `thirdName`, `phoneNumber`, `login`, `password`, `email`) VALUES (@fName, @sName, @tName, @phone, @login, @password, @mail)", db.getConnection());
            command.Parameters.Add("@fName", MySqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = sName;
            command.Parameters.Add("@tName", MySqlDbType.VarChar).Value = tName;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Реєстрацію завершено");
            else
                MessageBox.Show("Реєстрацію не вдалося завершити");

            db.closeConnection();
            LoginForm f2 = new LoginForm();
            this.Hide();
            f2.ShowDialog();
            Application.Exit();
        }

        private Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginBox.Text;

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

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }
        private void RegisterForm2_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
