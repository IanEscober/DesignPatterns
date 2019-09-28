namespace State.States
{
    using State.Contexts;

    public interface ILidState
    {
        bool Validate(IBinService binService);
        void Transition(IBinService binService);
    }
}
