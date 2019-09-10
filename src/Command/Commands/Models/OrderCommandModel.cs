namespace Command.Commands.Models
{
    public class OrderCommandModel : ICommandModel
    {
        public int OrderId { get; set; }
        public int Price { get; set; }
    }
}
