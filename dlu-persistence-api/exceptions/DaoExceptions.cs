using System;

namespace dlu_persistence_api.exceptions
{
    public class DaoExceptions : Exception
    {
        public DaoExceptions()
        {
        }

        public DaoExceptions(string message) : base(message)
        {
        }

        public DaoExceptions(string message, Exception inner): base(message, inner)
        {
        }


    }
}