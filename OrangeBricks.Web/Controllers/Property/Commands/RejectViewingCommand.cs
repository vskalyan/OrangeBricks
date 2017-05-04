namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class RejectViewingCommand
    {
        public int PropertyId { get; set; }

        public int ViewingId { get; set; }
    }
}