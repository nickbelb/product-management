using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ProductService
    {
        ProductRepository ProductRepository = new ProductRepository();
        public List<Product> GetProductsService()
        {
            return ProductRepository.GetProductsRepository();
        }

        public bool DeleteProductService(int productID)
        {
            return ProductRepository.DeleteProductRepository(productID);
        }

        public bool AddProductService(Product product)
        {
            return ProductRepository.AddProductRepository(product);
        }

        public Product GetItemByIdService(int productId)
        {
            return ProductRepository.GetProductByIdRepository(productId);
        }

        public bool UpdateProductService(Product product)
        {
            return ProductRepository.UpdateProductRepository(product);
        }

    }

}
