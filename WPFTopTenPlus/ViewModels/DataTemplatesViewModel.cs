using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Mvvm;
using System.ComponentModel;
using System.Net.Http;
using System.Collections.ObjectModel;
using WPFTopTenPlus.Models;

namespace WPFTopTenPlus.ViewModels
{
    public class DataTemplatesViewModel : BindableBase
    {
        public DataTemplatesViewModel()
        {
            if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                LoadProducts();
            }

        }

        async void LoadProducts()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://zzaapi.azurewebsites.net/api/Products");
                var products = await response.Content.ReadAsAsync<ObservableCollection<Product>>();
                foreach (var product in products)
                {
                    product.Image = "http://zzaapi.azurewebsites.net/Images/" + product.Image;
                }
                Products = products;
            }
        }

        private ObservableCollection<Product> _Products;

        public ObservableCollection<Product> Products
        {
            get { return _Products; }
            set { SetProperty(ref _Products, value); }
        }

    }
}
