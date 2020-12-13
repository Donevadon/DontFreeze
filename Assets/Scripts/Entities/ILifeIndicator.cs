using Game.Entities.Indicator;

namespace Game.Entities
{
    public interface ILifeIndicator : IHealth, IStamina, IThirst,ISatiety,IUpdateIndicators
    {
        
    }
}