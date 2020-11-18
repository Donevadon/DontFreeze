using Game.States;

namespace Game.UnityEngine.UnityState
{
    internal class UnityStamina : StaminaState
    {
        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}