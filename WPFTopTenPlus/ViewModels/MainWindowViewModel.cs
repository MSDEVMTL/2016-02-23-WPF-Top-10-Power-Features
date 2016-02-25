using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Mvvm;

namespace WPFTopTenPlus.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private BindableBase _CurrentViewModel;
        private Dictionary<string, BindableBase> _ChildViewModels = new Dictionary<string, BindableBase>();
        private bool _IsNotHome;

        public MainWindowViewModel()
        {
            NavCommand = new DelegateCommand<string>(OnNav);
            HomeCommand = new DelegateCommand(() => OnNav("Home"));
            InitializeChildViewModels();
            CurrentViewModel = _ChildViewModels["Home"];
        }

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public bool IsNotHome
        {
            get { return _IsNotHome; }
            set { SetProperty(ref _IsNotHome, value); }
        }


        public DelegateCommand<string> NavCommand { get; set; }
        public DelegateCommand HomeCommand { get; set; }

        private void InitializeChildViewModels()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            _ChildViewModels.Add("Data Binding Errors", new DataBindingErrorsViewModel());
            _ChildViewModels.Add("Vector Images", new VectorImagesViewModel());
            _ChildViewModels.Add("Converters", new ConvertersViewModel());
            _ChildViewModels.Add("VisualTree", new VisualTreeViewModel());
            _ChildViewModels.Add("VSM", new VSMViewModel());
            _ChildViewModels.Add("DataTemplates", new DataTemplatesViewModel());
            _ChildViewModels.Add("Templates Combo", new TemplatesComboViewModel());
            _ChildViewModels.Add("Designer Data Binding", new DesignerDataBindingViewModel());

            homeViewModel.Initialize(NavCommand, _ChildViewModels.Keys.ToList());
            _ChildViewModels.Add("Home", homeViewModel);
        }

        private void OnNav(string viewName)
        {
            CurrentViewModel = _ChildViewModels[viewName];
            IsNotHome = viewName == "Home" ? false : true;
        }

    }
}
