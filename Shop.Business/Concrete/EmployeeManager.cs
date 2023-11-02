using Shop.Business.Abstract;
using Shop.Core_.Utilities.Results;
using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.Entityframework;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
       private readonly IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal ?? throw new ArgumentNullException(nameof(employeeDal));
        }
        public IResult AddEmployee(Employee employee)
        {
            _employeeDal.Add(employee);
            return new SuccessResult();
        }

        public IResult DeleteEmployee(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult();
        }

        public IDataResult<List<Employee>> GetAllEmployees()
        {
            _employeeDal.GetAll();
            return new SuccessDataResult<List<Employee>>(); 
        }

        public IDataResult<Employee> GetEmployeeById(int employeeId)
        {
            _employeeDal.Get(e => e.EmployeeID == employeeId);
            return new SuccessDataResult<Employee>();
        }

        public IResult UpdateEmployee(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult();
        }
    }
}
