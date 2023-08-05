using App.Data.Models;
using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace App.Data.API
{
    public interface IClientApi
    {
        [Get("/Clients")]
        Task<IEnumerable<Client>> GetClientsAsync();
    }
}
