using System;
using System.Collections.Generic;
using UnitTest;

namespace UTest
{
    public class DependencyServiceStub : IDependencyService
    {
        readonly Dictionary<Type, object> registeredServices = new Dictionary<Type, object>();

        public void Register<T>(object impl)
        {
            if(registeredServices == null)
            {
                return;
            }
            registeredServices[typeof(T)] = impl;
        }

        public T Get<T>() where T : class
        {
            var service = (T)registeredServices[typeof(T)];

            return service;
        }
    }
}
