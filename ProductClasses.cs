using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Implementation
{
    public class ProductClasses
    {



    }
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }

        public string ProductNumber { get; set; }

        public string Color { get; set; }

        public double StandardCost { get; set; }

        public double ListPrice { get; set; }
        public int Size { get; set; }
        public double Weight { get; set; }
        public int ProductCategoryID { get; set; }
        public int ProductModelID { get; set; }

    }

    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }

    }

    public class ProductModel
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }

    }
}
