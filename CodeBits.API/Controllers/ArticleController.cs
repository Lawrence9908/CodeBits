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
using System.Security.Claims;

namespace CodeBits.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ArticleController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Article
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewArticlerDto>>> GetArticles()
        {
           var articles  = await _context.Articles.ToListAsync();
            return _mapper.Map<List<ViewArticlerDto>>(articles);
        }

        // GET: api/Article/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewArticlerDto>> GetArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            return _mapper.Map<ViewArticlerDto>(article);
        }

        // PUT: api/Article/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticle(int id, UpdateArticleDto model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }
            var article = _mapper.Map<Article>(model);
            article.Updated = DateTime.UtcNow;
            _context.Articles.Update(article);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
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

        // POST: api/Article
        [HttpPost]
        public async Task<ActionResult<ViewArticlerDto>> PostArticle(AddArticleDto model)
        {
            var identity = User.Identity as ClaimsIdentity;

            if (identity == null)
            {
                return BadRequest("User identity not found.");
            }

            // Get user details from claims
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var article = _mapper.Map<Article>(model);
            article.Updated = DateTime.UtcNow;
            article.Created = DateTime.UtcNow;
            article.CommentCount = 0;
            article.UserId = userId;

            _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticle", new { id = article.Id }, article);
        }

        // DELETE: api/Article/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
