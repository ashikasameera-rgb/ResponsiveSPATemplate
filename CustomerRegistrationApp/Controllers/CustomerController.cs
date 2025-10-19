using CustomerRegistrationApp.Data;
using CustomerRegistrationApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace CustomerRegistrationApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var customers=await _context.Customers.ToListAsync();
            return View(customers);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Customer c)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(c);
                await _context.SaveChangesAsync();

                return Json(new { success = true,data=c });
            }

            return Json(new {success=false});

        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] Customer c)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Update(c);
                await _context.SaveChangesAsync();

                return Json(new { success = true, data = c });
            }

            return Json(new { success = false });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);

            if (customer == null)
                return Json(new {success=false });

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return Json(new {success=true });

        }






    }
}
