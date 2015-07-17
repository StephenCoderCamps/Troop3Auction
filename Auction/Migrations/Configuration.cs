namespace Auction.Migrations
{
    using Auction.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Auction.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Auction.Models.ApplicationDbContext context)
        {
            var items = new Item[] {

                new Item {Name="Tesla",
                          Description="Stephens Dream Car that he drools over!",
                          MinimumBid=70000m},

                new Item {Name="Computer-Air",
                          Description="Lindseys Mac",
                          MinimumBid=500m},

                new Item {Name="Bass Guitar",
                          Description="Nates dream guitar/lefay",
                          MinimumBid=4700m}

            };

            context.Items.AddOrUpdate(y => y.Name, items);

        }
    }
}
