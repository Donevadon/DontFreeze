using Game.States;
using UnityEngine;

namespace Game.UnityEngine.UnityState
{
    public class UnityStateHealth : StateHealth
    {
        protected override void Initialize()
        {
            stamina = new UnityStamina();
            health = new UnityHealth();
            hunger = new UnityHunger();
            thirst = new UnityThirst();
            UI = UICanvas.GetInstance();
        }
    }
}