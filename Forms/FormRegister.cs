using AdressBook.Data;
using AdressBook.Models;
using Microsoft.EntityFrameworkCore;

namespace AdressBook
{
    public partial class FormRegister : System.Windows.Forms.Form
    {
        private AdressBookContext context = new AdressBookContext();
        public FormRegister()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Add("ÃÂ„‡ÙÓÌ");
            comboBox.Items.Add("“ÂÎÂ2");
            comboBox.Items.Add("¡ËÎ‡ÈÌ");
        }
        private void buttonGoLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var password = textBoxPassword.Text;
            var repeatPassword = textBoxRepeatPassword.Text;
            string newLogin = textBoxLogin.Text;
            bool isDuplicate = context.Users.Any(p => p.Login == newLogin);
            var organization = comboBox.Text.ToString();

            if (isDuplicate)
            {
                buttonRegister.Enabled = false;
            }
            else
            {
                if (textBoxName.Text.Length < 2 || textBoxSurename.Text.Length < 2 || newLogin.Length < 3
                    && password.Length < 4 || password != repeatPassword)
                {
                    buttonRegister.Enabled = false;
                }
                else
                {
                    var newUser = new Users()
                    {
                        FirstName = textBoxName.Text,
                        SecondName = textBoxSurename.Text,
                        Role = "User",
                        Login = newLogin,
                        Password = password,
                        Company = organization
                    };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    buttonRegister.Enabled = true;

                    FormLogin frm = new FormLogin();
                    frm.Show();
                    this.Hide();
                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string newLogin = textBoxLogin.Text;
            bool isDuplicate = context.Users.Any(p => p.Login == newLogin);

            if (isDuplicate)
            {
                labelLogin.Text = "ÀŒ√»Õ «¿Õﬂ“";
                labelLogin.Show();
                labelLogin.ForeColor = Color.FromArgb(255, 0, 0);
                panelLogin.Show();
                panelLogin.BackColor = Color.FromArgb(255, 0, 0);
            }
            else if (textBoxLogin.Text.Length < 3)
            {
                labelLogin.Text = "—À»ÿ ŒÃ  Œ–Œ“ »…";
                labelLogin.Show();
                labelLogin.ForeColor = Color.FromArgb(255, 0, 0);
                panelLogin.Show();
                panelLogin.BackColor = Color.FromArgb(255, 0, 0);
            }
            else if (textBoxPassword.Text.Length < 4)
            {
                labelPassword.Text = "—À»ÿ ŒÃ  Œ–Œ“ »…";
                labelPassword.Show();
                labelPassword.ForeColor = Color.FromArgb(255, 0, 0);
                panelPassword.Show();
                panelPassword.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                labelLogin.Hide();
                panelLogin.Hide();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4)
            {
                labelPassword.Text = "—À»ÿ ŒÃ  Œ–Œ“ »…";
                labelPassword.Show();
                labelPassword.ForeColor = Color.FromArgb(255, 0, 0);
                panelPassword.Show();
                panelPassword.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                labelPassword.Hide();
                panelPassword.Hide();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                labelRepeatPassword.Text = "œ¿–ŒÀ» Õ≈ —Œ¬œ¿ƒ¿ﬁ“";
                labelRepeatPassword.Show();
                labelRepeatPassword.ForeColor = Color.FromArgb(255, 0, 0);
                panelRepeatPassword.Show();
                panelRepeatPassword.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                labelRepeatPassword.Hide();
                panelRepeatPassword.Hide();
            }
        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = 'ï';
            textBoxPassword.MaxLength = 7;
            textBoxRepeatPassword.PasswordChar = 'ï';
            textBoxRepeatPassword.MaxLength = 7;
            textBoxLogin.MaxLength = 7;
            textBoxName.MaxLength = 10;
            textBoxSurename.MaxLength = 15;

            labelLogin.Hide();
            panelLogin.Hide();
            labelPassword.Hide();
            panelPassword.Hide();
            labelRepeatPassword.Hide();
            panelRepeatPassword.Hide();
        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Start();
        }
        private void textBoxName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxSurename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
