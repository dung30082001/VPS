using BusinessObject.Models;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace APIConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private IContractRepository repository = new ContractRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Contract>>> GetContract()
        {
            return repository.GetContract();
        }
        //[HttpGet]
        [HttpGet("{id}")]
        public async Task<ActionResult<Contract>> GetContractById(int id)
        {
            return repository.GetContractById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContract(int id, Contract contract)
        {
            repository.UpdateContract(id, contract);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContract(int id)
        {
            var account = repository.GetContractById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteContract(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Contract>> PostContract(Contract contract)
        {
            repository.AddContract(contract);
            return NoContent();
        }
    }
}
