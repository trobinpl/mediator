using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Sample
{
    public class DumbHandlerProvider : IHandlerProvider
    {
        private Dictionary<Type, Type> _handlers = new Dictionary<Type, Type>()
        {
            { typeof(HelloWorldResponse), typeof(HelloWorldQueryHandler) }
        };

        public IQueryHandler<TQuery, TResponse> ProvideHandler<TQuery, TResponse>()
        {
            Type responseType = typeof(TResponse);
            IQueryHandler<TQuery, TResponse> handler = null;

            if (!this._handlers.ContainsKey(responseType))
            {
                throw new ApplicationException($"Handler for query {responseType} is not registered");
                
            }
            Type handlerType = this._handlers[responseType];

            handler = (IQueryHandler<TQuery, TResponse>)Activator.CreateInstance(handlerType);

            return handler;
        }
    }
}
