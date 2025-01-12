using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS.Pages
{
    public class KnjigaOknoModel : PageModel
    {

        private KnjigaDbContext _context;
        private UserDBContext _dbContext;

        public SeznamKnjig seznamKnig { get; set; } = new SeznamKnjig();

        [BindProperty]
        public Knjiga NewKnjiga { get; set; }

        public KnjigaOknoModel(KnjigaDbContext context, UserDBContext context1)
        {
            _context = context;
            _dbContext = context1;
        }
        public void OnGet(int id)
        {
            _dbContext.Database.EnsureCreated();
            NewKnjiga = _context.knjigas.Where(knjiga => knjiga.Id == id).FirstOrDefault();
        }

        public IActionResult OnPost(int id)
        {
            Console.WriteLine("1");
             _dbContext.Add(_context.knjigas.Where(knjiga => knjiga.Id == id).FirstOrDefault());

            _dbContext.SaveChanges();
            return RedirectToPage("OsebnaKniznicaOkno");
        }
    }
}
