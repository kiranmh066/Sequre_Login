using OfficeSeatBookingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSeatBookingDAL.Repost
{
    public interface IEmployeeRepost
    {
        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int employeeId);

        Employee GetEmployeeById(int employeeId);

        IEnumerable<Employee> GetEmployees();

        void AddEmployee(Employee employee);
        Employee Login(Employee employee);
    }
}
