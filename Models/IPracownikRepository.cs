namespace urlopy2.Models
{
    public interface IPracownikRepository
    {
        IEnumerable<Pracownik> PobierzWszystkichPracownikow();
        Pracownik PobierzPracownikaId(int pracownikId);
		//void DodajPracownika(Pracownik pracownik);
		//void EdytujPracownika(Pracownik pracownik);
		//void UsunPracownika(Pracownik pracownik);
	}
}
