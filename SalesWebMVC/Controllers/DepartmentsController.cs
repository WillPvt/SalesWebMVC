﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departmentList = new List<Department>();
            departmentList.Add(new Department { Id = 1, Name = "Eletronics"});
            departmentList.Add(new Department { Id = 2, Name = "Fashion" });
            return View(departmentList);
        }
    }
}