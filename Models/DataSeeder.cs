namespace urlopy2.Models
{
    public class DataSeeder
    {
        private readonly AppDbContext appDbContext;

        public DataSeeder(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void Seed()
        {
            if (!appDbContext.Pracownicy.Any())
            {
                var pracownicy = new List<Pracownik>()
                {
                        new Pracownik()
                        {
                            LastName = "Karthik",
                            FirstName = "India",
                            EmailAddress = "qq@pl"
                        },
                        new Pracownik()
                        {
                            LastName = "Jacob",
                            FirstName = "US",
                            EmailAddress = "kkdsa@pl"
                        }
                };

                appDbContext.AddRange(pracownicy);
                appDbContext.SaveChanges();
            }
        }
    }
}
