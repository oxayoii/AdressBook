using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Models
{
    public partial class Users
    {
        [Key]
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? Role { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Company { get; set; }
    }
}
