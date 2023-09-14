﻿using System;

namespace www.worldisawesome.fun.ExceptionModels
{
    public class MyUnauthorizedException : Exception
    {
        public MyUnauthorizedException()
        {
        }

        public MyUnauthorizedException(string message)
            : base(message)
        {
        }

        public MyUnauthorizedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
