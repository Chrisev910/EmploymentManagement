using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
            new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com" },
            new Employee() { Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
            new Employee() { Id = 3, Name = "Sam", Department = "IT", Email = "sam@pragimtech.com" },
            new Employee() { Id = 3, Name = "Chris", Department = "MIS", Email = "chammond@pragimtech.com" },
            new Employee() { Id = 3, Name = "Mark", Department = "MIS", Email = "marmstrong@pragimtech.com" },
            new Employee() { Id = 3, Name = "Les", Department = "MIS", Email = "ldanks@pragimtech.com" },
            new Employee() { Id = 3, Name = "Lewis", Department = "MIS", Email = "ldanks2@pragimtech.com" }
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);            
        }
    }
}
