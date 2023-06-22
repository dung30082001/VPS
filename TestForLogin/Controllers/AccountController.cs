using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace TestForLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private IAccountRepository repository = new AccountRepository();
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccount()
        {
            return repository.GetAccount();
        }
        [HttpGet]
        [Route("total")]
        public async Task<int> GetTotalAccount()
        {
            return repository.GetTotalAccount();
        }
    [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccountById(int id)
        {
            return repository.GetAccountById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccount(int id, Account account)
        {
            repository.UpdateAccount(id, account);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            var account =  repository.GetAccountById(id);
            if (account == null)
            {
                return NotFound();
            }

            repository.DeleteAccount(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Account>> PostAccount(Account acc)
        {
            repository.AddAccount(acc);
            return NoContent();
        }
    }
}
