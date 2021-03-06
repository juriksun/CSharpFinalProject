﻿using System;

namespace WeatherLibrary
{
    public class WeatherDataServiceException : Exception
    {
        public WeatherDataServiceException()
        {
        }

        public WeatherDataServiceException(string message)
            : base(message)
        {
        }

        public WeatherDataServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}