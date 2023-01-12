using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PaymentAPI.Models;
using PaymentAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionDetailController : ControllerBase
    {
        private ITransactionDetailsService __customerService;
        private TransactionDetailsContext _context;

        public TransactionDetailController(ITransactionDetailsService service, TransactionDetailsContext context)
        {
            __customerService = service;
            _context = context;
        }
        // GET api/<CustomerDetail>/5
        [HttpGet("{id}")]
        public async Task<List<TransactionDetails>> Get(int id)
        {
            return await __customerService.getTransactionByCustomerId(_context, id);
        }

        // POST api/<CustomerDetail>
        [HttpPost]
        public IActionResult Post([FromBody] TransactionDetails value)
        {
            var result = __customerService.insertTransactionalDetails(_context, value);
            if (result == 1)
            {
                return Ok("Record inserted sucessfully");
            }
            return Ok("Record faled to insert");
        }

        [HttpGet("getRewards")]
        public ActionResult GetRewardByCustomerId(int id)
        {
            var result =  __customerService.GetRewardDetailsByCustomerId(_context, id);
            var response = JsonConvert.SerializeObject(result);
            return Ok(response);
        }

        [HttpGet("getrewards/{id}")]
        public async Task<List<TransactionDetails>> GetRewardForAllCutomer(int id)
        {
            return await __customerService.getTransactionByCustomerId(_context, id);
        }
    }
}
