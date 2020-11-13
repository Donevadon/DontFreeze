namespace Game
{
    public interface IMove
    {
        float Speed{get;set;}
        float AccelerationUp{get;set;}
        float AccelerationRight{get;set;}
        void Move(float addMass);
    }
}