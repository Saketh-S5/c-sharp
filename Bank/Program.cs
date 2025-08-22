namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAcc p1 = new SavingsAcc("Josh", 10023);
            p1.Deposit(1000);
            p1.GetBalance();
            p1.Withdraw(1000);
            p1.CalcInterest(6, 2);
            p1.DisplayInterest();
            p1.AddInterest();
            p1.GetBalance();

        }
    }
}