using DotNet_MVC_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_MVC_EntityFramework.Repositories
{
    interface IEmployeeRepository:IRepository<Employee>
    {
        IEnumerable<Employee> GetHighestPaidEmployee();
    }
}
