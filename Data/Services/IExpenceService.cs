using Expance.Models;

namespace Expance.Data.Services
{
    public interface IExpenceService
    {
        Task Add(FinanceApp expence);
        Task<IEnumerable<FinanceApp>> GetAll();
        IQueryable GetChartData();
    }
}
