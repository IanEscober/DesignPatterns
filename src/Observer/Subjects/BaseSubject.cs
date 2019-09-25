namespace Observer.Subjects
{
    using Observer.Observers;

    public abstract class BaseSubject<T>
    {
        private readonly ChangeManager<T> changeManager;

        protected BaseSubject(ChangeManager<T> changeManager)
        {
            this.changeManager = changeManager;
        }

        public virtual void Attach(IObserver<T> observer)
        {
            this.changeManager.Register(this, observer);
        }

        public virtual void Detach(IObserver<T> observer)
        {
            this.changeManager.Unregister(this, observer);
        }

        public virtual void Notify(params T[] args)
        {
            this.changeManager.Notify(args);
        }
    }
}
