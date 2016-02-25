using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Mvvm;

namespace WPFTopTenPlus.ViewModels
{
    public class VSMViewModel : BindableBase
    {
        private bool _IsCollapsed;

        public bool IsCollapsed
        {
            get { return _IsCollapsed; }
            set { SetProperty(ref _IsCollapsed, value); }
        }

        public void ToggleIsCollapsed()
        {
            IsCollapsed = !IsCollapsed;
        }

    }
}
