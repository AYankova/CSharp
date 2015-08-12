using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Knight:Character,IFighter
    {
        private const int AttackPointsKnight = 100;
        private const int DefensePointsKnight = 100;
        private const int HitPointsKnight = 100;

        public Knight(string name, Point position,int owner):base(name,position,owner)
        {
            this.HitPoints = HitPointsKnight;
        }
        public int AttackPoints
        {
            get { return AttackPointsKnight; }
        }

        public int DefensePoints
        {
            get { return DefensePointsKnight; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
        
    }
}
