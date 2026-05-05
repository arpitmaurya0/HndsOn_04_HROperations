using ClassLibrary.HRInterface;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace HndsOn_04_HROperations.Controllers
{
    public class EmployeeController : Controller
    {

        public readonly IEmployee _iemployee;

        public EmployeeController(IEmployee iemployee)
        {
            _iemployee = iemployee;
        }

        [HttpGet]
        public async Task<IActionResult> AddEmp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmp(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var res = await _iemployee.AddEmployee(employee);
                if(res == true)
                {
                    return RedirectToAction("AllEmp");
                }
            }
            return View(employee);
        }

        
        [HttpGet]
        public async Task<IActionResult> AllEmp()
        {
            var res = await _iemployee.GetEmployees();
            return View(res);
        }

        public async Task<IActionResult> details(int id)
        {
            var res = await _iemployee.GetDetails(id);
            return View(res);
        }
    }
}
