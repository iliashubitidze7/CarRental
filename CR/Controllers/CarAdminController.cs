using CR.DataAccess.Repository.IRepository;
using CR.Models;
using Microsoft.AspNetCore.Mvc;

namespace CR.Controllers
{
    public class CarAdminController : Controller
    {
        private readonly IUnitOfwork unitOfwork;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CarAdminController(IUnitOfwork unitOfwork, IWebHostEnvironment webHostEnvironment)
        {
            this.unitOfwork = unitOfwork;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Car> cars = unitOfwork.Car.GetAll().ToList();

            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car,IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = webHostEnvironment.WebRootPath;
                if(file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string carPath = Path.Combine(wwwRootPath, @"img");

                    using(var fileStream = new FileStream(Path.Combine(carPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    car.ImageUrl = @"\img\" + fileName;
                }
                unitOfwork.Car.Add(car);
                unitOfwork.Save();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Edit(int? id) { 
            if(id == null || id == 0)
            {
                return NotFound();
            }

            Car carFromDb = unitOfwork.Car.Get(u => u.Id == id);

            if (carFromDb == null) { 
                return NotFound();
            }

            return View(carFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Car car, IFormFile? file) {
            if (ModelState.IsValid)
            {
                string wwwRootPath = webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string carPath = Path.Combine(wwwRootPath, @"img");

                    using (var fileStream = new FileStream(Path.Combine(carPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    car.ImageUrl = @"\img\" + fileName;
                }

                unitOfwork.Car.Update(car);
                unitOfwork.Save();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id) {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Car carFromDb = unitOfwork.Car.Get(u => u.Id == id);

            if (carFromDb == null)
            {
                return NotFound();
            }

            return View(carFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST (int? id)
        {
            Car? car = unitOfwork.Car.Get(u => u.Id == id);

            if (car == null) { 
                return NotFound();
            }

            unitOfwork.Car.Remove(car);
            unitOfwork.Save();

            return RedirectToAction("Index");
        }
    }
}
