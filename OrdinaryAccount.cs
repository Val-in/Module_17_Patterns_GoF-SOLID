namespace Module_17_Patterns_GoF__SOLID
{
    public class OrdinaryAccount : Account
    {
        public OrdinaryAccount() 
        {
            Type = "Ordinary";
        }

        public override double CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.02;

            if (Balance >= 1000)
                Interest -= Balance * 0.04;
            return Interest;
        }
    }
}
