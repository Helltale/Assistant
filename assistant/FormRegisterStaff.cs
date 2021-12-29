using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace assistant
{
    public partial class FormRegisterStaff : Form
    {
        public FormRegisterStaff()
        {
            InitializeComponent();
        }

        private bool IsUser
        {
            get
            {
                //проверка логина и почты на уникальность
                bool been = false;

                string loginUser = textBoxRS_login.Text;
                string mailUser = textBoxRS_mailS.Text;

                DatabaseMNG _databaseMNG = new DatabaseMNG();
                DataTable _dataTable = new DataTable();
                MySqlDataAdapter _mySqlDataAdapter = new MySqlDataAdapter();
                MySqlCommand _mySqlCommand = new MySqlCommand("SELECT * FROM 'users' WHERE 'login = @UserLogin' AND" +
                    "'mail' = @UserMail", _databaseMNG.GetConnection); //@UserLogin, @UserMail - заглушки

                //меняем заглушки на переменные
                _mySqlCommand.Parameters.Add("@UserLogin", MySqlDbType.VarChar).Value = loginUser;
                _mySqlCommand.Parameters.Add("@UserMail", MySqlDbType.VarChar).Value = mailUser;

                _mySqlDataAdapter.SelectCommand = _mySqlCommand;//выбираем коммпанду
                _mySqlDataAdapter.Fill(_dataTable);//заполняем данные в таблицу

                if(_dataTable.Rows.Count > 0)
                {
                    been = true;
                    if(MessageBox.Show("Такой пользовательуже существует\nПерейти на вкладку входа?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                    }    
                }




            }
        }

        private void buttonRS_create_Click(object sender, EventArgs e)
        {
            if (textBoxRS_login.Text == "Логин" || textBoxRS_password.Text == "Пароль"  //проверка на заполненность полей
                || textBoxRS_password1.Text == "Повторите пароль" || textBoxRS_mailS.Text == "Почта")
            {
                MessageBox.Show("Не все поля введены", "Ошибка");
                return;
            }

            if(!IsUser)
            {
                
            }
        }








        private void FormRegisterStaff_Load(object sender, EventArgs e)
        {

        }

        private void textBoxRS_login_Enter(object sender, EventArgs e)
        {
            if (textBoxRS_login.Text == "Логин")//если вводится подсказка
            {
                textBoxRS_login.Text = "";
                textBoxRS_login.ForeColor = Color.Black;
            }
        }

        private void textBoxRS_login_Leave(object sender, EventArgs e)
        {
            if (textBoxRS_login.Text == "")//если ничего нет
            {
                textBoxRS_login.Text = "Логин";
                textBoxRS_login.ForeColor = Color.Gray;
            }
        }

        private void textBoxRS_password_Enter(object sender, EventArgs e)
        {
            if (textBoxRS_password.Text == "Пароль")//если вводится подсказка
            {
                textBoxRS_password.Text = "";
                textBoxRS_password.ForeColor = Color.Black;
            }
        }

        private void textBoxRS_password_Leave(object sender, EventArgs e)
        {
            if (textBoxRS_password.Text == "")//если ничего нет
            {
                textBoxRS_password.Text = "Пароль";
                textBoxRS_password.ForeColor = Color.Gray;
            }
        }

        private void textBoxRS_password1_Enter(object sender, EventArgs e)
        {
            if (textBoxRS_password1.Text == "Повторите пароль")//если вводится подсказка
            {
                textBoxRS_password1.Text = "";
                textBoxRS_password1.ForeColor = Color.Black;
            }
        }

        private void textBoxRS_password1_Leave(object sender, EventArgs e)
        {
            if (textBoxRS_password1.Text == "")//если ничего нет
            {
                textBoxRS_password1.Text = "Повторите пароль";
                textBoxRS_password1.ForeColor = Color.Gray;
            }
        }

        private void textBoxRS_mailS_Enter(object sender, EventArgs e)
        {
            if (textBoxRS_mailS.Text == "Почта")//если вводится подсказка
            {
                textBoxRS_mailS.Text = "";
                textBoxRS_mailS.ForeColor = Color.Black;
            }
        }

        private void textBoxRS_mailS_Leave(object sender, EventArgs e)
        {
            if (textBoxRS_mailS.Text == "")//если ничего нет
            {
                textBoxRS_mailS.Text = "Почта";
                textBoxRS_mailS.ForeColor = Color.Gray;
            }
        }

        
    }
}
