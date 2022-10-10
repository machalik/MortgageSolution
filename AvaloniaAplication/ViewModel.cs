using SharedProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaAplication
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public Model model;

        public double LoanAmount
        {
            get => model.LoanAmount;
            set
            {
                model.LoanAmount = value;
                Calculate();
            }
        }

        public double InterestRate
        {
            get => model.InterestRate;
            set
            {
                model.InterestRate = value;
                Calculate();
            }
        }

        public int LoanTerm
        {
            get => model.LoanTerm;
            set
            {
                model.LoanTerm = value;
                Calculate();
            }
        }

        private double _monthlyPayment;


        public double MonthlyPayment
        {
            get => _monthlyPayment;
            set
            {
                _monthlyPayment = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MonthlyPayment));
            }
        }

        public ViewModel()
        {
            model = new Model { Id = 0, LoanAmount = 8000000.0, InterestRate = 6.0 };
        }

        private void Calculate()
        {
            const int frequency = 12;
            
            double i = LoanAmount / (frequency * 100);
            int n = LoanTerm * frequency;

            double v = 1 / (1 + i);

            MonthlyPayment = (i * LoanAmount) / (1 - Math.Pow(v, n));
        }
    }
}
