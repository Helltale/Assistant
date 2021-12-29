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
    public partial class FormRegisterClients : Form
    {
        public FormRegisterClients()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRC_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRC_firstname_Enter(object sender, EventArgs e)
        {
            if (textBoxRC_firstname.Text == "Имя")//если вводится подсказка
            {
                textBoxRC_firstname.Text = "";
                textBoxRC_firstname.ForeColor = Color.Black;
            }
        }

        private void textBoxRC_firstname_Leave(object sender, EventArgs e)
        {
            if (textBoxRC_firstname.Text == "")//если ничего нет
            {
                textBoxRC_firstname.Text = "Имя";
                textBoxRC_firstname.ForeColor = Color.Gray;
            }
        }

        private void textBoxRC_lastname_Enter(object sender, EventArgs e)
        {
            if (textBoxRC_lastname.Text == "Фамилия")//если вводится подсказка
            {
                textBoxRC_lastname.Text = "";
                textBoxRC_lastname.ForeColor = Color.Black;
            }
        }

        private void textBoxRC_lastname_Leave(object sender, EventArgs e)
        {
            if (textBoxRC_lastname.Text == "")//если ничего нет
            {
                textBoxRC_lastname.Text = "Фамилия";
                textBoxRC_lastname.ForeColor = Color.Gray;
            }
        }

        private void textBoxRC_patronymuc_Enter(object sender, EventArgs e)
        {
            if (textBoxRC_patronymuc.Text == "Отчество")//если вводится подсказка
            {
                textBoxRC_patronymuc.Text = "";
                textBoxRC_patronymuc.ForeColor = Color.Black;
            }
        }

        private void textBoxRC_patronymuc_Leave(object sender, EventArgs e)
        {
            if (textBoxRC_patronymuc.Text == "")//если ничего нет
            {
                textBoxRC_patronymuc.Text = "Отчество";
                textBoxRC_patronymuc.ForeColor = Color.Gray;
            }
        }

        private void textBoxRC_birthday_Enter(object sender, EventArgs e)
        {
            if (textBoxRC_birthday.Text == "Дата рождения")//если вводится подсказка
            {
                textBoxRC_birthday.Text = "";
                textBoxRC_birthday.ForeColor = Color.Black;
            }
        }

        private void textBoxRC_birthday_Leave(object sender, EventArgs e)
        {
            if (textBoxRC_birthday.Text == "")//если ничего нет
            {
                textBoxRC_birthday.Text = "Дата рождения";
                textBoxRC_birthday.ForeColor = Color.Gray;
            }
        }

        private void textBoxRC_telephone_Enter(object sender, EventArgs e)
        {
            if (textBoxRC_telephone.Text == "Телефон")//если вводится подсказка
            {
                textBoxRC_telephone.Text = "";
                textBoxRC_telephone.ForeColor = Color.Black;
            }
        }

        private void textBoxRC_telephone_Leave(object sender, EventArgs e)
        {
            if (textBoxRC_telephone.Text == "")//если ничего нет
            {
                textBoxRC_telephone.Text = "Телефон";
                textBoxRC_telephone.ForeColor = Color.Gray;
            }
        }

        private void textBoxRC_email_Enter(object sender, EventArgs e)
        {
            if (textBoxRC_email.Text == "E-mail")//если вводится подсказка
            {
                textBoxRC_email.Text = "";
                textBoxRC_email.ForeColor = Color.Black;
            }
        }

        private void textBoxRC_email_Leave(object sender, EventArgs e)
        {
            if (textBoxRC_email.Text == "")//если ничего нет
            {
                textBoxRC_email.Text = "E-mail";
                textBoxRC_email.ForeColor = Color.Gray;
            }
        }

        private void buttonRC_create_Click(object sender, EventArgs e)
        {

        }
    }
}
