using SRHLStats2020.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRHLStats2020.Models.ViewModels
{
    public class DataViewModel
    {
        public List<Arena> Arenas { get; internal set; }

        public List<Club> Clubs { get; internal set; }

        public List<Match> Matches { get; internal set; }

        public List<MatchCategory> MatchCategories { get; internal set; }

        public List<MatchStatus> MatchStatuses { get; internal set; }

        public List<MatchType> MatchTypes { get; internal set; }

        public List<Person> People { get; internal set; }

        public List<Series> Series { get; internal set; }

        public List<Team> Teams { get; internal set; }

    }
}
