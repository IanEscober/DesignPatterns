namespace Composite
{
    using System;

    public abstract class CashAccount
    {
        public abstract void Visit();
        public abstract Type GetAccountType();
    }
}
