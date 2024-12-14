using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Server.Data;
using PruebaTecnica.Server.Models;

namespace PruebaTecnica.Server.Controllers
{
    [ApiController]
    [Route("ClientsData")]
    public class ClientsDataController : ControllerBase
    {
        PruebaTecnicaContext ContextDB = new PruebaTecnicaContext();

        [HttpGet(Name = "GetClients")]
        public PageResult<Client> Get(int? page, int pagesize = 10)
        {
            var countClient = ContextDB.Clients.Count();
            var result = new PageResult<Client>
            {
                Count = countClient,
                PageIndex = page ?? 1,
                PageSize = pagesize,
                Items = ContextDB.Clients.Skip((page - 1 ?? 0) * pagesize).Take(pagesize).ToList()
            };
            return result;
        }
    }
}