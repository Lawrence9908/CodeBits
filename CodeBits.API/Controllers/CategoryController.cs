using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeBits.API.Data;
using CodeBits.API.Entities;
using AutoMapper;
using CodeBits.API.Models.Dtos;

namespace CodeBits.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoryController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
             _mapper = mapper;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewCategoryDto>>> GetCategories()
        {
            var categories  = await _context.Categories.ToListAsync();
            return  _mapper.Map<List<ViewCategoryDto>>(categories);
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewCategoryDto>> GetCategory(int id)
        {

            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return _mapper.Map<ViewCategoryDto>(category);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, UpdateCategoryDto model)
        {

            if (id != model.Id)
            {
                return BadRequest();
            }

            var category  = _mapper.Map<Category>(model);
            _context.Categories.Update(category);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Category
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(AddCategoryDto model)
        {
            var category = _mapper.Map<Category>(model);
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
