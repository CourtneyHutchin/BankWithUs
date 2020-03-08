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
        public int DebitNum { get; set; }
        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int AccountPin { get; set; }

        [Required]
        public int PhoneNum { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int CheckingAmount { get; set; }

        [Required]
        public int SavingsAmount { get; set; }

    }
}
