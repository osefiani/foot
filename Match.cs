using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace foot
{
    public class Match
    {
        private Club away;
        private Club home;
        private int awayGoals;
        private int homeGoals;
        private bool? isForfeit; 
      
        
        
        

        public Match(Club away, Club home, int awayGoals, int homeGoals)
        {
            this.away = away;
            this.home = home;
            this.awayGoals = awayGoals;
            this.homeGoals = homeGoals;
            this.isForfeit = null;
        }
        public Match(Club away, Club home, bool isForfeit)
        {
            this.away = away;
            this.home = home;
            
            if (isForfeit == true)
            {
                this.awayGoals = 0;
                this.homeGoals = 3;
                this.isForfeit = true;
            }
            else
            {
                this.awayGoals = 3;
                this.homeGoals = 0;
                this.isForfeit = false;
            }
        }

        public  int AwayGoals
        {
            get { return this.awayGoals; }
        }
        public  int HomeGoals
        {
            get { return this.homeGoals; }
        }

        public  Club Home
        {
            get { return this.home; }
        }
        public  Club Away
        {
            get { return this.away; }
        }

        public bool ishomeForfeit()   
        {
            if (this.isForfeit == true) 
                return true;
            else 
                return false;
            
           
        }
        public bool isawayForfeit() 
        {
            if (this.isForfeit == false)
                return true;
            else
                return false;
           
        }

        public bool isdraw()
        {
            if (this.awayGoals == this.homeGoals)
                
               return true;
            else 
                return false;

        }
    
    }
}
