using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Models
{
    /// <summary>
    /// Just binding once so it is not necessary INotifyPropertyChanged
    /// </summary>
    public class Section
    {
        public Section(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
