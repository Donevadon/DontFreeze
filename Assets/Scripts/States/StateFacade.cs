namespace Game.States
{
    public class StateFacade
    {
        protected HealthState health;
        protected ThirstState thirst;
        protected StaminaState stamina;
        protected HungerState hunger;
        protected IStateUI UI;
        

        public StateFacade(IStateUI UI,
            HealthState health,
            ThirstState thirst,
            StaminaState stamina,
            HungerState hunger)
        {
            this.UI = UI;
            this.health = health;
            this.thirst = thirst;
            this.stamina = stamina;
            this.hunger = hunger;
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
    }
}