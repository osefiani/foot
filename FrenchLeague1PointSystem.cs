using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace foot
{
    class FrenchLeague1PointSystem : PointSystem
    {
        private class PointTotal : ITotal
        {
            private int Goalaverage;
            private int points;

            public PointTotal(int Goalaverage, int points)
            {
                this.Goalaverage = Goalaverage;
                this.points = points; 
            }
            public void Increment(ITotal with)
            {
                this.points += ((PointTotal)with).points;
            }

        }

        private static FrenchLeague1PointSystem TheInstance = new FrenchLeague1PointSystem();
        private ITotal initialPoints;

        public ITotal InitialPoints
        {
            get { return this.initialPoints; }
        }

        public static PointSystem Instance
        {
            get { return TheInstance; }
        }

        public override PointSystem.ITotal GetPointsFromMatch(Match m, bool home)
        {
            // TODO 
            return new PointTotal(4, 7);
        }

    }
}
