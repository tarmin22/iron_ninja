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

            int count1 = Aaron.ConsumptionHistory.Count;
            int count2 = Aiden.ConsumptionHistory.Count;
            if (count1 > count2)
            {
                System.Console.WriteLine(Aaron + "Consumed more than " + Aiden + "!");
                System.Console.WriteLine("Aaron consumed" + count1);
            }
            else if (count1 == count2)
            {
                System.Console.WriteLine("Both " + Aaron + " and " + Aiden + " consumed the same amount!");
                System.Console.WriteLine(Aiden + " consumed " + count2);
                System.Console.WriteLine("Aaron consumed" + count1);

            }
            else if (count1 < count2)
            {
                System.Console.WriteLine(Aiden + "Consumed more than " + Aaron + "!");
                System.Console.WriteLine(Aiden + " consumed " + count2);
            }


        }
    }
}
