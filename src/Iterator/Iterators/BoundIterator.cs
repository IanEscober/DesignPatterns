namespace Iterator.Iterators
{
    using System;

    public class BoundIterator<T> : BaseIterator<T>
    {
        private readonly Func<T, bool> onBound;
        private readonly Action<T> process;

        public BoundIterator(T[] list, Func<T, bool> onBound, Action<T> process) 
            : base(list)
        {
            this.onBound = onBound;
            this.process = process;
        }

        public override void Traverse()
        {
            for (var i = this.First; !this.IsDone(); i = this.Next())
            {
                if (this.onBound(i))
                {
                    this.process(i);
                }
            }
        }
    }
}
