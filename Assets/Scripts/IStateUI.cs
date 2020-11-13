namespace Game
{
    public interface IStateUI
    {
        void StaminaChangeHandler(object sender, StateEvent state);
        void HealthChangeHandler(object sender, StateEvent state);
        void HungerChangeHandler(object sender, StateEvent state);
        void ThirstChangeHandler(object sender, StateEvent state);
    }
}