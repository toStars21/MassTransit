﻿// Copyright 2007-2018 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
namespace MassTransit.AmazonSqsTransport.Configuration.Configuration
{
    using MassTransit.Configuration;
    using Topology;


    public interface IAmazonSqsReceiveEndpointConfiguration :
        IReceiveEndpointConfiguration,
        IAmazonSqsEndpointConfiguration
    {
        IAmazonSqsReceiveEndpointConfigurator Configurator { get; }

        IAmazonSqsBusConfiguration BusConfiguration { get; }

        IAmazonSqsHostConfiguration HostConfiguration { get; }

        IAmazonSqsHostControl Host { get; }

        bool SubscribeMessageTopics { get; set; }

        ReceiveSettings Settings { get; }
    }
}