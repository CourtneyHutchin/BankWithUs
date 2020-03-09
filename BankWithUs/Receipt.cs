using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankWithUs
{
    /// <summary>
    /// Represents a single transaction
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// Unique id for the receipt
        /// </summary>
        [Key]
        public int ReceiptId { get; set; }

        /// <summary>
        /// Account number of the user
        /// </summary>
        [Required]
        public int AccountNumber { get; set; }

        [Required, StringLength(15)]
        public string FirstName { get; set; }

        [Required, StringLength(15)]
        public string LastName { get; set; }

        /// <summary>
        /// The amount they transfered or deposited
        /// </summary>
        [Required]
        public double Amount { get; set; }

        /// <summary>
        /// The user's updated cheking balance after the transaction
        /// </summary>
        [Required]
        public double NewCheckingBalance { get; set; }

        /// <summary>
        /// The user's updated savings balance after the transaction
        /// </summary>
        [Required]
        public double NewSavingsBalance { get; set; }

        /// <summary>
        /// Date of the transfer or deposit
        /// </summary>
        [Required]
        public DateTime TransactionDate { get; set; }
    }
}
