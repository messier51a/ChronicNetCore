using System.Collections.Generic;
using System.Linq;
using ChronicNetCore.Tags.Repeaters;
using ChronicNetCore;

namespace ChronicNetCore.Handlers
{
    public class OdRmnHandler : IHandler
    {
        public Span Handle(IList<Token> tokens, Options options)
        {
            var month = tokens[1].GetTag<RepeaterMonthName>();
            var day = tokens[0].GetTag<OrdinalDay>().Value;
            var now = options.Clock();
            
            if (Time.IsMonthOverflow(now.Year, (int)month.Value, day))
            {
                return null;
            }
            return Utils.HandleMD(month, day, tokens.Skip(2).ToList(), options);
        }
    }
}