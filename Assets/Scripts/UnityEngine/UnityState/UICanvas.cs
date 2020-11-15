using UnityEngine;
using UnityEngine.UI;
using Game.States;

namespace Game.UnityEngine.UnityState
{
    public class UICanvas : MonoBehaviour, IStateUI
    {
        private static UICanvas canvas;
        [SerializeField] private Image stamina;
        [SerializeField] private Image health;
        [SerializeField] private Image hunger;
        [SerializeField] private Image thirst;

        private UICanvas()
        {

        }

        public static UICanvas GetInstance()
        {
            return canvas;
        }

        private void Awake() 
        {
            canvas = this;   
        }

        public void HealthChangeHandler(object sender, StateEvent state)
        {
            health.fillAmount = state.State / 100;
        }

        public void HungerChangeHandler(object sender, StateEvent state)
        {
            hunger.fillAmount = state.State / 100;
        }

        public void StaminaChangeHandler(object sender, StateEvent state)
        {
            stamina.fillAmount = state.State / 100;
        }

        public void ThirstChangeHandler(object sender, StateEvent state)
        {
            thirst.fillAmount = state.State / 100;
        }
    }
}