using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djur
{
    public class Cat : Animal
    {
        public override void HungryAnimal()
        {            
            Console.WriteLine("away: chasing mice");
            ChaseMice();
        }

        public override void Interact(Ball e = null)
        {
            if (IsHungry)
                HungryAnimal();
            else
            {
                Console.WriteLine("im playing...");
                FoodStatus--;
            }
        }

        public void ChaseMice()
        {
            if(new Random().Next(0, 2) == 1)
            {
                FoodStatus = 3;
            }
        }
    }
}
