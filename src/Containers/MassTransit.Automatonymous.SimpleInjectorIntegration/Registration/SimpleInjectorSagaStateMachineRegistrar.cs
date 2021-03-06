// Copyright 2007-2019 Chris Patterson, Dru Sellers, Travis Smith, et. al.
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
namespace MassTransit.AutomatonymousSimpleInjectorIntegration.Registration
{
    using Automatonymous;
    using Automatonymous.Registration;
    using SimpleInjector;


    public class SimpleInjectorSagaStateMachineRegistrar :
        ISagaStateMachineRegistrar
    {
        readonly Container _container;

        public SimpleInjectorSagaStateMachineRegistrar(Container container)
        {
            _container = container;
        }

        public void RegisterStateMachineSaga<TStateMachine, TInstance>()
            where TStateMachine : class, SagaStateMachine<TInstance>
            where TInstance : class, SagaStateMachineInstance
        {
            _container.RegisterSingleton<ISagaStateMachineFactory, SimpleInjectorSagaStateMachineFactory>();
            _container.RegisterSingleton<IStateMachineActivityFactory, SimpleInjectorStateMachineActivityFactory>();

            _container.RegisterSingleton<TStateMachine>();
            _container.RegisterSingleton<SagaStateMachine<TInstance>>(() => _container.GetInstance<TStateMachine>());
        }
    }
}
