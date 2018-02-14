using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    public interface IMediator
    {
        TResponse Dispatch<TQuery, TResponse>(TQuery query);
    }
}
