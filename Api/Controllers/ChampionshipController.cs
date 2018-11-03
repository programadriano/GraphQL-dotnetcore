using System.Collections.Generic;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ChampionshipController : Controller
    {

        private ChampionshipService _championship;

        public ChampionshipController(ChampionshipService championship)
        {
            _championship = championship;
        }
        // GET api/values
        [HttpGet]
        public IList<Championship> Get()
        {
            return _championship.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Championship Get(int id)
        {
            return _championship.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Championship championship)
        {
            try
            {
                _championship.Add(championship);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Championship championship)
        {
            _championship.Update(championship);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _championship.Remove(id);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }
    }
}