using MyFirstApp.Models;
using MyFirstApp.Services.IServices;
using System.Collections.Generic;

namespace MyFirstApp.Services
{
    public class TransactionTypeService : ITransactionTypeService
    {
        public TransactionType GetTransactionTypeById(int pId)
        {
            return new TransactionType { Id = 1, Description = "Test", Type = "test" };
        }
        public List<TransactionType> GetAllTransactionTypes()
        {
            return new List<TransactionType> { new TransactionType { Id = 1, Description = "Test", Type = "test" } };
        }
    }
}
