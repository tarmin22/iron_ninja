using System;
using System.Collections.Generic;

namespace iron_ninja
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                bool full = false;
                if (calorieIntake > 1200)
                {
                    full = true;
                }
                return full;
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume

            if (IsFull)
            {
                System.Console.WriteLine(this + " is full");
            }
            else
            {
                ConsumptionHistory.Add(item);
                calorieIntake += item.Calories;
                if (item.IsSpicy)
                {
                    calorieIntake -= 5;
                }
                System.Console.WriteLine(this + " " + item.GetInfo());

            }
        }
    }

}