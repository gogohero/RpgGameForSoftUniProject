namespace Hero3TrialMono.Exeptions
{
    using System;

    public class ObjectOutOfBounds : Exception
    {
        public ObjectOutOfBounds(string message)
            :base(message)
        {
                
        }
    }
}
