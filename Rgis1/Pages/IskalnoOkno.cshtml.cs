using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS.Pages
{
    public class IskalnoOknoModel : PageModel
    {
        private KnjigaDbContext _context;

        public SeznamKnjig seznamKnig { get; set; } = new SeznamKnjig();

        [BindProperty]
        public string name { get; set; }

        public IskalnoOknoModel(KnjigaDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost(string name)
        {
            int idk = _context.knjigas.Where(item=> item.naziv == name).FirstOrDefault().Id;
            return RedirectToPage("KnjigaOkno", new {id=idk });
        }
    }
}
