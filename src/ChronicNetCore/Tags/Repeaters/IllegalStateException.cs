using System;

namespace ChronicNetCore.Tags.Repeaters
{
    public class IllegalStateException : Exception
    {
        public IllegalStateException(string message) 
            : base(message)
        {
            
        }
    }
}