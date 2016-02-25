using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Mvvm;
using WPFTopTenPlus.Models;
using System.Collections.ObjectModel;

namespace WPFTopTenPlus.ViewModels
{
    public class VisualTreeViewModel : BindableBase
    {
        private ObservableCollection<Customer> _Customers = new ObservableCollection<Customer>();

        public VisualTreeViewModel()
        {
            _Customers.Add(new Customer { Id = 1, Name = "Fred Flintstone", Phone = "999-999-9999" });
            _Customers.Add(new Customer { Id = 2, Name = "Barney Rubble", Phone = "555-555-5555" });
        }
        public ObservableCollection<Customer> Customers
        {
            get { return _Customers; }
            set { SetProperty(ref _Customers, value); }
        }

    }
}
