using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djur
{
    public class Ball
    {
        public Ball()
        {
            weary = 0;
        }
        private int weary;
        public bool IsWornOut
        {
            get
            {
                return weary == 5;
            }
        }

        public void Use()
        {
            weary++;
        }

        public override string ToString()
        {
            return $"The ball is about {(weary * 2) * 10} % worn out";
        }
    }
}
