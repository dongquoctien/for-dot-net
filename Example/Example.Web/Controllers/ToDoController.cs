using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Web.db;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        private TodoContext _context;
        public ToDoController(TodoContext todoContext
        
        )
        {
            this._context = todoContext;
        }

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var item = await _context.TodoItems.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}