namespace BankWithUs
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BankContext : DbContext
    {
        public BankContext()
            : base("name=BankContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Receipt> Receipts { get; set; }

    }
}