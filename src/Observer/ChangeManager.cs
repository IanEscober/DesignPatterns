namespace Observer
{
    using System.Collections.Generic;
    using System.Linq;
    using Observer.Observers;
    using Observer.Subjects;

    public class ChangeManager<T>
    {
        private readonly Dictionary<BaseSubject<T>, ICollection<IObserver<T>>> mappings;

        public ChangeManager()
        {
            this.mappings = new Dictionary<BaseSubject<T>, ICollection<IObserver<T>>>();
        }

        public void Register(BaseSubject<T> baseSubject, IObserver<T> observer)
        {
            if (this.mappings.ContainsKey(baseSubject))
            {
                var subject = this.mappings.Keys.FirstOrDefault(key => key == baseSubject);
                var observers = this.mappings[baseSubject];
                this.mappings[baseSubject].Add(observer);
            }
            else
            {
                this.mappings.Add(baseSubject, new List<IObserver<T>> { observer });
            }
        }

        public void Unregister(BaseSubject<T> baseSubject, IObserver<T> observer)
        {
            if (this.mappings.ContainsKey(baseSubject))
            {
                var subject = this.mappings.Keys.FirstOrDefault(key => key == baseSubject);
                var observers = this.mappings[baseSubject];

                if (observers.Contains(observer))
                {
                    this.mappings[baseSubject].Remove(observer);
                }
            }
        }

        public void Notify(params T[] args)
        {
            foreach (var subject in this.mappings.Keys)
            {
                foreach (var observer in this.mappings[subject])
                {
                    observer.Update(subject, args);
                }
            }
        }
    }
}
