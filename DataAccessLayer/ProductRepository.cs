using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DataAccessLayer
{

    
    public class ProductRepository
    {
        ProductManagementEntities productEntities = new ProductManagementEntities();

        public List<Product> GetProductsRepository()
        {
            return productEntities.Products.ToList();
        }

        public bool DeleteProductRepository(int productId)
        {
            var product = productEntities.Products.FirstOrDefault(prod=>prod.ProductID== productId);
            if(product != null)
            {
                productEntities.Products.Remove(product);
                productEntities.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AddProductRepository(Product product)
        {
            if(product != null)
            {
                productEntities.Products.Add(product);
                productEntities.SaveChanges();
                return true;
            }
            return false;
        }


        public bool UpdateProductRepository(Product product)
        {
            var productToUpdate = productEntities.Products.FirstOrDefault(prod => prod.ProductID == product.ProductID);
            if(productToUpdate != null)
            {
                Mapper.Map(product,productToUpdate);
                productEntities.SaveChanges();
                return true;
            }

            return false;
        }

        public Product GetProductByIdRepository(int productId)
        {
            return productEntities.Products.FirstOrDefault(prod=>prod.ProductID== productId);
        }
    }
}
