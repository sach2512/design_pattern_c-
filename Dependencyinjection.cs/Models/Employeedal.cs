namespace Dependencyinjection.cs.Models
{
    public class Employeedal
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


        public List<Employee> selectallemployee()
        {
            return employees;
        }
    }
}
