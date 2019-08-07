using System;
using System.Collections.Generic;

namespace iron_ninja
{

    class Program
    {
        static void Main(string[] args)
        {
            Buffet mixed = new Buffet();

            SweetTooth Aiden = new SweetTooth();
            SpiceHound Aaron = new SpiceHound();

            Aiden.Consume(mixed.Serve());
            Aiden.Consume(mixed.Serve());
            Aiden.Consume(mixed.Serve());
            Aiden.Consume(mixed.Serve());
            Aaron.Consume(mixed.Serve());
            Aaron.Consume(mixed.Serve());
            Aaron.Consume(mixed.Serve());
            Aaron.Consume(mixed.Serve());

        }
    }
}
