using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Backend.Models;
using App.Backend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        private ReceiptRepository _repository;


        public ReceiptController()
        {
            _repository = new ReceiptRepository();
        }

        // GET api/receipts
        [HttpGet]
        public ActionResult<IEnumerable<Receipt>> Get()
        {
            return Ok(_repository.All());
        }

        // GET api/receipts/5
        [HttpGet("{id}")]
        public ActionResult<Receipt> Get(int id)
        {
            return Ok(_repository.Get(id));
        }

        // POST api/receipts
        [HttpPost]
        public void Post([FromBody] Receipt receipt)
        {
            _repository.Create(receipt);
        }

        // PUT api/receipts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Receipt receipt)
        {
            _repository.Update(id, receipt);
        }

        // DELETE api/receipts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(_repository.Get(id));
        }
    }
}