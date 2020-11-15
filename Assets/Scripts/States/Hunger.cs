namespace Game.States
{
    public abstract class Hunger : State
    {
        protected override float Quantity
        {
            get => quantity;
            set
            {
                if(value <= 0) 
                {
                    quantity = 0;
                    StateEnded?.Invoke(this,new StateEvent(damage));
                }
                else if(value > maxValue) quantity = maxValue;
                else quantity = value;
                StateChanged?.Invoke(this,new StateEvent(Quantity));
            }
        }
        private float damage;
        private float Consumption{get;set;} = 0.1f;
        public event StateHandler StateEnded;
        public override event StateHandler StateChanged;

        public Hunger()
            :base()
        {
            recovery.Add(this);
        }

        protected override void ObserverAction()
        {
            Quantity -= Consumption;
        }
    }
}