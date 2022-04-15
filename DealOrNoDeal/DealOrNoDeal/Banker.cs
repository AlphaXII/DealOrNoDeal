using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DealOrNoDeal
{
    class Banker
    {

        private double offer;

        public Banker()
        {
            
        }

        public double Offer
        {
            get
            {
                return offer;
            }
        }

        public void CalculateOfferAmount(List<Case> caseList)
        {
            double totalCaseAmountSquared = 0;

            foreach (Case caseRemaining in caseList)
            {
                totalCaseAmountSquared = totalCaseAmountSquared + (caseRemaining.MoneyAmount * caseRemaining.MoneyAmount);
            }

            offer = Math.Sqrt(totalCaseAmountSquared / caseList.Count);
        }

    }
}
