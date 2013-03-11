using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace foot
{
    
    public abstract class PointSystem 
    {
        
        private ITotal initialPoints;

        public abstract PointSystem.ITotal GetPointsFromMatch(Match m, bool isHome);

        public PointSystem.ITotal InitialPoints
        {
            get { return this.initialPoints; }
        }

        public interface ITotal
        {
            void Increment(ITotal With);
            string ToString();
        }                                                                                

    }
}
