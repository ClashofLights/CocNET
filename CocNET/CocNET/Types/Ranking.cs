﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocNET.Types
{
    public class Ranking : BadRequest
    {
        public List<Clan> ClanRanking { get; set; }
        public List<Player> PlayerRanking { get; set; }
    }
}
