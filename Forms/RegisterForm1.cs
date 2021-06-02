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
    public partial class RegisterForm1 : Form
    {
        public RegisterForm1()
        {
            InitializeComponent();
            this.ActiveControl = null;
         
        }

        private void registerButton1_Click(object sender, EventArgs e)
        {
            if ((this.fnameBox.Text != "Ім'я") && (this.snameBox.Text != "Прізвище") && (this.tnameBox.Text != "По-батькові") && (this.phoneBox.Text != "Телефон") && (this.emailBox.Text != "Пошта") && (this.fnameBox.Text != "") && (this.snameBox.Text != "") && (this.tnameBox.Text != "") && (this.phoneBox.Text != "") && (this.emailBox.Text != ""))
            {
                RegisterForm2 f2 = new RegisterForm2(this.fnameBox.Text, this.snameBox.Text, this.tnameBox.Text, this.phoneBox.Text, this.emailBox.Text);
                this.Hide();
                f2.ShowDialog();
                Application.Exit();
            }
            else
                MessageBox.Show("Введено не всю інформацію");
        }

        private void fnameBox_Enter(object sender, EventArgs e)
        {
            if (fnameBox.Text == "Ім'я")
                fnameBox.Text = "";
        }

        private void fnameBox_Leave(object sender, EventArgs e)
        {
            if (fnameBox.Text == "")
                fnameBox.Text = "Ім'я";
        }

        private void snameBox_Enter(object sender, EventArgs e)
        {
            if (snameBox.Text == "Прізвище")
                snameBox.Text = "";
        }

        private void snameBox_Leave(object sender, EventArgs e)
        {
            if (snameBox.Text == "")
                snameBox.Text = "Прізвище";
        }

        private void tnameBox_Enter(object sender, EventArgs e)
        {
            if (tnameBox.Text == "По-батькові")
                tnameBox.Text = "";
        }

        private void tnameBox_Leave(object sender, EventArgs e)
        {
            if (tnameBox.Text == "")
                tnameBox.Text = "По-батькові";
        }

        private void phoneBox_Enter(object sender, EventArgs e)
        {
            if (phoneBox.Text == "Телефон")
                phoneBox.Text = "";
        }

        private void phoneBox_Leave(object sender, EventArgs e)
        {
            if (phoneBox.Text == "")
                phoneBox.Text = "Телефон";
        }

        private void emailBox_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "Пошта")
                emailBox.Text = "";
        }

        private void emailBox_Leave(object sender, EventArgs e)
        {
            if (emailBox.Text == "")
                emailBox.Text = "Пошта";
        }

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

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void RegisterForm1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

    }
}
