using System;

namespace Game.Entities
{
    public interface IPlayerUI
    {
        event EventHandler<float> DamageTaked;
    }
}