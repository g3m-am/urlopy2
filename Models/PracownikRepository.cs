namespace urlopy2.Models
{
    public class PracownikRepository : IPracownikRepository
    {
        private readonly AppDbContext _appDbContext;

        public PracownikRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Pracownik PobierzPracownikaId(int pracownikId)
        {
            return _appDbContext.Pracownicy.FirstOrDefault(p => p.Id == pracownikId);
        }

        public IEnumerable<Pracownik> PobierzWszystkichPracownikow()
        {
            return _appDbContext.Pracownicy ;
        }

        //public void DodajPracownika(Pracownik pracownik)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EdytujPracownika(Pracownik pracownik)
        //{
        //    throw new NotImplementedException();
        //}


        //public void UsunPracownika(Pracownik pracownik)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
