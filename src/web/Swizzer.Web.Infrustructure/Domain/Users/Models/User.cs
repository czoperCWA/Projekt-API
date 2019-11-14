using Swizzer.Shared.Providers;
using Swizzer.Web.Infrustructure.Domain.Messages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Web.Infrustructure.Domain.Users.Models
{
    public class User : IIdProvider, ICreatedAtProvider
    {
        public Guid ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public ICollection<Message> SentMessages { get; set; } = new HashSet<Message>();
        public ICollection<Message> ReceivedMessages { get; set; } = new HashSet<Message>();
    }
}
