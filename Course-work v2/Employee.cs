// Employee.cs
using System;

public class Employee : ISalary
{
    // Атрибуты
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

   

    // Реализация интерфейса ISalary
    public virtual double CalculateSalary()
    {
        return 2000; // Базовая реализация расчета зарплаты
    }
    // Улучшенный метод для вывода информации о сотруднике
    public override string ToString()
    {
        return $"{FirstName} {LastName}, Age: {Age}, Type: {GetType().Name}";
    }
}
