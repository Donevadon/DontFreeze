using System;

namespace Game.Indication
{
    public interface IStaminaIndicator
    {
        event EventHandler<float> StateChanged;
        void Replenish(float value);
        bool Subtract(float stamina);
    }
}