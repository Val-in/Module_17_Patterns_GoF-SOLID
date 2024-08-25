namespace Module_17_Patterns_GoF__SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrdinaryAccount ordinaryAccount = new OrdinaryAccount();
            ordinaryAccount.Balance = 1500;
            ordinaryAccount.CalculateInterest(); // добавить вызов метода
            Console.WriteLine(ordinaryAccount.Interest);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            ordinaryAccount.Balance = 800;
            ordinaryAccount.CalculateInterest();
            Console.WriteLine(ordinaryAccount.Interest);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            SalaryAccount salaryAccount = new SalaryAccount();
            salaryAccount.Balance = 500;
            salaryAccount.CalculateInterest();
            Console.WriteLine(salaryAccount.Interest);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            salaryAccount.Balance = 2000;
            salaryAccount.CalculateInterest();
            Console.WriteLine(salaryAccount.Interest);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
