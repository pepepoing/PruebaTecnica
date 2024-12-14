using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Server.Data;
using PruebaTecnica.Server.Models;

namespace PruebaTecnica.Server.Controllers
{
    [ApiController]
    [Route("SPClientsData")]
    public class SPClientsController : ControllerBase
    {
        PruebaTecnicaContext ContextDB = new PruebaTecnicaContext();

        [HttpGet(Name = "GetSPClients")]
        public PageResult<Client> Get(int? page, int pagesize = 10)
        {
            var countClient = ContextDB.Clients.Count();
            var clientsResult = ContextDB.Set<Client>()
                                     .FromSqlInterpolated($"EXEC dbo.SPGetClient {page}, {pagesize}")
                                     .ToList();

            var result = new PageResult<Client>
            {
                Count = countClient,
                PageIndex = page ?? 1,
                PageSize = pagesize,
                Items = clientsResult
            };
            return result;

        }
    }
}