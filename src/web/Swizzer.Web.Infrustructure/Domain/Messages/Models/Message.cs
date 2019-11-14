using Swizzer.Shared.Providers;
using Swizzer.Web.Infrustructure.Domain.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Web.Infrustructure.Domain.Messages.Models
{
    public class Message : IIdProvider, ICreatedAtProvider
    {
        public DateTime CreatedAt { get; set; }
        public Guid ID { get; set; }
        public string Content { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }

    }
}
