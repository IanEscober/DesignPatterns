namespace Interpreter.Contexts
{
    public interface IContext<TIn, TOut>
    {
        TIn Base { get; set; }
        TOut Translation { get; set;  }
    }
}
