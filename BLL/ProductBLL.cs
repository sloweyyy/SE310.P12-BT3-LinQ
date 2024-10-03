using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL dal = new ProductDAL();

        public void AddProduct(ProductDTO product)
        {
            dal.AddProduct(product);
        }

        public void EditProduct(ProductDTO product)
        {
            dal.EditProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            dal.DeleteProduct(productId);
        }

        public void DeleteExpiredProduct()
        {
            dal.DeleteExpiredProduct();
        }

        public DataTable GetProductList()
        {
            return dal.GetProductList();
        }

        public DataTable GetExpiredProductList()
        {
            return dal.GetExpiredProductList();
        }

        public DataTable FindProductWithHighestPrice()
        {
            return dal.FindProductWithHighestPrice();
        }

        public DataTable FindProductsFromJapan()
        {
            return dal.FindProductsFromJapan();
        }

        public DataTable GetProductsInPriceRange(decimal min, decimal max)
        {
            return dal.GetProductsInPriceRange(min, max);
        }

        public bool CheckIfProductCodeExists(int productId)
        {
            return dal.CheckIfProductCodeExists(productId);
        }
    }
}