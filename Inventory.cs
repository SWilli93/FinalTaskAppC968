using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskAppC968
{
    public class Inventory
    {
        public BindingList<Product> Products {get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public bool RemoveProduct(int id)
        {
            var partToRemove = Products.FirstOrDefault(p => p.ProductID == id);
            if (partToRemove != null)
            {
                Products.Remove(partToRemove);
                return true;
            }
            return false;
        }
        public void updateProduct(int id, Product product)
        {
            var oldProduct = Products.FirstOrDefault(p => p.ProductID == id);

            if (oldProduct != null)
            {
                oldProduct.Name = product.Name;
                oldProduct.Price = product.Price;
                oldProduct.InStock = product.InStock;
                oldProduct.Min = product.Min;
                oldProduct.Max = product.Max;
            }
        }
        public void addPart(Part part)
        {
            AllParts.Add(part);
        }
        public bool deletePart(Part part)
        {
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }
        public Part? lookupPart(int id)
        {
            var partToFind = AllParts.FirstOrDefault(p => p.PartID == id);
            return partToFind;
            
        }
        public void updatePart(int id, Part part)
        {
            var oldPart = AllParts.FirstOrDefault(p => p.PartID == id);
            if (oldPart != null)
            {
                oldPart.Name = part.Name;
                oldPart.Price = part.Price;
                oldPart.InStock = part.InStock;
                oldPart.Min = part.Min;
                oldPart.Max = part.Max;
            }
        }
    }
}
