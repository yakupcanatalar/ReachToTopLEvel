using Entities.Models;
using Repository;

namespace Contracts;

public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository{
    public EmployeeRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

}