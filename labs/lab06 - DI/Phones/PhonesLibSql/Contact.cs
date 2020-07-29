using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesLibSql
{
    [Table("Contacts")]
    public class Contact
    {
        public long Id { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Contact() { }
    }
}
