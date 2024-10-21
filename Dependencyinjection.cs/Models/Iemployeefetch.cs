
namespace Dependencyinjection.cs.Models
{
    public class Iemployeefetch : Employeefetch
    {
        public List<Employee> GetEmployeeList()
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                ID = 1,
                Department="test1",
                Name="test1",
            },
            new Employee()
            {
                ID = 2,
                Department="test1",
                Name="test1",
            },
             new Employee()
            {
                ID = 2,
                Department="test1",
                Name="test1",
            },
        };
            return employees;

        }
    }
}
