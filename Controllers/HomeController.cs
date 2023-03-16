using Microsoft.AspNetCore.Mvc;
using urlopy2.Models;
using urlopy2.ViewModels;

namespace urlopy2.Controllers
{
	public class HomeController : Controller
    {
        private readonly IPracownikRepository _pracownikRepository;

        public HomeController(IPracownikRepository pracownikRepository)
        {
            _pracownikRepository = pracownikRepository;
        }

        public IActionResult Index()
        {
            var pracownicy = _pracownikRepository.PobierzWszystkichPracownikow().OrderBy(p => p.LastName);

            var homeVM = new HomeVM()
            {
                Tytul = "Przegląd pracowników",
                Pracownicy = pracownicy.ToList()
            };

            return View(homeVM);
		}
    }
}