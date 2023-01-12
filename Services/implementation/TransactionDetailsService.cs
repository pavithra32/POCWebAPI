using PaymentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Services.implementation
{
    public class TransactionDetailsService : ITransactionDetailsService
    {
        public RewardDetails GetRewardDetailsByCustomerId(TransactionDetailsContext _context, int customerId)
        {
            RewardDetails details = new RewardDetails();
            var transactionHistory =  _context.TransactionDetails.Where(x => x.CustomerId == customerId).ToList();
            details.customerId = customerId;
            var total = 0;
            transactionHistory.ForEach((x) =>
            {
                var history = new TransactionHistory();
                history.transactionDate = x.transactionDate.ToShortDateString();
                history.amount = x.Amount;
                history.rewardPoints = this.calcualteRewardPoints(x.Amount);
                details.transactonHistory.Add(history);
                total += history.rewardPoints;

            });
            details.totalRewardPoints = total;


            return details;

        }

        public async Task<List<TransactionDetails>> getTransactionByCustomerId(TransactionDetailsContext _context, int customerId)
        {
            var details = _context.TransactionDetails.Where(x => x.CustomerId == customerId).ToList();
            return details;
        }

        public int insertTransactionalDetails(TransactionDetailsContext _context, TransactionDetails details)
        {
            TransactionDetails record = new TransactionDetails();
            record.Amount = details.Amount;
            record.CustomerId = details.CustomerId;
            record.transactionDate = details.transactionDate;
            _context.TransactionDetails.Add(record);
            return _context.SaveChanges(); ;
        }
        private int calcualteRewardPoints(int amount)
        {
            int rewardPoints = 0;
            if(amount > 100)
            {
                rewardPoints = 50 + ((amount - 100) * 2);
            }
            else if (amount <= 100 && amount >= 50)
            {
                rewardPoints = (amount - 50);
            }
            return rewardPoints;
        }
    }
}
