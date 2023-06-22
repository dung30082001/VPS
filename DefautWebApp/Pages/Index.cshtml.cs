using BusinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DefautWebApp.Pages
{
    public class IndexModel : PageModel
    {

        public VPSContext context;

        public double finalsum;

        public int finalperson;

        public int finalorder;

        public int finalblog;

        public double finalorderin6;
        public List<Product> listP;
        public List<OrderDetail> listOD;
        public List<Order> listO6;
        public List<Account> listAcc;
        public List<Order> listOr;
        public List<Blog> listBlog;
        public IndexModel(VPSContext _context)
        {
            context = _context;
        }

        public void OnGet()
        {
            listP = context.Products.Include(x=> x.Category).ToList();
            listOD = context.OrderDetails.ToList();
            foreach(var item in listOD)
            {
                finalsum += item.UnitPrice.Value;
            }
            listAcc = context.Accounts.ToList();
            listBlog = context.Blogs.ToList();
            finalperson = listAcc.Count;
            listOr = context.Orders.ToList();
            finalorder = listOr.Count;
            finalblog = listBlog.Count;
            listO6 = context.Orders.Where(x => x.OrderDate >Convert.ToDateTime("2023-06-01") && x.OrderDate<Convert.ToDateTime("2023-06-30")).ToList();
            foreach( var item in listO6)
            {
                finalorderin6 += item.Price;
            }
        }
    }
}