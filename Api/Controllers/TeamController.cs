using System.Collections.Generic;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        private TeamService _teamService;

        public TeamController(TeamService teamService)
        {
            _teamService = teamService;
        }
        // GET api/values
        [HttpGet]
        public IList<Team> Get()
        {
            return _teamService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return _teamService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Team leaderboard)
        {
            try
            {
                _teamService.Add(leaderboard);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Team leaderboard)
        {
            _teamService.Update(leaderboard);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _teamService.Remove(id);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }
    }
}