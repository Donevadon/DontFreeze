using Game.States;

namespace Game.UnityEngine.UnityState
{
    public class UnityThirst : Thirst
    {
        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}