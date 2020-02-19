using DotNet_MVC_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet_MVC_EntityFramework.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public IEnumerable<Employee> GetHighestPaidEmployee()
        {
            throw new NotImplementedException();
        }
    }
}