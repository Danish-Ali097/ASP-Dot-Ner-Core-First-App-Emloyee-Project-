using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Ner_Core_First_App__Emloyee_Project_.Models
{
    public class MockedEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeelist;

        public MockedEmployeeRepository()
        {
            _employeelist = new List<Employee>()
            {
                new Employee()  {Id=1, Name="Danish Ali", Email="danish@gmail.com", Department= Dept.IT},
                new Employee()  {Id=2, Name="Kainat Murtaza", Email="kainat@gmail.com", Department= Dept.HR},
                new Employee()  {Id=3, Name="Hamza Malik", Email="hamza@gmail.com", Department= Dept.IT},
                new Employee()  {Id=4, Name="Ahsan Ali", Email="ahsan@gmail.com", Department= Dept.HR},
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeelist.Max(e => e.Id) + 1;
            _employeelist.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeelist.FirstOrDefault(e => e.Id == id);
            if(employee != null)
            {
                _employeelist.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> getAllEmployee()
        {
            return _employeelist;
        }

        public Employee getEmployee(int Id)
        {
            return _employeelist.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeelist.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
