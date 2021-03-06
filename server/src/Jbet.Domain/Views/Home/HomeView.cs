﻿using Jbet.Domain.Views.Match;
using Jbet.Domain.Views.Team;
using System.Collections.Generic;

namespace Jbet.Domain.Views.Home
{
    public class HomeView
    {
        public HomeView(IEnumerable<MatchView> topMatches, IEnumerable<TeamView> bestTeams)
        {
            TopMatches = topMatches;
            BestTeams = bestTeams;
        }

        public IEnumerable<MatchView> TopMatches { get; set; }

        public IEnumerable<TeamView> BestTeams { get; set; }
    }
}