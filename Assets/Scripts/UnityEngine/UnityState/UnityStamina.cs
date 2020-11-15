using Game.States;

namespace Game.UnityEngine.UnityState
{
    internal class UnityStamina : Stamina
    {
        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}