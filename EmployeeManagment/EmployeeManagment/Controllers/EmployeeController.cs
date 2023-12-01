using EmployeeManagment.Models;
using EmployeeManagment.Repositories;

namespace EmployeeManagment.Controllers
{
    public class EmployeeController
    {
        private ICompanyRepository<Employee> _companyRepository;
        public EmployeeController(ICompanyRepository<Employee> companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public string Index ()
        {
            return _companyRepository.Get(1).Name;
        }
    }
}
