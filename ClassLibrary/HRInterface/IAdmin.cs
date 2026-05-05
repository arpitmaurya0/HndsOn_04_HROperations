using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HRInterface
{
    public interface IAdmin
    {
        Task<bool> Authenticate(Admin admin);
    }
}
