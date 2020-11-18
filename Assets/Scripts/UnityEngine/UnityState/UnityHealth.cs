using Game.States;

namespace Game.UnityEngine.UnityState
{
    internal class UnityHealth : HealthState
    {
        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}