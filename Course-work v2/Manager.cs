// Manager.cs
public class Manager : Employee
{
    public override double CalculateSalary()
    {
        // Логика расчета зарплаты для менеджера
        return base.CalculateSalary() + CalculateCommission();
    }
    private double CalculateCommission()
    {
        // Расчет комиссии для менеджера
        return 0.1 * base.CalculateSalary();
    }
}