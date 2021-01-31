using Microsoft.AspNetCore.Mvc;
using QuestTracker.Web.Data;
using System;
using System.Collections.Generic;
using static QuestTracker.Model;

namespace QuestTracker.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyController : ControllerBase
    {
        private IPartyRepo _repository;

        public PartyController(IPartyRepo repository)
        {
            _repository = repository;
        }

        // GET: api/<PartyController>
        [HttpGet]
        public IEnumerable<string> GetPartyNames()
        {
            return _repository.GetPartyNames();
        }

        // GET api/<PartyController>/ABC
        [HttpGet("{partyName}")]
        public Party GetParty(string partyName)
        {
            return _repository.GetParty(partyName);
        }

        // POST api/<PartyController>/ABC/new
        [HttpPost("{partyName}/new")]
        public void FormNewParty(string partyName)
        {
            _repository.FormNewParty(partyName);
        }

        // POST api/<PartyController>/ABC/addAdventurer
        [HttpPost("{partyName}/addAdventurer")]
        public void AddAdventurer(string partyName, [FromBody] Adventurer adventurer)
        {
            _repository.AddAdventurer(partyName, adventurer);
        }

        // DELETE api/<PartyController>/5
        [HttpDelete("{partyName}")]
        public void DeleteParty(string partyName)
        {
            _repository.DeleteParty(partyName);
        }
    }
}
