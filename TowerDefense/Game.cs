using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Game
    {
        public void Main()
        {
            
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TowerDefenseException)
            {
                Console.WriteLine("unhandled exception");
            }
            catch(Exception)
            {
                Console.WriteLine("unhandled exception");
            }
         
        }
    }
}
