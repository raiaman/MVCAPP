using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebApp.Repository
{
    internal interface IEmpRepository
    {
        List<EmpModel> GetAllEmployees();
        bool AddEmployee(EmpModel obj);
        bool UpdateEmployee(EmpModel obj);
        bool DeleteEmployee(int Id);
    }
}
