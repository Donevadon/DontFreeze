namespace Game
{
    public interface IHealth
    {
        event StateHandler HealthChanged;
        void Remove(float damage);
        bool Recovery(float HP);
    }
}