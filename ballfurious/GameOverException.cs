using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ballfurious
{
    public class GameOverException : Exception
    {
        public const string INVALID_HEAD_POINT = "Invalid Head Point";

        public GameOverException(string pMessage)
            : base(pMessage)
        {

        }
    }
}
