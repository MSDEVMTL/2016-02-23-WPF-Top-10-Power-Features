using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace WPFTopTenPlus.Models
{
    public class TileInfo
    {
        public ICommand Command { get; set; }
        public string ViewName { get; set; }
        public string Color { get; set; }
    }
}
