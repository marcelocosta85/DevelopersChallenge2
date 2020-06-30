using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Nibo.Business.Models
{
    public class Transaction : Entity
    {
        public TransactionType Type { get; set; }
        public DateTime DatePosted { get; set; }
        public decimal TransactionAmount { get; set; }
        public string Description { get; set; }
    }
}
