// Administrator.cs
public class Administrator : Employee
{
    public override double CalculateSalary()
    {
        // Логика расчета зарплаты для администратора
        return base.CalculateSalary() + 1200; 
    }
    private double AdditionalBenefits()
    {
        // Дополнительные льготы для администратора
        return 1000;
    }
}