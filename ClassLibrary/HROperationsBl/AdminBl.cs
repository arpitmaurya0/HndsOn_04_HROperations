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
    public class AdminBl : IAdmin
    {
        private readonly AppDb _db;
        public AdminBl(AppDb db)
        {
            _db = db;
        }

        public async Task<bool> Authenticate(Admin admin)
        {
            return await _db.Admins.AnyAsync(x => x.AdmUserName == admin.AdmUserName && x.AdmPassword == admin.AdmPassword);
        }
    }
}
