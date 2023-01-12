using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class CustomerDetailsContext : DbContext
    {
        public CustomerDetailsContext(DbContextOptions<CustomerDetailsContext> options) : base(options)
        {

        }

        public DbSet<CustomerDetails> CustomerDetails { get; set; }
    }
}
