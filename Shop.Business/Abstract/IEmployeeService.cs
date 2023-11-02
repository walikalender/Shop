using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IEmployeeService
    {
        // Yeni bir çalışan ekler.
        IResult AddEmployee(Employee employee);

        // Bir çalışanı siler.
        IResult DeleteEmployee(Employee employee);

        // Mevcut bir çalışanı günceller.
        IResult UpdateEmployee(Employee employee);

        // Belirli bir çalışan ID'sine göre çalışanı getirir.
        IDataResult<Employee> GetEmployeeById(int employeeId);

        // Tüm çalışanları getirir.
        IDataResult<List<Employee>> GetAllEmployees();
    }
}
