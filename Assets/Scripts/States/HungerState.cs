using System;

namespace Game.States
{
    public abstract class HungerState : State
    {
        public override float Quantity
        {
            get => quantity;
            protected set
            {
                if(value <= 0) 
                {
                    quantity = 0;
                    StateEnded?.Invoke(this,damage);
                }
                else if(value > maxValue) quantity = maxValue;
                else quantity = value;
                StateChanged?.Invoke(this,Quantity);
            }
        }
        private float damage;
        private float Consumption{get;set;} = 0.1f;
        public event EventHandler<float> StateEnded;
        public override event EventHandler<float> StateChanged;

        public HungerState()
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