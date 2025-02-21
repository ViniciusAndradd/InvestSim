using System;

namespace InvestSim.Models
{
    public class Investment
    {
        public double InterestRate { get; set; }
        public double AppliedValue { get; set; }
        public double ApplicationTime { get; set; }
        public double FinalValue { get; set; }
        public double Income {  get; set; }

        public Investment(double interestRate, double applicationtime,double appliedValue)
        {
            InterestRate = interestRate;
            ApplicationTime = applicationtime;
            AppliedValue = appliedValue;
        }

        public Investment()
        {

        }

        public double SimulateInvestment()
        {
            FinalValue = AppliedValue * (Math.Pow((1 + ConvertInterestetRate(InterestRate)), ApplicationTime));
            Income = FinalValue - AppliedValue;
            return FinalValue;
        }

        public double ConvertInterestetRate(double interestRate)
        {
            return interestRate / 100;
        }

    }
}
