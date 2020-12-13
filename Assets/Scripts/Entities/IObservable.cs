namespace Game.Entities
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
    }
}