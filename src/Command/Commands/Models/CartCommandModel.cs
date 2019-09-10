namespace Command.Commands.Models
{
    public class CartCommandModel : ICommandModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
