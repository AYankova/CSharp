using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Zombie:Animal
    {
        public Zombie(string name,Point location):base(name,location,0)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            return 0;
        }
    }
}
