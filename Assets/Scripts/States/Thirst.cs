namespace Game.States
{
    public abstract class Thirst : State
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

        public Thirst()
            :base()
        {
            recovery.Add(this);
        }

        public void Recover(float water)
        {
            Quantity += water;
        }

        public void Remove(float value)
        {
            Quantity -= value;
        }


        protected override void ObserverAction()
        {
            Quantity -= Consumption;
        }
    }
}