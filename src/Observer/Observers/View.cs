namespace Observer.Observers
{
    using System;
    using Observer.Subjects;

    public class View : IObserver<string>
    {
        private readonly BaseSubject<string> baseSubject;

        public View(BaseSubject<string> baseSubject)
        {
            this.baseSubject = baseSubject;
            this.baseSubject.Attach(this);
        }

        public void Update(BaseSubject<string> baseSubject, params string[] args)
        {
            if (baseSubject == this.baseSubject)
            {
                if (this.baseSubject.GetType() == typeof(NotifyPropertyChange))
                {
                    var subject = this.baseSubject as NotifyPropertyChange;
                    var changedProperty = subject.NotifiableProperty;

                    Console.WriteLine($"Changed Property: {changedProperty}");
                }
            }
        }

        public void Block()
        {
            this.baseSubject.Detach(this);
        }
    }
}
