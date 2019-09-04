namespace Facade.Effects
{
    using System;
    using Facade.Actions;

    public class StringEffect : IEffect
    {
        public void CreateEffect(ActionModel action)
        {
            switch (action.Type)
            {
                case "Populate":
                    Console.WriteLine("Populated string");
                    break;
                default:
                    break;
            }
        }
    }
}
