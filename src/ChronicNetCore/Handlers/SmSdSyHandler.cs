using System;
using System.Collections.Generic;
using System.Linq;
using ChronicNetCore;

namespace ChronicNetCore.Handlers
{
    public class SmSdSyHandler : IHandler
    {
        public virtual Span Handle(IList<Token> tokens, Options options)
        {
            var month = (int)tokens[0].GetTag<ScalarMonth>().Value;
            var day = tokens[1].GetTag<ScalarDay>().Value;
            var year = tokens[2].GetTag<ScalarYear>().Value;

            var time_tokens = tokens.Skip(3).ToList();
            if (Time.IsMonthOverflow(year, month, day))
            {
                return null;
            }

            try
            {
                var dayStart = Time.New(year, month, day);
                return Utils.DayOrTime(dayStart, time_tokens, options);
            }
            catch (ArgumentException)
            {

                return null;
            }
        }
    }
}