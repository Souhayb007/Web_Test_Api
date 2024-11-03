using Web_Test_Api.Model;

namespace Web_Test_Api.Service
{
    public interface IStorage
    {
        
        public IList<Product> GetAll();
        public void AddProduct(Product product);
        public int DeleteProduct(int barcode);
        public int UpdateProduct(int barcode,Product product);


    }
}
