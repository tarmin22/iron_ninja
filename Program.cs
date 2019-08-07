using System;
using System.Collections.Generic;

namespace iron_ninja
{
    class Food : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }
        public string GetInfo()
        {
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
    class Drink : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }

        public string GetInfo()
        {
            return $"{Name} (Drink).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        // Add a constructor method
        public Drink(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
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
    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull { get; }
        public abstract void Consume(IConsumable item);
    }
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

    // class Ninja
    // {
    //     private int calorieIntake;
    //     public List<Food> FoodHistory;

    //     // add a constructor
    //     public Ninja()
    //     {
    //         calorieIntake = 0;
    //         FoodHistory = new List<Food>();
    //     }

    //     // add a public "getter" property called "IsFull"
    //     public bool IsFull
    //     {
    //         get
    //         {
    //             bool full = false;
    //             if (calorieIntake > 1200)
    //             {
    //                 full = true;
    //             }
    //             return full;
    //         }
    //     }

    //     // build out the Eat method
    //     public void Eat(Food item)
    //     {

    //         if (IsFull)
    //             Console.WriteLine("Ninja is full and cannot eat anymore");
    //         else
    //         {
    //             this.FoodHistory.Add(item);
    //             this.calorieIntake += item.Calories;
    //             if (item.IsSpicy)
    //                 Console.WriteLine(item.Name + " is spicy");
    //             else if (item.IsSweet)
    //                 Console.WriteLine(item.Name + " is sweet");
    //         }

    //     }
    // }

    interface IConsumable
    {
        string Name { get; set; }
        int Calories { get; set; }
        bool IsSpicy { get; set; }
        bool IsSweet { get; set; }
        string GetInfo();
    }
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
