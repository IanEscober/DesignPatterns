namespace Facade.Effects
{
    using Facade.Actions;

    public interface IEffect
    {
        void CreateEffect(ActionModel action);
    }
}
