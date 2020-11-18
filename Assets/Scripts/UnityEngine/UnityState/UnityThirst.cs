using Game.States;

namespace Game.UnityEngine.UnityState
{
    public class UnityThirst : ThirstState
    {
        protected override IObservable GetRecovery()
        {
            return Recovery.GetInstance();
        }
    }
}