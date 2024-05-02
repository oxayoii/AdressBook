using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Models
{
    public class Report
    {
        [Key]
        public Guid Id { get; set; }
        public string Changes { get; set; }
        public DateTime Time {  get; set; }
        public Guid UserId { get; set; }
        public Users? Users { get; set; }
    }
}
