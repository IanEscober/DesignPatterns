namespace Strategy.Strategies
{
    public interface ITinSanitizer<T>
    {
        T Santize(T input);
    }
}
