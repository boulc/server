using System.Diagnostics.CodeAnalysis;

namespace GraphQL.Server.Transports.Subscriptions.Abstractions
{
    /// <summary>
    ///     Protocol message types defined in
    ///     https://github.com/enisdenjo/graphql-ws/blob/master/PROTOCOL.md
    /// </summary>
    public class CloseCode
    {
        public const int InternalServerError = 4500;
        public const int InternalClientError = 4005;
        public const int BadRequest = 4400;
        public const int BadResponse = 4004;
        /** Tried subscribing before connect ack */
        public const int Unauthorized = 4401;
        public const int Forbidden = 4403;
        public const int SubprotocolNotAcceptable = 4406;
        public const int ConnectionInitialisationTimeout = 4408;
        public const int ConnectionAcknowledgementTimeout = 4504;
        /** Subscriber distinction is very important */
        public const int SubscriberAlreadyExists = 4409;
        public const int TooManyInitialisationRequests = 4429;
}
}
