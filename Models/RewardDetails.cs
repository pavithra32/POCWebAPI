using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class RewardDetails
    {
        public int customerId { get; set; }
        public int totalRewardPoints { get; set; }
        public List<TransactionHistory> transactonHistory = new List<TransactionHistory>();
    }

    public class TransactionHistory
    {
        public string transactionDate { get; set; }
        public int amount { get; set; }
        public int rewardPoints { get; set; }
    }
}
