using UnityEngine;

namespace Game.States
{
    public abstract class State : IObserver
    {
        protected float quantity = 100;
        protected virtual float Quantity
        {
            get => quantity;
            set
            {
                if(value > maxValue) quantity = maxValue;
                else if(value < 0) quantity = 0;
                else quantity = value;
                StateChanged?.Invoke(this,new StateEvent(Quantity));
            }
        }
        protected float maxValue = 100;
        protected IObservable recovery;
        public virtual event StateHandler StateChanged;
        public State()
        {
            recovery = GetRecovery();
        }
        protected abstract IObservable GetRecovery();

        protected abstract void ObserverAction();

        void IObserver.Action()
        {
            ObserverAction();
        }
    }
}