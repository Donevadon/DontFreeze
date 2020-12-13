using UnityEngine;

namespace Game.Entities
{
    public abstract class Organism : IObserver
    {
        private IMove movement;
        private ILifeIndicator indicator;
        private IObservable observable;
        private IPlayerUI UI;
        public Organism(IObservable observable,IMove moveModule,ILifeIndicator indicator,IPlayerUI ui)
        {
            this.observable = observable;
            movement = moveModule;
            this.indicator = indicator;
            this.UI = ui;
            UI.DamageTaked += TakeDamage;
            observable.Add(this);
        }

        private void TakeDamage(object sender,float damage) 
        {
            IHealth health = indicator;
            health.TakeDamage(damage);
        }

        // private void Control()
        // {
        //     //TODO: Класс управления для считывания нажаний клавиш в графическом движке
        //     movement.AccelerationUp = Input.GetAxis("Vertical");
        //     movement.AccelerationRight = Input.GetAxis("Horizontal");
        //     if(Input.GetButton("Run")) movement.Run(states.SpeedUp());
        // }

        public void Action()
        {
            movement.Move(0);
            // Control();
        }
    }
}