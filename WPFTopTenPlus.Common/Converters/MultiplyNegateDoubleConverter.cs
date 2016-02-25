using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace WPFTopTenPlus.Common.Converters
{
    public class MultiplyNegateDoubleConverter : MarkupExtension, IValueConverter
    {
        public double MultiplyBy { get; set; }
        public bool Negate { get; set; }

        public MultiplyNegateDoubleConverter()
        {
            MultiplyBy = 1;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double dVal;
            bool castedOk = double.TryParse(value.ToString(), out dVal);
            if (!castedOk) return value;

            if (Negate) dVal = -dVal;

            return dVal * MultiplyBy;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
