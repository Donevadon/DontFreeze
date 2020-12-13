using UnityEngine;
using UnityEngine.UI;
using Game.Indication;

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

        public void HealthChangeHandler(object sender, float state)
        {
            health.fillAmount = state / 100;
        }

        public void HungerChangeHandler(object sender, float state)
        {
            hunger.fillAmount = state / 100;
        }

        public void StaminaChangeHandler(object sender, float state)
        {
            stamina.fillAmount = state / 100;
        }

        public void ThirstChangeHandler(object sender, float state)
        {
            thirst.fillAmount = state / 100;
        }
    }
}