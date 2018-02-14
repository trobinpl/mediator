using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    public class Mediator : IMediator
    {
        private IHandlerProvider _handlerProvider { get; set; }

        public Mediator(IHandlerProvider handlerProvider)
        {
            this._handlerProvider = handlerProvider;
        }
        public TResponse Dispatch<TQuery, TResponse>(TQuery query)
        {
            var handler = this._handlerProvider.ProvideHandler<TQuery, TResponse>();

            return handler.Handle(query);
        }

        
    }
}
