using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Sample
{
    public class Application
    {
        private IMediator _mediator;

        public Application(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public void Run()
        {
            HelloWorldQuery query = new HelloWorldQuery()
            {
                Language = HelloWorldQuery.SupportedLanguage.EN,
            };

            HelloWorldResponse response = this._mediator.Dispatch<HelloWorldQuery, HelloWorldResponse>(query);

            Console.WriteLine(response.HelloWorldText);
            Console.ReadLine();
        }
    }
}
