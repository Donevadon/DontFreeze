using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public abstract class Stamina : IObserver
    {
        private float quantity = 100;
        private IObservable recovery;
        private float Quantity
        {
            get => quantity;
            set
            {
                if(value > 100) quantity = 100;
                else if(value < 0) quantity = 0;
                else quantity = value;
            }
        }
        protected float recover = 0.01f;
        protected float cost = 0.1f;
        public event StateHandler StaminaChanged;

        public Stamina()
        {
            StaminaChanged += Recover;
            recovery = GetRecovery();
        }

        protected abstract IObservable GetRecovery();

        public bool SpeedUp()
        {
            if((quantity - cost) < 0) return false;
            else 
            {
                Quantity -= cost;
                StaminaChanged(this,new StateEvent(Quantity));
                return true;
            }
        }

        private void Recover(object sender,StateEvent state)
        {
            recovery.Add(this);
        }

        public void Action()
        {
            if(Quantity < 1)
            {
                Quantity += recover;
                StaminaChanged(this,new StateEvent(Quantity));
            }else
            {
                recovery.Remove(this);
            }
        }
    }
}