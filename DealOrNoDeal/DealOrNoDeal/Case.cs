using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    class Case
    {
        private int caseID;
        private double moneyAmount;

        public Case(int caseID, double amount)
        {
            this.caseID = caseID;
            moneyAmount = amount;
        }

        public int CaseID
        {
            get { return caseID; }
        }
        public double MoneyAmount
        {
            get 
            {
                return moneyAmount;
            }
        }

    }
}
