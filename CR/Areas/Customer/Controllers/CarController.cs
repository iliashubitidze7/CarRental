using CR.DataAccess.Repository.IRepository;
using CR.Models;
using Microsoft.AspNetCore.Mvc;

namespace CR.Areas.Customer.Controllers
{
    [Area("Customer")]

    public class CarController : Controller
    {
        private readonly IUnitOfwork unitOfwork;

        public CarController(IUnitOfwork unitOfwork)
        {
            this.unitOfwork = unitOfwork;
        }

        public IActionResult Index()
        {
            List<Car> cars = unitOfwork.Car.GetAll().ToList();

            return View(cars);
        }
    }
}
