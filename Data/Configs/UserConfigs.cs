using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configs
{
    public class UserConfigs : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(x => x.Comments)
                   .WithOne(x => x.User)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Auctions)
                   .WithOne(x => x.Seller)
                   .HasForeignKey(x => x.SellerId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.WatchList)
                   .WithMany(x => x.Viewers);

            builder.HasMany(x => x.Venichles)
                   .WithOne(x => x.Owner)
                   .HasForeignKey(x => x.OwnerId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Bids)
                   .WithOne(x => x.User)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
