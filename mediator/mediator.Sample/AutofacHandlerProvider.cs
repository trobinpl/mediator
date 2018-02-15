using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Sample
{
    public class AutofacHandlerProvider : IHandlerProvider
    {
        IComponentContext _context;
        public AutofacHandlerProvider(IComponentContext context)
        {
            _context = context;
        }

        public IQueryHandler<TQuery, TResponse> ProvideHandler<TQuery, TResponse>()
        {
            IQueryHandler<TQuery, TResponse> handler = this._context.Resolve<IQueryHandler<TQuery, TResponse>>();
            return handler;
        }
    }
}
