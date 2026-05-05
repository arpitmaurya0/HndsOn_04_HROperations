using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HRInterface
{
    public interface IEmployee
    {
        Task <bool> AddEmployee (Employee employee);
        Task<Employee> GetDetails(int Id);
        Task<List<Employee>> GetEmployees();
    }
}
