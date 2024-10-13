using Data.Entities;
using Data.Entities.VenichleInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configs
{
    public class AuctionConfigs : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            builder.HasOne(x => x.Seller)
                .WithMany(x => x.Auctions)
                .HasForeignKey(x => x.SellerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Venichle)
                .WithOne(x => x.Auction)
                .HasForeignKey<Auction>(x => x.VenichleId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(x => x.Viewers)
                   .WithMany(x => x.WatchList);

            builder.HasMany(x => x.Comments)
                   .WithOne(x => x.Auction)
                   .HasForeignKey(x => x.AuctionId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Bids)
                   .WithOne(x => x.Auction)
                   .HasForeignKey(x => x.AuctionId);
        }
    }
}
