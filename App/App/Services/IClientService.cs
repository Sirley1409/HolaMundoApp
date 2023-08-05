using App.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IClientService
    {
        Task<List<Client>> GetClientsAsync();
    }
}

