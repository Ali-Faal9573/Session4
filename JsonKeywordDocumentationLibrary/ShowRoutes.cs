using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonKeywordDocumentationLibrary
{
    public static class ShowRoutes
    {
        public static string routes()
        {
            return "/abstract => Abstract Keyword\n/async => Async Keyword\n/const => Const Keyword\n/event => Event Keyword\n/extern => Extern Keyword\n/new => New Keyword\n/override => Override Keyword";
        }
    }
}
