using Microsoft.AspNetCore.Mvc;
using ProductsApi.Application.DTO;
using ProductsApi.Application.Interfaces;
using ProductsApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ControllerBase<Entity, EntityDTO> : Controller
        where Entity : BaseEntity
        where EntityDTO : BaseDTO
    {
        readonly protected IAppBase<Entity, EntityDTO> app;

        public ControllerBase(IAppBase<Entity, EntityDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            try
            {
                var products = app.SelectAll();
                return new OkObjectResult(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelectById(int id)
        {
            try
            {
                var products = app.SelectById(id);
                return new OkObjectResult(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Include([FromBody] EntityDTO data)
        {
            try
            {
                return new OkObjectResult(app.Include(data));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] EntityDTO data)
        {
            try
            {
                app.Update(data);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Exclude(int id)
        {
            try
            {
                app.Exclude(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
