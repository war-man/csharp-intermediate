﻿using System;

namespace Exercises_S6_L38
{
    public class SendMessage : IActivity
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Sending message...");
        }
    }
}