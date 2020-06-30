using Desafio.Nibo.Business.Interfaces;
using Desafio.Nibo.Business.Models;
using Desafio.Nibo.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Nibo.Data.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(NiboDbContext context) : base(context)
        {

        }
    }
}
