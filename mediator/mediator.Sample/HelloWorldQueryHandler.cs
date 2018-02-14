using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Sample
{
    public class HelloWorldQueryHandler : IQueryHandler<HelloWorldQuery, HelloWorldResponse>
    {
        public HelloWorldResponse Handle(HelloWorldQuery helloWorldQuery)
        {
            HelloWorldResponse response = new HelloWorldResponse();
            switch (helloWorldQuery.Language)
            {
                case HelloWorldQuery.SupportedLanguage.PL:
                    response.HelloWorldText = "Witaj świecie!";
                    break;
                case HelloWorldQuery.SupportedLanguage.EN:
                    response.HelloWorldText = "Hello world";
                    break;
            }

            return response;
        }
    }
}
