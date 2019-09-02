namespace Composite.Composites
{
    public abstract class CompositeAccount : CashAccount
    {
        public abstract void Add(CashAccount cashAccount);
        public abstract void Remove(CashAccount cashAccount);
    }
}
