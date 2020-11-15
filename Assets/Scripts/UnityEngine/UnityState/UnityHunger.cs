using Game.States;

namespace Game.UnityEngine.UnityState
{
    internal class UnityHunger : Hunger
    {
        public UnityHunger()
            :base()
        {
        }

        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}