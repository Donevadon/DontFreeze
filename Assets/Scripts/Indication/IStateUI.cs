namespace Game.Indication
{
    public interface IStateUI
    {
        void StaminaChangeHandler(object sender, float state);
        void HealthChangeHandler(object sender, float state);
        void HungerChangeHandler(object sender, float state);
        void ThirstChangeHandler(object sender, float state);
    }
}