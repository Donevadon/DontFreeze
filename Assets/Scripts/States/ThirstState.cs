using System;

namespace Game.States
{
    public abstract class ThirstState : State
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

        public ThirstState()
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