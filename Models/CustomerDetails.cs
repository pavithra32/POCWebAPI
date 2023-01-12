using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class CustomerDetails
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string CustomerName { get; set; }
    }
}
