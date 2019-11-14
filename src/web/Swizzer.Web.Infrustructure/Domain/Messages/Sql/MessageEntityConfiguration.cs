using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swizzer.Web.Infrustructure.Domain.Messages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Web.Infrustructure.Domain.Messages.Sql
{
    public class MessageEntityConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Receiver)
                .WithMany(x => x.ReceivedMessages)
                .HasForeignKey(x => x.ReceiverId);

            builder.HasOne(x => x.Sender)
                .WithMany(x => x.SentMessages)
                .HasForeignKey(x => x.SenderId);
        }
    }
}
