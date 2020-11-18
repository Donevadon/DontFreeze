using Game.States;

namespace Game.UnityEngine.UnityState
{
    internal class UnityHunger : HungerState
    {
        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}