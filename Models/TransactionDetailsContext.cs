using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class TransactionDetailsContext : DbContext
    {
        public TransactionDetailsContext(DbContextOptions<TransactionDetailsContext> options) : base(options)
        {

        }

        public DbSet<TransactionDetails> TransactionDetails { get; set; }
    }
}
