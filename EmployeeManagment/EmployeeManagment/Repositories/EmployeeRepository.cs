using EmployeeManagment.Models;

namespace EmployeeManagment.Repositories
{
    public class EmployeeRepository:ICompanyRepository<Employee>
    {
        List<Employee> Employees;
        public EmployeeRepository()
        {
            Employees = new List<Employee>();
            Employees.Add(new Employee() { Id = 1, Name = "Hamza", Email = "Hamza@gmail.com", Departement = "IT" });
            Employees.Add(new Employee() { Id = 2, Name = "Nouali", Email = "Nouali@gmail.com", Departement = "Commerce" });


        }
        public Employee Get(int id)
        {
            return Employees.SingleOrDefault(emp => emp.Id == id);
        }
    }
}
