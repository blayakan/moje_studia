using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using zaliczenie_razor_pages;
using zaliczenie_razor_pages.Models;

namespace zaliczenie_razor_pages.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly zaliczenie_razor_pages.ApplicationDbContext _context;

        public IndexModel(zaliczenie_razor_pages.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
