using System.Threading.Tasks;
using UnityEngine;

namespace Game.States
{
    public abstract class Stamina : State
    {
        protected float recover = 0.01f;
        protected float cost = 0.1f;

        public Stamina()
            :base()
        {
            StateChanged += Recover;
        }

        public bool SpeedUp()
        {
            if((quantity - cost) < 0) return false;
            else 
            {
                Quantity -= cost;
                return true;
            }
        }

        private void Recover(object sender,StateEvent state)
        {
            recovery.Add(this);
        }

        protected override void ObserverAction()
        {
            if(Quantity < 1)
            {
                Quantity += recover;
            }else
            {
                recovery.Remove(this);
            }
        }
    }
}