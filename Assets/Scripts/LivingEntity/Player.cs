using Game.States;
using UnityEngine;
namespace Game.LivingEntity
{
    public class Player : IObserver
    {
        private IMove movement;
        private StateFacade states;
        private IObservable observable;
        private IPlayerUI UI;
        public Player(IObservable observable,IMove moveModule,StateFacade state,IPlayerUI ui)
        {
            this.observable = observable;
            movement = moveModule;
            states = state;
            this.UI = ui;
            UI.DamageTaked += TakeDamage;
            observable.Add(this);
        }

        private void TakeDamage(object sender,float damage) => states.RemoveHealth(damage);

        private void Control()
        {
            movement.AccelerationUp = Input.GetAxis("Vertical");
            movement.AccelerationRight = Input.GetAxis("Horizontal");
            if(Input.GetButton("Run")) movement.Run(states.SpeedUp());
        }

        public void Action()
        {
            movement.Move(0);
            Control();
        }
    }
}