using Contracts;
using LoggerService;

namespace Services;

public sealed class CompanyService:ICompanyService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly ILoggerManager _loggerManager;

    public CompanyService(IRepositoryManager repositoryManager,ILoggerManager loggerManager)
    {
        _loggerManager = loggerManager;
        _repositoryManager = repositoryManager;
    }
}