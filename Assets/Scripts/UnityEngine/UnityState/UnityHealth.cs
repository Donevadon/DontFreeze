using Game.States;

namespace Game.UnityEngine.UnityState
{
    internal class UnityHealth : Health
    {
        public UnityHealth()
            :base()
        {
        }

        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}