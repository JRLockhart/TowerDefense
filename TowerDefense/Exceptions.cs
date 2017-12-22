using System;

namespace TowerDefense
{
    class TowerDefenseExceptions : System.Exception
    {
        public TowerDefenseExceptions()
        {

        }

        public TowerDefenseExceptions(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TowerDefenseExceptions
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
