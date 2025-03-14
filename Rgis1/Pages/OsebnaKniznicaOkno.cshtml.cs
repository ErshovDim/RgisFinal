using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RGIS.Pages
{
    public class OsebnaKniznicaOknoModel : PageModel
    {

        private UserDBContext _context;

        public OsebnaKniznica seznamKnig { get; set; } = new OsebnaKniznica();

        [BindProperty]
        public string name { get; set; }

        public OsebnaKniznicaOknoModel(UserDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
           // ///_context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            //_context.knjigas.Add(new Knjiga("Doglapan", "Ashneer Grover", "This is the unfettered story of Ashneer Grover-the favourite and misunderstood poster boy of Start-up India.", "Biography"));
            //_context.knjigas.Add(new Knjiga("Meditations", "Marcus Aurelius", "With ancient wisdom that is as relevant in modern times as it was then, 'Meditations' is one of the greatest works of Greek and philosophical literature.", "Biography"));
            //_context.knjigas.Add(new Knjiga("12 Years a Slave", "Solomon Northup", "And What Difference is There in the Colour of the Soul? A hardworking farmer and an exceptional fiddler, Solomon Northup is born a free man of colour.", "Biography"));
            //_context.knjigas.Add(new Knjiga("It Starts with Us", "Colleen Hoover", "Before It Ends with Us, it started with Atlas.", "Romance"));
            //_context.knjigas.Add(new Knjiga("Your Time Will Come", "Colleen Hoover", "Love can break the strongest of men and they are the ones to fall hard. But after the fall, will they be able to bounce back and start afresh?", "Romance"));
            //_context.knjigas.Add(new Knjiga("The Fine Print", "Lauren Asher", "A spicy series about three billionaire brothers and the women who bring them to their knees...", "Romance"));
            //_context.knjigas.Add(new Knjiga("Sapiens", "Yuval Noah Harari", "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.", "History"));
            //_context.knjigas.Add(new Knjiga("Shivaji", "Ranjit Desai", "The epic text of Ranjit Desai's Shriman Yogi finds new voice in Vikrant Pande's nuanced translation, an immersive narrative of the foundations of the Maratha empire and the saga of its charismatic founder.", "History"));
            //_context.knjigas.Add(new Knjiga("Karna", "Ranjit Desai", "'Who am I?' It was a question that had troubled him all his life. His whole life had seemed entangled in the answer. ", "History"));


            // _context.SaveChanges();
            seznamKnig.kniznica = _context.kniznica.ToList();

        }
        public IActionResult OnPost()
        {
            Console.WriteLine(name);
            Console.WriteLine("1");
            Knjiga nnn = _context.kniznica.Where(knjiga => knjiga.naziv == name).FirstOrDefault();
            
            Console.WriteLine(nnn.opis);

            _context.Remove(nnn);

            _context.SaveChanges();
            return RedirectToPage("OsebnaKniznicaOkno");
        }
    }
}
