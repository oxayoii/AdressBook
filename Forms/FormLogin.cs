using AdressBook.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBook
{
    public partial class FormLogin : Form
    {
        private AdressBookContext context = new AdressBookContext();
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonGoRegister_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            var user = context.Users.FirstOrDefault(p => p.Login == login);

            if (user != null && password != null)
            {
                if (context.Users.Any(p => p.Login == login && context.Users.Any(p => p.Password == password)))
                {
                    if (user.Role == "User")
                    {
                        var userEntry = context.Users.FirstOrDefault(u => u.Login == login);

                        FormApp frm = new FormApp(userEntry);
                        frm.Show();
                        this.Hide();
                    }
                    else if (user.Role == "Admin")
                    {
                        FormAdmin frm = new FormAdmin();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
