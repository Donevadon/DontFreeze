namespace Game.Entities
{
    public interface IMove
    {
        float Speed{get;}
        float AccelerationUp{set;}
        float AccelerationRight{set;}
        void Move(float addMass);
        void Run(bool active);
    }
}