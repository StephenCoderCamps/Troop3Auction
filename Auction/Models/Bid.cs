using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class Bid
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal BidAmount { get; set; }

        public Item Item { get; set; }

        public Bid()
        {
              //this.Item = new Item();
        }
    }
}