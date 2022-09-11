using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Models
{
    public class Address
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content{ get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        [StringLength(5)]
        public string PostCode { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
