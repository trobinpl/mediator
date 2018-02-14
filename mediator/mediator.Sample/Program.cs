using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IHandlerProvider dumbHandlerProvider = new DumbHandlerProvider();
            Mediator mediator = new Mediator(dumbHandlerProvider);

            HelloWorldQuery query = new HelloWorldQuery()
            {
                Language = HelloWorldQuery.SupportedLanguage.EN,
            };

            HelloWorldResponse response = mediator.Dispatch<HelloWorldQuery, HelloWorldResponse>(query);

            Console.WriteLine(response.HelloWorldText);
            Console.ReadLine();
        }
    }
}
