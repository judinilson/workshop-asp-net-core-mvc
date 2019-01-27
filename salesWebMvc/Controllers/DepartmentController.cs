using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using salesWebMvc.Models;

namespace salesWebMvc.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "eletronicos" });
            list.Add(new Department { Id = 2, Name = "Faishon" });

            return View(list);
        }
    }
}