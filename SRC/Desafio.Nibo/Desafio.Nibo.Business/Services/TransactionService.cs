using Desafio.Nibo.Business.Interfaces;
using Desafio.Nibo.Business.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Nibo.Business.Services
{
    public class TransactionService : BaseService, ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository, INotifier notifier) : base(notifier)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task Add(Transaction transaction)
        {
            if (_transactionRepository.Find(t => t.Id == transaction.Id).Result.Any())
            {
                Notify("Already exists a transaction.");
                return;
            }
            await _transactionRepository.Add(transaction);
        }
        public async Task Update(Transaction transaction)
        {
            await _transactionRepository.Update(transaction);
        }

        public async Task Remove(Guid id)
        {
            await _transactionRepository.Remove(id);
        }

        public void Dispose()
        {
            _transactionRepository?.Dispose();
        }

        public Task<List<Transaction>> GetDistinctTransactions(List<IFormFile> files)
        {
            throw new NotImplementedException();
        }
    }
}
