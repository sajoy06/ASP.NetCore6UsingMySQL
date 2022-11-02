using Microsoft.AspNetCore.Mvc;
using MySQL.Models;

namespace MySQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _iEmployeeRepository;

        public HomeController(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
        }
        public string Index()
        {
            return @"Name: " +_iEmployeeRepository.GetEmployee(2).Name ;
        }
    }
}
