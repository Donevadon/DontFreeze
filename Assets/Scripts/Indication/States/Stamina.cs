using System;

namespace Game.Indication.States
{
    public class Stamina : IStaminaIndicator
    {

        private IIndicationValue state;

        public Stamina(IIndicationValue indicator)
        {
            this.state = indicator;
        }

        public event EventHandler<float> StateChanged { add => state.StateChanged += value; remove => state.StateChanged -= value; }

        public void Replenish(float value)
        {
            throw new NotImplementedException();
        }

        public bool Subtract(float stamina)
        {
            throw new NotImplementedException();
        }
    }
}