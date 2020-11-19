using Game.LivingEntity;
using Game.UnityEngine.UnityState;
using UnityEngine;

namespace Game.UnityEngine
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            UnityPlayerUI ui = UnityPlayerUI.GetInstance();
            Player player = new Player(Recovery.GetInstance(),
                ui.MoveInstance(),
                new States.StateFacade(UICanvas.GetInstance(),
                    new States.HealthState(Recovery.GetInstance()),
                    new States.ThirstState(Recovery.GetInstance()),
                    new States.StaminaState(Recovery.GetInstance()),
                    new States.HungerState(Recovery.GetInstance())),
                ui);
        }
    }
}