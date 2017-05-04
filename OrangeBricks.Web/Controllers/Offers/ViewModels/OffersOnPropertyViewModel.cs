using System;
using System.Collections.Generic;

namespace OrangeBricks.Web.Controllers.Offers.ViewModels
{
    public class OffersOnPropertyViewModel
    {
        public string PropertyType { get; set; }
        public int NumberOfBedrooms{ get; set; }
        public string StreetName { get; set; }
        public bool HasOffers { get; set; }
        public IEnumerable<OfferViewModel> Offers { get; set; }
        public IEnumerable<ViewingRequest> ViewingRequests { get; set; }
        public int PropertyId { get; set; }
        public bool HasViewingRequests { get; set; }
    }

    public class OfferViewModel
    {
        public int Id;
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsPending { get; set; }
        public string Status { get; set; }
    }

    public class ViewingRequest
    {
        public int Id;
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
    }
}