using Expance.Models;
using Microsoft.EntityFrameworkCore;

namespace Expance.Data.Services
{
    public class ExpenceService : IExpenceService
    {
        private readonly FinanceAppContext _context;
        public ExpenceService(FinanceAppContext context)
        {
            _context = context;
        }

        public async Task Add(FinanceApp expence)
        {
            _context.Expances.Add(expence);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<FinanceApp>> GetAll()
        {
            var expence = await _context.Expances.ToListAsync();
            return expence;
        }

        public IQueryable GetChartData()
        {
            var data = _context.Expances
                               .GroupBy(e => e.Category)
                               .Select(g => new
                               {
                                   category = g.Key,
                                   total = g.Sum(e => e.Amount)
                               });
            return data;
        }
    }
}
