using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1, Name="Dilli", Department=Dept.IT, Email="dilli@gmail.com"},
                new Employee(){Id=2, Name="Ram", Department=Dept.ME, Email="ram@gmail.com"}
            };
        }

      

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }
    }



}
