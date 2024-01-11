using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262519_PRG2Assignment
{
    class PointCard
    {
        public int Points { get; private set; }
        public int PunchCardProgress { get; private set; }
        public string Tier { get; private set; }

        public PointCard()
        {
            
        }

        public PointCard(int initialPoints, int initialPunchCardProgress, string initialTier)
        {
            Points = initialPoints;
            PunchCardProgress = initialPunchCardProgress;
            Tier = initialTier;
        }

        public void AddPoints(int pointsToAdd)
        {
            Points += pointsToAdd;
        }

        public void RedeemPoints(int pointsToRedeem)
        {
            if (Points >= pointsToRedeem)
            {
                Points -= pointsToRedeem;
            }
            else
            {
               
            }
        }

        public void Punch()
        {
            PunchCardProgress++;
        }
    }
}
