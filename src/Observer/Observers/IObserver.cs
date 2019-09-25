namespace Observer.Observers
{
    using Observer.Subjects;

    public interface IObserver<T>
    {
        void Update(BaseSubject<T> baseSubject, params T[] args);
    }
}
