using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject
{
    public class CalculationService
    {
        readonly int frequency = 12;

        public double MonthlyPayment(double loanAmount, double interestRate, int loanTerm)
        {
            double i = interestRate / (frequency * 100);
            int n = loanTerm * frequency;

            double v = 1 / (1 + i);

            double monthlyPayment = (i * loanAmount) / (1 - Math.Pow(v, n));

            return monthlyPayment;
        }
    }
}
