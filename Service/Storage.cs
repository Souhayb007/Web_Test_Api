using Microsoft.AspNetCore.Mvc;
using Web_Test_Api.Model;

namespace Web_Test_Api.Service
{
    public class Storage : IStorage
    {
        private static IList<Product> Products = new List<Product>();
        
        public Storage() { }  
        
        public IList<Product> GetAll()
        {
            return Products;
        }
        public void AddProduct(Product product) {
            Product pr = Products.FirstOrDefault(p=>p.barcode==product.barcode);  
            if (pr == null) { Products.Add(product);}
        }

        public int DeleteProduct(int barcode) {
            Product pr = Products.FirstOrDefault(p => p.barcode == barcode);
            if (pr == null) { return 0; } else 
            {
                Products.Remove(pr);
                return 1; 
            }
        }
        public int UpdateProduct(int barcode, Product product) {
            Product pr =Products.FirstOrDefault(p => p.barcode == barcode);
            if (pr != null)
            {
                pr.discount = product.discount;
                pr.categorie = product.categorie;
                pr.name = product.name;
                return 1;
            }
            else { return 0; }
        }




    }
}
