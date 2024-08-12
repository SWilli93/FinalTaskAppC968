using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskAppC968
{
    public class Outsourced : Part
    {

        
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        string CompanyName { get; set; }


        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            int PartId = partID;
            string Name = name;
            decimal Price = price;
            int InStock = inStock;
            int Min = min;
            int Max = max;
            string CompanyName = companyName;
        }
    }
}
