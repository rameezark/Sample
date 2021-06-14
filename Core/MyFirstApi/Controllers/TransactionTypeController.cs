using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Model.Model;
using MyFirstApi.Service.Services.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionTypeController : ControllerBase
    {
        private readonly ITransactionTypeService     _service;
        public TransactionTypeController(ITransactionTypeService service)
        {
            _service = service;
        }
        [HttpGet("{pId}")]
        [Route("GetTransactionTypeById")]
        public async Task<TransactionType> GetTransactionTypeById(int pId)
        {
            return await _service.GetTransactionTypeById(pId);
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<List<TransactionType>> GetAllTransactionTypes()
        {
            return await _service.GetAllTransactionTypes();
        }
    }
}
