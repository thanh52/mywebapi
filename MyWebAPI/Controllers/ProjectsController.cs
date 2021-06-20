using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Base.Data.Models;
using Base.Service.IServices;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET: api/Projects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProject()
        {
            return await _projectService.GetAllProjectAsync();
        }

        //// GET: api/Projects/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Project>> GetProject(Guid id)
        //{
        //    var project = await _context.Project.FindAsync(id);

        //    if (project == null)
        //    {
        //        return NotFound();
        //    }

        //    return project;
        //}

        //// PUT: api/Projects/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProject(Guid id, Project project)
        //{
        //    if (id != project.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(project).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProjectExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Projects
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Project>> PostProject(Project project)
        //{
        //    _context.Project.Add(project);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetProject", new { id = project.Id }, project);
        //}

        //// DELETE: api/Projects/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProject(Guid id)
        //{
        //    var project = await _context.Project.FindAsync(id);
        //    if (project == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Project.Remove(project);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ProjectExists(Guid id)
        //{
        //    return _context.Project.Any(e => e.Id == id);
        //}
    }
}
