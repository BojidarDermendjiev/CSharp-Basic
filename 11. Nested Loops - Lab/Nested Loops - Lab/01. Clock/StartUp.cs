﻿namespace _01._Clock
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            for (int hour = 0; hour <= 23; hour++)
                for (int minutes = 0; minutes <= 59; minutes++)
                    Console.WriteLine($"{hour}:{minutes}");
        }
    }
}
