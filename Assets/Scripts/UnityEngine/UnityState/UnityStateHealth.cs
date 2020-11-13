using UnityEngine;
using Game.State;

namespace Game.UnityEngine.UnityState
{
    public class UnityStateHealth : StateHealth
    {
        protected override void Initialize()
        {
            stamina = new UnityStamina();
            health = new Health();
            UI = UICanvas.GetInstance();
            SubscribeEvent();
        }

        private void SubscribeEvent()
        {
            stamina.StaminaChanged += UI.StaminaChangeHandler;
            health.HealthChanged += UI.HealthChangeHandler;
            //thirst.ThirstChanged += UI.ThirstChangeHandler;
            //hunger.HungerChanged += UI.ThirstChangeHandler;
        }
    }
}