﻿using Jbet.Domain.Events.Base;
using System;

namespace Jbet.Domain.Events.UserMatchBets
{
    public class UserMadeMatchBet : IEvent
    {
        public Guid UserMatchBetId { get; set; }

        public Guid UserId { get; set; }

        public Guid MatchId { get; set; }
    }
}