using System;
using System.Collections.Generic;

namespace iron_ninja
{
    class Buffet
    {
        public List<IConsumable> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Cheese Burger", 1000, false, false),
                new Food("Ceasar Salad", 650, false, false),
                new Food("Kentucky Fried Chicken", 1100, false, false),
                new Food("California Roll", 600, false, false),
                new Food("Curry Chicken", 650, true, false),
                new Food("Chicken Bake", 660, false, false),
                new Food("Pizza", 650, false, false),
                new Drink("Pina Colada", 600, false, true),
                new Drink("White Russian",550,false,true),
                new Drink("Black Russian",550, false, true)
            };

        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, 10)];
        }
    }
}