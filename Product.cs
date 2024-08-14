using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

        public BindingList<Part> AssociatedParts { get; set; }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void addAssociatedPart(Part part)
        {
                AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int id)
        {
            var partToRemove = AssociatedParts.FirstOrDefault(p => p.PartID == id);
            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            return false;
        }

        public Part lookupAssociatedPart(int id)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == id);
        }
    }
}
