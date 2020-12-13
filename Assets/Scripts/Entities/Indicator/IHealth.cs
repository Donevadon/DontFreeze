namespace Game.Entities.Indicator
{
    public interface IHealth
    {
        void TakeDamage(float damage);
        bool HealHealth(float HP);
    }
}