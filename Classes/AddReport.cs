using AdressBook.Data;
using AdressBook.Models;

namespace AdressBook.Classes
{
    public class AddReport
    {
        private AdressBookContext context = new AdressBookContext();
        public void Add(string fio, string number, Guid id)
        {
            var newReport = new Report
            {
                Changes = "Добавление:" + fio + number,
                Time = DateTime.Now,
                UserId = id
            };
            context.Report.Add(newReport);
            context.SaveChanges();
        }
        public void Delete(string fio, string number, Guid id)
        {
            var newReport = new Report
            {
                Changes = "Удаление:" + fio + number,
                Time = DateTime.Now,
                UserId = id
            };
            context.Report.Add(newReport);
            context.SaveChanges();
        }
        public void Edit(string fio, string number, Guid id)
        {
            var newReport = new Report
            {
                Changes = "Редактирование:" + fio + number,
                Time = DateTime.Now,
                UserId = id
            };
            context.Report.Add(newReport);
            context.SaveChanges();
        }
    }
}
