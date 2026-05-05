using ClassLibrary.HRInterface;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace HndsOn_04_HROperations.Controllers
{
    public class AdminController : Controller
    {
        public readonly IAdmin _iadmin;
        public AdminController(IAdmin iadmin)
        {
            _iadmin = iadmin;
        }

        [HttpGet]
        public async Task<IActionResult> Adminlogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Adminlogin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var res = await _iadmin.Authenticate(admin);
                if(res == true)
                {
                    return RedirectToAction("AddEmployee");
                }
            }
            ViewData["error"] = "Invalid Email or Password";
            return View();
        }

        public async Task<IActionResult> AddEmployee()
        {
            return View();
        }


    }
}
