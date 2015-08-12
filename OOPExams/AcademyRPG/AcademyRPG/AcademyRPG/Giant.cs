using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant:Character,IFighter,IGatherer
    {
        private const int GiantHitPoints=200;
        private int giantAttackPoints;
        private const int GiantDefensePoints = 80;
        bool isEnhanced;

        public Giant(string name,Point position,int owner=0):base(name,position,0)
        {
            this.isEnhanced = false;
            this.HitPoints = GiantHitPoints;
            this.AttackPoints = 150;
        }

        public int AttackPoints
        {
            get { return this.giantAttackPoints; }
            private set { this.giantAttackPoints = value; }
        }

        public int DefensePoints
        {
            get { return GiantDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type==ResourceType.Stone)
            {
                if (!this.isEnhanced )
                {
                    this.isEnhanced = true;
                    this.AttackPoints += 100;
                }
                return true;
            }

            return false;
        }
    }
}
