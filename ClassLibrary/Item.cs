﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Item
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Area { get; private set; }
        public string Category { get; private set; }
        public string Description { get; private set; }
        public string IDLocation { get; private set; }
        public int ProviderID { get; private set; }
        public Item(int id, string name, int area, string category, string description, string idlocation, int providerID)
        {
            ID = id;
            Name = name;
            Area = area;
            Category = category;
            Description = description;
            IDLocation = idlocation;
            ProviderID = providerID;
        }
    }
}
