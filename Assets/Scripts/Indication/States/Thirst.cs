using System;

namespace Game.Indication.States
{
    public class Thirst : IThirstIndicator
    {

        private IIndicationValue state;

        public Thirst(IIndicationValue indicator)
        {
            state = indicator;
        }
        public event EventHandler<float> StateChanged;

        public void Remove(float value)
        {
            throw new NotImplementedException();
        }

        public bool Replenish(float thirst)
        {
            throw new NotImplementedException();
        }
    }
}