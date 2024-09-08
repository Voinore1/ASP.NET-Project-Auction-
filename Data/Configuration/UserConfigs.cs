using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    internal class UserConfigs : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Username).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x=>x.Balance).HasDefaultValue(0);


            builder.HasMany(x => x.Auctions).WithOne(x => x.Seller).HasForeignKey(x => x.SellerId);
            builder.HasMany(x=>x.WatchList).WithMany(x => x.Watchers);
        }
    }
}
