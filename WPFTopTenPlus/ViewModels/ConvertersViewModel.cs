using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Mvvm;

namespace WPFTopTenPlus.ViewModels
{
    public class ConvertersViewModel : BindableBase
    {

        private bool _Show;

        public bool Show
        {
            get { return _Show; }
            set { SetProperty(ref _Show, value); }
        }

    }
}
