using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Models
{
    public class Property
    {
        public Property()
        {
            Offers = new List<Offer>();
            Viewings = new List<Viewing>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string PropertyType { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int NumberOfBedrooms { get; set; }

        [Required]
        public string SellerUserId { get; set; }

        public bool IsListedForSale { get; set; }

        public List<Offer> Offers { get; set; }

        public List<Viewing> Viewings { get; set; }
    }
}