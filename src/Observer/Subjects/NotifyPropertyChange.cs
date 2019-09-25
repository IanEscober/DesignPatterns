namespace Observer.Subjects
{
    public class NotifyPropertyChange : BaseSubject<string>
    {
        private string notifiableProperty;

        public NotifyPropertyChange(ChangeManager<string> changeManager) : base(changeManager)
        {
            this.notifiableProperty = string.Empty;
        }

        public string NotifiableProperty
        {
            get => this.notifiableProperty;
            set
            {
                this.notifiableProperty = value;
                this.Notify(value);
            }
        }
    }
}
