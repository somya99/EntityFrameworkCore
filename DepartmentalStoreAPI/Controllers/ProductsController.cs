using AutoMapper;
using DepartmentalStoreAPI.DepartmentalStore.Data;
using DepartmentalStoreAPI.DepartmentalStore.Domain;
using DepartmentalStoreAPI.DepartmentalStore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IDStoreRepository _repository;
        private readonly IMapper _mapper;


        public ProductsController(IDStoreRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<ActionResult<ProductModel[]>> Get(bool includeInventory = true)
        {
            try
            {
                var results = await _repository.GetAllProductAsync(includeInventory);

                return _mapper.Map<ProductModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("{productId}")]
        public async Task<ActionResult<ProductModel>> GetById(long productId, bool includeInventory = true)
        {
            try
            {
                var result = await _repository.GetProductAsync(productId, includeInventory);

                if (result == null) return NotFound();

                return _mapper.Map<ProductModel>(result);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("name/{productname}")]
        public async Task<ActionResult<ProductModel>> GetByName(string productname, bool includeInventory = true)
        {
            try
            {
                var result = await _repository.GetProductByNameAsync(productname, includeInventory);

                if (result == null) return NotFound();

                return _mapper.Map<ProductModel>(result);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("instock")]
        public async Task<ActionResult<ProductModel[]>> GetProductByInStock(bool includeInventory = true)
        {
            try
            {
                var results = await _repository.GetAllProductByInStock(includeInventory);

                if (!results.Any()) return NotFound();

                return _mapper.Map<ProductModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("outofstock")]
        public async Task<ActionResult<ProductModel[]>> GetProductByOutOfStock(bool includeInventory = true)
        {
            try
            {
                var results = await _repository.GetAllProductByOutOfStock(includeInventory);

                if (!results.Any()) return NotFound();

                return _mapper.Map<ProductModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        public async Task<ActionResult<ProductModel>> Post(Product product)
        {
            try
            {
                _repository.Add(product);
                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/Products/{product.ProductId}", _mapper.Map<ProductModel>(product));
                }

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

            return BadRequest();
        }
        [HttpPut("{productId}")]
        public async Task<ActionResult<ProductModel>> Put(long productId, ProductModel model)
        {
            try
            {
                var product = await _repository.GetProductAsync(productId, true);
                if (product == null) return NotFound("Couldn't find the product");

                _mapper.Map(model, product);

                if (model.Inventory != null)
                {
                    var inventory = await _repository.GetInventoryAsync(model.Inventory.InventoryId);
                    if (inventory != null)
                    {
                        product.Inventory = inventory;
                    }
                }

                if (await _repository.SaveChangesAsync())
                {
                    return _mapper.Map<ProductModel>(product);
                }
                else
                {
                    return BadRequest("Failed to update database.");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to get Product");
            }
        }
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(long productId)
        {
            try
            {
                var product = await _repository.GetProductAsync(productId);
                if (product == null) return NotFound("Failed to find the product to delete");
                _repository.Delete(product);

                if (await _repository.SaveChangesAsync())
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Failed to delete product");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to get product");
            }
        }
    }
}
