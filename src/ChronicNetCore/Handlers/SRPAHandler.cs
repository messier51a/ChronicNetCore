using System.Collections.Generic;
using System.Linq;

namespace ChronicNetCore.Handlers
{
    public class SRPAHandler : SRPHandler
    {
        public override Span Handle(IList<Token> tokens, Options options)
        {
            var anchorSpan = tokens.Skip(3).GetAnchor(options);
            return Handle(tokens, anchorSpan, options);
        }
    }
}