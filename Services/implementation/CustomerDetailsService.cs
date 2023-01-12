using PaymentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Services.implementation
{
    public class CustomerDetailsService : ICustomerDetailsService
    {

        public Task<CustomerDetails[]> getAllCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerDetails> getCustomerDetailsById(CustomerDetailsContext _context, int customerId)
        {
            var details = _context.CustomerDetails.Find(customerId);
            return details;
        }

        public int insertCustomerDetails(CustomerDetailsContext _context, CustomerDetails details)
        {
            CustomerDetails record = new CustomerDetails();
            record.CustomerName = details.CustomerName;
             _context.CustomerDetails.Add(record);
            return _context.SaveChanges(); ;
        }

    }
}
