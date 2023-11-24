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
    public class CommentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CommentController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Comment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewCommentDto>>> GetComments()
        {
            var comments  = await _context.Comments.ToListAsync();
            return _mapper.Map<List<ViewCommentDto>>(comments);
        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewCommentDto>> GetComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);

            if (comment == null)
            {
                return NotFound();
            }

            return _mapper.Map<ViewCommentDto>(comment);
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComment(int id,UpdateCommentDto model)
        {
            var userId = User.Identity.Name;
            if (id != model.Id )
            {
                return BadRequest();
            }
            var comment = _mapper.Map<Comment>(model);
            if(comment.UserId != userId)
            {
               return Unauthorized();
            }
            _context.Comments.Update(comment);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentExists(id))
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

        // POST: api/Comment
        [HttpPost]
        public async Task<ActionResult<Comment>> PostComment(AddCommentDto model)
        {
            var comment = _mapper.Map<Comment>(model);
            
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComment", new { id = comment.Id }, comment);
        }

        // DELETE: api/Comment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
    }
}
