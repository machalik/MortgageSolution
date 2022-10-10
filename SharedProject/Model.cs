namespace SharedProject
{
    public class Model
    {
        public int Id { get; set; }
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public int LoanTerm { get; set; }

        public Model(double loanAmount, double interestRate, int loanTerm)
        {
            LoanAmount = loanAmount;
            InterestRate = interestRate;
            LoanTerm = loanTerm;
        }
    }
}