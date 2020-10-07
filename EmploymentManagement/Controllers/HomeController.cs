using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmploymentManagement.Models;
using EmploymentManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employyee Details"
            };

            return View(homeDetailsViewModel);
        }
    }
}
