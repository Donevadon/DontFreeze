using System;

namespace Game.Indication.States
{
    public class Health : IHealthIndicator
    {
        private IIndicationValue state;

        public Health(IIndicationValue state)
        {
            this.state = state;
        }

        public event EventHandler StateEnded
        {
            add
            {
                state.StateEnded += value;
            }
            remove
            {
                state.StateEnded -= value;
            }
        }
        public event EventHandler<float> StateChanged {add => state.StateChanged += value; remove => state.StateChanged -= value;}

        public bool Heal(float HP)
        {
            //TODO:Реализовать лечение
            throw new NotImplementedException();
        }

        public void TakeDamage(float damage)
        {
            //TODO:Реализовать получение урона
            throw new NotImplementedException();
        }
    }
}