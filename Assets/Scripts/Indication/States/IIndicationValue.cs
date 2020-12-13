using System;

namespace Game.Indication.States
{
    public interface IIndicationValue
    {
        float Quantity { get;}
        void Add(float health);
        void Remove(float damage);
        event EventHandler StateEnded;
        event EventHandler<float> StateChanged;
        event EventHandler StateFulled;
    }
}