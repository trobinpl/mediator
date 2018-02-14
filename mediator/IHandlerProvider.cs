using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    public interface IHandlerProvider
    {
        //IQueryHandler<TQuery, TResponse> ProvideHandler<TQuery, TResponse>();

        IQueryHandler<TQuery, TResponse> ProvideHandler<TQuery, TResponse>();
    }
}
