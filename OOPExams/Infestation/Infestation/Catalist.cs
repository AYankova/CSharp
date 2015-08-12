using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Catalist:ISupplement
    {
        public Catalist(int powerEffect,int healthEffect,int aggEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggEffect;
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {

        }

        public int PowerEffect { get; protected set; }
       

        public int HealthEffect{ get; protected set; }

        public int AggressionEffect { get; protected set; }
        
    }
}
