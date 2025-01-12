using Microsoft.EntityFrameworkCore;
using RGIS;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test_ChangePregled()
        {

            //
            Knjiga testKniga = new Knjiga("Doglapan", "Ashneer Grover", "This is the unfettered story of Ashneer Grover-the favourite and misunderstood poster boy of Start-up India.", "Biography");
            testKniga.ChangePregled("Good book");
            Assert.Equal(testKniga.pregled, "Good book");
        }
        [Fact]
        public void Test_GetKategorija()
        {
            Knjiga testKniga = new Knjiga("Doglapan", "Ashneer Grover", "This is the unfettered story of Ashneer Grover-the favourite and misunderstood poster boy of Start-up India.", "Biography");
            string kat = testKniga.GetKategorija();
            Assert.Equal(kat, "Biography");
        }
        [Fact]
        public void Test_DeletePregled()
        {
            Knjiga testKniga = new Knjiga("Doglapan", "Ashneer Grover", "This is the unfettered story of Ashneer Grover-the favourite and misunderstood poster boy of Start-up India.", "Biography");
            testKniga.DeletePregled();
            Assert.Equal(testKniga.pregled, "");
        }
        [Fact]
        public void Test_GetCount()
        {
            Knjiga book1 = new Knjiga("Doglapan", "Ashneer Grover", "This is the unfettered story of Ashneer Grover-the favourite and misunderstood poster boy of Start-up India.", "Biography");
            Knjiga book2 = new Knjiga("Meditations", "Marcus Aurelius", "With ancient wisdom that is as relevant in modern times as it was then, 'Meditations' is one of the greatest works of Greek and philosophical literature.", "Biography");
            Knjiga book3 = new Knjiga("12 Years a Slave", "Solomon Northup", "And What Difference is There in the Colour of the Soul? A hardworking farmer and an exceptional fiddler, Solomon Northup is born a free man of colour.", "Biography");

            OsebnaKniznica kniznica = new OsebnaKniznica();
            kniznica.kniznica.Add(book1);
            kniznica.kniznica.Add(book2);
            kniznica.kniznica.Add(book3);

            Assert.Equal(kniznica.GetCount(), 3);
        }

        [Fact]
        public void Test_DeleteBook()
        {
            Knjiga book1 = new Knjiga("Doglapan", "Ashneer Grover", "This is the unfettered story of Ashneer Grover-the favourite and misunderstood poster boy of Start-up India.", "Biography");
            Knjiga book2 = new Knjiga("Meditations", "Marcus Aurelius", "With ancient wisdom that is as relevant in modern times as it was then, 'Meditations' is one of the greatest works of Greek and philosophical literature.", "Biography");
            Knjiga book3 = new Knjiga("12 Years a Slave", "Solomon Northup", "And What Difference is There in the Colour of the Soul? A hardworking farmer and an exceptional fiddler, Solomon Northup is born a free man of colour.", "Biography");

            OsebnaKniznica kniznica = new OsebnaKniznica();
            kniznica.kniznica.Add(book1);
            kniznica.kniznica.Add(book2);
            kniznica.kniznica.Add(book3);

            kniznica.DeleteBook(book1);

            Assert.Equal(kniznica.GetCount(), 2);
        }

        [Fact]
        public void Test_AddBook()
        {
            Knjiga book1 = new Knjiga("Doglapan", "Ashneer Grover", "This is the unfettered story of Ashneer Grover-the favourite and misunderstood poster boy of Start-up India.", "Biography");


            OsebnaKniznica kniznica = new OsebnaKniznica();
            kniznica.AddBook(book1);

            Assert.Equal(kniznica.GetCount(), 1);
        }

        [Fact]
        public void Test_GetID()
        {
            Uporabnik uporabnik = new Uporabnik(1, "Tom", "Reddl");
            Assert.Equal(uporabnik.GetID(), 1);
        }

        [Fact]
        public void Test_GetIme()
        {
            Uporabnik uporabnik = new Uporabnik(1, "Tom", "Reddl");
            Assert.Equal(uporabnik.GetIme(), "Tom");
        }

        [Fact]
        public void Test_ChangeIme()
        {

            Uporabnik uporabnik = new Uporabnik(1, "Tom", "Reddl");
            uporabnik.ChangeIme("Volan");
            Assert.Equal(uporabnik.GetIme(), "Volan");
        }



    }
}
