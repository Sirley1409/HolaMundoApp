using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using System.Globalization;

namespace App.Views
{

        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class GastosViajePage : ContentPage
        {
            public GastosViajePage()
            {
                InitializeComponent();
            }
        //private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(e.NewTextValue))
        //    {
        //        if (decimal.TryParse(e.NewTextValue, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal value))
        //        {
        //            string formattedValue = value.ToString("C0", CultureInfo.CurrentCulture);
        //            ((Entry)sender).Text = formattedValue;
        //        }
        //    }
        //}
    }
}
