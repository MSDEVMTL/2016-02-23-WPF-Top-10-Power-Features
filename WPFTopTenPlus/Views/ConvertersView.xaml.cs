using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WPFTopTenPlus.Views
{
    public partial class ConvertersView : UserControl
    {
        public ConvertersView()
        {
            InitializeComponent();

            //var dpd = DependencyPropertyDescriptor.FromProperty(FrameworkElement.ActualWidthProperty, typeof(FrameworkElement));
            //if (dpd != null)
            //{
            //    dpd.AddValueChanged(rect1, (s, e) =>
            //    {
            //        Debug.WriteLine(rect1.ActualWidth.ToString());
            //    });
            //}
        }
    }
}
