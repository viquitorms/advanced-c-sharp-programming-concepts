// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for Event Challenge

namespace EventsChallenge
{
    public delegate void EventHandler(decimal oldValue, decimal newValue);
    class PiggyBank {

        public event EventHandler? HasBalanceChanged;

        private decimal _BalanceAmount;

        public decimal TheBalance {
            set {
                decimal oldValue = _BalanceAmount;
                _BalanceAmount = value;
                this.HasBalanceChanged?.Invoke(oldValue, _BalanceAmount);
            }
            get {
                return _BalanceAmount;
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            decimal[] testValues = { 250, 1000, -750, 100, -200 };
            
            PiggyBank pb = new PiggyBank();

            pb.HasBalanceChanged += new EventHandler(SetNewBalanceValue);

            foreach (decimal testValue in testValues) {
                pb.TheBalance += testValue;
            }
            Console.WriteLine($"Final value is {pb.TheBalance}");
        }

        static void SetNewBalanceValue(decimal oldValue, decimal newValue) {
            Console.WriteLine($"The value changed from {oldValue} to {newValue}");
        }
    }
}
