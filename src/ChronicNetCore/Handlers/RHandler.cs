using System.Collections.Generic;

namespace ChronicNetCore.Handlers
{
    public class RHandler : IHandler
    {
        public Span Handle(IList<Token> tokens, Options options)
        {
            var ddTokens = tokens.DealiasAndDisambiguateTimes(options);
            return ddTokens.GetAnchor(options);
        }
    }
}