using Desafio.Nibo.Business.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Nibo.Business.Interfaces
{
    public interface ITransactionService : IDisposable
    {
        Task Add(Transaction transaction);
        Task Update(Transaction transaction);
        Task Remove(Guid id);
        Task <List<Transaction>> GetDistinctTransactions(List<IFormFile> files);
    }
}
