namespace urlopy2.Models;

public class MockPracownikRepository : IPracownikRepository
{
	private List<Pracownik> pracownicy;

	public MockPracownikRepository()
	{
        if (pracownicy == null)
        {
           ZaladujPracownikow();
        }
    }

    private void ZaladujPracownikow()
    {
        pracownicy = new List<Pracownik>
         {
            new Pracownik { Id=1, LastName = "Nowak", FirstName = "Adam", PhoneNumber = "123 222 444", EmailAddress = "an@g3m.pl", Tekst = "urlop okolicznościowy", DataOd = DateTime.Parse("20-02-2023"), DataDo = DateTime.Parse("24-02-2023"), IleDni = 5, JestAkceptacja = true,ZdjecieUrl="/images/fordMustang.jpg", MiniaturkaUrl="/images/fordMustang.jpg" },
			new Pracownik { Id=2, LastName = "Kowalski", FirstName = "Waldek", PhoneNumber = "456 222 444", EmailAddress = "wk@g3m.pl", Tekst = "urlop bezpłatny", DataOd = DateTime.Parse("20-02-2023"), DataDo = DateTime.Parse("24-02-2023"), IleDni = 5, JestAkceptacja = true,ZdjecieUrl="/images/jaguar.jpg", MiniaturkaUrl="/images/jaguar.jpg" },
			new Pracownik { Id=3, LastName = "Red", FirstName = "Andrzej", PhoneNumber = "789 222 444", EmailAddress = "ar@g3m.pl", Tekst = "urlop okolicznościowy", DataOd = DateTime.Parse("20-02-2023"), DataDo = DateTime.Parse("24-02-2023"), IleDni = 5, JestAkceptacja = true,ZdjecieUrl="/images/nissan.jpg", MiniaturkaUrl="/images/nissan.jpg" }
		};

    }

    public Pracownik? PobierzPracownikaId(int pracownikId)
    {
        return pracownicy.FirstOrDefault(p => p.Id == pracownikId);
    }

    public IEnumerable<Pracownik> PobierzWszystkichPracownikow()
    {
        return pracownicy;
    }

    public void DodajPracownika(Pracownik pracownik)
    {
        throw new System.NotImplementedException();
    }

    public void EdytujPracownika(Pracownik pracownik)
    {
        throw new System.NotImplementedException();
    }

    public void UsunPracownika(Pracownik pracownik)
    {
        throw new System.NotImplementedException();
    }
}
