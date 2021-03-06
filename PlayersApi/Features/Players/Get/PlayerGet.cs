﻿using System.Collections.Generic;
using PlayersApi.Features.Players.Get;

namespace PlayersApi {
    public class PlayerGet {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Xp { get; set; }
        public int Age { get; set; }
        public List<BadgeGet> Badges { get; set; }
    }
}