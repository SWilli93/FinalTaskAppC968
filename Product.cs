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
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        


        public Product(int productID, string name, decimal price, int inStock, int min, int max, BindingList<Part> associatedParts)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = associatedParts;
        }

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
