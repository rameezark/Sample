using MyFirstApi.Model.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstApi.Service.Services.IServices
{
    public interface ITransactionTypeService
    {
        Task<TransactionType> GetTransactionTypeById(int pId);
        Task<List<TransactionType>> GetAllTransactionTypes();
    }
}
