﻿using NServiceBus.Transport;
using NUnit.Framework;

[TestFixture]
public class When_sending_from_send_only_endpoint_SqlServer : When_sending_from_send_only_endpoint
{
    protected override TransportDefinition SetupTransport()
    {
        return Helper.SetupSqlTransport();
    }
}