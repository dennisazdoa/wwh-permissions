using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Reference.StatticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;

        //Static data is allocated once and shared amond all instances of the class.
        public static double currInterstRate = 0.04;

        public SavingsAccount(double balance)
        {
            currInterstRate = 0.04; //This is static data
            currBalance = balance;
        }

        public static double GetInterestRate()
        {
            return currInterstRate;
        }

        public static void SetInterestRate(double newRate)
        {
            currInterstRate = newRate;
        }
    }
}
