
using Microsoft.EntityFrameworkCore;
using MyFirstApi.Model.Model;
using MyFirstApi.Service.Data;
using MyFirstApi.Service.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace MyFirstApi.Service.Services
{
    public class TransactionTypeService : ITransactionTypeService
    {
        public readonly DataContext _dbContext;
        public TransactionTypeService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<TransactionType> GetTransactionTypeById(int pId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(""))
                {
                    var result = connection.ExecuteReaderAsync()
                }



                    List<TransactionType> x= _dbContext.Set<TransactionType>()
                                                   .FromSqlRaw("dbo.SomeSproc")
                                                   .ToList();
                return await _dbContext.BaTransType.Where(x => x.Id == pId).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<TransactionType>> GetAllTransactionTypes()
        {
            try
            {
                return await _dbContext.BaTransType.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
