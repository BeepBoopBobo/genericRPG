﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericRPG
{
    internal class Enemy:NPC
    {
        public Enemy(string name, int level, string type, int maxHealthPoints) : base(name,level, type, maxHealthPoints) { }
    }
}
