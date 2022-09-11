using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Debe colocar su nombre")]
        [StringLength(40)]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        [StringLength(32)]
        public string Email { get; set; }

        [Required]
        public int Age { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> BirthDay { get; set; }

        //Customer.Address[0]
        //Customer.Address[1]
        public IList<Address> Adresses { get; set; }

        public Gender Gender {get;set;}

        public CreditCard CreditCard { get; set; }
        public string GetFullName()
        {
            return $"{Name} {Email} {Age}";
        }

    }
}
