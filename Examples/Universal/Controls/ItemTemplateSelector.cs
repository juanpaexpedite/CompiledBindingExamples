using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Universal.Controls
{
    public class ItemTemplateSelector : DataTemplateSelector
    {

        public DataTemplate EvenTemplate { get; set; }
        public DataTemplate OddTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            //Just a test that only works with Section Model
            var id = int.Parse(item.ToString());

            return id % 2 == 0 ? EvenTemplate : OddTemplate;
        }
    }
}
