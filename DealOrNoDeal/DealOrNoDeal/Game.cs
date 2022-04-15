using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    class Game
    {
        private Case playerCase;
        private List<Case> caseList;

        public Game()
        {
        }

        public void GenerateShuffledCaseList()
        {
            Random randomObject = new Random((int)(DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond));

            double[] caseValues = { 0.01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000,
                                    50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000};

            //shuffle algorithm
            for (int i = 0; i < caseValues.Length; i++) 
            {
                int swapIndex = randomObject.Next(0, 25);
                double temp = caseValues[swapIndex];
                caseValues[swapIndex] = caseValues[i];
                caseValues[i] = temp;
            }
            
            int count = 0;

            //set shuffled case with ID and value
            foreach (double values in caseValues)
            {
                caseList.Add(new Case(count, values));
                count++;
            }
        }

        public void RemoveCase(Case removeCase)
        {
                caseList.Remove(removeCase);
        }


    }
}