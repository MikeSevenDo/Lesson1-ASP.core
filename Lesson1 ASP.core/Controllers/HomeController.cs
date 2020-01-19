using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeModel> employees = new List<EmployeeModel>()
        {
            new EmployeeModel
            {
                Id = 1, 
                Age = 22, 
                FirstName = "Миша", 
                SurName = "Семиделихин1", 
                Patronymic = "Сергеевич", 
                Position = "Человек"
            },
            new EmployeeModel{
                Id = 2, 
                Age = 25, 
                FirstName = "Миша2", 
                SurName = "Семиделихин2", 
                Patronymic = "Сергеевич", 
                Position = "Человек"
            }
        };




        /// <summary>
        /// Get "home/index"
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(employees);
        }
    }
}