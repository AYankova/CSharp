using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja:Character,IFighter,IGatherer,IWorldObject
    {
        private const int NinjaHitPoints = 1;
        private int attackpoints;

        public Ninja(string name,Point position,int owner):base(name,position,owner)
        {
            this.HitPoints = NinjaHitPoints;
            this.AttackPoints = 0;
        }

        public int AttackPoints
        {
            get { return this.attackpoints; }
            private set
            {
                this.attackpoints = value;
            }
        }

        public int DefensePoints { get { return int.MaxValue; } }
       

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int maxPoints= availableTargets.Max(x => x.HitPoints);
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if ((availableTargets[i].Owner != this.Owner) && (availableTargets[i].Owner != 0) && (availableTargets[i].HitPoints==maxPoints))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber || resource.Type == ResourceType.Stone)
            {
                if (resource.Type == ResourceType.Lumber)
                {
                    this.AttackPoints += resource.Quantity;
                }
                else if (resource.Type == ResourceType.Stone)
                {
                    this.AttackPoints += resource.Quantity * 2;
                }

                return true;
            }

            return false;
        }
        public bool IsDestroyed
        {
            get { return false; }
        }
    }
}
