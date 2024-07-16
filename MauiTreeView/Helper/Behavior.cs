using Syncfusion.Maui.TreeView;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MauiTreeView
{
    public class ExpanderIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Assembly assembly = typeof(App).GetTypeInfo().Assembly;
            return (bool)value ? ImageSource.FromResource("MauiTreeView.Icons.expand.png", assembly) : ImageSource.FromResource("MauiTreeView.Icons.collapse.png", assembly);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ExpanderIconVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Assembly assembly = typeof(App).GetTypeInfo().Assembly;
            return (bool)value ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
