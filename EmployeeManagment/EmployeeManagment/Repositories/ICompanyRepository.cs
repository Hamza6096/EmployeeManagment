namespace EmployeeManagment.Repositories
{
    public interface ICompanyRepository <TEntity>
    {
        TEntity Get(int id);
    }
}
