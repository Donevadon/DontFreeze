using System;

namespace Game.LivingEntity
{
    public interface IPlayerUI
    {
        event EventHandler<float> DamageTaked;
    }
}