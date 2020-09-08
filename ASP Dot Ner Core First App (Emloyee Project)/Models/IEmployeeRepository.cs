using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Ner_Core_First_App__Emloyee_Project_.Models
{
    public interface IEmployeeRepository
    {
        Employee getEmployee(int Id);
        IEnumerable<Employee> getAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int id);
    }
}
