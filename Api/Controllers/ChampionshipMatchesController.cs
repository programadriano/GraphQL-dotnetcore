using System.Collections.Generic;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ChampionshipMatchesController : Controller
    {

        private ChampionshipMatchesService _championshipMatches;

        public ChampionshipMatchesController(ChampionshipMatchesService championship)
        {
            _championshipMatches = championship;
        }
        // GET api/values
        [HttpGet]
        public IList<ChampionshipMatches> Get()
        {
            return _championshipMatches.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ChampionshipMatches Get(int id)
        {
            return _championshipMatches.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]ChampionshipMatches championship)
        {
            try
            {
                _championshipMatches.Add(championship);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ChampionshipMatches championship)
        {
            _championshipMatches.Update(championship);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _championshipMatches.Remove(id);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }
    }
}