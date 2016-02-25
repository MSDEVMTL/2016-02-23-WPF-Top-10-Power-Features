using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFTopTenPlus.ViewModels
{
    public class DataBindingErrorsViewModel : BindableBase
    {
        private string _Message;

        public string Message
        {
            get { return _Message; }
            set { SetProperty(ref _Message, value); }
        }

    }
}
