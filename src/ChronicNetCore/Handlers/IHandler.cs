using System.Collections.Generic;
using ChronicNetCore.Handlers;

namespace ChronicNetCore.Handlers
{
    public interface IHandler
    {
        Span Handle(IList<Token> tokens, Options options);
    }



}