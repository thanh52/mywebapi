using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Data.Models
{
    [Table("User")]
    public class User:BaseClass
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set;}
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
    }
}
