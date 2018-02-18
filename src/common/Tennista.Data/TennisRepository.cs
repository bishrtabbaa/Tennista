using System;
using System.Collections.Generic;
using Tennista.Model;

namespace Tennista.Data
{
    public class TennisRepository : ITennisRepository
    {
        public IEnumerable<Player> GetPlayers()
        {
            return new List<Player>()
            {
                new Player() { Id=1, Name="Roger Federer", BackhandType="SGL", PreferredHandType="RIGHT", PlaceOfBirth="Basel, Switzerland"},
                new Player() { Id=2, Name="Rafael Nadal", BackhandType="DBL", PreferredHandType="LEFT", PlaceOfBirth="Manocor, Spain"},
                new Player() { Id=3, Name="Novak Djokovic", BackhandType="DBL", PreferredHandType="RIGHT", PlaceOfBirth="Zagreb, Serbia" },
                new Player() { Id=4, Name="Andy Murray", BackhandType="DBL", PreferredHandType="RIGHT", PlaceOfBirth="Glasgow, Scotland" }
            };
        }

        public IEnumerable<Tournament> GetTournaments()
        {
            return new List<Tournament>()
            {
                new Tournament() { Name="Australian Open", Location="Melbourne, Australia", Points=2000, SurfaceType="Hard"},
                new Tournament() { Name="French Open", Location="Paris, France", Points=2000, SurfaceType="Clay"},
                new Tournament() { Name="Wimbledon", Location="London, England", Points=2000, SurfaceType="Grass"},
                new Tournament() { Name="US Open", Location="New York, NYC", Points=2000, SurfaceType="Hard"}
            };
        }

        public IEnumerable<Match> GetMatches()
        {
            var matches = new List<Match>();


            return matches;
        }

    }
}
