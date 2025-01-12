using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS.Pages
{
    public class PregledOknoModel : PageModel



    {
        [BindProperty]
        //public Pregled Newpregled { get; set; }
        public string Newpregled { get; set; }

        private KnjigaDbContext _context;
        private UserDBContext _dbContext;

       // public SeznamKnjig seznamKnig { get; set; } = new SeznamKnjig();

       // [BindProperty]
        //public Knjiga NewKnjiga { get; set; }

        public PregledOknoModel(KnjigaDbContext context, UserDBContext context1)
        {
            _context = context;
            _dbContext = context1;
        }
        public void OnGet()
        {
        }
       


        public IActionResult OnPost(int id) {
            Console.WriteLine(Newpregled);
            Console.WriteLine("1");
            _context.knjigas.Where(knjiga => knjiga.Id == id).FirstOrDefault().pregled = Newpregled;
            //_dbContext.kniznica.Where(knjiga => knjiga.Id == id).FirstOrDefault().pregled = pregled1.pregled;
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
