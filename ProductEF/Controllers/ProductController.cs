using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductEF.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductService productService = new ProductService();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetProducts()
        {
            List<Product> products = productService.GetProductsService();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteProduct(int productID)
        {
            if (productService.DeleteProductService(productID))
            {
                return Json(JsonRequestBehavior.AllowGet);
            }
            return null;
        }

        [HttpPost]
        public JsonResult AddProduct(Product product)
        {
            var productAdded = productService.AddProductService(product);
            return Json(productAdded, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetProductById(int productID)
        {
            var product = productService.GetItemByIdService(productID);
            return Json(product, JsonRequestBehavior.AllowGet);
        }

        public  JsonResult UpdateProduct(Product product)
        {
            var productUpdated = productService.UpdateProductService(product);
            return Json(productUpdated, JsonRequestBehavior.AllowGet);
        }


    }
}