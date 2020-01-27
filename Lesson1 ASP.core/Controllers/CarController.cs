using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WEbStore.Controllers
{
    public class CarController : Controller
    {
        private readonly List<CarModel> cars = new List<CarModel>()
        {
            new CarModel
            {
                Id = 1,
                MarkName = "BMW",
                ModelName = "X6",
                ProductionDate = new DateTime(2015, 10, 10),
                MaxSpeed = 280
            },
            new CarModel
            {
                Id = 2,
                MarkName = "KIA",
                ModelName = "Rio",
                ProductionDate = new DateTime(2017, 10, 1),
                MaxSpeed = 140
            },
            new CarModel
            {
                Id = 3,
                MarkName = "Toyota",
                ModelName = "Camry",
                ProductionDate = new DateTime(2019, 1, 15),
                MaxSpeed = 220
            },
            new CarModel
            {
                Id = 4,
                MarkName = "ВАЗ",
                ModelName = "Чайка",
                ProductionDate = new DateTime(2015, 5, 20),
                MaxSpeed = 120
            }
        };

        /// <summary>
        /// /car/index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(cars);
        }

        /// <summary>
        /// car/details/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            var car = cars.FirstOrDefault(x => x.Id == id);
            if (car == null)
                return NotFound();
            return View(car);
        }
    }
}