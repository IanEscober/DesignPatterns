namespace Proxy.Subjects
{
    public interface IOperation<T>
    {
        T Perfrom(params object[] args);
    }
}
