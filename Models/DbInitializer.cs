namespace urlopy2.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pracownicy.Any())
            {
                context.AddRange(
                    new Pracownik { LastName = "Nowak", FirstName = "Adam", PhoneNumber = "123 222 444", EmailAddress = "an@g3m.pl", Tekst = "urlop okolicznościowy", DataOd = DateTime.Parse("20-02-2023"), DataDo = DateTime.Parse("24-02-2023"), IleDni = 5, JestAkceptacja = true, ZdjecieUrl = "/images/fordMustang.jpg", MiniaturkaUrl = "/images/fordMustang.jpg" },
                    new Pracownik { LastName = "Kowalski", FirstName = "Waldek", PhoneNumber = "456 222 444", EmailAddress = "wk@g3m.pl", Tekst = "urlop bezpłatny", DataOd = DateTime.Parse("20-02-2023"), DataDo = DateTime.Parse("24-02-2023"), IleDni = 5, JestAkceptacja = true, ZdjecieUrl = "/images/jaguar.jpg", MiniaturkaUrl = "/images/jaguar.jpg" },
                    new Pracownik { LastName = "Red", FirstName = "Andrzej", PhoneNumber = "789 222 444", EmailAddress = "ar@g3m.pl", Tekst = "urlop okolicznościowy", DataOd = DateTime.Parse("20-02-2023"), DataDo = DateTime.Parse("24-02-2023"), IleDni = 5, JestAkceptacja = true, ZdjecieUrl = "/images/nissan.jpg", MiniaturkaUrl = "/images/nissan.jpg" }
                );
            }
            context.SaveChanges();
        }
        
    }
}
