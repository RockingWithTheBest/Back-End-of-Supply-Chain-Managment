using AutoMapper;
using Back_End.Models;
using Back_End.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SupplyChain.Data_Transfer_Object_DTOs_;
using SupplyChain.Repository.Interface;
using xx1.Db;

namespace SupplyChain.Controllers
{

    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private IProduct _productrepo;
        private readonly IMapper _mapper;
        public ProductController(IProduct productrepo, IMapper mapper)
        {
            _productrepo = productrepo;
            _mapper = mapper;
        }


        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Index")]
        public IActionResult Index()
        {
            var productEntities = _productrepo.GetAllProducts();
            if (productEntities == null)
            {
                return NotFound();
            }
            // Map to DTOs
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(productEntities);
            return Ok(productDto);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetAllByDescrption")]
        public IActionResult GetAllByDescrption(string description)
        {
            var  productEntities = _productrepo.GetProductByDescription(description);
            if (productEntities == null)
            {
                return NotFound();
            }
            // Map to DTOs
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(productEntities);
            return Ok(productDto);
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetItemThroughId")]
        public IActionResult GetItemById(int Id)
        {
            var productEntities = _productrepo.GetProductById(Id);
            if (productEntities == null)
            {
                return NotFound("Id not valid");
            }
 
            return Ok(productEntities);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("AddOrder")]
        public IActionResult AddOrder(ProductEntity product)
        {        
            var productId = _productrepo.AddProduct(product);
            if(productId<= 0)
            {
                return BadRequest("Failed");
            }
            else
            {
                //var productdto = _mapper.Map<ProductDto>(productId);
                return Ok("Added! " + productId);
            }       
        }

        [HttpPut]
        [Microsoft.AspNetCore.Mvc.Route("Edit")]
        public IActionResult Edit(ProductEntity product)
        {
            var productEntity = _productrepo.UpdateSingleProduct(product);
            if (productEntity <= 0)
            {
                return BadRequest("Failed!");
            }
            return Ok("Updated : "+productEntity);
        }

        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("Delete")]
        public IActionResult Delete(int id)
        {
            var productId = _productrepo.DeleteProduct(id);
            if (productId <= 0)
            {
                return BadRequest("Failed!");
            }
            else
                return Ok("Deleted : " + productId);
        }
    }
}
