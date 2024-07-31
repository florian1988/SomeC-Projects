using DiaryApi.Data;
using DiaryApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryEntriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DiaryEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<DiaryEntry> GetEntries()
        {
            Console.WriteLine(_context.DiaryEntries.ToList().Count);
            return _context.DiaryEntries.ToList();
        }
        
    }
}
