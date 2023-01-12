using PaymentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Services
{
    public interface ICustomerDetailsService
    {
        Task<CustomerDetails> getCustomerDetailsById(CustomerDetailsContext _context, int customerId);
        Task<CustomerDetails[]> getAllCustomerDetails();
        int insertCustomerDetails(CustomerDetailsContext _context, CustomerDetails details);
    }
}
