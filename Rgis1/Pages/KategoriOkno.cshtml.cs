using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS.Pages
{
    public class KategoriOknoModel : PageModel
    {
        private KnjigaDbContext _context;

        public SeznamKnjig seznamKnig { get; set; } = new SeznamKnjig();

        [BindProperty]
        public Knjiga NewKnjiga { get; set; }

        public KategoriOknoModel(KnjigaDbContext context)
        {
            _context = context;
        }
        public void OnGet(string id)
        {

            seznamKnig.seznam = _context.knjigas.Where(p=> p.kategorija == id).ToList();
        }
    }
}
