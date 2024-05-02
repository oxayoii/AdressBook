using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Models
{
    public partial class Books
    {
        [Key]
        public Guid id { get; set; }
        public string? FIO { get; set; }
        public string? Number { get; set; }
        public Guid UserId { get; set; }
        public Users? Users { get; set; }
    }
}
