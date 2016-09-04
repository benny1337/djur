using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djur
{
    public class Puppy: Dog
    {
        public int Months { get; set; }
        public Puppy()
        {
            Age = 0;
        }
    }
}
