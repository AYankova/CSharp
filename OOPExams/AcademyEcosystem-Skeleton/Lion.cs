using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Lion:Animal,ICarnivore
    {
        public Lion(string name, Point location)
            : base(name,location,6)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && animal.Size<= 2*this.Size)
            {

                if (animal.GetType().Name == "Zombie")
                {
                    return 10;
                }
                else
                {
                    this.Size += 1;
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }
    }
}
