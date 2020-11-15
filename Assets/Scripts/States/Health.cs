namespace Game.States
{
    public abstract class Health : State
    {
        protected override void ObserverAction()
        {
            
        }
        public bool Recover(float health)
        {
            if(Quantity == 100) return false;
            Quantity += health;
            return true;
        }

        public void Remove(float damage)
        {
            Quantity -= damage;
        }
    }
}