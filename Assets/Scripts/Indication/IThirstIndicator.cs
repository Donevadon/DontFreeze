using System;

namespace Game.Indication
{
    public interface IThirstIndicator
    {
        event EventHandler<float> StateChanged;
        bool Replenish(float thirst);
        void Remove(float value);
    }
}