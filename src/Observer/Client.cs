namespace Observer
{
    using System;
    using Observer.Observers;
    using Observer.Subjects;

    public class Client
    {
        public static void Main(string[] args)
        {
            var changeManager = new ChangeManager<string>();
            var notifyPropertyChange = new NotifyPropertyChange(changeManager);
            var firstView = new View(notifyPropertyChange);
            var secondView = new View(notifyPropertyChange);

            notifyPropertyChange.NotifiableProperty = "First Change";
            firstView.Block();
            notifyPropertyChange.NotifiableProperty = "Second Change";

            Console.ReadKey();
        }
    }
}
