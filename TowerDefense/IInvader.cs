namespace TowerDefense
{
    interface IInvader
    {
        public MapLocation Location { get; }

        public abstract virtual int Health { get; }

        public bool HasScored { get; }

        public bool IsNeutralized { get; }

        public bool IsActive { get; }

        public void Move();

        public virtual void DecreaseHealth(int factor);
    }

}
}