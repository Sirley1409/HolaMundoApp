using App.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App.Controls
{
    public class GastosViajeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object gastosObject, BindableObject container)
        {
            if (!(gastosObject is GastosViaje gastosViaje))
            {
                return DefaultTemplate;

            }
            return DefaultTemplate;
        }
    }
}
