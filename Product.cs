﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskAppC968
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public void addAssociatedPart(Part part)
        {
                AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int id)
        {
            AssociatedParts.Remove(AssociatedParts[id]);
            return true;
        }

        public Part lookupAssociatedPart(int id)
        {
            return AssociatedParts[id];
        }
    }
}
