using Auction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Views.Bids
{
    public class BidOnItemVM
    {
        public Bid Bid { get; set; }

        public Item Item { get; set; }

    }
}