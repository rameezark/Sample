using MyFirstApp.Models;
using System.Collections.Generic;

namespace MyFirstApp.Services.IServices
{
    public interface ITransactionTypeService 
    {
        TransactionType GetTransactionTypeById(int pId);
        List<TransactionType> GetAllTransactionTypes();
    }
}
