using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InStock.Dtos.Stock;
using InStock.Helpers;
using InStock.Models;

namespace InStock.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock?> GetBySymbolAsync(string symbol);
        Task<Stock> CreatedAsync(Stock stockModel);
        Task<Stock> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}