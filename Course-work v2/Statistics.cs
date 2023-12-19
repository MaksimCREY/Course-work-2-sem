// Statistics.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Statistics
{
    // Список сотрудников, используемый для статистических вычислений
    private List<Employee> employees;

    // Конструктор класса, принимающий список сотрудников
    public Statistics(List<Employee> employees)
    {
        // Проверка наличия списка сотрудников
        this.employees = employees ?? throw new ArgumentNullException(nameof(employees), "Список сотрудников не может быть нулевым.");
    }

    // Метод для расчета общей зарплаты всех сотрудников
    public double CalculateTotalSalary()
    {
        return employees.Sum(e => e.CalculateSalary());
    }

    // Метод для нахождения старшего сотрудника
    public Employee GetOldestEmployee()
    {
        // Проверка, что список сотрудников не пуст
        if (employees.Count == 0)
            return null;

        // Возвращает сотрудника с максимальным возрастом
        return employees.OrderByDescending(e => e.Age).FirstOrDefault();
    }

    // Метод для нахождения младшего сотрудника
    public Employee GetYoungestEmployee()
    {
        // Проверка, что список сотрудников не пуст
        if (employees.Count == 0)
            return null;

        // Возвращает сотрудника с минимальным возрастом
        return employees.OrderBy(e => e.Age).FirstOrDefault();
    }

    // Дополнительные методы для статистических вычислений

    // Метод для расчета среднего возраста сотрудников
    public double CalculateAverageAge()
    {
        // Проверка, что список сотрудников не пуст
        if (employees.Count == 0)
            return 0;

        // вычисления среднего возраста
        return employees.Average(e => e.Age);
    }

    // Метод для подсчета количества сотрудников младше определенного возраста
    public int CountEmployeesYoungerThan(int age)
    {
        // подсчет сотрудников, чей возраст меньше заданного значения
        return employees.Count(e => e.Age < age);
    }
}
