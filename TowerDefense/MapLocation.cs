﻿using System;

namespace TowerDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if(!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside of the boundries");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}