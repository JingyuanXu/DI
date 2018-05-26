using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication20.Repo
{
    public class EmployeeRepo:IEmployeeRepo
    {
        private readonly IDbSet<Employee> _dbSet;
        private readonly Employee2Entities _context;
        private Employee2Entities db = new Employee2Entities();
        public EmployeeRepo(Employee2Entities context)
        {
            _context = context;
            _dbSet = context.Set<Employee>();
        }
        public IEnumerable<Employee> GetAll()
        {
           return _dbSet.AsNoTracking().ToList();
        }


        public IEnumerable<Employee> GetEmployeeManagerById(int id)
        {
            var manager = db.Employees.FirstOrDefault(e => e.Id == id);
            var employeesOfManager = db.Employees.Where(e => e.ManagerId == manager.Id);

            return employeesOfManager;
        }
        public IEnumerable<Employee> GetById(int id)
        {        
            var employees = _context.Employees.Where(e => e.Id == id);

            return employees;
        }
    }
}