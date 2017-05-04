using System;
using System.Collections.Generic;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class RequestViewingCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public RequestViewingCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(RequestViewingCommand command)
        {
            var property = _context.Properties.Find(command.PropertyId);

            var viewingRequest = new Viewing
            {
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                BuyerUserId = command.BuyerUserId,
                Status = ViewingStatus.Pending
            };

            property.Viewings.Add(viewingRequest);
            
            _context.SaveChanges();
        }
    }
}