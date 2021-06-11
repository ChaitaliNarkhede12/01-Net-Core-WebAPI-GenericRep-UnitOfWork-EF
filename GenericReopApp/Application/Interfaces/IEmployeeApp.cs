using DataaAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEmployeeApp
    {
        Task<IEnumerable<Employee>> GetEmployeeList();
        Task<IEnumerable<Employee>> GetEmployeeById(Expression<Func<Employee, bool>> predicate);
        Employee GetEmployeeById(int id);
        Task<string> AddEmployee(Employee employee);
        Task<string> UpdateEmployee(Employee employee);
        Task<string> DeleteEmployee(int id);
    }
}
