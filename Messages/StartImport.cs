using System;
using NServiceBus;

namespace Messages
{
    public class StartImport: IMessage
    {
        public Guid SessionId { get; set; }
    }
}
