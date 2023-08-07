﻿using Microsoft.AspNetCore.Mvc;
using SalesMVC.Models;

namespace SalesMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department {Id = 1, Name = "Eletrônica" });
            list.Add(new Department{ Id = 2, Name = "Jardinagem" });

            return View(list);
        }
    }
}
