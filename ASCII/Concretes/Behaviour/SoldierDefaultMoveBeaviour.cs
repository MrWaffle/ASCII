﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    public class SoldierDefaultMoveBeaviour : SoldierBehaviour
    {
        public SoldierDefaultMoveBeaviour(ISoldier baseSoldier) : base(baseSoldier)
        {
        }

        public override void DoBehaviour()
        {
            Console.WriteLine("Default Move");
        }
    }
}
