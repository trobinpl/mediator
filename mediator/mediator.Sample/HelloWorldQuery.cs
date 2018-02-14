using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator.Sample
{
    public class HelloWorldQuery : IQuery<HelloWorldResponse>
    {
        public enum SupportedLanguage
        {
            PL = 0,
            EN = 1
        };

        public SupportedLanguage Language { get; set; }
    }
}
