using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Models;
using PaymentAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerDetailController : ControllerBase
    {
        private ICustomerDetailsService __customerService;
        private CustomerDetailsContext _context;

        public CustomerDetailController(ICustomerDetailsService service, CustomerDetailsContext context)
        {
            __customerService = service;
            _context = context;
        }
       
        // GET api/<CustomerDetail>/5
        [HttpGet("{id}")]
        public async Task<CustomerDetails> Get(int id)
        {
            return await __customerService.getCustomerDetailsById(_context, id);
        }

        // POST api/<CustomerDetail>
        [HttpPost]
        public IActionResult Post([FromBody] CustomerDetails value)
        {
            var result = __customerService.insertCustomerDetails(_context, value);
            if (result == 1)
            {
                return Ok("Record inserted sucessfully");
            }
            return Ok("Record faled to insert");
        }
        
    }
}
