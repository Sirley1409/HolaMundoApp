﻿using App.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Inicio";
            OpenWebCommand = new Command(async () =>  await Shell.Current.GoToAsync($"//{nameof(GastosViajePage)}"));
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }
        

        public ICommand OpenWebCommand { get; }
    }
}