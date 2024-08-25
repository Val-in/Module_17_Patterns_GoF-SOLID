namespace Module_17_Patterns_GoF__SOLID
{
    public class SalaryAccount : Account
    {
        public SalaryAccount() 
        {
            Type = "Salary";
        }

        public override double CalculateInterest()
        {
            // расчет процентной ставкu зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
            return Interest;
        }
    }
}
