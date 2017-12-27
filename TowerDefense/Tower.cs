using System;

namespace TowerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfuleShot()
        {
            return _random.NextDouble() < _accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {

            foreach(Invader invader in invaders)
            {
                // Do stuff with invader
                if(invader.IsActive && _location.InRangeOf(invader.Location, range))
                {
                    if(IsSuccessfuleShot()){

                    invader.DecreaseHealth(power);
                    }
                    break;
                }
            }
            
        }
    }
}
