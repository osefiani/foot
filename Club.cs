using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace foot
{
    public class Club
    {
     
        private string nameClub;

        public Club(string name)
        {
            this.nameClub = name;
        }

        public string toString
        {
            get { return this.nameClub; }
        }

    }
}
