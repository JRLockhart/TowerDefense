using System;

namespace TowerDefense
{
    class Tower
    {
        protected virtual int Range{ get;} = 1;
        protected virtual int Power{ get; } = 1;
        protected virtual double Accuracy { get; } =.75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfuleShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {

            foreach(Invader invader in invaders)
            {
                // Do stuff with invader
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfuleShot()){

                    invader.DecreaseHealth(Power);
                    }
                    break;
                }
            }
            
        }
    }
}
