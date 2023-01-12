using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class TransactionDetails
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "number")]
        public int CustomerId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime transactionDate { get; set; }

        [Column(TypeName = "number")]
        public int Amount { get; set; }
    }
}
