namespace TowerDefense
{
    class Level
    {

        private readonly Invader[] _invader;

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        //returns true if player wins, false otherwise
        public bool Play()
        {
            // run until all invaders are neutralized or an invader reaches the end of the path
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders > 0)
            {
                //Each tower has opportunity to fire on invaders
                foreach(TowerDefense tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
            }


            // Count and move the invaders that are still active.
            remainingInvaders = 0;
            foreach(Invader invader in _invader)
            {
                if (invader.IsActive)
                {
                    invader.Move();
                    if (invader.HasScored)
                    {
                        return false;
                    }

                    remainingInvaders++;
                }
            }
        }
    }
}