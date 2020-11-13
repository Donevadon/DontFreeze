using Game.State;

namespace Game.UnityEngine.UnityState
{
    public class UnityStamina : Stamina
    {
        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}