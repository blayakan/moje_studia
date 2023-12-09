using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using zaliczenie_razor_pages;
using zaliczenie_razor_pages.Models;

namespace zaliczenie_razor_pages.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly zaliczenie_razor_pages.ApplicationDbContext _context;

        public IndexModel(zaliczenie_razor_pages.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.Category).ToListAsync();
        }
    }
}
