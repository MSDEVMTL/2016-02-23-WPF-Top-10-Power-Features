using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFTopTenPlus.Models;

namespace WPFTopTenPlus.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private ICommand _navCommand;
        private ObservableCollection<TileInfo> _Tiles = new ObservableCollection<TileInfo>();

        public ObservableCollection<TileInfo> Tiles
        {
            get { return _Tiles; }
            set { SetProperty(ref _Tiles, value); }
        }

        internal void Initialize(ICommand navCommand, IEnumerable<string> viewNames)
        {
            viewNames.ToList().ForEach(v => Tiles.Add(new TileInfo { Command = navCommand, ViewName = v, Color = GetTileColor() }));
        }

        private string[] _colorwheel = { "#AA7B39", "#2A4E6E", "#AA5C39", "#267356" };
        private int _currentColor = 0;
        private string GetTileColor()
        {
            var color = _colorwheel[_currentColor];
            _currentColor++;
            if (_currentColor >= _colorwheel.Length) _currentColor = 0;
             return color;
        }


    }
}
