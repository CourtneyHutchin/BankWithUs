using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankWithUs
{
    class Account
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public int AccountNum { get; set; }

        [Required]
        [CreditCard]
        public int DebitNum { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(4, 4)]
        public int AccountPin { get; set; }

        [Required]
        [Phone]
        public int PhoneNum { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double CheckingAmount { get; set; }

        [Required]
        public double SavingsAmount { get; set; }

    }
}
