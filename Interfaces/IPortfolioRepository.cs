using System.Collections.Generic;
using System.Threading.Tasks;
using InStock.Models;

namespace InStock.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>> GetUserPortfolio(AppUser user);

        Task<Portfolio> CreateAsync(Portfolio portfolio);

        Task<Portfolio> DeletePortfolio(AppUser appUser,string symbol);
    }
}
