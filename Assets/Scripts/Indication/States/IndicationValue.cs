using System;

namespace Game.Indication.States
{
    public class IndicationValue : IIndicationValue
    {
        private float quantity;
        public float Quantity
        {
            get => quantity;
            private set
            {
                if(value <= 0) 
                {
                    quantity = 0;
                    StateEnded?.Invoke(this,new EventArgs());
                }
                else if(value >= MaxValue)
                {
                     quantity = MaxValue;
                     StateFulled?.Invoke(this,new EventArgs());
                }
                else quantity = value;
                StateChanged?.Invoke(this,Quantity);
            }
        }

        public float MaxValue = 100;
        public event EventHandler StateFulled;
        public event EventHandler StateEnded;
        public event EventHandler<float> StateChanged;

        public IndicationValue(float initialValue = 100, float maxValue = 100)
        {
            quantity = initialValue;
            MaxValue = maxValue;
        }

        public void Add(float value)
        {
            Quantity += value;
        }

        public void Remove(float value)
        {
            Quantity -= value;
        }
    }
}