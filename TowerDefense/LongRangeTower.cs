using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 3;

        public override int Health {get; protected set; } = 2;

        public LongRangeTower(Path path) : base(path)
        {



        }
    }
}