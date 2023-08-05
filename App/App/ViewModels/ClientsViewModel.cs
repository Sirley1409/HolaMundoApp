using App.Data.Models;
using App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;

namespace App.ViewModels
{
    public class ClientsViewModel : BaseViewModel
    {
        private readonly IClientService _clientService;

        public ClientsViewModel(IClientService clientService)
        {
            _clientService = clientService;
            AppearingCommand = new AsyncCommand(async()=> await OnAppearingAsync());
        }

        #region Properties
        public ObservableRangeCollection<Client> Clients { get; set; } = new ObservableRangeCollection<Client> ();

        public ICommand AppearingCommand { get; set; }
        #endregion
        private async Task OnAppearingAsync()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            var clients = await _clientService.GetClientsAsync();

            if (clients.Count > 0) 
            {
                Clients.ReplaceRange(clients);
            }
        }
    }
}
