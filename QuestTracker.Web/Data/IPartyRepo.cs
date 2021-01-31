using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static QuestTracker.Model;

namespace QuestTracker.Web.Data
{
    public interface IPartyRepo
    {
        IEnumerable<string> GetPartyNames();
        Party GetParty(string partyName);
        void FormNewParty(string partyName);
        void AddAdventurer(string partyName, [FromBody] Adventurer adventurer);
        void DeleteParty(string partyName);
    }
}
