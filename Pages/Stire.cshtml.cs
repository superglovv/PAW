using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.ContextModels;

namespace WebApplication1.Pages
{
    public class StireModel : PageModel
    {
        private readonly StiriContext _context;

        public StireModel(StiriContext context)
        {
            _context = context;
        }

        public Stire Stire { get; set; }

        public async Task<IActionResult> OnGetAsync(int stireId)
        {
            Stire = await _context.Stiri
                .Where(s => s.Id == stireId)
                .Select(s => new Stire
                {
                    Id = s.Id,
                    Titlu = s.Titlu,
                    Lead = s.Lead,
                    Autor = s.Autor,
                    DataAdaugarii = s.DataAdaugarii,
                    Categorie = _context.Categorii.FirstOrDefault(c => c.Id == s.CategorieId)
                })
                .FirstOrDefaultAsync();

            if (Stire == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }
    }
}
