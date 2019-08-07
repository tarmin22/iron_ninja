using System;
using System.Collections.Generic;

namespace iron_ninja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {
                bool full = false;
                if (calorieIntake > 1500)
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
                if (item.IsSweet)
                {
                    calorieIntake += 10;
                }
                System.Console.WriteLine(this + " " + item.GetInfo());
            }
        }
    }
}