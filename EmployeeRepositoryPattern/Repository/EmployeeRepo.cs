using EmployeeRepositoryPattern.Data;
using EmployeeRepositoryPattern.Infrastructure;
using EmployeeRepositoryPattern.Models;


namespace EmployeeRepositoryPattern.Repository
{
    public class EmployeeRepo : IEmployee

    {
        private EmployeeContext _context;

        public EmployeeRepo(EmployeeContext context)
        {
            _context = context;
        }

        void IEmployee.Delete(Employee employee)
        { 
            _context.Employees.Remove(employee);
        }

        List<Employee> IEmployee.GetAll()
        {
            return _context.Employees.ToList();
        }

        Employee IEmployee.GetById(int Id)
        {
            return _context.Employees.Where(x => x.Id == Id).FirstOrDefault();
        }

        void IEmployee.Insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        void IEmployee.Save()
        {
            _context.SaveChanges();
        }

        void IEmployee.Update(Employee employee)
        {
            _context.Update(employee);
        }
    }
}
