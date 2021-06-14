using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;
using MyFirstApp.Services.IServices;
using System.Collections.Generic;

namespace MyFirstApp.Controllers
{
    [Route("api/Transaction")]
    [ApiController]
    public class TransactionTypesController : ControllerBase
    {
        private readonly ITransactionTypeService _service;
        public TransactionTypesController(ITransactionTypeService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<TransactionType> GetTransactionTypeById(int pId)
        {
           return _service.GetTransactionTypeById(pId);
       }
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<TransactionType>> GetAllTransactionTypes() 
        {
            return _service.GetAllTransactionTypes();
        } 
    }
}
