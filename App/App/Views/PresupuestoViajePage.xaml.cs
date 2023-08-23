using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PresupuestoViajePage : ContentPage
	{
		public PresupuestoViajePage ()
		{
			InitializeComponent ();
		}
        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                if (decimal.TryParse(e.NewTextValue, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal value))
                {
                    string formattedValue = value.ToString("C0", CultureInfo.CurrentCulture);
                    ((Entry)sender).Text = formattedValue;
                }
            }
        }
    }
}