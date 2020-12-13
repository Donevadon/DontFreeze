using System;

namespace Game.Indication
{
    public interface IHealthIndicator
    {
        event EventHandler StateEnded;
        event EventHandler<float> StateChanged;

        void TakeDamage(float damage);
        bool Heal(float HP);
    }
}