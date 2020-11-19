namespace Game.States
{
    public class HealthState : State
    {
        public HealthState(IObservable observable) : base(observable)
        {
        }

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