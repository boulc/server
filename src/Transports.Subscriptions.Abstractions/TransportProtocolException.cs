using System;

namespace GraphQL.Server.Transports.Subscriptions.Abstractions
{
    public class TransportProtocolException : Exception
    {
        public int CloseCode { get; set; }

        public TransportProtocolException(string message, int closeCode) : base(message)
        {
            CloseCode = closeCode;
        }

        public TransportProtocolException(int closeCode, Exception inner) : base(inner.Message, inner)
        {
            CloseCode = closeCode;
        }
    }
}
