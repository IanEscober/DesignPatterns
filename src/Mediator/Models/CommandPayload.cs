namespace Mediator.Models
{
    public class CommandPayload : IPayload
    {
        public string Command { get; set; }

        public object[] Arguments { get; set; }
    }
}
