using App.Services;
using App.Data.API;
using App.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace App.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientApi _clientApi;
       public ClientService (IClientApi clientApi)
        {
            _clientApi = clientApi;
        }
        public async Task<List<Client>> GetClientsAsync()
        {
            var clients = new List<Client>();
            try
            {
                var response = await _clientApi.GetClientsAsync();
                clients = response.ToList();
                return clients;

            }
            catch (Exception ex)
            {

                var error = ex.Message;
            }
            return clients;
        }
    }
}
