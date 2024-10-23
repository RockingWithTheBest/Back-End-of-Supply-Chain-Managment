using AutoMapper;
using Back_End.Models;
using SupplyChain.Data_Transfer_Object_DTOs_;
using SupplyChain.Repository.Interface;
using xx1.Db;

namespace SupplyChain.Repository.Implementation
{
    public class ProductRepository : IProduct
    {
        ApplicationDBContext dbContext;
        private readonly IMapper mapper;
        public ProductRepository(ApplicationDBContext cb) 
        { 
            dbContext = cb;
        }

        public int AddProduct(ProductEntity product)
        {
            int result = -1;
            if (product == null)
            {
                result = 0;
            }
            else
            {
                //var productEntity = mapper.Map<ProductEntity>(product);
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                result = product.Id;
            }
            return result;
        }

        public void Dispose()
        {
            dbContext?.Dispose();
        }

        public IEnumerable<ProductEntity> GetAllProducts()
        {
            var products = dbContext.Products.ToList();
            return products;
        }

        public IEnumerable<ProductEntity> GetProductByDescription(string description)
        {
            var products = dbContext.Products.Where(x => x.Description == description).ToList();
            return products;
        }

        public int UpdateSingleProduct(ProductEntity product)
        {
            var productVar = dbContext.Products.Where(c=>c.Id == product.Id).FirstOrDefault()??null;
            if(productVar != null)
            {
                productVar.Id = product.Id;
                productVar.Description = product.Description;
                productVar.Price = product.Price;
                productVar.Brand = product.Brand;
                productVar.Name = product.Name;
                productVar.StockQuantity = product.StockQuantity;
                dbContext.SaveChanges();
                return productVar.Id;
            }
            return -1;
        }

        public int DeleteProduct(int id)
        {
            int result = -1;
            if (id <= 0)
            {
                return result;
            }
            var product = dbContext.Products.Find(id);
            if(product == null)
            {
                return -1;
            }
            dbContext.Remove(product);
            dbContext.SaveChanges();
            return id;
        }

        public ProductEntity GetProductById(int id)
        {
            var product = dbContext.Products.FirstOrDefault(productid => productid.Id == id);
            return product;
        }
    }
}