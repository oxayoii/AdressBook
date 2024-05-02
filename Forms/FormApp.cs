using AdressBook.Data;
using AdressBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AdressBook.Classes;

namespace AdressBook
{
    public partial class FormApp : Form
    {
        private AdressBookContext context = new AdressBookContext();
        AddReport addReport = new AddReport();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        public FormApp(Users user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            labelId.Text = user.Id.ToString();
            LoadDataGrid();

            //  timer.Interval = 24 * 60 * 60 * 1000; // 24 часа в миллисекундах
            timer.Interval = 10000;
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Guid idUser = Guid.Parse(labelId.Text);
            var changes = context.Report.Where(b => b.UserId == idUser).ToList();

            listBoxReport.Items.Clear();

            foreach (var change in changes)
            {
                listBoxReport.Items.Add($"{change.Changes} в {change.Time}");
            }
        }
        private void LoadDataGrid()
        {
            Guid id = Guid.Parse(labelId.Text);
            var data = context.Books.Where(b => b.UserId == id).Select(
                x => new
                {
                    N = x.id,
                    ФИО = x.FIO,
                    Телефон = x.Number
                }).ToList();
            dataGridView.DataSource = data;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var FIO = textBoxFIO.Text.ToString();
            var number = textBoxPhone.Text.ToString();
            Guid id = Guid.Parse(labelId.Text);

            if (FIO.Length > 5 && number.Length == 11)
            {
                var newItem = new Books
                {
                    FIO = FIO,
                    Number = number,
                    UserId = id
                };
                context.Books.Add(newItem);
                context.SaveChanges();
                LoadDataGrid();
                addReport.Add(FIO, number, id);
            }
            else
            {
                MessageBox.Show("Неккоректные данные");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    Guid id = (Guid)row.Cells["N"].Value;
                    var record = context.Books.FirstOrDefault(p => p.id == id);
                    if (record != null)
                    {
                        var FIO = record.FIO;
                        var number = record.Number;
                        addReport.Delete(FIO, number, id);
                        context.Books.Remove(record);
                    }
                    context.SaveChanges();
                    LoadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите данные для удаления");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var number = Guid.Parse(textBoxNumber.Text);
            var fio = textBoxFIO.Text.ToString();
            var phone = textBoxPhone.Text.ToString();

            var record = context.Books.Find(number);
            if (record != null)
            {
                if (fio.Length > 5 && phone.Length == 11)
                {
                    record.id = number;
                    record.FIO = fio;
                    record.Number = phone;
                    record.UserId = Guid.Parse(labelId.Text);
                    context.SaveChanges();
                    LoadDataGrid();
                    addReport.Edit(fio, phone, number);
                }
                else
                {
                    MessageBox.Show("Введите корректные данные");
                }
            }
            else
            {
                MessageBox.Show("Выберите запись, которую вы хотите отредактировать");
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(labelId.Text);
            string searchText = textBoxSearch.Text.ToLower().Trim();
            var books = context.Books.Where(p => p.UserId == id)
                .Where(b => b.FIO.ToLower().Contains(searchText) || b.Number.ToLower().Contains(searchText)).ToList();  
                dataGridView.DataSource = books; 
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[selectedRow];
                textBoxNumber.Text = row.Cells[0].Value.ToString();
                textBoxFIO.Text = row.Cells[1].Value.ToString();
                textBoxPhone.Text = row.Cells[2].Value.ToString();
            }
        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
