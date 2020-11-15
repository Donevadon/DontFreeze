namespace Game.States
{
    public abstract class StateHealth
    {
        protected Health health;
        protected Thirst thirst;
        protected Stamina stamina;
        protected Hunger hunger;
        protected IStateUI UI;
        

        public StateHealth()
        {
            Initialize();
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
        protected abstract void Initialize();
    }
}