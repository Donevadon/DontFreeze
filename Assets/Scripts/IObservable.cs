namespace Game
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
    }
}