using System.Collections.Generic;

namespace ChronicNetCore
{
    public interface ITokenScanner
    {
        IList<Token> Scan(IList<Token> tokens, Options options);
    }
}