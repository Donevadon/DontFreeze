using UnityEngine;
using System;

namespace Game.States
{
    public abstract class State : IObserver
    {
        protected float quantity = 100;
        public virtual float Quantity
        {
            get => quantity;
            protected set
            {
                if(value > maxValue) quantity = maxValue;
                else if(value < 0) quantity = 0;
                else quantity = value;
                StateChanged?.Invoke(this,Quantity);
            }
        }
        protected float maxValue = 100;
        protected IObservable recovery;
        public virtual event EventHandler<float> StateChanged;
        public State(IObservable observable)
        {
            recovery = observable;
        }
        protected abstract void ObserverAction();

        void IObserver.Action()
        {
            ObserverAction();
        }
    }
}