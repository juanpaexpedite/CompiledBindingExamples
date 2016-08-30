﻿using System;
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
        public Section(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
