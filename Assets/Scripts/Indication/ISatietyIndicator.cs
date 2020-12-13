using System;

namespace Game.Indication
{
    public interface ISatietyIndicator
    {
        event EventHandler<float> StateChanged;
        bool Replenish(float satiety);
        void Remove(float value);
    }
}