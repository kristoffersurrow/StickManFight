using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickManFight
{
    interface IFighter
    {
        int Health { get; set; }

        int AttackMax { get; set; }

        int BlockMax { get; set; }
    }
}
