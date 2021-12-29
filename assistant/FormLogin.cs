using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assistant
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //инициализируем подсказки в текстбоксах
            login_textBox.Text = "Login";
            login_textBox.ForeColor = Color.Gray;

            password_textBox.Text = "Password";
            password_textBox.ForeColor = Color.Gray;
        }

        private void login_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_Enter(object sender, EventArgs e)
        {

        }

        private void FormLogin_Leave(object sender, EventArgs e)
        {

        }

        private void login_textBox_Enter(object sender, EventArgs e)
        {
            if(login_textBox.Text == "Login")//если вводится подсказка
            {
                login_textBox.Text = "";
                login_textBox.ForeColor = Color.Black;
            }
        }

        private void login_textBox_Leave(object sender, EventArgs e)
        {
            if (login_textBox.Text == "")//если вводится подсказка
            {
                login_textBox.Text = "Login";
                login_textBox.ForeColor = Color.Gray;
            }
        }

        private void password_textBox_Enter(object sender, EventArgs e)
        {
            if (login_textBox.Text == "Password")//если вводится подсказка
            {
                login_textBox.Text = "";
                login_textBox.ForeColor = Color.Black;
            }
        }

        private void password_textBox_Leave(object sender, EventArgs e)
        {
            if (login_textBox.Text == "")//если ничего нет
            {
                login_textBox.Text = "Password";
                login_textBox.ForeColor = Color.Gray;
            }
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            if(login_textBox.Text == "Login")//не введён логин
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if(login_textBox.Text == "Login" || password_textBox.Text == "Password")//неправильно введён логин или пароль, обратитесь к администратору
            {
                MessageBox.Show("Неправильно введён логин или пароль,\nпри необходимости обратитесь к администратору.");
            }
        }

        private void password_textBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void password_textBox_Enter_1(object sender, EventArgs e)
        {
            if (password_textBox.Text == "Password")//если вводится подсказка
            {
                password_textBox.Text = "";
                password_textBox.ForeColor = Color.Black;
            }
        }

        private void password_textBox_Leave_1(object sender, EventArgs e)
        {
            if (password_textBox.Text == "")//если ничего нет
            {
                password_textBox.Text = "Password";
                password_textBox.ForeColor = Color.Gray;
            }
        }
    }
}
