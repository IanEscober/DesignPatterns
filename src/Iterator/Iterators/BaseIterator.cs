namespace Iterator.Iterators
{
    public abstract class BaseIterator<T>
    {
        private readonly T[] list;
        private int index;

        protected BaseIterator(T[] list)
        {
            this.list = list;
            this.index = 0;
        }

        protected virtual T Next()
        {
            return this.list[++this.index];
        }

        protected virtual bool IsDone()
        {
            return this.index == this.list.Length - 1;
        }

        protected T First
        {
            get { return this.list[0]; }
        }

        protected T Current
        {
            get { return this.list[this.index]; }
        }

        public abstract void Traverse();
    }
}
