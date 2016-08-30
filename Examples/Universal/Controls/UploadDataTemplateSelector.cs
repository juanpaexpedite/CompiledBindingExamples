using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Universal.Controls
{
    public class UploadDataTemplateSelector : DateTemplateSelector
    {

        public DataTemplate ImageItem
        {
            get { return (DataTemplate)GetValue(ImageItemProperty); }
            set { SetValue(ImageItemProperty, value); }
        }

        public static readonly DependencyProperty ImageItemProperty =
            DependencyProperty.Register(nameof(ImageItem), typeof(DataTemplate), typeof(UploadDataTemplateSelector), new PropertyMetadata(DependencyProperty.UnsetValue));

    }
}
