// Developer.cs
public class Developer : Employee
{
    public override double CalculateSalary()
    {
        // Логика расчета зарплаты для разработчика
        return base.CalculateSalary() + CalculateBonus(); 
    }
    private double CalculateBonus()
    {
        // Расчет бонуса для разработчика
        return 2000;
    }
}
