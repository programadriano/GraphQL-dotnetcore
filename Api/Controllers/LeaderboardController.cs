using System.Collections.Generic;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class LeaderboardController : Controller
    {

        private LeaderboardService _leaderboardService;

        public LeaderboardController(LeaderboardService leaderboardService)
        {
            _leaderboardService = leaderboardService;
        }
        // GET api/values
        [HttpGet]
        public IList<Leaderboard> Get()
        {
            return _leaderboardService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Leaderboard Get(int id)
        {
            return _leaderboardService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Leaderboard leaderboard)
        {
            try
            {
                _leaderboardService.Add(leaderboard);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Leaderboard leaderboard)
        {
            _leaderboardService.Update(leaderboard);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _leaderboardService.Remove(id);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }
    }
}