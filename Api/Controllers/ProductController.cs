using BusinesLogic;
using DomainLayer.Admin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       readonly IProductCatalog ProductLog;
        public ProductController(IProductCatalog productCatalog)
        {
            ProductLog = productCatalog;
                
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductLog.GetAll();
        }
    }
}
