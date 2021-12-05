using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{

    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [Route("getActivities")]
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> getActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        [Route("ABC")]
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> ABC()
        {
            return await _context.Activities.Where(act => act.Category == "drinks").ToListAsync();
        }

        [HttpGet("{id}")] //activities id
        public async Task<ActionResult<Activity>> getActivity(Guid id)
        {
            var a = await _context.Activities.FindAsync(id);
            if (a == null)
                a = new Activity();
            return a;
        }
    }
}