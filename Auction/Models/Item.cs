using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal MinimumBid { get; set; }

        public List<Bid> Bids { get; set; }

        public Item()
        {
            this.Bids = new List<Bid>();
        }

        public int NumberOfBids { get; set; }
        
    }
}