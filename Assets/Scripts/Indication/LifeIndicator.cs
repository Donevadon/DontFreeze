using System;
using Game.Entities;

namespace Game.Indication
{
    public abstract class LifeIndicator : IDisposable ,ILifeIndicator
    {
        protected IHealthIndicator health;
        protected IThirstIndicator thirst;
        protected IStaminaIndicator stamina;
        protected ISatietyIndicator satiety;
        protected IStateUI UI;
        

        public LifeIndicator(IStateUI UI)
        {
            this.UI = UI;
            this.health = CreateHealth();
            this.thirst = CreateThirst();
            this.stamina = CreateStamina();
            this.satiety = CreateSatiety();
            SubscribeEvent();
        }

        protected abstract ISatietyIndicator CreateSatiety();
        protected abstract IStaminaIndicator CreateStamina();
        protected abstract IThirstIndicator CreateThirst();
        protected abstract IHealthIndicator CreateHealth();

        private void SubscribeEvent()
        {
            stamina.StateChanged += UI.StaminaChangeHandler;
            health.StateChanged += UI.HealthChangeHandler;
            thirst.StateChanged += UI.ThirstChangeHandler;
            satiety.StateChanged += UI.HungerChangeHandler;
        }

        public void Dispose()
        {
            stamina.StateChanged -= UI.StaminaChangeHandler;
            health.StateChanged -= UI.HealthChangeHandler;
            thirst.StateChanged -= UI.ThirstChangeHandler;
            satiety.StateChanged -= UI.HungerChangeHandler;
        }

        public void TakeDamage(float damage)
        {
            throw new NotImplementedException();
        }

        public bool HealHealth(float HP)
        {
            throw new NotImplementedException();
        }

        public bool Subtract(float stamina)
        {
            throw new NotImplementedException();
        }

        public bool Drink(float value)
        {
            throw new NotImplementedException();
        }

        public bool Eat(float value)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}