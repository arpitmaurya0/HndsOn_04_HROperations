using ClassLibrary.HRInterface;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HROperationsBl
{
    public class EmployeeBl : IEmployee
    {
        private readonly AppDb _db;
        public EmployeeBl(AppDb db)
        {
            _db = db;
        }

        public async Task<bool> AddEmployee(Employee employee)
        {
            if(employee == null)
            {
                return false;
            }
            await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Employee> GetDetails(int Id)
        {
            return await _db.Employees.FindAsync(Id);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _db.Employees.AsNoTracking().ToListAsync();
        }
    }
}
