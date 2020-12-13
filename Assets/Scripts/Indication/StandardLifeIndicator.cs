using Game.Indication.States;

namespace Game.Indication
{
    public class StandardLifeIndicator : LifeIndicator
    {
        public StandardLifeIndicator(IStateUI UI) : base(UI)
        {
        }

        protected override IHealthIndicator CreateHealth()
        {
            return new Health(new IndicationValue());
        }

        protected override ISatietyIndicator CreateSatiety()
        {
            return new Satiety(new IndicationValue());
        }

        protected override IStaminaIndicator CreateStamina()
        {
            return new Stamina(new IndicationValue());
        }

        protected override IThirstIndicator CreateThirst()
        {
            return new Thirst(new IndicationValue());
        }
    }
}