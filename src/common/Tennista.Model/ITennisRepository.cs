using System;
using System.Collections.Generic;
using System.Text;

namespace Tennista.Model
{
    public interface ITennisRepository
    {
        IEnumerable<Player> GetPlayers();
        IEnumerable<Tournament> GetTournaments();
        IEnumerable<Match> GetMatches();
    }
}
