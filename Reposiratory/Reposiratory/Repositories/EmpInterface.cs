using Reposiratory.Models;
using System.Collections.Generic;

namespace Reposiratory.Repositories
{
    public interface EmpInterface
    {
        List<Employee> getemployee();
        void addemployee(Employee ep);
        void search(Employee es);
    }
}
