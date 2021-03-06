using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class ShieldedInvader : Invader
    {
        private static Random _random = new Random();

        public override int Health {get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public virtual void DecreaseHealth(int factor)
        {
            
            if(_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
        }
    }
}