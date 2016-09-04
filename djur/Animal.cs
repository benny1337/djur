using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djur
{
    public abstract class Animal
    {
        public Animal()
        {
            FoodStatus = 2;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string FavFood { get; set; }
        public string Breed { get; set; }        
        public bool IsHungry
        {
            get
            {
                return FoodStatus < 1;
            }
        }

        protected int FoodStatus { get; set; }

        public virtual void HungryAnimal()
        {
            Console.WriteLine("nope im hungry, dont you touch me. you little dwarf");
        }

        public virtual void Interact(Ball ball = null)
        {
            if (IsHungry)
                HungryAnimal();
            else
            {
                if (ball == null)
                {
                    Console.WriteLine("halloj");
                    FoodStatus--;
                }
                else
                {
                    if (ball.IsWornOut)
                    {
                        Console.WriteLine("i do not like the ball. you idiot");
                    }
                    else
                    {
                        Console.Write("now im playing with the ball!");
                        ball.Use();
                        Console.WriteLine(ball.ToString());
                        FoodStatus = FoodStatus - 2;
                    }                    
                }
            }
        }

        public void Eat(string food)
        {
            if (FavFood.Equals(food))
                FoodStatus = 10;
            else
                HungryAnimal();
        }

        public override string ToString()
        {
            var label = IsHungry ? "hungry" : "not hungry";
            return $"{Name}, a {Age} year old {Breed}, is {label} and likes to eat {FavFood}";
        }
    }
}
