using System;

namespace Game.Indication.States
{
    public class Satiety : ISatietyIndicator
    {
        private IIndicationValue state;

        public Satiety(IIndicationValue indicator)
        {
            state = indicator;
        }
        public event EventHandler<float> StateChanged { add => state.StateChanged += value; remove => state.StateChanged -= value; }

        public void Remove(float value)
        {
            throw new NotImplementedException();
        }

        public bool Replenish(float satiety)
        {
            throw new NotImplementedException();
        }
    }
}