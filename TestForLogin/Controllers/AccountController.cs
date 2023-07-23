using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace APIConnect.Controllers
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
        [Route("taikhoangthang1")]
        public IActionResult GetOrder1()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-01-01") && o.CreatedDate <= Convert.ToDateTime("2023-01-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang2")]
        public IActionResult GetOrder2()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-02-01") && o.CreatedDate <= Convert.ToDateTime("2023-02-28"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang3")]
        public IActionResult GetOrder3()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-03-01") && o.CreatedDate <= Convert.ToDateTime("2023-03-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang4")]
        public IActionResult GetOrder4()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-04-01") && o.CreatedDate <= Convert.ToDateTime("2023-04-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang5")]
        public IActionResult GetOrder5()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-05-01") && o.CreatedDate <= Convert.ToDateTime("2023-05-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang6")]
        public IActionResult GetOrder6()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-06-01") && o.CreatedDate <= Convert.ToDateTime("2023-06-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang7")]
        public IActionResult GetOrder7()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-07-01") && o.CreatedDate <= Convert.ToDateTime("2023-07-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang8")]
        public IActionResult GetOrder8()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-08-01") && o.CreatedDate <= Convert.ToDateTime("2023-08-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang9")]
        public IActionResult GetOrder9()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-09-01") && o.CreatedDate <= Convert.ToDateTime("2023-09-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang10")]
        public IActionResult GetOrder10()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-10-01") && o.CreatedDate <= Convert.ToDateTime("2023-10-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang11")]
        public IActionResult GetOrder11()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-11-01") && o.CreatedDate <= Convert.ToDateTime("2023-11-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("taikhoangthang12")]
        public IActionResult GetOrder12()
        {
            VPSContext context = new VPSContext();
            var totalAccount = context.Accounts
        .Where(o => o.CreatedDate >= Convert.ToDateTime("2023-12-01") && o.CreatedDate <= Convert.ToDateTime("2023-12-30"))
        .Count();
            return Ok(totalAccount);
        }
        [HttpGet]
        [Route("GetAllEmployee")]
        public async Task<ActionResult<IEnumerable<Account>>> GetAllEmployee()
        {
            return repository.GetAccountEmployee();
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
            var account = repository.GetAccountById(id);
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
