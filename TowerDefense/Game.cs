using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            
            Map map = new Map(8, 5);

            try
            {
                MapLocation [] path = {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                    
                };

                Invader[] invaders = 
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new BasicInvader(path),
                    new BasicInvader(path)
                };

                Tower[] towers = 
                {
                    new towers(new MapLocation(1, 2, map)),
                    new towers(new MapLocation(1, 2, map)),
                    new towers(new MapLocation(1, 2, map))
                };
                Level level = new Level(invaders);
                {
                    towers = towers;
                };

                bool playerWon = level.Play();


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
