using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ViewModels
{
    public class SectionsViewModel
    {
        public List<Section> Sections { get; set; }

        public SectionsViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            Sections = new List<Section>();

            for (int i=0;i<10;i++)
            {
                Sections.Add(new Section($"Section {i}", RandomDescription));
            }
        }

        private string RandomDescription = "Pellentesque dictum, eros sit amet laoreet sodales, enim nibh sollicitudin mi, at suscipit magna arcu non felis. In hac habitasse platea dictumst. Sed lobortis, elit in accumsan lacinia, diam libero vehicula elit, at sollicitudin nisi est eu ligula. Praesent at facilisis mauris.";
    }
}
