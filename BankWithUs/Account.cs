using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankWithUs
{
    /// <summary>
    /// This is the bank account class per user, all fields required for creation
    /// This uses Data Annotations taken from : https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netframework-4.8
    /// </summary>
    class Account
    {
        /// <summary>
        /// Key element for account, CustomerId
        /// </summary>
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public int AccountNum { get; set; }

        /// <summary>
        /// Required debitNum, validated same as a Credit Card
        /// </summary>
        [Required]
        [CreditCard]
        public int DebitNum { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Required Email Address, simple validation as email address annotation
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Account pin range may be adjusted but should be a four digit pin, min 4, max 4 digits
        /// </summary>
        [Required]
        [Range(4, 4)]
        public int AccountPin { get; set; }

        /// <summary>
        /// Phone number set as Phone validation
        /// </summary>
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
