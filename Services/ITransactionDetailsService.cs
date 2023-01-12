using PaymentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Services
{
    public interface ITransactionDetailsService
    {
        Task<List<TransactionDetails>> getTransactionByCustomerId(TransactionDetailsContext _context, int customerId);

        int insertTransactionalDetails(TransactionDetailsContext _context, TransactionDetails details);

        RewardDetails GetRewardDetailsByCustomerId(TransactionDetailsContext _context, int customerId);
    }
}
