using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentManagement.Controllers
{
    public class Student : Controller
    {
        public string Index()
        {
            return "<h2>Hello from the Student page</h2>";
        }
    }
}
