namespace Module_17_Patterns_GoF__SOLID
{
    public abstract class Account
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        //абстрактный метод для расчета процентной ставки
        public abstract double CalculateInterest();
    }
}
