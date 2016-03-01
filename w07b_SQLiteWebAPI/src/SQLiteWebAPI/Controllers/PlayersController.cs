using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DataModel.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SQLiteWebAPI.Controllers
{

    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private PlayerContext _context { get; set; }

        public PlayersController(PlayerContext context)
        {
            _context = context;
        }

        // GET: api/student
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return _context.Players.ToList();
        }

        // GET api/student/5
        [HttpGet("{id}")]
        public Player Get(int PlayerId)
        {
            return _context.Players.FirstOrDefault(s => s.PlayerId == PlayerId);
        }

        // POST api/student
        [HttpPost]
        public void Post([FromBody]Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        // PUT api/student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Player player)
        {
            _context.Players.Update(player);
            _context.SaveChanges();
        }

        // DELETE api/student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var player = _context.Players.FirstOrDefault(t => t.PlayerId == id);
            if (player != null)
            {
                _context.Players.Remove(player);
                _context.SaveChanges();
            }
        }
    }
}
