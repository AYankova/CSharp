using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Rock:StaticObject ,IResource
    {
        public Rock(Point position,int hitpoints):base(position,0)
        {
            this.HitPoints = hitpoints;
            this.Quantity = this.HitPoints / 2;
        }
    
       public int Quantity{get;private set;}

       public ResourceType Type
       {
           get
           {
               return ResourceType.Stone;
           }
       }
  
    }
}


