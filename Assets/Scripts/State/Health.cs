namespace Game.State
{
    public class Health : IHealth
    {
        private float hp = 100;
        private float HP
        {
            get => hp;
            set
            {
                if(value > 100) hp = value;
                else if(value < 0) hp = 0;
                else hp = value;
            }
        }
        public event StateHandler HealthChanged;

        public bool Recovery(float health)
        {
            if(HP == 100) return false;
            HP += health;
            HealthChanged?.Invoke(this,new StateEvent(HP));
            return true;
        }

        public void Remove(float damage)
        {
            HP -= damage;
            HealthChanged?.Invoke(this,new StateEvent(HP));
        }
    }
}