namespace Game.States
{
    public abstract class StateHealth
    {
        protected HealthState health;
        protected ThirstState thirst;
        protected StaminaState stamina;
        protected HungerState hunger;
        protected IStateUI UI;
        

        public StateHealth()
        {
            Initialize();
            SubscribeEvent();
        }

        public bool RecoveryHealth(float HP)
        {
            return health.Recover(HP);
        }

        public void RemoveHealth(float damage)
        {
            health.Remove(damage);
        }

        public bool SpeedUp()
        {
            bool result = stamina.SpeedUp();
            return result;
        }
        protected virtual void SubscribeEvent()
        {
            stamina.StateChanged += UI.StaminaChangeHandler;
            health.StateChanged += UI.HealthChangeHandler;
            thirst.StateChanged += UI.ThirstChangeHandler;
            hunger.StateChanged += UI.HungerChangeHandler;
        }

        protected abstract void Initialize();
    }
}