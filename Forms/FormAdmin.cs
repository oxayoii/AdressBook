using AdressBook.Data;
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
    public partial class FormAdmin : Form
    {
        private AdressBookContext context = new AdressBookContext();
        public FormAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            var data = context.Users.ToList();
            dataGridView.DataSource = data;

            comboBoxOrg.Items.Add("Мегафон");
            comboBoxOrg.Items.Add("Теле2");
            comboBoxOrg.Items.Add("Билайн");

            comboBoxRole.Items.Add("User");
            comboBoxRole.Items.Add("Admin");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(textBoxId.Text);
            var company = comboBoxOrg.Text.ToString();
            var role = comboBoxRole.Text.ToString();

            var record = context.Users.Find(id);

            if (record != null)
            {
                record.Role = role;
                record.Company = company;
                context.SaveChanges();

                MessageBox.Show("Данные успешно сохранены");
                var data = context.Users.ToList();
                dataGridView.DataSource = data;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[selectedRow];
                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxSurename.Text = row.Cells[2].Value.ToString();
                textBoxLogin.Text = row.Cells[4].Value.ToString();
                textBoxPassword.Text = row.Cells[5].Value.ToString();
                comboBoxOrg.Text = row.Cells[6].Value.ToString();
                comboBoxRole.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    Guid id = (Guid)row.Cells["Id"].Value;
                    var record = context.Users.FirstOrDefault(p => p.Id == id);
                    if (record != null)
                    {
                        context.Users.Remove(record);
                    }
                    context.SaveChanges();
                    MessageBox.Show("Данные удалены.");
                    var data = context.Users.ToList();
                    dataGridView.DataSource = data;
                }
            }
            else
            {
                MessageBox.Show("Выберите данные для удаления");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}
