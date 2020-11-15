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
            SubscribeEvent();
        }

        private void SubscribeEvent()
        {
            stamina.StateChanged += UI.StaminaChangeHandler;
            health.StateChanged += UI.HealthChangeHandler;
            thirst.StateChanged += UI.ThirstChangeHandler;
            hunger.StateChanged += UI.HungerChangeHandler;
        }
    }
}