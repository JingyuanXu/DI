using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication20.Repo
{
   public interface IEmployeeRepo
   {
       IEnumerable<Employee> GetAll();
        IEnumerable<Employee> GetEmployeeManagerById(int id);
       IEnumerable<Employee> GetById(int id);

   }
}
